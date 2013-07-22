// 下列 ifdef 块是创建使从 DLL 导出更简单的
// 宏的标准方法。此 DLL 中的所有文件都是用命令行上定义的 QUANTBOXC2CTP_EXPORTS
// 符号编译的。在使用此 DLL 的
// 任何其他项目上不应定义此符号。这样，源文件中包含此文件的任何其他项目都会将
// QUANTBOXC2CTP_API 函数视为是从 DLL 导入的，而此 DLL 则将用此宏定义的
// 符号视为是被导出的。
#ifndef _QUANTBOXC2CTP_H_
#define _QUANTBOXC2CTP_H_

#ifdef QUANTBOXC2CTP_EXPORTS
#define QUANTBOXC2CTP_API __declspec(dllexport)
#else
#define QUANTBOXC2CTP_API __declspec(dllimport)
#endif

#ifdef __cplusplus
extern "C" {
#endif

#include "include\CTP\ThostFtdcUserApiStruct.h"

//用于分隔输入的合列表，与前置机地址列表，所以不能出现“:”一类的
#define _QUANTBOXC2CTP_SEPS_ ",;"

//连接状态枚举
enum ConnectionStatus
{
	E_uninit,		//未初始化
	E_inited,		//已经初始化
	E_unconnected,	//连接已经断开
	E_connecting,	//连接中
	E_connected,	//连接成功
	E_authing,		//授权中
	E_authed,		//授权成功
	E_logining,		//登录中
	E_logined,		//登录成功
	E_confirming,	//结算单确认中
	E_confirmed,	//已经确认
	E_conn_max		//最大值
};

//回调函数类型定义（为编写方便，按字母排序）
typedef void (__stdcall *fnOnConnect)(void* pApi,CThostFtdcRspUserLoginField *pRspUserLogin,ConnectionStatus result);//连接后的结果状态
typedef void (__stdcall *fnOnDisconnect)(void* pApi,CThostFtdcRspInfoField *pRspInfo,ConnectionStatus step);//出错时所处的状态
typedef void (__stdcall *fnOnErrRtnOrderAction)(void* pTraderApi,CThostFtdcOrderActionField *pOrderAction, CThostFtdcRspInfoField *pRspInfo);
typedef void (__stdcall *fnOnErrRtnOrderInsert)(void* pTraderApi,CThostFtdcInputOrderField *pInputOrder, CThostFtdcRspInfoField *pRspInfo);
typedef void (__stdcall *fnOnRspError)(void* pApi,CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
typedef void (__stdcall *fnOnRspOrderAction)(void* pTraderApi,CThostFtdcInputOrderActionField *pInputOrderAction, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
typedef void (__stdcall *fnOnRspOrderInsert)(void* pTraderApi,CThostFtdcInputOrderField *pInputOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
typedef void (__stdcall *fnOnRspQryDepthMarketData)(void* pTraderApi,CThostFtdcDepthMarketDataField *pDepthMarketData, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
typedef void (__stdcall *fnOnRspQryInstrument)(void* pTraderApi,CThostFtdcInstrumentField *pInstrument, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
typedef void (__stdcall *fnOnRspQryInstrumentCommissionRate)(void* pTraderApi,CThostFtdcInstrumentCommissionRateField *pInstrumentCommissionRate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
typedef void (__stdcall *fnOnRspQryInstrumentMarginRate)(void* pTraderApi,CThostFtdcInstrumentMarginRateField *pInstrumentMarginRate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
typedef void (__stdcall *fnOnRspQryInvestorPosition)(void* pTraderApi,CThostFtdcInvestorPositionField *pInvestorPosition, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
typedef void (__stdcall *fnOnRspQryInvestorPositionDetail)(void* pTraderApi,CThostFtdcInvestorPositionDetailField *pInvestorPositionDetail, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
typedef void (__stdcall *fnOnRspQryOrder)(void* pTraderApi,CThostFtdcOrderField *pOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
typedef void (__stdcall *fnOnRspQryTrade)(void* pTraderApi,CThostFtdcTradeField *pTrade, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
typedef void (__stdcall *fnOnRspQryTradingAccount)(void* pTraderApi,CThostFtdcTradingAccountField *pTradingAccount, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
typedef void (__stdcall *fnOnRtnDepthMarketData)(void* pMdUserApi,CThostFtdcDepthMarketDataField *pDepthMarketData);
typedef void (__stdcall *fnOnRtnInstrumentStatus)(void* pTraderApi,CThostFtdcInstrumentStatusField *pInstrumentStatus);
typedef void (__stdcall *fnOnRtnOrder)(void* pTraderApi,CThostFtdcOrderField *pOrder);
typedef void (__stdcall *fnOnRtnTrade)(void* pTraderApi,CThostFtdcTradeField *pTrade);

//创建接收消息队列，支持响应行情和交易
QUANTBOXC2CTP_API void* __stdcall CTP_CreateMsgQueue();

//向消息队列注册回调函数
QUANTBOXC2CTP_API void __stdcall CTP_RegOnConnect(void* pMsgQueue,fnOnConnect pCallback);
QUANTBOXC2CTP_API void __stdcall CTP_RegOnDisconnect(void* pMsgQueue,fnOnDisconnect pCallback);
QUANTBOXC2CTP_API void __stdcall CTP_RegOnErrRtnOrderAction(void* pMsgQueue,fnOnErrRtnOrderAction pCallback);
QUANTBOXC2CTP_API void __stdcall CTP_RegOnErrRtnOrderInsert(void* pMsgQueue,fnOnErrRtnOrderInsert pCallback);
QUANTBOXC2CTP_API void __stdcall CTP_RegOnRspError(void* pMsgQueue,fnOnRspError pCallback);
QUANTBOXC2CTP_API void __stdcall CTP_RegOnRspOrderAction(void* pMsgQueue,fnOnRspOrderAction pCallback);
QUANTBOXC2CTP_API void __stdcall CTP_RegOnRspOrderInsert(void* pMsgQueue,fnOnRspOrderInsert pCallback);
QUANTBOXC2CTP_API void __stdcall CTP_RegOnRspQryDepthMarketData(void* pMsgQueue,fnOnRspQryDepthMarketData pCallback);
QUANTBOXC2CTP_API void __stdcall CTP_RegOnRspQryInstrument(void* pMsgQueue,fnOnRspQryInstrument pCallback);
QUANTBOXC2CTP_API void __stdcall CTP_RegOnRspQryInstrumentCommissionRate(void* pMsgQueue,fnOnRspQryInstrumentCommissionRate pCallback);
QUANTBOXC2CTP_API void __stdcall CTP_RegOnRspQryInstrumentMarginRate(void* pMsgQueue,fnOnRspQryInstrumentMarginRate pCallback);
QUANTBOXC2CTP_API void __stdcall CTP_RegOnRspQryInvestorPosition(void* pMsgQueue,fnOnRspQryInvestorPosition pCallback);
QUANTBOXC2CTP_API void __stdcall CTP_RegOnRspQryInvestorPositionDetail(void* pMsgQueue,fnOnRspQryInvestorPositionDetail pCallback);
QUANTBOXC2CTP_API void __stdcall CTP_RegOnRspQryOrder(void* pMsgQueue,fnOnRspQryOrder pCallback);
QUANTBOXC2CTP_API void __stdcall CTP_RegOnRspQryTrade(void* pMsgQueue,fnOnRspQryTrade pCallback);
QUANTBOXC2CTP_API void __stdcall CTP_RegOnRspQryTradingAccount(void* pMsgQueue,fnOnRspQryTradingAccount pCallback);
QUANTBOXC2CTP_API void __stdcall CTP_RegOnRtnDepthMarketData(void* pMsgQueue,fnOnRtnDepthMarketData pCallback);
QUANTBOXC2CTP_API void __stdcall CTP_RegOnRtnInstrumentStatus(void* pMsgQueue,fnOnRtnInstrumentStatus pCallback);
QUANTBOXC2CTP_API void __stdcall CTP_RegOnRtnOrder(void* pMsgQueue,fnOnRtnOrder pCallback);
QUANTBOXC2CTP_API void __stdcall CTP_RegOnRtnTrade(void* pMsgQueue,fnOnRtnTrade pCallback);

//释放消息队列
QUANTBOXC2CTP_API void __stdcall CTP_ReleaseMsgQueue(void* pMsgQueue);
//清空消息队列内容
QUANTBOXC2CTP_API void __stdcall CTP_ClearMsgQueue(void* pMsgQueue);

//处理消息队列第一条记录
QUANTBOXC2CTP_API bool __stdcall CTP_ProcessMsgQueue(void* pMsgQueue);
//开启队列回调主动推送线程
QUANTBOXC2CTP_API void __stdcall CTP_StartMsgQueue(void* pMsgQueue);
//停止队列回调主动推送线程
QUANTBOXC2CTP_API void __stdcall CTP_StopMsgQueue(void* pMsgQueue);
//设置是否直接触发回调
//QUANTBOXC2CTP_API void __stdcall CTP_EmitDirectly(void* pMsgQueue,bool bDirect);

//行情接口=======================================

//创建行情接口
QUANTBOXC2CTP_API void* __stdcall MD_CreateMdApi();
//将消息队列注册到行情接口上
QUANTBOXC2CTP_API void __stdcall MD_RegMsgQueue2MdApi(void* pMdUserApi,void* pMsgQueue);
//连接
QUANTBOXC2CTP_API void __stdcall MD_Connect(
	void* pMdUserApi,
	const char* szPath,
	const char* szAddresses,
	const char* szBrokerId,
	const char* szInvestorId,
	const char* szPassword);

//订阅合约，多个合约以“,”分隔，与证券统一调用接口，交易所参数目前无效
QUANTBOXC2CTP_API void __stdcall MD_Subscribe(void* pMdUserApi,const char* szInstrumentIDs,const char* szExchageID);
//取消订阅，多个合约以“,”分隔，与证券统一调用接口，交易所参数目前无效
QUANTBOXC2CTP_API void __stdcall MD_Unsubscribe(void* pMdUserApi,const char* szInstrumentIDs,const char* szExchageID);
//断开连接
QUANTBOXC2CTP_API void __stdcall MD_Disconnect(void* pMdUserApi);
//释放行情接口
QUANTBOXC2CTP_API void __stdcall MD_ReleaseMdApi(void* pMdUserApi);

//交易接口=======================================
QUANTBOXC2CTP_API void* __stdcall TD_CreateTdApi();
//将消息队列注册到交易接口上
QUANTBOXC2CTP_API void __stdcall TD_RegMsgQueue2TdApi(void* pTraderApi,void* pMsgQueue);
//连接
QUANTBOXC2CTP_API void __stdcall TD_Connect(
	void* pTraderApi,
	const char* szPath,
	const char* szAddresses,
	const char* szBrokerId,
	const char* szInvestorId,
	const char* szPassword,
	THOST_TE_RESUME_TYPE nResumeType,
	const char* szUserProductInfo,
	const char* szAuthCode);

//报单
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
	TThostFtdcVolumeConditionType VolumeCondition);

//撤单
QUANTBOXC2CTP_API void __stdcall TD_CancelOrder(void* pTraderApi,CThostFtdcOrderField *pOrder);

//断开连接
QUANTBOXC2CTP_API void __stdcall TD_Disconnect(void* pTraderApi);
//释放行情接口
QUANTBOXC2CTP_API void __stdcall TD_ReleaseTdApi(void* pTraderApi);
//查综合持仓
QUANTBOXC2CTP_API void __stdcall TD_ReqQryInvestorPosition(void* pTraderApi,const char* szInstrumentId);
//查持仓明细
QUANTBOXC2CTP_API void __stdcall TD_ReqQryInvestorPositionDetail(void* pTraderApi,const char* szInstrumentId);
//查资金账号
QUANTBOXC2CTP_API void __stdcall TD_ReqQryTradingAccount(void* pTraderApi);
//查合约
QUANTBOXC2CTP_API void __stdcall TD_ReqQryInstrument(void* pTraderApi,const char* szInstrumentId);
//查手续费
QUANTBOXC2CTP_API void __stdcall TD_ReqQryInstrumentCommissionRate(void* pTraderApi,const char* szInstrumentId);
//查保证金
QUANTBOXC2CTP_API void __stdcall TD_ReqQryInstrumentMarginRate(void* pTraderApi,const char* szInstrumentId,TThostFtdcHedgeFlagType HedgeFlag);
//查深度行情
QUANTBOXC2CTP_API void __stdcall TD_ReqQryDepthMarketData(void* pTraderApi,const char* szInstrumentId);

#ifdef __cplusplus
}
#endif


#endif//end of _QUANTBOXC2CTP_H_