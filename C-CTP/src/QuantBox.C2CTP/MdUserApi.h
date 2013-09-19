#pragma once

#include "QuantBox.C2CTP.h"
#include "include\CTP\ThostFtdcMdApi.h"

#include <set>
#include <string>

using namespace std;

class CCTPMsgQueue;

class CMdUserApi :
	public CThostFtdcMdSpi
{
public:
	CMdUserApi(void);
	virtual ~CMdUserApi(void);

	void RegisterMsgQueue(CCTPMsgQueue* pMsgQueue);

	void Connect(const string& szPath,
		const string& szAddresses,
		const string& szBrokerId,
		const string& szInvestorId,
		const string& szPassword);
	void Disconnect();

	void Subscribe(const string& szInstrumentIDs);
	void Unsubscribe(const string& szInstrumentIDs);

private:
	//订阅行情
	void Subscribe(const set<string>& instrumentIDs);
	//登录请求
	void ReqUserLogin();

	virtual void OnFrontConnected();
	virtual void OnFrontDisconnected(int nReason);
	virtual void OnRspUserLogin(CThostFtdcRspUserLoginField *pRspUserLogin, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	virtual void OnRspError(CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	virtual void OnRspSubMarketData(CThostFtdcSpecificInstrumentField *pSpecificInstrument, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	virtual void OnRspUnSubMarketData(CThostFtdcSpecificInstrumentField *pSpecificInstrument, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	virtual void OnRtnDepthMarketData(CThostFtdcDepthMarketDataField *pDepthMarketData);

	//检查是否出错
	bool IsErrorRspInfo(CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);//将出错消息送到消息队列
	bool IsErrorRspInfo(CThostFtdcRspInfoField *pRspInfo);//不送出错消息

private:
	CRITICAL_SECTION			m_csMapInstrumentIDs;

	ConnectionStatus			m_status;				//连接状态
	int							m_nRequestID;			//请求ID，每次请求前自增
	
	set<string>					m_setInstrumentIDs;		//正在订阅的合约
	CThostFtdcMdApi*			m_pApi;					//行情API
	CCTPMsgQueue*				m_msgQueue;				//消息队列指针

	string						m_szPath;				//生成配置文件的路径
	set<string>					m_arrAddresses;			//服务器地址
	string						m_szBrokerId;			//期商ID
	string						m_szInvestorId;			//投资者ID
	string						m_szPassword;			//密码
};

