// Copyright Idaho O Edokpayi 2008
// Code is governed by Code Project Open License 

#include <exception>
#include <windows.h>
#include <algorithm>

using namespace std;

/////////////////////////
// Array based lock free
// queue 
/////////////////////////
template<class T>
class ArrayQ
{
private:
	T* pData;
	volatile LONG nWrite;
	volatile LONG nRead;
	volatile LONG nSize;
	// size of array at creation
	enum SizeEnum{ InitialSize=240 };
	// Lock pData to copy
	void Resize()
	{
		// Declare temporary size variable
		LONG nNewSize = 0;		
		CRITICAL_SECTION cs;

		// double the size of our queue
		InterlockedExchangeAdd(&nNewSize,2 * nSize);

		// allocate the new array
		T* pNewData = new T[nNewSize];
		const ULONG uiTSize = sizeof(T);

		// Initialize the critical section to protect the copy
		InitializeCriticalSection(&cs);

		// Enter the critical section
		EnterCriticalSection(&cs);

		// copy the old data
		memcpy_s((void*)pNewData,nNewSize*uiTSize,(void*)pData,nSize*uiTSize);		

		// dump the old array
		delete[] pData;

		// save the new array
		pData = pNewData;

		// save the new size
		nSize = nNewSize;

		// Leave the critical section
		LeaveCriticalSection(&cs);

		// Delete the critical section
		DeleteCriticalSection(&cs);
	}
public:
	ArrayQ()	: nWrite(0), nRead(0), pData(new T[InitialSize]), nSize(InitialSize)
	{

	}

	~ArrayQ()
	{
		delete[] pData;
	}


	void enqueue( const T& t ) 
	{
		// temporary write index and size
		volatile LONG nTempWrite, nTempSize;

		// atomic copy of the originals to temporary storage
		InterlockedExchange(&nTempWrite,nWrite);
		InterlockedExchange(&nTempSize,nSize);

		// increment before bad things happen
		InterlockedIncrement(&nWrite);

		// check to make sure we haven't exceeded our storage 
		if(nTempWrite == nTempSize)
		{
			// we should resize the array even if it means using a lock
			Resize();			
		}

		pData[nTempWrite] = t;		
	}

	// returns false if queue is empty
	bool dequeue( T& t ) 
	{
		// temporary write index and size
		volatile LONG nTempWrite, nTempRead;

		// atomic copy of the originals to temporary storage
		InterlockedExchange(&nTempWrite,nWrite);
		InterlockedExchange(&nTempRead,nRead);

		// increment before bad things happen
		InterlockedIncrement(&nRead);

		// check to see if queue is empty
		if(nTempRead == nTempWrite)
		{
			// reset both indices
			InterlockedCompareExchange(&nRead,0,nTempRead+1);
			InterlockedCompareExchange(&nWrite,0,nTempWrite);
			return false;
		}

		t = pData[nTempRead];
		return true;
	}

};


//////////////////////////////
// queue based on work of 
// Maged M. Michael &
// Michael L. Scott
//////////////////////////////

template< class T >
class MSQueue
{
private:

	// pointer structure
	struct node_t;

	struct pointer_t 
	{
		node_t* ptr;
		LONG count;
		// default to a null pointer with a count of zero
		pointer_t(): ptr(NULL),count(0){}
		pointer_t(node_t* node, const LONG c ) : ptr(node),count(c){}
		pointer_t(const pointer_t& p)
		{
			InterlockedExchange(&count,p.count);
			InterlockedExchangePointer(&ptr,p.ptr);
		}

		pointer_t(const pointer_t* p): ptr(NULL),count(0)
		{
			if(NULL == p)
				return;

			InterlockedExchange(&count,const_cast< LONG >(p->count));
			InterlockedExchangePointer(ptr,const_cast< node_t* >(p->ptr));			
		}

	};

	// node structure
	struct node_t 
	{
		T value;
		pointer_t next;
		// default constructor
		node_t(){}
	};

	pointer_t Head;
	pointer_t Tail;
	bool CAS(pointer_t& dest,pointer_t& compare, pointer_t& value)
	{
		if(compare.ptr==InterlockedCompareExchangePointer((PVOID volatile*)&dest.ptr,value.ptr,compare.ptr))
		{
			InterlockedExchange(&dest.count,value.count);
			return true;
		}

		return false;
	}
public:	
	// default constructor
	MSQueue()
	{
		node_t* pNode = new node_t();
		Head.ptr = Tail.ptr = pNode;
	}
	~MSQueue()
	{
		// remove the dummy head
		delete Head.ptr;
	}

	// insert items of class T in the back of the queue
	// items of class T must implement a default and copy constructor
	// Enqueue method
	void enqueue(const T& t)
	{
		// Allocate a new node from the free list
		node_t* pNode = new node_t(); 

		// Copy enqueued value into node
		pNode->value = t;

		// Keep trying until Enqueue is done
		bool bEnqueueNotDone = true;

		while(bEnqueueNotDone)
		{
			// Read Tail.ptr and Tail.count together
			pointer_t tail(Tail);

			bool nNullTail = (NULL==tail.ptr); 
			// Read next ptr and count fields together
			pointer_t next( // ptr 
							(nNullTail)? NULL : tail.ptr->next.ptr,
							// count
							(nNullTail)? 0 : tail.ptr->next.count
							) ;


			// Are tail and next consistent?
			if(tail.count == Tail.count && tail.ptr == Tail.ptr)
			{
				if(NULL == next.ptr) // Was Tail pointing to the last node?
				{
					// Try to link node at the end of the linked list										
					if(CAS( tail.ptr->next, next, pointer_t(pNode,next.count+1) ) )
					{
						bEnqueueNotDone = false;
					} // endif

				} // endif

				else // Tail was not pointing to the last node
				{
					// Try to swing Tail to the next node
					CAS(Tail, tail, pointer_t(next.ptr,tail.count+1) );
				}

			} // endif

		} // endloop
	}

	// remove items of class T from the front of the queue
	// items of class T must implement a default and copy constructor
	// Dequeue method
	bool dequeue(T& t)
	{
		pointer_t head;
		// Keep trying until Dequeue is done
		bool bDequeNotDone = true;
		while(bDequeNotDone)
		{
			// Read Head
			head = Head;
			// Read Tail
			pointer_t tail(Tail);

			if(head.ptr == NULL)
			{
				// queue is empty
				return false;
			}

			// Read Head.ptr->next
			pointer_t next(head.ptr->next);

			// Are head, tail, and next consistent
			if(head.count == Head.count && head.ptr == Head.ptr)
			{
				if(head.ptr == tail.ptr) // is tail falling behind?
				{
					// Is the Queue empty
					if(NULL == next.ptr)
					{
						// queue is empty cannot deque
						return false;
					}
					CAS(Tail,tail, pointer_t(next.ptr,tail.count+1)); // Tail is falling behind. Try to advance it
				} // endif

				else // no need to deal with tail
				{
					// read value before CAS otherwise another deque might try to free the next node
					t = next.ptr->value;

					// try to swing Head to the next node
					if(CAS(Head,head, pointer_t(next.ptr,head.count+1) ) )
					{
						bDequeNotDone = false;
					}
				}

			} // endif

		} // endloop
		
		// It is now safe to free the old dummy node
		delete head.ptr;

		// queue was not empty, deque succeeded
		return true;
	}
};