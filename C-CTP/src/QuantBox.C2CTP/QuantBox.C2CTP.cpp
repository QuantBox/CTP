// QuantBox.C2CTP.cpp : 定义 DLL 应用程序的导出函数。
//

#include "stdafx.h"
#include "QuantBox.C2CTP.h"

#include "MdUserApi.h"
#include "TraderApi.h"
#include "CTPMsgQueue.h"

inline CCTPMsgQueue* CTP_GetQueue(void* pMsgQueue)
{
	return static_cast<CCTPMsgQueue*>(pMsgQueue);
}

inline CMdUserApi* MD_GetApi(void* pMdUserApi)
{
	return static_cast<CMdUserApi*>(pMdUserApi);
}

inline CTraderApi* TD_GetApi(void* pTraderApi)
{
	return static_cast<CTraderApi*>(pTraderApi);
}


QUANTBOXC2CTP_API void* __stdcall CTP_CreateMsgQueue()
{
	return new CCTPMsgQueue();
}

QUANTBOXC2CTP_API void __stdcall CTP_ReleaseMsgQueue(void* pMsgQueue)
{
	if(pMsgQueue)
	{
		delete CTP_GetQueue(pMsgQueue);
	}
}

QUANTBOXC2CTP_API void __stdcall CTP_RegOnConnect(void* pMsgQueue,fnOnConnect pCallback)
{
	if(pMsgQueue)
	{
		CTP_GetQueue(pMsgQueue)->RegisterCallback(pCallback);
	}
}

QUANTBOXC2CTP_API void __stdcall CTP_RegOnDisconnect(void* pMsgQueue,fnOnDisconnect pCallback)
{
	if(pMsgQueue)
	{
		CTP_GetQueue(pMsgQueue)->RegisterCallback(pCallback);
	}
}

QUANTBOXC2CTP_API void __stdcall CTP_RegOnErrRtnOrderAction(void* pMsgQueue,fnOnErrRtnOrderAction pCallback)
{
	if(pMsgQueue)
	{
		CTP_GetQueue(pMsgQueue)->RegisterCallback(pCallback);
	}
}

QUANTBOXC2CTP_API void __stdcall CTP_RegOnErrRtnOrderInsert(void* pMsgQueue,fnOnErrRtnOrderInsert pCallback)
{
	if(pMsgQueue)
	{
		CTP_GetQueue(pMsgQueue)->RegisterCallback(pCallback);
	}
}

QUANTBOXC2CTP_API void __stdcall CTP_RegOnRspError(void* pMsgQueue,fnOnRspError pCallback)
{
	if(pMsgQueue)
	{
		CTP_GetQueue(pMsgQueue)->RegisterCallback(pCallback);
	}
}

QUANTBOXC2CTP_API void __stdcall CTP_RegOnRspOrderAction(void* pMsgQueue,fnOnRspOrderAction pCallback)
{
	if(pMsgQueue)
	{
		CTP_GetQueue(pMsgQueue)->RegisterCallback(pCallback);
	}
}

QUANTBOXC2CTP_API void __stdcall CTP_RegOnRspOrderInsert(void* pMsgQueue,fnOnRspOrderInsert pCallback)
{
	if(pMsgQueue)
	{
		CTP_GetQueue(pMsgQueue)->RegisterCallback(pCallback);
	}
}

QUANTBOXC2CTP_API void __stdcall CTP_RegOnRspQryDepthMarketData(void* pMsgQueue,fnOnRspQryDepthMarketData pCallback)
{
	if(pMsgQueue)
	{
		CTP_GetQueue(pMsgQueue)->RegisterCallback(pCallback);
	}
}

QUANTBOXC2CTP_API void __stdcall CTP_RegOnRspQryInstrument(void* pMsgQueue,fnOnRspQryInstrument pCallback)
{
	if(pMsgQueue)
	{
		CTP_GetQueue(pMsgQueue)->RegisterCallback(pCallback);
	}
}

