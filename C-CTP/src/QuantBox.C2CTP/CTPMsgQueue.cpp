#include "StdAfx.h"
#include "CTPMsgQueue.h"

void CCTPMsgQueue::Clear()
{
	SMsgItem* pItem = NULL;
	//清空队列
	while(m_queue_TD.dequeue(pItem))
	{
		delete pItem;
	}
	while(m_queue_MD.dequeue(pItem))
	{
		delete pItem;
	}
}

bool CCTPMsgQueue::Process()
{
	SMsgItem* pItem = NULL;
	if(m_queue_TD.dequeue(pItem))
	{
		_Output_TD(pItem);
		delete pItem;
		return true;
	}
	else if(m_queue_MD.dequeue(pItem))
	{
		_Output_MD(pItem);
		delete pItem;
		return true;
	}
	return false;
}

void CCTPMsgQueue::StartThread()
{
	if (NULL == m_hThread)
	{
		m_bRunning = true;
		m_hThread = CreateThread(NULL,0,ProcessThread,this,CREATE_SUSPENDED,NULL);
		SetThreadPriority(m_hThread,THREAD_PRIORITY_HIGHEST);
		ResumeThread(m_hThread);
	}
}

void CCTPMsgQueue::StopThread()
{
	//停止线程
	m_bRunning = false;

	// 线程可能正在Wait，让它结束等待
	SetEvent(m_hEvent);
	
	WaitForSingleObject(m_hThread,INFINITE);
	CloseHandle(m_hThread);
	m_hThread = NULL;
}

DWORD WINAPI ProcessThread(LPVOID lpParam)
{
	CCTPMsgQueue* pMsgQueue = reinterpret_cast<CCTPMsgQueue *>(lpParam);
	if (pMsgQueue)
		pMsgQueue->RunInThread();
	return 0;
}

void CCTPMsgQueue::RunInThread()
{
	while (m_bRunning)
	{
		if(Process())
		{
		}
		else
		{
			//挂起，等事件到来
			WaitForSingleObject(m_hEvent,INFINITE);
		}
	}

	//清理线程
	CloseHandle(m_hThread);
	m_hThread = NULL;
	m_bRunning = false;
}

void CCTPMsgQueue::_Input_MD(SMsgItem* pMsgItem)
{
	m_queue_MD.enqueue(pMsgItem);
	SetEvent(m_hEvent);
}

void CCTPMsgQueue::_Input_TD(SMsgItem* pMsgItem)
{
	m_queue_TD.enqueue(pMsgItem);
	SetEvent(m_hEvent);
}

void CCTPMsgQueue::_Output_MD(SMsgItem* pMsgItem)
{
	Output_OnRtnDepthMarketData(pMsgItem);
}

void CCTPMsgQueue::_Output_TD(SMsgItem* pMsgItem)
{
	//OutputDebugStringA("CTP,2");
	//内部调用，不判断指针是否有效
	switch(pMsgItem->type)
	{
	case E_fnOnConnect:
		Output_OnConnect(pMsgItem);
		break;
	case E_fnOnDisconnect:
		Output_OnDisconnect(pMsgItem);
		break;
	case E_fnOnErrRtnOrderAction:
		Output_OnErrRtnOrderAction(pMsgItem);
		break;
	case E_fnOnErrRtnOrderInsert:
		Output_OnErrRtnOrderInsert(pMsgItem);
		break;
	case E_fnOnRspError:
		Output_OnRspError(pMsgItem);
		break;
	case E_fnOnRspOrderAction:
		Output_OnRspOrderAction(pMsgItem);
		break;
	case E_fnOnRspOrderInsert:
		Output_OnRspOrderInsert(pMsgItem);
		break;
	case E_fnOnRspQryDepthMarketData:
		Output_OnRspQryDepthMarketData(pMsgItem);
		break;
	case E_fnOnRspQryInstrument:
		Output_OnRspQryInstrument(pMsgItem);
		break;
	case E_fnOnRspQryInstrumentCommissionRate:
		Output_OnRspQryInstrumentCommissionRate(pMsgItem);
		break;
	case E_fnOnRspQryInstrumentMarginRate:
		Output_OnRspQryInstrumentMarginRate(pMsgItem);
		break;
	case E_fnOnRspQryInvestorPosition:
		Output_OnRspQryInvestorPosition(pMsgItem);
		break;
	case E_fnOnRspQryInvestorPositionDetail:
		Output_OnRspQryInvestorPositionDetail(pMsgItem);
		break;
	case E_fnOnRspQryOrder:
		Output_OnRspQryOrder(pMsgItem);
		break;
	case E_fnOnRspQryTrade:
		Output_OnRspQryTrade(pMsgItem);
		break;
	case E_fnOnRspQryTradingAccount:
		Output_OnRspQryTradingAccount(pMsgItem);
		break;
	case E_fnOnRtnDepthMarketData: //这条不会运行
		Output_OnRtnDepthMarketData(pMsgItem);
		break;
	case E_fnOnRtnInstrumentStatus:
		Output_OnRtnInstrumentStatus(pMsgItem);
		break;
	case E_fnOnRtnOrder:
		Output_OnRtnOrder(pMsgItem);
		break;
	case E_fnOnRtnTrade:
		Output_OnRtnTrade(pMsgItem);
		break;
	default:
		_ASSERT(false);
		break;
	}
}


