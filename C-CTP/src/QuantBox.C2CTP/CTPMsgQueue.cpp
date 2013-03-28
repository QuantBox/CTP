#include "StdAfx.h"
#include "CTPMsgQueue.h"

void CCTPMsgQueue::Clear()
{
	SMsgItem* pItem = NULL;
	//清空队列
	while(m_queue.dequeue(pItem))
	{
		_Output(pItem);
		delete pItem;
	}
}

bool CCTPMsgQueue::Process()
{
	SMsgItem* pItem = NULL;
	if(m_queue.dequeue(pItem))
	{
		_Output(pItem);
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
	//m_nSleep = 1;
	while (m_bRunning)
	{
		if(Process())
		{
			//成功处理了一个
			//m_nSleep = 1;
		}
		else
		{
			//挂起，等事件到来
			WaitForSingleObject(m_hEvent,INFINITE);

			//失败表示队列为空，等待一会再来取为好
			//m_nSleep *= 2;
			//m_nSleep %= 255;//不超过N毫秒,不能用2的N次方，会导致Sleep(0)占用CPU
			//Sleep(m_nSleep);
		}
	}

	//清理线程
	CloseHandle(m_hThread);
	m_hThread = NULL;
	m_bRunning = false;
}

void CCTPMsgQueue::_Input(SMsgItem* pMsgItem)
{
	//由于只内部调用，所以不再检查指针是否有效
	//OutputDebugStringA("CTP,1");
	m_queue.enqueue(pMsgItem);
	SetEvent(m_hEvent);
}

void CCTPMsgQueue::_Output(SMsgItem* pMsgItem)
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
	case E_fnOnRtnDepthMarketData:
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
	//if(m_bDirect&&m_fnOnConnect)
	//{
	//	(*m_fnOnConnect)(pApi,pRspUserLogin,result);
	//	return;
	//}

	SMsgItem* pItem = new SMsgItem;
	if(pItem)
	{
		memset(pItem,0,sizeof(SMsgItem));
		pItem->type = E_fnOnConnect;
		pItem->pApi = pApi;
		pItem->Status = result;

		if(pRspUserLogin)
			pItem->RspUserLogin = *pRspUserLogin;

		_Input(pItem);
	}
}

void CCTPMsgQueue::Input_OnDisconnect(void* pApi,CThostFtdcRspInfoField *pRspInfo,ConnectionStatus step)
{
	//if(m_bDirect&&m_fnOnDisconnect)
	//{
	//	(*m_fnOnDisconnect)(pApi,pRspInfo,step);
	//	return;
	//}

	SMsgItem* pItem = new SMsgItem;
	if(pItem)
	{
		memset(pItem,0,sizeof(SMsgItem));
		pItem->type = E_fnOnDisconnect;
		pItem->pApi = pApi;
		pItem->Status = step;

		if(pRspInfo)
			pItem->RspInfo = *pRspInfo;

		_Input(pItem);
	}
}

