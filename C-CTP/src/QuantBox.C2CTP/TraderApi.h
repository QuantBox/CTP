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
	//请求数据包类型
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

	//请求数据包结构体
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
	//数据包发送线程
	friend DWORD WINAPI SendThread(LPVOID lpParam);
	void RunInThread();
	void StopThread();

	//指定数据包类型，生成对应数据包
	SRequest * MakeRequestBuf(RequestType type);
	//清除将发送请求包队列
	void ReleaseRequestListBuf();
	//清除已发送请求包池
	void ReleaseRequestMapBuf();
	//清除指定请求包池中指定包
	void ReleaseRequestMapBuf(int nRequestID);
	//添加到已经请求包池
	void AddRequestMapBuf(int nRequestID,SRequest* pRequest);
	//添加到将发送包队列
	void AddToSendQueue(SRequest * pRequest);

	void ReqAuthenticate();
	void ReqUserLogin();
	void ReqSettlementInfoConfirm();

	//检查是否出错
	bool IsErrorRspInfo(CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);//向消息队列输出信息
	bool IsErrorRspInfo(CThostFtdcRspInfoField *pRspInfo);//不输出信息

	//连接
	virtual void OnFrontConnected();
	virtual void OnFrontDisconnected(int nReason);

	//认证
	virtual void OnRspAuthenticate(CThostFtdcRspAuthenticateField *pRspAuthenticateField, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	virtual void OnRspUserLogin(CThostFtdcRspUserLoginField *pRspUserLogin, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	virtual void OnRspSettlementInfoConfirm(CThostFtdcSettlementInfoConfirmField *pSettlementInfoConfirm, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);

	//下单
	virtual void OnRspOrderInsert(CThostFtdcInputOrderField *pInputOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	virtual void OnErrRtnOrderInsert(CThostFtdcInputOrderField *pInputOrder, CThostFtdcRspInfoField *pRspInfo);

	//撤单
	virtual void OnRspOrderAction(CThostFtdcInputOrderActionField *pInputOrderAction, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	virtual void OnErrRtnOrderAction(CThostFtdcOrderActionField *pOrderAction, CThostFtdcRspInfoField *pRspInfo);
	
	//报单回报
	virtual void OnRspQryOrder(CThostFtdcOrderField *pOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	virtual void OnRtnOrder(CThostFtdcOrderField *pOrder);
	
	//撤单回报
	virtual void OnRspQryTrade(CThostFtdcTradeField *pTrade, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	virtual void OnRtnTrade(CThostFtdcTradeField *pTrade);

	//仓位
	virtual void OnRspQryInvestorPosition(CThostFtdcInvestorPositionField *pInvestorPosition, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	virtual void OnRspQryInvestorPositionDetail(CThostFtdcInvestorPositionDetailField *pInvestorPositionDetail, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	virtual void OnRspQryInvestorPositionCombineDetail(CThostFtdcInvestorPositionCombineDetailField *pInvestorPositionCombineDetail, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) {};

	//资金
	virtual void OnRspQryTradingAccount(CThostFtdcTradingAccountField *pTradingAccount, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	
	//合约、手续费
	virtual void OnRspQryInstrument(CThostFtdcInstrumentField *pInstrument, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	virtual void OnRspQryInstrumentMarginRate(CThostFtdcInstrumentMarginRateField *pInstrumentMarginRate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	virtual void OnRspQryInstrumentCommissionRate(CThostFtdcInstrumentCommissionRateField *pInstrumentCommissionRate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	
	//查询行情响应
	virtual void OnRspQryDepthMarketData(CThostFtdcDepthMarketDataField *pDepthMarketData, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);

	//其它
	virtual void OnRspError(CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	virtual void OnRtnInstrumentStatus(CThostFtdcInstrumentStatusField *pInstrumentStatus);

private:
	ConnectionStatus			m_status;				//连接状态
	volatile LONG				m_lRequestID;			//请求ID,得保持自增
	
	CThostFtdcRspUserLoginField m_RspUserLogin;			//返回的登录成功响应，目前利用此内成员进行报单所属区分

	CRITICAL_SECTION			m_csOrderRef;
	int							m_nMaxOrderRef;			//报单引用，用于区分报单，保持自增

	CThostFtdcTraderApi*		m_pApi;					//交易API
	CCTPMsgQueue*				m_msgQueue;				//消息队列指针

	string						m_szPath;				//生成配置文件的路径
	set<string>					m_arrAddresses;			//服务器地址
	string						m_szBrokerId;			//期商ID
	string						m_szInvestorId;			//投资者ID
	string						m_szPassword;			//密码
	string						m_szUserProductInfo;	//产品信息
	string						m_szAuthCode;			//认证码

	int							m_nSleep;
	volatile bool				m_bRunning;
	HANDLE						m_hThread;

	CRITICAL_SECTION			m_csList;
	list<SRequest*>				m_reqList;				//将发送请求队列

	CRITICAL_SECTION			m_csMap;
	map<int,SRequest*>			m_reqMap;				//已发送请求池
};

