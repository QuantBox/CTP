// ���� ifdef ���Ǵ���ʹ�� DLL �������򵥵�
// ��ı�׼�������� DLL �е������ļ��������������϶���� QUANTBOXC2CTP_EXPORTS
// ���ű���ġ���ʹ�ô� DLL ��
// �κ�������Ŀ�ϲ�Ӧ����˷��š�������Դ�ļ��а������ļ����κ�������Ŀ���Ὣ
// QUANTBOXC2CTP_API ������Ϊ�Ǵ� DLL ����ģ����� DLL ���ô˺궨���
// ������Ϊ�Ǳ������ġ�
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

//���ڷָ�����ĺ��б���ǰ�û���ַ�б����Բ��ܳ��֡�:��һ���
#define _QUANTBOXC2CTP_SEPS_ ",;"

//����״̬ö��
enum ConnectionStatus
{
	E_uninit,		//δ��ʼ��
	E_inited,		//�Ѿ���ʼ��
	E_unconnected,	//�����Ѿ��Ͽ�
	E_connecting,	//������
	E_connected,	//���ӳɹ�
	E_authing,		//��Ȩ��
	E_authed,		//��Ȩ�ɹ�
	E_logining,		//��¼��
	E_logined,		//��¼�ɹ�
	E_confirming,	//���㵥ȷ����
	E_confirmed,	//�Ѿ�ȷ��
	E_conn_max		//���ֵ
};

//�ص��������Ͷ��壨Ϊ��д���㣬����ĸ����
typedef void (__stdcall *fnOnConnect)(void* pApi,CThostFtdcRspUserLoginField *pRspUserLogin,ConnectionStatus result);//���Ӻ�Ľ��״̬
typedef void (__stdcall *fnOnDisconnect)(void* pApi,CThostFtdcRspInfoField *pRspInfo,ConnectionStatus step);//����ʱ������״̬
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

//����������Ϣ���У�֧����Ӧ����ͽ���
QUANTBOXC2CTP_API void* __stdcall CTP_CreateMsgQueue();

//����Ϣ����ע��ص�����
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

//�ͷ���Ϣ����
QUANTBOXC2CTP_API void __stdcall CTP_ReleaseMsgQueue(void* pMsgQueue);
//�����Ϣ��������
QUANTBOXC2CTP_API void __stdcall CTP_ClearMsgQueue(void* pMsgQueue);

//������Ϣ���е�һ����¼
QUANTBOXC2CTP_API bool __stdcall CTP_ProcessMsgQueue(void* pMsgQueue);
//�������лص����������߳�
QUANTBOXC2CTP_API void __stdcall CTP_StartMsgQueue(void* pMsgQueue);
//ֹͣ���лص����������߳�
QUANTBOXC2CTP_API void __stdcall CTP_StopMsgQueue(void* pMsgQueue);
//�����Ƿ�ֱ�Ӵ����ص�
//QUANTBOXC2CTP_API void __stdcall CTP_EmitDirectly(void* pMsgQueue,bool bDirect);

//����ӿ�=======================================

//��������ӿ�
QUANTBOXC2CTP_API void* __stdcall MD_CreateMdApi();
//����Ϣ����ע�ᵽ����ӿ���
QUANTBOXC2CTP_API void __stdcall MD_RegMsgQueue2MdApi(void* pMdUserApi,void* pMsgQueue);
//����
QUANTBOXC2CTP_API void __stdcall MD_Connect(
	void* pMdUserApi,
	const char* szPath,
	const char* szAddresses,
	const char* szBrokerId,
	const char* szInvestorId,
	const char* szPassword);

//���ĺ�Լ�������Լ�ԡ�,���ָ�����֤ȯͳһ���ýӿڣ�����������Ŀǰ��Ч
QUANTBOXC2CTP_API void __stdcall MD_Subscribe(void* pMdUserApi,const char* szInstrumentIDs,const char* szExchageID);
//ȡ�����ģ������Լ�ԡ�,���ָ�����֤ȯͳһ���ýӿڣ�����������Ŀǰ��Ч
QUANTBOXC2CTP_API void __stdcall MD_Unsubscribe(void* pMdUserApi,const char* szInstrumentIDs,const char* szExchageID);
//�Ͽ�����
QUANTBOXC2CTP_API void __stdcall MD_Disconnect(void* pMdUserApi);
//�ͷ�����ӿ�
QUANTBOXC2CTP_API void __stdcall MD_ReleaseMdApi(void* pMdUserApi);

//���׽ӿ�=======================================
QUANTBOXC2CTP_API void* __stdcall TD_CreateTdApi();
//����Ϣ����ע�ᵽ���׽ӿ���
QUANTBOXC2CTP_API void __stdcall TD_RegMsgQueue2TdApi(void* pTraderApi,void* pMsgQueue);
//����
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

//����
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

//����
QUANTBOXC2CTP_API void __stdcall TD_CancelOrder(void* pTraderApi,CThostFtdcOrderField *pOrder);

//�Ͽ�����
QUANTBOXC2CTP_API void __stdcall TD_Disconnect(void* pTraderApi);
//�ͷ�����ӿ�
QUANTBOXC2CTP_API void __stdcall TD_ReleaseTdApi(void* pTraderApi);
//���ۺϳֲ�
QUANTBOXC2CTP_API void __stdcall TD_ReqQryInvestorPosition(void* pTraderApi,const char* szInstrumentId);
//��ֲ���ϸ
QUANTBOXC2CTP_API void __stdcall TD_ReqQryInvestorPositionDetail(void* pTraderApi,const char* szInstrumentId);
//���ʽ��˺�
QUANTBOXC2CTP_API void __stdcall TD_ReqQryTradingAccount(void* pTraderApi);
//���Լ
QUANTBOXC2CTP_API void __stdcall TD_ReqQryInstrument(void* pTraderApi,const char* szInstrumentId);
//��������
QUANTBOXC2CTP_API void __stdcall TD_ReqQryInstrumentCommissionRate(void* pTraderApi,const char* szInstrumentId);
//�鱣֤��
QUANTBOXC2CTP_API void __stdcall TD_ReqQryInstrumentMarginRate(void* pTraderApi,const char* szInstrumentId,TThostFtdcHedgeFlagType HedgeFlag);
//���������
QUANTBOXC2CTP_API void __stdcall TD_ReqQryDepthMarketData(void* pTraderApi,const char* szInstrumentId);

#ifdef __cplusplus
}
#endif


#endif//end of _QUANTBOXC2CTP_H_