void CCTPMsgQueue::Input_OnRspError(void* pApi,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
{
	if(NULL==pRspInfo)
		return;

	//if(m_bDirect&&m_fnOnRspError)
	//{
	//	(*m_fnOnRspError)(pApi,pRspInfo,nRequestID,bIsLast);
	//	return;
	//}

	SMsgItem* pItem = new SMsgItem;
	if(pItem)
	{
		pItem->type = E_fnOnRspError;
		pItem->pApi = pApi;
		pItem->nRequestID = nRequestID;
		pItem->bIsLast = bIsLast;
		pItem->RspInfo = *pRspInfo;

		_Input(pItem);
	}
}

void CCTPMsgQueue::Input_OnRtnDepthMarketData(void* pMdApi,CThostFtdcDepthMarketDataField *pDepthMarketData)
{
	if(NULL == pDepthMarketData)
		return;

	//if(m_bDirect&&m_fnOnRtnDepthMarketData)
	//{
	//	(*m_fnOnRtnDepthMarketData)(pMdApi,pDepthMarketData);
	//	return;
	//}

	SMsgItem* pItem = new SMsgItem;
	if(pItem)
	{
		pItem->type = E_fnOnRtnDepthMarketData;
		pItem->pApi = pMdApi;
		pItem->DepthMarketData = *pDepthMarketData;

		_Input(pItem);
	}
}

void CCTPMsgQueue::Input_OnRtnInstrumentStatus(void* pTraderApi,CThostFtdcInstrumentStatusField *pInstrumentStatus)
{
	if(NULL == pInstrumentStatus)
		return;

	//if(m_bDirect&&m_fnOnRtnInstrumentStatus)
	//{
	//	(*m_fnOnRtnInstrumentStatus)(pTraderApi,pInstrumentStatus);
	//	return;
	//}

	SMsgItem* pItem = new SMsgItem;
	if(pItem)
	{
		pItem->type = E_fnOnRtnInstrumentStatus;
		pItem->pApi = pTraderApi;
		pItem->InstrumentStatus = *pInstrumentStatus;

		_Input(pItem);
	}
}

void CCTPMsgQueue::Input_OnRtnOrder(void* pTraderApi,CThostFtdcOrderField *pOrder)
{
	if(NULL == pOrder)
		return;

	//if(m_bDirect&&m_fnOnRtnOrder)
	//{
	//	(*m_fnOnRtnOrder)(pTraderApi,pOrder);
	//	return;
	//}

	SMsgItem* pItem = new SMsgItem;
	if(pItem)
	{
		pItem->type = E_fnOnRtnOrder;
		pItem->pApi = pTraderApi;
		pItem->Order = *pOrder;

		_Input(pItem);
	}
}

void CCTPMsgQueue::Input_OnRtnTrade(void* pTraderApi,CThostFtdcTradeField *pTrade)
{
	if(NULL == pTrade)
		return;

	//if(m_bDirect&&m_fnOnRtnTrade)
	//{
	//	(*m_fnOnRtnTrade)(pTraderApi,pTrade);
	//	return;
	//}

	SMsgItem* pItem = new SMsgItem;
	if(pItem)
	{
		pItem->type = E_fnOnRtnTrade;
		pItem->pApi = pTraderApi;
		pItem->Trade = *pTrade;

		_Input(pItem);
	}
}

void CCTPMsgQueue::Input_OnRspOrderInsert(void* pTraderApi,CThostFtdcInputOrderField *pInputOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	if(NULL == pInputOrder
		&&NULL == pRspInfo)
		return;

	//if(m_bDirect&&m_fnOnRspOrderInsert)
	//{
	//	(*m_fnOnRspOrderInsert)(pTraderApi,pInputOrder,pRspInfo,nRequestID,bIsLast);
	//	return;
	//}

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

		_Input(pItem);
	}
}

void CCTPMsgQueue::Input_OnRspQryInstrument(void* pTraderApi,CThostFtdcInstrumentField *pInstrument, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	if(NULL == pInstrument
		&&NULL == pRspInfo)
		return;

	//if(m_bDirect&&m_fnOnRspQryInstrument)
	//{
	//	(*m_fnOnRspQryInstrument)(pTraderApi,pInstrument,pRspInfo,nRequestID,bIsLast);
	//	return;
	//}

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

		_Input(pItem);
	}
}

void CCTPMsgQueue::Input_OnRspQryInstrumentMarginRate(void* pTraderApi,CThostFtdcInstrumentMarginRateField *pInstrumentMarginRate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	if(NULL == pInstrumentMarginRate
		&&NULL == pRspInfo)
		return;

	//if(m_bDirect&&m_fnOnRspQryInstrumentMarginRate)
	//{
	//	(*m_fnOnRspQryInstrumentMarginRate)(pTraderApi,pInstrumentMarginRate,pRspInfo,nRequestID,bIsLast);
	//	return;
	//}

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

		_Input(pItem);
	}
}

void CCTPMsgQueue::Input_OnRspQryInstrumentCommissionRate(void* pTraderApi,CThostFtdcInstrumentCommissionRateField *pInstrumentCommissionRate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	if(NULL == pInstrumentCommissionRate
		&&NULL == pRspInfo)
		return;

	//if(m_bDirect&&m_fnOnRspQryInstrumentCommissionRate)
	//{
	//	(*m_fnOnRspQryInstrumentCommissionRate)(pTraderApi,pInstrumentCommissionRate,pRspInfo,nRequestID,bIsLast);
	//	return;
	//}

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

		_Input(pItem);
	}
}

void CCTPMsgQueue::Input_OnRspQryInvestorPosition(void* pTraderApi,CThostFtdcInvestorPositionField *pInvestorPosition, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	if(NULL == pInvestorPosition
		&&NULL == pRspInfo)
		return;

	//if(m_bDirect&&m_fnOnRspQryInvestorPosition)
	//{
	//	(*m_fnOnRspQryInvestorPosition)(pTraderApi,pInvestorPosition,pRspInfo,nRequestID,bIsLast);
	//	return;
	//}

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

		_Input(pItem);
	}
}