void CCTPMsgQueue::Input_OnConnect(void* pApi,CThostFtdcRspUserLoginField *pRspUserLogin,ConnectionStatus result)
{
	SMsgItem* pItem = new SMsgItem;
	if(pItem)
	{
		memset(pItem,0,sizeof(SMsgItem));
		pItem->type = E_fnOnConnect;
		pItem->pApi = pApi;
		pItem->Status = result;

		if(pRspUserLogin)
			pItem->RspUserLogin = *pRspUserLogin;

		_Input_TD(pItem);
	}
}

void CCTPMsgQueue::Input_OnDisconnect(void* pApi,CThostFtdcRspInfoField *pRspInfo,ConnectionStatus step)
{
	SMsgItem* pItem = new SMsgItem;
	if(pItem)
	{
		memset(pItem,0,sizeof(SMsgItem));
		pItem->type = E_fnOnDisconnect;
		pItem->pApi = pApi;
		pItem->Status = step;

		if(pRspInfo)
			pItem->RspInfo = *pRspInfo;

		_Input_TD(pItem);
	}
}

void CCTPMsgQueue::Input_OnRspError(void* pApi,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
{
	if(NULL==pRspInfo)
		return;

	SMsgItem* pItem = new SMsgItem;
	if(pItem)
	{
		pItem->type = E_fnOnRspError;
		pItem->pApi = pApi;
		pItem->nRequestID = nRequestID;
		pItem->bIsLast = bIsLast;
		pItem->RspInfo = *pRspInfo;

		_Input_TD(pItem);
	}
}

void CCTPMsgQueue::Input_OnRtnDepthMarketData(void* pMdApi,CThostFtdcDepthMarketDataField *pDepthMarketData)
{
	if(NULL == pDepthMarketData)
		return;

	SMsgItem* pItem = new SMsgItem;
	if(pItem)
	{
		pItem->type = E_fnOnRtnDepthMarketData;
		pItem->pApi = pMdApi;
		pItem->DepthMarketData = *pDepthMarketData;

		_Input_MD(pItem);
	}
}

void CCTPMsgQueue::Input_OnRtnInstrumentStatus(void* pTraderApi,CThostFtdcInstrumentStatusField *pInstrumentStatus)
{
	if(NULL == pInstrumentStatus)
		return;

	SMsgItem* pItem = new SMsgItem;
	if(pItem)
	{
		pItem->type = E_fnOnRtnInstrumentStatus;
		pItem->pApi = pTraderApi;
		pItem->InstrumentStatus = *pInstrumentStatus;

		_Input_TD(pItem);
	}
}

void CCTPMsgQueue::Input_OnRtnOrder(void* pTraderApi,CThostFtdcOrderField *pOrder)
{
	if(NULL == pOrder)
		return;

	SMsgItem* pItem = new SMsgItem;
	if(pItem)
	{
		pItem->type = E_fnOnRtnOrder;
		pItem->pApi = pTraderApi;
		pItem->Order = *pOrder;

		_Input_TD(pItem);
	}
}

void CCTPMsgQueue::Input_OnRtnTrade(void* pTraderApi,CThostFtdcTradeField *pTrade)
{
	if(NULL == pTrade)
		return;

	SMsgItem* pItem = new SMsgItem;
	if(pItem)
	{
		pItem->type = E_fnOnRtnTrade;
		pItem->pApi = pTraderApi;
		pItem->Trade = *pTrade;

		_Input_TD(pItem);
	}
}

void CCTPMsgQueue::Input_OnRspOrderInsert(void* pTraderApi,CThostFtdcInputOrderField *pInputOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	if(NULL == pInputOrder
		&&NULL == pRspInfo)
		return;

	SMsgItem* pItem = new SMsgItem;
	if(pItem)
	{
		memset(pItem,0,sizeof(SMsgItem));
		pItem->type = E_fnOnRspOrderInsert;
		pItem->pApi = pTraderApi;
		pItem->nRequestID = nRequestID;
		pItem->bIsLast = bIsLast;

		if(pInputOrder)
			pItem->InputOrder = *pInputOrder;
		if(pRspInfo)
			pItem->RspInfo = *pRspInfo;

		_Input_TD(pItem);
	}
}

void CCTPMsgQueue::Input_OnRspQryInstrument(void* pTraderApi,CThostFtdcInstrumentField *pInstrument, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	if(NULL == pInstrument
		&&NULL == pRspInfo)
		return;

	SMsgItem* pItem = new SMsgItem;
	if(pItem)
	{
		memset(pItem,0,sizeof(SMsgItem));
		pItem->type = E_fnOnRspQryInstrument;
		pItem->pApi = pTraderApi;
		pItem->nRequestID = nRequestID;
		pItem->bIsLast = bIsLast;

		if(pInstrument)
			pItem->Instrument = *pInstrument;
		if(pRspInfo)
			pItem->RspInfo = *pRspInfo;

		_Input_TD(pItem);
	}
}

void CCTPMsgQueue::Input_OnRspQryInstrumentMarginRate(void* pTraderApi,CThostFtdcInstrumentMarginRateField *pInstrumentMarginRate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	if(NULL == pInstrumentMarginRate
		&&NULL == pRspInfo)
		return;

	SMsgItem* pItem = new SMsgItem;
	if(pItem)
	{
		memset(pItem,0,sizeof(SMsgItem));
		pItem->type = E_fnOnRspQryInstrumentMarginRate;
		pItem->pApi = pTraderApi;
		pItem->nRequestID = nRequestID;
		pItem->bIsLast = bIsLast;

		if(pInstrumentMarginRate)
			pItem->InstrumentMarginRate = *pInstrumentMarginRate;
		if(pRspInfo)
			pItem->RspInfo = *pRspInfo;

		_Input_TD(pItem);
	}
}

void CCTPMsgQueue::Input_OnRspQryInstrumentCommissionRate(void* pTraderApi,CThostFtdcInstrumentCommissionRateField *pInstrumentCommissionRate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	if(NULL == pInstrumentCommissionRate
		&&NULL == pRspInfo)
		return;

	SMsgItem* pItem = new SMsgItem;
	if(pItem)
	{
		memset(pItem,0,sizeof(SMsgItem));
		pItem->type = E_fnOnRspQryInstrumentCommissionRate;
		pItem->pApi = pTraderApi;
		pItem->nRequestID = nRequestID;
		pItem->bIsLast = bIsLast;

		if(pInstrumentCommissionRate)
			pItem->InstrumentCommissionRate = *pInstrumentCommissionRate;
		if(pRspInfo)
			pItem->RspInfo = *pRspInfo;

		_Input_TD(pItem);
	}
}

void CCTPMsgQueue::Input_OnRspQryInvestorPosition(void* pTraderApi,CThostFtdcInvestorPositionField *pInvestorPosition, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	if(NULL == pInvestorPosition
		&&NULL == pRspInfo)
		return;

	SMsgItem* pItem = new SMsgItem;
	if(pItem)
	{
		memset(pItem,0,sizeof(SMsgItem));
		pItem->type = E_fnOnRspQryInvestorPosition;
		pItem->pApi = pTraderApi;
		pItem->nRequestID = nRequestID;
		pItem->bIsLast = bIsLast;

		if(pInvestorPosition)
			pItem->InvestorPosition = *pInvestorPosition;
		if(pRspInfo)
			pItem->RspInfo = *pRspInfo;

		_Input_TD(pItem);
	}
}

void CCTPMsgQueue::Input_OnRspQryInvestorPositionDetail(void* pTraderApi,CThostFtdcInvestorPositionDetailField *pInvestorPositionDetail, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	if(NULL == pInvestorPositionDetail
		&&NULL == pRspInfo)
		return;

	SMsgItem* pItem = new SMsgItem;
	if(pItem)
	{
		memset(pItem,0,sizeof(SMsgItem));
		pItem->type = E_fnOnRspQryInvestorPositionDetail;
		pItem->pApi = pTraderApi;
		pItem->nRequestID = nRequestID;
		pItem->bIsLast = bIsLast;

		if(pInvestorPositionDetail)
			pItem->InvestorPositionDetail = *pInvestorPositionDetail;
		if(pRspInfo)
			pItem->RspInfo = *pRspInfo;

		_Input_TD(pItem);
	}
}

void CCTPMsgQueue::Input_OnErrRtnOrderInsert(void* pTraderApi,CThostFtdcInputOrderField *pInputOrder, CThostFtdcRspInfoField *pRspInfo)
{
	if(NULL == pInputOrder
		&&NULL == pRspInfo)
		return;

	SMsgItem* pItem = new SMsgItem;
	if(pItem)
	{
		memset(pItem,0,sizeof(SMsgItem));
		pItem->type = E_fnOnErrRtnOrderInsert;
		pItem->pApi = pTraderApi;
		if(pInputOrder)
			pItem->InputOrder = *pInputOrder;
		if(pRspInfo)
			pItem->RspInfo = *pRspInfo;

		_Input_TD(pItem);
	}
}

void CCTPMsgQueue::Input_OnRspOrderAction(void* pTraderApi,CThostFtdcInputOrderActionField *pInputOrderAction, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	if(NULL == pInputOrderAction
		&&NULL == pRspInfo)
		return;

	SMsgItem* pItem = new SMsgItem;
	if(pItem)
	{
		memset(pItem,0,sizeof(SMsgItem));
		pItem->type = E_fnOnRspOrderAction;
		pItem->pApi = pTraderApi;
		pItem->nRequestID = nRequestID;
		pItem->bIsLast = bIsLast;

		if(pInputOrderAction)
			pItem->InputOrderAction = *pInputOrderAction;
		if(pRspInfo)
			pItem->RspInfo = *pRspInfo;

		_Input_TD(pItem);
	}
}

void CCTPMsgQueue::Input_OnErrRtnOrderAction(void* pTraderApi,CThostFtdcOrderActionField *pOrderAction, CThostFtdcRspInfoField *pRspInfo)
{
	if(NULL == pOrderAction
		&&NULL == pRspInfo)
		return;

	SMsgItem* pItem = new SMsgItem;
	if(pItem)
	{
		memset(pItem,0,sizeof(SMsgItem));
		pItem->type = E_fnOnErrRtnOrderAction;
		pItem->pApi = pTraderApi;
		if(pOrderAction)
			pItem->OrderAction = *pOrderAction;
		if(pRspInfo)
			pItem->RspInfo = *pRspInfo;

		_Input_TD(pItem);
	}
}

void CCTPMsgQueue::Input_OnRspQryOrder(void* pTraderApi,CThostFtdcOrderField *pOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	if(NULL == pOrder
		&&NULL == pRspInfo)
		return;

	SMsgItem* pItem = new SMsgItem;
	if(pItem)
	{
		memset(pItem,0,sizeof(SMsgItem));
		pItem->type = E_fnOnRspQryOrder;
		pItem->pApi = pTraderApi;
		pItem->nRequestID = nRequestID;
		pItem->bIsLast = bIsLast;

		if(pOrder)
			pItem->Order = *pOrder;
		if(pRspInfo)
			pItem->RspInfo = *pRspInfo;

		_Input_TD(pItem);
	}
}

void CCTPMsgQueue::Input_OnRspQryTrade(void* pTraderApi,CThostFtdcTradeField *pTrade, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	if(NULL == pTrade
		&&NULL == pRspInfo)
		return;

	SMsgItem* pItem = new SMsgItem;
	if(pItem)
	{
		memset(pItem,0,sizeof(SMsgItem));
		pItem->type = E_fnOnRspQryTrade;
		pItem->pApi = pTraderApi;
		pItem->nRequestID = nRequestID;
		pItem->bIsLast = bIsLast;
		if(pTrade)
			pItem->Trade = *pTrade;
		if(pRspInfo)
			pItem->RspInfo = *pRspInfo;

		_Input_TD(pItem);
	}
}

void CCTPMsgQueue::Input_OnRspQryTradingAccount(void* pTraderApi,CThostFtdcTradingAccountField *pTradingAccount, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	if(NULL == pTradingAccount
		&&NULL == pRspInfo)
		return;

	SMsgItem* pItem = new SMsgItem;
	if(pItem)
	{
		memset(pItem,0,sizeof(SMsgItem));
		pItem->type = E_fnOnRspQryTradingAccount;
		pItem->pApi = pTraderApi;
		pItem->nRequestID = nRequestID;
		pItem->bIsLast = bIsLast;
		if(pTradingAccount)
			pItem->TradingAccount = *pTradingAccount;
		if(pRspInfo)
			pItem->RspInfo = *pRspInfo;

		_Input_TD(pItem);
	}
}

void CCTPMsgQueue::Input_OnRspQryDepthMarketData(void* pTraderApi,CThostFtdcDepthMarketDataField *pDepthMarketData, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	if(NULL == pDepthMarketData
		&&NULL == pRspInfo)
		return;

	SMsgItem* pItem = new SMsgItem;
	if(pItem)
	{
		memset(pItem,0,sizeof(SMsgItem));
		pItem->type = E_fnOnRspQryDepthMarketData;
		pItem->pApi = pTraderApi;
		pItem->nRequestID = nRequestID;
		pItem->bIsLast = bIsLast;
		if(pDepthMarketData)
			pItem->DepthMarketData = *pDepthMarketData;
		if(pRspInfo)
			pItem->RspInfo = *pRspInfo;

		_Input_TD(pItem);
	}
}