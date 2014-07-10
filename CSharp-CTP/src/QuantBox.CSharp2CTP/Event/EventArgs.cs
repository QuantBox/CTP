using QuantBox.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuantBox.CSharp2CTP.Event
{
    //通用
    public class OnConnectArgs : EventArgs
    {
        public readonly IntPtr pApi;
        public readonly CThostFtdcRspUserLoginField pRspUserLogin;
        public readonly ConnectionStatus result;
        public OnConnectArgs(IntPtr pApi, ref CThostFtdcRspUserLoginField pRspUserLogin, ConnectionStatus result)
        {
            this.pApi = pApi;
            this.pRspUserLogin = pRspUserLogin;
            this.result = result;
        }
    }

    public class OnDisconnectArgs : EventArgs
    {
        public readonly IntPtr pApi;
        public readonly CThostFtdcRspInfoField pRspInfo;
        public readonly ConnectionStatus step;
        public OnDisconnectArgs(IntPtr pApi, ref CThostFtdcRspInfoField pRspInfo, ConnectionStatus step)
        {
            this.pApi = pApi;
            this.pRspInfo = pRspInfo;
            this.step = step;
        }
    }

    public class OnRspErrorArgs : EventArgs
    {
        public readonly IntPtr pApi;
        public readonly CThostFtdcRspInfoField pRspInfo;
        public readonly int nRequestID;
        public readonly bool bIsLast;
        public OnRspErrorArgs(IntPtr pApi, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            this.pApi = pApi;
            this.pRspInfo = pRspInfo;
            this.nRequestID = nRequestID;
            this.bIsLast = bIsLast;
        }
    }


    //行情
    public class OnRtnDepthMarketDataArgs : EventArgs
    {
        public readonly IntPtr pMdUserApi;
        public readonly CThostFtdcDepthMarketDataField pDepthMarketData;
        public OnRtnDepthMarketDataArgs(IntPtr pMdUserApi, ref CThostFtdcDepthMarketDataField pDepthMarketData)
        {
            this.pMdUserApi = pMdUserApi;
            this.pDepthMarketData = pDepthMarketData;
        }
    }

    //交易
    public class OnErrRtnOrderActionArgs : EventArgs
    {
        public readonly IntPtr pTraderApi;
        public readonly CThostFtdcOrderActionField pOrderAction;
        public readonly CThostFtdcRspInfoField pRspInfo;
        public OnErrRtnOrderActionArgs(IntPtr pTraderApi, ref CThostFtdcOrderActionField pOrderAction, ref CThostFtdcRspInfoField pRspInfo)
        {
            this.pTraderApi = pTraderApi;
            this.pOrderAction = pOrderAction;
            this.pRspInfo = pRspInfo;
        }
    }

    public class OnErrRtnOrderInsertArgs : EventArgs
    {
        public readonly IntPtr pTraderApi;
        public readonly CThostFtdcInputOrderField pInputOrder;
        public readonly CThostFtdcRspInfoField pRspInfo;
        public OnErrRtnOrderInsertArgs(IntPtr pTraderApi, ref CThostFtdcInputOrderField pInputOrder, ref CThostFtdcRspInfoField pRspInfo)
        {
            this.pTraderApi = pTraderApi;
            this.pInputOrder = pInputOrder;
            this.pRspInfo = pRspInfo;
        }
    }

    public class OnRspOrderActionArgs : EventArgs
    {
        public readonly IntPtr pTraderApi;
        public readonly CThostFtdcInputOrderActionField pInputOrderAction;
        public readonly CThostFtdcRspInfoField pRspInfo;
        public readonly int nRequestID;
        public readonly bool bIsLast;
        public OnRspOrderActionArgs(IntPtr pTraderApi, ref CThostFtdcInputOrderActionField pInputOrderAction, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            this.pTraderApi = pTraderApi;
            this.pInputOrderAction = pInputOrderAction;
            this.pRspInfo = pRspInfo;
            this.nRequestID = nRequestID;
            this.bIsLast = bIsLast;
        }
    }

    public class OnRspOrderInsertArgs : EventArgs
    {
        public readonly IntPtr pTraderApi;
        public readonly CThostFtdcInputOrderField pInputOrder;
        public readonly CThostFtdcRspInfoField pRspInfo;
        public readonly int nRequestID;
        public readonly bool bIsLast;
        public OnRspOrderInsertArgs(IntPtr pTraderApi, ref CThostFtdcInputOrderField pInputOrder, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            this.pTraderApi = pTraderApi;
            this.pInputOrder = pInputOrder;
            this.pRspInfo = pRspInfo;
            this.nRequestID = nRequestID;
            this.bIsLast = bIsLast;
        }
    }

    public class OnRspQryDepthMarketDataArgs : EventArgs
    {
        public readonly IntPtr pTraderApi;
        public readonly CThostFtdcDepthMarketDataField pDepthMarketData;
        public readonly CThostFtdcRspInfoField pRspInfo;
        public readonly int nRequestID;
        public readonly bool bIsLast;
        public OnRspQryDepthMarketDataArgs(IntPtr pTraderApi, ref CThostFtdcDepthMarketDataField pDepthMarketData, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            this.pTraderApi = pTraderApi;
            this.pDepthMarketData = pDepthMarketData;
            this.pRspInfo = pRspInfo;
            this.nRequestID = nRequestID;
            this.bIsLast = bIsLast;
        }
    }

    public class OnRspQryInstrumentArgs : EventArgs
    {
        public readonly IntPtr pTraderApi;
        public readonly CThostFtdcInstrumentField pInstrument;
        public readonly CThostFtdcRspInfoField pRspInfo;
        public readonly int nRequestID;
        public readonly bool bIsLast;
        public OnRspQryInstrumentArgs(IntPtr pTraderApi, ref CThostFtdcInstrumentField pInstrument, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            this.pTraderApi = pTraderApi;
            this.pInstrument = pInstrument;
            this.pRspInfo = pRspInfo;
            this.nRequestID = nRequestID;
            this.bIsLast = bIsLast;
        }
    }

    public class OnRspQryInstrumentCommissionRateArgs : EventArgs
    {
        public readonly IntPtr pTraderApi;
        public readonly CThostFtdcInstrumentCommissionRateField pInstrumentCommissionRate;
        public readonly CThostFtdcRspInfoField pRspInfo;
        public readonly int nRequestID;
        public readonly bool bIsLast;
        public OnRspQryInstrumentCommissionRateArgs(IntPtr pTraderApi, ref CThostFtdcInstrumentCommissionRateField pInstrumentCommissionRate, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            this.pTraderApi = pTraderApi;
            this.pInstrumentCommissionRate = pInstrumentCommissionRate;
            this.pRspInfo = pRspInfo;
            this.nRequestID = nRequestID;
            this.bIsLast = bIsLast;
        }
    }

    public class OnRspQryInstrumentMarginRateArgs : EventArgs
    {
        public readonly IntPtr pTraderApi;
        public readonly CThostFtdcInstrumentMarginRateField pInstrumentMarginRate;
        public readonly CThostFtdcRspInfoField pRspInfo;
        public readonly int nRequestID;
        public readonly bool bIsLast;
        public OnRspQryInstrumentMarginRateArgs(IntPtr pTraderApi, ref CThostFtdcInstrumentMarginRateField pInstrumentMarginRate, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            this.pTraderApi = pTraderApi;
            this.pInstrumentMarginRate = pInstrumentMarginRate;
            this.pRspInfo = pRspInfo;
            this.nRequestID = nRequestID;
            this.bIsLast = bIsLast;
        }
    }

    public class OnRspQryInvestorPositionArgs : EventArgs
    {
        public readonly IntPtr pTraderApi;
        public readonly CThostFtdcInvestorPositionField pInvestorPosition;
        public readonly CThostFtdcRspInfoField pRspInfo;
        public readonly int nRequestID;
        public readonly bool bIsLast;
        public OnRspQryInvestorPositionArgs(IntPtr pTraderApi, ref CThostFtdcInvestorPositionField pInvestorPosition, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            this.pTraderApi = pTraderApi;
            this.pInvestorPosition = pInvestorPosition;
            this.pRspInfo = pRspInfo;
            this.nRequestID = nRequestID;
            this.bIsLast = bIsLast;
        }
    }

    public class OnRspQryInvestorPositionDetailArgs : EventArgs
    {
        public readonly IntPtr pTraderApi;
        public readonly CThostFtdcInvestorPositionDetailField pInvestorPositionDetail;
        public readonly CThostFtdcRspInfoField pRspInfo;
        public readonly int nRequestID;
        public readonly bool bIsLast;
        public OnRspQryInvestorPositionDetailArgs(IntPtr pTraderApi, ref CThostFtdcInvestorPositionDetailField pInvestorPositionDetail, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            this.pTraderApi = pTraderApi;
            this.pInvestorPositionDetail = pInvestorPositionDetail;
            this.pRspInfo = pRspInfo;
            this.nRequestID = nRequestID;
            this.bIsLast = bIsLast;
        }
    }

    public class OnRspQryOrderArgs : EventArgs
    {
        public readonly IntPtr pTraderApi;
        public readonly CThostFtdcOrderField pOrder;
        public readonly CThostFtdcRspInfoField pRspInfo;
        public readonly int nRequestID;
        public readonly bool bIsLast;
        public OnRspQryOrderArgs(IntPtr pTraderApi, ref CThostFtdcOrderField pOrder, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            this.pTraderApi = pTraderApi;
            this.pOrder = pOrder;
            this.pRspInfo = pRspInfo;
            this.nRequestID = nRequestID;
            this.bIsLast = bIsLast;
        }
    }

    public class OnRspQryTradeArgs : EventArgs
    {
        public readonly IntPtr pTraderApi;
        public readonly CThostFtdcTradeField pTrade;
        public readonly CThostFtdcRspInfoField pRspInfo;
        public readonly int nRequestID;
        public readonly bool bIsLast;
        public OnRspQryTradeArgs(IntPtr pTraderApi, ref CThostFtdcTradeField pTrade, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            this.pTraderApi = pTraderApi;
            this.pTrade = pTrade;
            this.pRspInfo = pRspInfo;
            this.nRequestID = nRequestID;
            this.bIsLast = bIsLast;
        }
    }

    public class OnRspQryTradingAccountArgs : EventArgs
    {
        public readonly IntPtr pTraderApi;
        public readonly CThostFtdcTradingAccountField pTradingAccount;
        public readonly CThostFtdcRspInfoField pRspInfo;
        public readonly int nRequestID;
        public readonly bool bIsLast;
        public OnRspQryTradingAccountArgs(IntPtr pTraderApi, ref CThostFtdcTradingAccountField pTradingAccount, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            this.pTraderApi = pTraderApi;
            this.pTradingAccount = pTradingAccount;
            this.pRspInfo = pRspInfo;
            this.nRequestID = nRequestID;
            this.bIsLast = bIsLast;
        }
    }

    public class OnRtnOrderArgs : EventArgs
    {
        public readonly IntPtr pTraderApi;
        public readonly CThostFtdcOrderField pOrder;
        public OnRtnOrderArgs(IntPtr pTraderApi, ref CThostFtdcOrderField pOrder)
        {
            this.pTraderApi = pTraderApi;
            this.pOrder = pOrder;
        }
    }

    public class OnRtnTradeArgs : EventArgs
    {
        public readonly IntPtr pTraderApi;
        public readonly CThostFtdcTradeField pTrade;
        public OnRtnTradeArgs(IntPtr pTraderApi, ref CThostFtdcTradeField pTrade)
        {
            this.pTraderApi = pTraderApi;
            this.pTrade = pTrade;
        }
    }

    public class OnRtnInstrumentStatusArgs : EventArgs
    {
        public readonly IntPtr pTraderApi;
        public readonly CThostFtdcInstrumentStatusField pInstrumentStatus;
        public OnRtnInstrumentStatusArgs(IntPtr pTraderApi, ref CThostFtdcInstrumentStatusField pInstrumentStatus)
        {
            this.pTraderApi = pTraderApi;
            this.pInstrumentStatus = pInstrumentStatus;
        }
    }
}