void CCTPMsgQueue::Input_OnRspQryInvestorPositionDetail(void* pTraderApi,CThostFtdcInvestorPositionDetailField *pInvestorPositionDetail, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	if(NULL == pInvestorPositionDetail
		&&NULL == pRspInfo)
		return;

	//if(m_bDirect&&m_fnOnRspQryInvestorPositionDetail)
	//{
	//	(*m_fnOnRspQryInvestorPositionDetail)(pTraderApi,pInvestorPositionDetail,pRspInfo,nRequestID,bIsLast);
	//	return;
	//}

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

		_Input(pItem);
	}
}

void CCTPMsgQueue::Input_OnErrRtnOrderInsert(void* pTraderApi,CThostFtdcInputOrderField *pInputOrder, CThostFtdcRspInfoField *pRspInfo)
{
	if(NULL == pInputOrder
		&&NULL == pRspInfo)
		return;

	//if(m_bDirect&&m_fnOnErrRtnOrderInsert)
	//{
	//	(*m_fnOnErrRtnOrderInsert)(pTraderApi,pInputOrder,pRspInfo);
	//	return;
	//}

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

		_Input(pItem);
	}
}

void CCTPMsgQueue::Input_OnRspOrderAction(void* pTraderApi,CThostFtdcInputOrderActionField *pInputOrderAction, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	if(NULL == pInputOrderAction
		&&NULL == pRspInfo)
		return;

	//if(m_bDirect&&m_fnOnRspOrderAction)
	//{
	//	(*m_fnOnRspOrderAction)(pTraderApi,pInputOrderAction,pRspInfo,nRequestID,bIsLast);
	//	return;
	//}

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

		_Input(pItem);
	}
}

void CCTPMsgQueue::Input_OnErrRtnOrderAction(void* pTraderApi,CThostFtdcOrderActionField *pOrderAction, CThostFtdcRspInfoField *pRspInfo)
{
	if(NULL == pOrderAction
		&&NULL == pRspInfo)
		return;

	//if(m_bDirect&&m_fnOnErrRtnOrderAction)
	//{
	//	(*m_fnOnErrRtnOrderAction)(pTraderApi,pOrderAction,pRspInfo);
	//	return;
	//}

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

		_Input(pItem);
	}
}

void CCTPMsgQueue::Input_OnRspQryOrder(void* pTraderApi,CThostFtdcOrderField *pOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	if(NULL == pOrder
		&&NULL == pRspInfo)
		return;

	//if(m_bDirect&&m_fnOnRspQryOrder)
	//{
	//	(*m_fnOnRspQryOrder)(pTraderApi,pOrder,pRspInfo,nRequestID,bIsLast);
	//	return;
	//}

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

		_Input(pItem);
	}
}

void CCTPMsgQueue::Input_OnRspQryTrade(void* pTraderApi,CThostFtdcTradeField *pTrade, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	if(NULL == pTrade
		&&NULL == pRspInfo)
		return;

	//if(m_bDirect&&m_fnOnRspQryTrade)
	//{
	//	(*m_fnOnRspQryTrade)(pTraderApi,pTrade,pRspInfo,nRequestID,bIsLast);
	//	return;
	//}

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

		_Input(pItem);
	}
}

void CCTPMsgQueue::Input_OnRspQryTradingAccount(void* pTraderApi,CThostFtdcTradingAccountField *pTradingAccount, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	if(NULL == pTradingAccount
		&&NULL == pRspInfo)
		return;

	//if(m_bDirect&&m_fnOnRspQryTradingAccount)
	//{
	//	(*m_fnOnRspQryTradingAccount)(pTraderApi,pTradingAccount,pRspInfo,nRequestID,bIsLast);
	//	return;
	//}

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

		_Input(pItem);
	}
}

void CCTPMsgQueue::Input_OnRspQryDepthMarketData(void* pTraderApi,CThostFtdcDepthMarketDataField *pDepthMarketData, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	if(NULL == pDepthMarketData
		&&NULL == pRspInfo)
		return;

	//if(m_bDirect&&m_fnOnRspQryDepthMarketData)
	//{
	//	(*m_fnOnRspQryDepthMarketData)(pTraderApi,pDepthMarketData,pRspInfo,nRequestID,bIsLast);
	//	return;
	//}

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

		_Input(pItem);
	}
}