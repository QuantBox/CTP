using System;

namespace QuantBox.CSharp2CTP
{
    public delegate void fnOnConnect(IntPtr pApi, ref CThostFtdcRspUserLoginField pRspUserLogin, ConnectionStatus result);
    public delegate void fnOnDisconnect(IntPtr pApi, ref CThostFtdcRspInfoField pRspInfo, ConnectionStatus step);
    public delegate void fnOnErrRtnOrderAction(IntPtr pTraderApi, ref CThostFtdcOrderActionField pOrderAction, ref CThostFtdcRspInfoField pRspInfo);
    public delegate void fnOnErrRtnOrderInsert(IntPtr pTraderApi, ref CThostFtdcInputOrderField pInputOrder, ref CThostFtdcRspInfoField pRspInfo);
    public delegate void fnOnErrRtnQuoteAction(IntPtr pTraderApi, ref CThostFtdcQuoteActionField pQuoteAction, ref CThostFtdcRspInfoField pRspInfo);
    public delegate void fnOnErrRtnQuoteInsert(IntPtr pTraderApi, ref CThostFtdcInputQuoteField pInputQuote, ref CThostFtdcRspInfoField pRspInfo);
    public delegate void fnOnRspError(IntPtr pApi, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
    public delegate void fnOnRspOrderAction(IntPtr pTraderApi, ref CThostFtdcInputOrderActionField pInputOrderAction, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
    public delegate void fnOnRspOrderInsert(IntPtr pTraderApi, ref CThostFtdcInputOrderField pInputOrder, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
    public delegate void fnOnRspQryDepthMarketData(IntPtr pTraderApi, ref CThostFtdcDepthMarketDataField pDepthMarketData, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
    public delegate void fnOnRspQryInstrument(IntPtr pTraderApi, ref CThostFtdcInstrumentField pInstrument, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
    public delegate void fnOnRspQryInstrumentCommissionRate(IntPtr pTraderApi, ref CThostFtdcInstrumentCommissionRateField pInstrumentCommissionRate, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
    public delegate void fnOnRspQryInstrumentMarginRate(IntPtr pTraderApi, ref CThostFtdcInstrumentMarginRateField pInstrumentMarginRate, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
    public delegate void fnOnRspQryInvestorPosition(IntPtr pTraderApi, ref CThostFtdcInvestorPositionField pInvestorPosition, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
    public delegate void fnOnRspQryInvestorPositionDetail(IntPtr pTraderApi, ref CThostFtdcInvestorPositionDetailField pInvestorPositionDetail, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
    public delegate void fnOnRspQryOrder(IntPtr pTraderApi, ref CThostFtdcOrderField pOrder, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
    public delegate void fnOnRspQryTrade(IntPtr pTraderApi, ref CThostFtdcTradeField pTrade, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
    public delegate void fnOnRspQryTradingAccount(IntPtr pTraderApi, ref CThostFtdcTradingAccountField pTradingAccount, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
    public delegate void fnOnRspQuoteAction(IntPtr pTraderApi, ref CThostFtdcInputQuoteActionField pInputQuoteAction, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
    public delegate void fnOnRspQuoteInsert(IntPtr pTraderApi, ref CThostFtdcInputQuoteField pInputQuote, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
    public delegate void fnOnRtnDepthMarketData(IntPtr pMdUserApi, ref CThostFtdcDepthMarketDataField pDepthMarketData);
    public delegate void fnOnRtnForQuoteRsp(IntPtr pMdUserApi, ref CThostFtdcForQuoteRspField pForQuoteRsp);
    public delegate void fnOnRtnInstrumentStatus(IntPtr pTraderApi, ref CThostFtdcInstrumentStatusField pInstrumentStatus);
    public delegate void fnOnRtnOrder(IntPtr pTraderApi, ref CThostFtdcOrderField pOrder);
    public delegate void fnOnRtnQuote(IntPtr pTraderApi, ref CThostFtdcQuoteField pQuote);
    public delegate void fnOnRtnTrade(IntPtr pTraderApi, ref CThostFtdcTradeField pTrade);
}
