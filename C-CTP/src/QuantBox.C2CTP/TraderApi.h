#pragma once

#include "QuantBox.C2CTP.h"
#include "include\CTP\ThostFtdcTraderApi.h"

#include <set>
#include <list>
#include <map>
#include <string>

using namespace std;

class CCTPMsgQueue;

class CTraderApi :
	public CThostFtdcTraderSpi
{
	//�������ݰ�����
	enum RequestType
	{
		E_ReqAuthenticateField,
		E_ReqUserLoginField,
		E_SettlementInfoConfirmField,
		E_QryInstrumentField,
		E_InputOrderField,
		E_InputOrderActionField,
		E_QryTradingAccountField,
		E_QryInvestorPositionField,
		E_QryInvestorPositionDetailField,
		E_QryInstrumentCommissionRateField,
		E_QryInstrumentMarginRateField,
		E_QryDepthMarketDataField,
	};

	//�������ݰ��ṹ��
	struct SRequest
	{
		RequestType type;
		union{
			CThostFtdcReqAuthenticateField				ReqAuthenticateField;
			CThostFtdcReqUserLoginField					ReqUserLoginField;
			CThostFtdcSettlementInfoConfirmField		SettlementInfoConfirmField;
			CThostFtdcQryDepthMarketDataField			QryDepthMarketDataField;
			CThostFtdcQryInstrumentField				QryInstrumentField;
			CThostFtdcQryInstrumentCommissionRateField	QryInstrumentCommissionRateField;
			CThostFtdcQryInstrumentMarginRateField		QryInstrumentMarginRateField;
			CThostFtdcQryInvestorPositionField			QryInvestorPositionField;
			CThostFtdcQryInvestorPositionDetailField    QryInvestorPositionDetailField;
			CThostFtdcQryTradingAccountField			QryTradingAccountField;
			CThostFtdcInputOrderField					InputOrderField;
			CThostFtdcInputOrderActionField				InputOrderActionField;
		};
	};

public:
	CTraderApi(void);
	virtual ~CTraderApi(void);

	void RegisterMsgQueue(CCTPMsgQueue* pMsgQueue);

	void Connect(const string& szPath,
		const string& szAddresses,
		const string& szBrokerId,
		const string& szInvestorId,
		const string& szPassword,
		THOST_TE_RESUME_TYPE nResumeType,
		const string& szUserProductInfo,
		const string& szAuthCode);
	void Disconnect();

	int ReqOrderInsert(
		const string& szInstrumentId,
		TThostFtdcDirectionType Direction,
		const TThostFtdcCombOffsetFlagType CombOffsetFlag,
		const TThostFtdcCombHedgeFlagType CombHedgeFlag,
		TThostFtdcVolumeType VolumeTotalOriginal,
		TThostFtdcPriceType LimitPrice,
		TThostFtdcOrderPriceTypeType OrderPriceType,
		TThostFtdcTimeConditionType TimeCondition,
		TThostFtdcContingentConditionType ContingentCondition,
		TThostFtdcPriceType StopPrice,
		TThostFtdcVolumeConditionType VolumeCondition);
	void ReqOrderAction(CThostFtdcOrderField *pOrder);

	void ReqQryTradingAccount();
	void ReqQryInvestorPosition(const string& szInstrumentId);
	void ReqQryInvestorPositionDetail(const string& szInstrumentId);
	void ReqQryInstrument(const string& szInstrumentId);
	void ReqQryInstrumentCommissionRate(const string& szInstrumentId);
	void ReqQryInstrumentMarginRate(const string& szInstrumentId,TThostFtdcHedgeFlagType HedgeFlag = THOST_FTDC_HF_Speculation);
	void ReqQryDepthMarketData(const string& szInstrumentId);

private:
	//���ݰ������߳�
	friend DWORD WINAPI SendThread(LPVOID lpParam);
	void RunInThread();
	void StopThread();

	//ָ�����ݰ����ͣ����ɶ�Ӧ���ݰ�
	SRequest * MakeRequestBuf(RequestType type);
	//������������������
	void ReleaseRequestListBuf();
	//����ѷ����������
	void ReleaseRequestMapBuf();
	//���ָ�����������ָ����
	void ReleaseRequestMapBuf(int nRequestID);
	//��ӵ��Ѿ��������
	void AddRequestMapBuf(int nRequestID,SRequest* pRequest);
	//��ӵ������Ͱ�����
	void AddToSendQueue(SRequest * pRequest);

	void ReqAuthenticate();
	void ReqUserLogin();
	void ReqSettlementInfoConfirm();

	//����Ƿ����
	bool IsErrorRspInfo(CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);//����Ϣ���������Ϣ
	bool IsErrorRspInfo(CThostFtdcRspInfoField *pRspInfo);//�������Ϣ

	//����
	virtual void OnFrontConnected();
	virtual void OnFrontDisconnected(int nReason);

	//��֤
	virtual void OnRspAuthenticate(CThostFtdcRspAuthenticateField *pRspAuthenticateField, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	virtual void OnRspUserLogin(CThostFtdcRspUserLoginField *pRspUserLogin, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	virtual void OnRspSettlementInfoConfirm(CThostFtdcSettlementInfoConfirmField *pSettlementInfoConfirm, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);

	//�µ�
	virtual void OnRspOrderInsert(CThostFtdcInputOrderField *pInputOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	virtual void OnErrRtnOrderInsert(CThostFtdcInputOrderField *pInputOrder, CThostFtdcRspInfoField *pRspInfo);

	//����
	virtual void OnRspOrderAction(CThostFtdcInputOrderActionField *pInputOrderAction, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	virtual void OnErrRtnOrderAction(CThostFtdcOrderActionField *pOrderAction, CThostFtdcRspInfoField *pRspInfo);
	
	//�����ر�
	virtual void OnRspQryOrder(CThostFtdcOrderField *pOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	virtual void OnRtnOrder(CThostFtdcOrderField *pOrder);
	
	//�����ر�
	virtual void OnRspQryTrade(CThostFtdcTradeField *pTrade, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	virtual void OnRtnTrade(CThostFtdcTradeField *pTrade);

	//��λ
	virtual void OnRspQryInvestorPosition(CThostFtdcInvestorPositionField *pInvestorPosition, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	virtual void OnRspQryInvestorPositionDetail(CThostFtdcInvestorPositionDetailField *pInvestorPositionDetail, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	virtual void OnRspQryInvestorPositionCombineDetail(CThostFtdcInvestorPositionCombineDetailField *pInvestorPositionCombineDetail, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) {};

	//�ʽ�
	virtual void OnRspQryTradingAccount(CThostFtdcTradingAccountField *pTradingAccount, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	
	//��Լ��������
	virtual void OnRspQryInstrument(CThostFtdcInstrumentField *pInstrument, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	virtual void OnRspQryInstrumentMarginRate(CThostFtdcInstrumentMarginRateField *pInstrumentMarginRate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	virtual void OnRspQryInstrumentCommissionRate(CThostFtdcInstrumentCommissionRateField *pInstrumentCommissionRate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	
	//��ѯ������Ӧ
	virtual void OnRspQryDepthMarketData(CThostFtdcDepthMarketDataField *pDepthMarketData, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);

	//����
	virtual void OnRspError(CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	virtual void OnRtnInstrumentStatus(CThostFtdcInstrumentStatusField *pInstrumentStatus);

private:
	ConnectionStatus			m_status;				//����״̬
	volatile LONG				m_lRequestID;			//����ID,�ñ�������
	
	CThostFtdcRspUserLoginField m_RspUserLogin;			//���صĵ�¼�ɹ���Ӧ��Ŀǰ���ô��ڳ�Ա���б�����������

	CRITICAL_SECTION			m_csOrderRef;
	int							m_nMaxOrderRef;			//�������ã��������ֱ�������������

	CThostFtdcTraderApi*		m_pApi;					//����API
	CCTPMsgQueue*				m_msgQueue;				//��Ϣ����ָ��

	string						m_szPath;				//���������ļ���·��
	set<string>					m_arrAddresses;			//��������ַ
	string						m_szBrokerId;			//����ID
	string						m_szInvestorId;			//Ͷ����ID
	string						m_szPassword;			//����
	string						m_szUserProductInfo;	//��Ʒ��Ϣ
	string						m_szAuthCode;			//��֤��

	int							m_nSleep;
	volatile bool				m_bRunning;
	HANDLE						m_hThread;

	CRITICAL_SECTION			m_csList;
	list<SRequest*>				m_reqList;				//�������������

	CRITICAL_SECTION			m_csMap;
	map<int,SRequest*>			m_reqMap;				//�ѷ��������
};

