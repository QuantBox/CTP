// Lock.h: interface for the CLock class.
//
//////////////////////////////////////////////////////////////////////

#if !defined(AFX_LOCK_H__C93ED1F3_8459_465C_89C0_F0B05C953228__INCLUDED_)
#define AFX_LOCK_H__C93ED1F3_8459_465C_89C0_F0B05C953228__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

class CLock
{
public:
	CLock(CRITICAL_SECTION* pCs)
		: m_pCs(pCs)
	{
		EnterCriticalSection(m_pCs);
	}
	~CLock()
	{
		LeaveCriticalSection(m_pCs);
	}
private:
	CRITICAL_SECTION* m_pCs;
};

#endif // !defined(AFX_LOCK_H__C93ED1F3_8459_465C_89C0_F0B05C953228__INCLUDED_)