QUANTBOXC2CTP_API void __stdcall CTP_RegOnRspQryInstrumentCommissionRate(void* pMsgQueue,fnOnRspQryInstrumentCommissionRate pCallback)
{
	if(pMsgQueue)
	{
		CTP_GetQueue(pMsgQueue)->RegisterCallback(pCallback);
	}
}

QUANTBOXC2CTP_API void __stdcall CTP_RegOnRspQryInstrumentMarginRate(void* pMsgQueue,fnOnRspQryInstrumentMarginRate pCallback)
{
	if(pMsgQueue)
	{
		CTP_GetQueue(pMsgQueue)->RegisterCallback(pCallback);
	}
}

QUANTBOXC2CTP_API void __stdcall CTP_RegOnRspQryInvestorPosition(void* pMsgQueue,fnOnRspQryInvestorPosition pCallback)
{
	if(pMsgQueue)
	{
		CTP_GetQueue(pMsgQueue)->RegisterCallback(pCallback);
	}
}

QUANTBOXC2CTP_API void __stdcall CTP_RegOnRspQryInvestorPositionDetail(void* pMsgQueue,fnOnRspQryInvestorPositionDetail pCallback)
{
	if(pMsgQueue)
	{
		CTP_GetQueue(pMsgQueue)->RegisterCallback(pCallback);
	}
}

QUANTBOXC2CTP_API void __stdcall CTP_RegOnRspQryOrder(void* pMsgQueue,fnOnRspQryOrder pCallback)
{
	if(pMsgQueue)
	{
		CTP_GetQueue(pMsgQueue)->RegisterCallback(pCallback);
	}
}

QUANTBOXC2CTP_API void __stdcall CTP_RegOnRspQryTrade(void* pMsgQueue,fnOnRspQryTrade pCallback)
{
	if(pMsgQueue)
	{
		CTP_GetQueue(pMsgQueue)->RegisterCallback(pCallback);
	}
}

QUANTBOXC2CTP_API void __stdcall CTP_RegOnRspQryTradingAccount(void* pMsgQueue,fnOnRspQryTradingAccount pCallback)
{
	if(pMsgQueue)
	{
		CTP_GetQueue(pMsgQueue)->RegisterCallback(pCallback);
	}
}

QUANTBOXC2CTP_API void __stdcall CTP_RegOnRtnDepthMarketData(void* pMsgQueue,fnOnRtnDepthMarketData pCallback)
{
	if(pMsgQueue)
	{
		CTP_GetQueue(pMsgQueue)->RegisterCallback(pCallback);
	}
}

QUANTBOXC2CTP_API void __stdcall CTP_RegOnRtnInstrumentStatus(void* pMsgQueue,fnOnRtnInstrumentStatus pCallback)
{
	if(pMsgQueue)
	{
		CTP_GetQueue(pMsgQueue)->RegisterCallback(pCallback);
	}
}

QUANTBOXC2CTP_API void __stdcall CTP_RegOnRtnOrder(void* pMsgQueue,fnOnRtnOrder pCallback)
{
	if(pMsgQueue)
	{
		CTP_GetQueue(pMsgQueue)->RegisterCallback(pCallback);
	}
}

QUANTBOXC2CTP_API void __stdcall CTP_RegOnRtnTrade(void* pMsgQueue,fnOnRtnTrade pCallback)
{
	if(pMsgQueue)
	{
		CTP_GetQueue(pMsgQueue)->RegisterCallback(pCallback);
	}
}

QUANTBOXC2CTP_API bool __stdcall CTP_ProcessMsgQueue(void* pMsgQueue)
{
	if(pMsgQueue)
	{
		return CTP_GetQueue(pMsgQueue)->Process();
	}
	return false;
}

QUANTBOXC2CTP_API void __stdcall CTP_ClearMsgQueue(void* pMsgQueue)
{
	if(pMsgQueue)
	{
		return CTP_GetQueue(pMsgQueue)->Clear();
	}
}

QUANTBOXC2CTP_API void __stdcall CTP_StartMsgQueue(void* pMsgQueue)
{
	if(pMsgQueue)
	{
		return CTP_GetQueue(pMsgQueue)->StartThread();
	}
}

