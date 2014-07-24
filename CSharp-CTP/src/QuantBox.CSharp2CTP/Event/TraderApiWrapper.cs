using QuantBox.CSharp2CTP.Callback;
using QuantBox.Library;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuantBox.CSharp2CTP.Event
{
    public class TraderApiWrapper : IDisposable
    {
        public event OnConnectHandler OnConnect;
        public event OnDisconnectHandler OnDisconnect;
        public event OnErrRtnOrderActionHandler OnErrRtnOrderAction;
        public event OnErrRtnOrderInsertHandler OnErrRtnOrderInsert;
        public event OnRspErrorHandler OnRspError;
        public event OnRspOrderActionHandler OnRspOrderAction;
        public event OnRspOrderInsertHandler OnRspOrderInsert;
        public event OnRspQryDepthMarketDataHandler OnRspQryDepthMarketData;
        public event OnRspQryInstrumentHandler OnRspQryInstrument;
        public event OnRspQryInstrumentCommissionRateHandler OnRspQryInstrumentCommissionRate;
        public event OnRspQryInstrumentMarginRateHandler OnRspQryInstrumentMarginRate;
        public event OnRspQryInvestorPositionHandler OnRspQryInvestorPosition;
        public event OnRspQryInvestorPositionDetailHandler OnRspQryInvestorPositionDetail;
        public event OnRspQryOrderHandler OnRspQryOrder;
        public event OnRspQryTradeHandler OnRspQryTrade;
        public event OnRspQryTradingAccountHandler OnRspQryTradingAccount;
        public event OnRtnInstrumentStatusHandler OnRtnInstrumentStatus;
        public event OnRtnOrderHandler OnRtnOrder;
        public event OnRtnTradeHandler OnRtnTrade;

        private bool disposed;

        public bool IsConnected { get; private set; }

        private MsgQueue m_pMsgQueue;
        private TradeApi m_Api;

        public TraderApiWrapper()
        {
            m_pMsgQueue = new MsgQueue();
            m_Api = new TradeApi(m_pMsgQueue);
        }

        //Implement IDisposable.
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // Free other state (managed objects).
                }
                // Free your own state (unmanaged objects).
                // Set large fields to null.
                Disconnect();
                disposed = true;
            }
            //base.Dispose(disposing);
        }

        // Use C# destructor syntax for finalization code.
        ~TraderApiWrapper()
        {
            // Simply call Dispose(false).
            Dispose(false);
        }

        public void Connect(string szPath, string szAddresses,
            string szBrokerId, string szInvestorId, string szPassword,
            THOST_TE_RESUME_TYPE nResumeType,
            string szUserProductInfo, string szAuthCode)
        {
            m_Api.Connection = new ConnectionInfo()
            {
                TempPath = szPath,
            };

            m_Api.Front = new FrontInfo()
            {
                BrokerId = szBrokerId,
                TradeAddress = szAddresses,
                UserProductInfo = szUserProductInfo,
                AuthCode = szAuthCode,
            };

            m_Api.Account = new AccountInfo()
            {
                InvestorId = szInvestorId,
                Password = szPassword,
            };

            m_Api.ResumeType = nResumeType;

            Disconnect_TD();
            Connect_TD();
        }

        public void Disconnect()
        {
            Disconnect_TD();
        }

        //建立行情
        private void Connect_TD()
        {
            m_Api.OnConnect = OnConnect_callback;
            m_Api.OnDisconnect = OnDisconnect_callback;
            m_Api.OnRspError = OnRspError_callback;

            m_Api.OnErrRtnOrderAction = OnErrRtnOrderAction_callback;
            m_Api.OnErrRtnOrderInsert = OnErrRtnOrderInsert_callback;
            m_Api.OnRspOrderAction = OnRspOrderAction_callback;
            m_Api.OnRspOrderInsert = OnRspOrderInsert_callback;
            m_Api.OnRspQryDepthMarketData = OnRspQryDepthMarketData_callback;
            m_Api.OnRspQryInstrument = OnRspQryInstrument_callback;
            m_Api.OnRspQryInstrumentCommissionRate = OnRspQryInstrumentCommissionRate_callback;
            m_Api.OnRspQryInstrumentMarginRate = OnRspQryInstrumentMarginRate_callback;
            m_Api.OnRspQryInvestorPosition = OnRspQryInvestorPosition_callback;
            m_Api.OnRspQryInvestorPositionDetail = OnRspQryInvestorPositionDetail_callback;
            m_Api.OnRspQryOrder = OnRspQryOrder_callback;
            m_Api.OnRspQryTrade = OnRspQryTrade_callback;
            m_Api.OnRspQryTradingAccount = OnRspQryTradingAccount_callback;
            m_Api.OnRtnInstrumentStatus = OnRtnInstrumentStatus_callback;
            m_Api.OnRtnOrder = OnRtnOrder_callback;
            m_Api.OnRtnTrade = OnRtnTrade_callback;

            m_Api.Connect();
        }

        private void Disconnect_TD()
        {
            m_Api.Disconnect();
        }

        public int SendOrder(
            int OrderRef,
            string szInstrument,
            string szExchange,
            TThostFtdcDirectionType Direction,
            string szCombOffsetFlag,
            string szCombHedgeFlag,
            int VolumeTotalOriginal,
            double LimitPrice,
            TThostFtdcOrderPriceTypeType OrderPriceType,
            TThostFtdcTimeConditionType TimeCondition,
            TThostFtdcContingentConditionType ContingentCondition,
            double StopPrice,
            TThostFtdcVolumeConditionType VolumeCondition)
        {
            return m_Api.SendOrder(
                OrderRef,
                szInstrument,
                szExchange,
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

        public void CancelOrder(ref CThostFtdcOrderField pOrder)
        {
            m_Api.CancelOrder(ref pOrder);
        }

        public void ReqQryInstrument(string szInstrument)
        {
            m_Api.ReqQryInstrument(szInstrument);
        }

        public void ReqQryTradingAccount()
        {
            m_Api.ReqQryTradingAccount();
        }

        public void ReqQryInvestorPosition(string szInstrument)
        {
            m_Api.ReqQryInvestorPosition(szInstrument);
        }

        public void ReqQryInvestorPositionDetail(string szInstrument)
        {
            m_Api.ReqQryInvestorPositionDetail(szInstrument);
        }

        public void ReqQryInstrumentCommissionRate(string szInstrument)
        {
            m_Api.ReqQryInstrumentCommissionRate(szInstrument);
        }

        public void ReqQryInstrumentMarginRate(string szInstrument, TThostFtdcHedgeFlagType HedgeFlag)
        {
            m_Api.ReqQryInstrumentMarginRate(szInstrument, HedgeFlag);
        }
        
        private void OnConnect_callback(object sender, IntPtr pApi, ref CThostFtdcRspUserLoginField pRspUserLogin, ConnectionStatus result)
        {
            if (m_Api.IsConnected)
            {
                IsConnected = true;
            }

            if (null != OnConnect)
            {
                OnConnect(this, new OnConnectArgs(pApi, ref pRspUserLogin, result));
            }
        }

        private void OnDisconnect_callback(object sender, IntPtr pApi, ref CThostFtdcRspInfoField pRspInfo, ConnectionStatus step)
        {
            if (IsConnected)
            {
                if (7 == pRspInfo.ErrorID//综合交易平台：还没有初始化
                    || 8 == pRspInfo.ErrorID)//综合交易平台：前置不活跃
                {
                    Disconnect_TD();
                    Connect_TD();
                }
            }

            if (null != OnDisconnect)
            {
                OnDisconnect(this, new OnDisconnectArgs(pApi, ref pRspInfo, step));
            }
        }

        private void OnErrRtnOrderAction_callback(object sender, IntPtr pTraderApi, ref CThostFtdcOrderActionField pOrderAction, ref CThostFtdcRspInfoField pRspInfo)
        {
            if (null != OnErrRtnOrderAction)
            {
                OnErrRtnOrderAction(this, new OnErrRtnOrderActionArgs(pTraderApi, ref pOrderAction, ref pRspInfo));
            }
        }

        private void OnErrRtnOrderInsert_callback(object sender, IntPtr pTraderApi, ref CThostFtdcInputOrderField pInputOrder, ref CThostFtdcRspInfoField pRspInfo)
        {
            if (null != OnErrRtnOrderInsert)
            {
                OnErrRtnOrderInsert(this, new OnErrRtnOrderInsertArgs(pTraderApi, ref pInputOrder, ref pRspInfo));
            }
        }

        private void OnRspError_callback(object sender, IntPtr pApi, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            if (null != OnRspError)
            {
                OnRspError(this,new OnRspErrorArgs(pApi,ref pRspInfo,nRequestID,bIsLast));
            }
        }

        private void OnRspOrderAction_callback(object sender, IntPtr pTraderApi, ref CThostFtdcInputOrderActionField pInputOrderAction, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            if (null != OnRspOrderAction)
            {
                OnRspOrderAction(this, new OnRspOrderActionArgs(pTraderApi, ref pInputOrderAction, ref pRspInfo, nRequestID, bIsLast));
            }
        }

        private void OnRspOrderInsert_callback(object sender, IntPtr pTraderApi, ref CThostFtdcInputOrderField pInputOrder, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            if (null != OnRspOrderInsert)
            {
                OnRspOrderInsert(this, new OnRspOrderInsertArgs(pTraderApi, ref pInputOrder, ref pRspInfo, nRequestID, bIsLast));
            }
        }

        private void OnRspQryDepthMarketData_callback(object sender, IntPtr pTraderApi, ref CThostFtdcDepthMarketDataField pDepthMarketData, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            if (null != OnRspQryDepthMarketData)
            {
                OnRspQryDepthMarketData(this, new OnRspQryDepthMarketDataArgs(pTraderApi, ref pDepthMarketData, ref pRspInfo, nRequestID, bIsLast));
            }
        }

        private void OnRspQryInstrument_callback(object sender, IntPtr pTraderApi, ref CThostFtdcInstrumentField pInstrument, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            if (null != OnRspQryInstrument)
            {
                OnRspQryInstrument(this, new OnRspQryInstrumentArgs(pTraderApi, ref pInstrument, ref pRspInfo, nRequestID, bIsLast));
            }
        }

        private void OnRspQryInstrumentCommissionRate_callback(object sender, IntPtr pTraderApi, ref CThostFtdcInstrumentCommissionRateField pInstrumentCommissionRate, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            if (null != OnRspQryInstrumentCommissionRate)
            {
                OnRspQryInstrumentCommissionRate(this, new OnRspQryInstrumentCommissionRateArgs(pTraderApi, ref pInstrumentCommissionRate, ref pRspInfo, nRequestID, bIsLast));
            }
        }

        private void OnRspQryInstrumentMarginRate_callback(object sender, IntPtr pTraderApi, ref CThostFtdcInstrumentMarginRateField pInstrumentMarginRate, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            if (null != OnRspQryInstrumentMarginRate)
            {
                OnRspQryInstrumentMarginRate(this, new OnRspQryInstrumentMarginRateArgs(pTraderApi, ref pInstrumentMarginRate, ref pRspInfo, nRequestID, bIsLast));
            }
        }

        private void OnRspQryInvestorPosition_callback(object sender, IntPtr pTraderApi, ref CThostFtdcInvestorPositionField pInvestorPosition, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            if (null != OnRspQryInvestorPosition)
            {
                OnRspQryInvestorPosition(this, new OnRspQryInvestorPositionArgs(pTraderApi, ref pInvestorPosition, ref pRspInfo, nRequestID, bIsLast));
            }
        }

        private void OnRspQryInvestorPositionDetail_callback(object sender, IntPtr pTraderApi, ref CThostFtdcInvestorPositionDetailField pInvestorPositionDetail, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            if (null != OnRspQryInvestorPositionDetail)
            {
                OnRspQryInvestorPositionDetail(this, new OnRspQryInvestorPositionDetailArgs(pTraderApi, ref pInvestorPositionDetail, ref pRspInfo, nRequestID, bIsLast));
            }
        }

        private void OnRspQryOrder_callback(object sender, IntPtr pTraderApi, ref CThostFtdcOrderField pOrder, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            if (null != OnRspQryOrder)
            {
                OnRspQryOrder(this, new OnRspQryOrderArgs(pTraderApi, ref pOrder, ref pRspInfo, nRequestID, bIsLast));
            }
        }

        private void OnRspQryTrade_callback(object sender, IntPtr pTraderApi, ref CThostFtdcTradeField pTrade, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            if (null != OnRspQryTrade)
            {
                OnRspQryTrade(this, new OnRspQryTradeArgs(pTraderApi, ref pTrade, ref pRspInfo, nRequestID, bIsLast));
            }
        }

        private void OnRspQryTradingAccount_callback(object sender, IntPtr pTraderApi, ref CThostFtdcTradingAccountField pTradingAccount, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            if (null != OnRspQryTradingAccount)
            {
                OnRspQryTradingAccount(this, new OnRspQryTradingAccountArgs(pTraderApi, ref pTradingAccount, ref pRspInfo, nRequestID, bIsLast));
            }
        }

        private void OnRtnInstrumentStatus_callback(object sender, IntPtr pTraderApi, ref CThostFtdcInstrumentStatusField pInstrumentStatus)
        {
            if (null != OnRtnInstrumentStatus)
            {
                OnRtnInstrumentStatus(this, new OnRtnInstrumentStatusArgs(pTraderApi, ref pInstrumentStatus));
            }
        }

        private void OnRtnOrder_callback(object sender, IntPtr pTraderApi, ref CThostFtdcOrderField pOrder)
        {
            if (null != OnRtnOrder)
            {
                OnRtnOrder(this, new OnRtnOrderArgs(pTraderApi, ref pOrder));
            }
        }

        private void OnRtnTrade_callback(object sender, IntPtr pTraderApi, ref CThostFtdcTradeField pTrade)
        {
            if (null != OnRtnTrade)
            {
                OnRtnTrade(this, new OnRtnTradeArgs(pTraderApi, ref pTrade));
            }
        }
    }
}