QUANTBOXC2CTP_API void __stdcall CTP_StopMsgQueue(void* pMsgQueue)
{
	if(pMsgQueue)
	{
		return CTP_GetQueue(pMsgQueue)->StopThread();
	}
}

//QUANTBOXC2CTP_API void __stdcall CTP_EmitDirectly(void* pMsgQueue,bool bDirect)
//{
//	if(pMsgQueue)
//	{
//		return CTP_GetQueue(pMsgQueue)->EmitDirectly(bDirect);
//	}
//}

QUANTBOXC2CTP_API void* __stdcall MD_CreateMdApi()
{
	return new CMdUserApi();
}

QUANTBOXC2CTP_API void __stdcall MD_RegMsgQueue2MdApi(void* pMdUserApi,void* pMsgQueue)
{
	if(pMdUserApi)
	{
		MD_GetApi(pMdUserApi)->RegisterMsgQueue((CCTPMsgQueue*)pMsgQueue);
	}
}

QUANTBOXC2CTP_API void __stdcall MD_Connect(void* pMdUserApi,
	const char* szPath,
	const char* szAddresses,
	const char* szBrokerId,
	const char* szInvestorId,
	const char* szPassword)
{
	if(pMdUserApi
		&&szPath
		&&szAddresses
		&&szBrokerId
		&&szInvestorId
		&&szPassword)
	{
		MD_GetApi(pMdUserApi)->Connect(szPath,szAddresses,szBrokerId,szInvestorId,szPassword);
	}
}

QUANTBOXC2CTP_API void __stdcall MD_Disconnect(void* pMdUserApi)
{
	if(pMdUserApi)
	{
		MD_GetApi(pMdUserApi)->Disconnect();
	}
}

QUANTBOXC2CTP_API void __stdcall MD_Subscribe(void* pMdUserApi,const char* szInstrumentIDs,const char* szExchageID)
{
	if(pMdUserApi
		&&szInstrumentIDs)
	{
		MD_GetApi(pMdUserApi)->Subscribe(szInstrumentIDs);
	}
}

QUANTBOXC2CTP_API void __stdcall MD_Unsubscribe(void* pMdUserApi,const char* szInstrumentIDs,const char* szExchageID)
{
	if(pMdUserApi
		&&szInstrumentIDs)
	{
		MD_GetApi(pMdUserApi)->Unsubscribe(szInstrumentIDs);
	}
}

QUANTBOXC2CTP_API void __stdcall MD_ReleaseMdApi(void* pMdUserApi)
{
	if(pMdUserApi)
	{
		delete MD_GetApi(pMdUserApi);
	}
}

QUANTBOXC2CTP_API void* __stdcall TD_CreateTdApi()
{
	return new CTraderApi();
}

QUANTBOXC2CTP_API void __stdcall TD_RegMsgQueue2TdApi(void* pTraderApi,void* pMsgQueue)
{
	if(pTraderApi)
	{
		TD_GetApi(pTraderApi)->RegisterMsgQueue((CCTPMsgQueue*)pMsgQueue);
	}
}

QUANTBOXC2CTP_API void __stdcall TD_Connect(
	void* pTraderApi,
	const char* szPath,
	const char* szAddresses,
	const char* szBrokerId,
	const char* szInvestorId,
	const char* szPassword,
	THOST_TE_RESUME_TYPE nResumeType,
	const char* szUserProductInfo,
	const char* szAuthCode)
{
	if(pTraderApi
		&&szPath
		&&szAddresses
		&&szBrokerId
		&&szInvestorId
		&&szPassword)
	{
		if(szUserProductInfo&&szAuthCode)
			TD_GetApi(pTraderApi)->Connect(szPath,szAddresses,szBrokerId,szInvestorId,szPassword,nResumeType,szUserProductInfo,szAuthCode);
		else
			TD_GetApi(pTraderApi)->Connect(szPath,szAddresses,szBrokerId,szInvestorId,szPassword,nResumeType,"","");
	}
}

QUANTBOXC2CTP_API int __stdcall TD_SendOrder(
	void* pTraderApi,
	const char* szInstrument,
	TThostFtdcDirectionType Direction,
	const char* szCombOffsetFlag,
	const char* szCombHedgeFlag,
	TThostFtdcVolumeType VolumeTotalOriginal,
	double LimitPrice,
	TThostFtdcOrderPriceTypeType OrderPriceType,
	TThostFtdcTimeConditionType TimeCondition,
	TThostFtdcContingentConditionType ContingentCondition,
	double StopPrice,
	TThostFtdcVolumeConditionType VolumeCondition)
{
	if(pTraderApi
		&&szInstrument
		&&szCombOffsetFlag
		&&szCombHedgeFlag)
	{
		return TD_GetApi(pTraderApi)->ReqOrderInsert(szInstrument,
			Direction,
			szCombOffsetFlag,
			szCombHedgeFlag,
			VolumeTotalOriginal,
			LimitPrice,
			OrderPriceType,
			TimeCondition,
			ContingentCondition,
			StopPrice,
			VolumeCondition);
	}
	return 0;
}

QUANTBOXC2CTP_API void __stdcall TD_CancelOrder(void* pTraderApi,CThostFtdcOrderField *pOrder)
{
	if(pTraderApi)
	{
		TD_GetApi(pTraderApi)->ReqOrderAction(pOrder);
	}
}

QUANTBOXC2CTP_API void __stdcall TD_Disconnect(void* pTraderApi)
{
	if(pTraderApi)
	{
		TD_GetApi(pTraderApi)->Disconnect();
	}
}

QUANTBOXC2CTP_API void __stdcall TD_ReleaseTdApi(void* pTraderApi)
{
	if(pTraderApi)
	{
		delete TD_GetApi(pTraderApi);
	}
}

QUANTBOXC2CTP_API void __stdcall TD_ReqQryInvestorPosition(void* pTraderApi,const char* szInstrumentId)
{
	if(pTraderApi)
	{
		TD_GetApi(pTraderApi)->ReqQryInvestorPosition(NULL==szInstrumentId?"":szInstrumentId);
	}
}

QUANTBOXC2CTP_API void __stdcall TD_ReqQryInvestorPositionDetail(void* pTraderApi,const char* szInstrumentId)
{
	if(pTraderApi)
	{
		TD_GetApi(pTraderApi)->ReqQryInvestorPositionDetail(NULL==szInstrumentId?"":szInstrumentId);
	}
}

QUANTBOXC2CTP_API void __stdcall TD_ReqQryTradingAccount(void* pTraderApi)
{
	if(pTraderApi)
	{
		TD_GetApi(pTraderApi)->ReqQryTradingAccount();
	}
}

QUANTBOXC2CTP_API void __stdcall TD_ReqQryInstrument(void* pTraderApi,const char* szInstrumentId)
{
	if(pTraderApi)
	{
		TD_GetApi(pTraderApi)->ReqQryInstrument(NULL==szInstrumentId?"":szInstrumentId);
	}
}

QUANTBOXC2CTP_API void __stdcall TD_ReqQryInstrumentCommissionRate(void* pTraderApi,const char* szInstrumentId)
{
	if(pTraderApi)
	{
		TD_GetApi(pTraderApi)->ReqQryInstrumentCommissionRate(szInstrumentId);
	}
}

QUANTBOXC2CTP_API void __stdcall TD_ReqQryInstrumentMarginRate(void* pTraderApi,const char* szInstrumentId,TThostFtdcHedgeFlagType HedgeFlag)
{
	if(pTraderApi)
	{
		TD_GetApi(pTraderApi)->ReqQryInstrumentMarginRate(szInstrumentId,HedgeFlag);
	}
}

QUANTBOXC2CTP_API void __stdcall TD_ReqQryDepthMarketData(void* pTraderApi,const char* szInstrumentId)
{
	if(pTraderApi)
	{
		TD_GetApi(pTraderApi)->ReqQryDepthMarketData(szInstrumentId);
	}
}