using QuantBox.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuantBox.CSharp2CTP.Callback
{
    public class TradeApi:BaseApi
    {
        private object locker = new object();

        private fnOnErrRtnOrderAction OnErrRtnOrderAction_1;
        private fnOnErrRtnOrderInsert OnErrRtnOrderInsert_1;
        private fnOnErrRtnQuoteAction OnErrRtnQuoteAction_1;
        private fnOnErrRtnQuoteInsert OnErrRtnQuoteInsert_1;
        private fnOnRspOrderAction OnRspOrderAction_1;
        private fnOnRspOrderInsert OnRspOrderInsert_1;
        private fnOnRspQuoteAction OnRspQuoteAction_1;
        private fnOnRspQuoteInsert OnRspQuoteInsert_1;
        private fnOnRspQryDepthMarketData OnRspQryDepthMarketData_1;
        private fnOnRspQryInstrument OnRspQryInstrument_1;
        private fnOnRspQryInstrumentCommissionRate OnRspQryInstrumentCommissionRate_1;
        private fnOnRspQryInstrumentMarginRate OnRspQryInstrumentMarginRate_1;
        private fnOnRspQryInvestorPosition OnRspQryInvestorPosition_1;
        private fnOnRspQryInvestorPositionDetail OnRspQryInvestorPositionDetail_1;
        private fnOnRspQryOrder OnRspQryOrder_1;
        private fnOnRspQryTrade OnRspQryTrade_1;
        private fnOnRspQrySettlementInfo OnRspQrySettlementInfo_1;
        private fnOnRspQryTradingAccount OnRspQryTradingAccount_1;
        private fnOnRtnInstrumentStatus OnRtnInstrumentStatus_1;
        private fnOnRtnOrder OnRtnOrder_1;
        private fnOnRtnQuote OnRtnQuote_1;
        private fnOnRtnTrade OnRtnTrade_1;

        private QuantBox.CSharp2CTP.fnOnErrRtnOrderAction OnErrRtnOrderAction_2;
        private QuantBox.CSharp2CTP.fnOnErrRtnOrderInsert OnErrRtnOrderInsert_2;
        private QuantBox.CSharp2CTP.fnOnErrRtnQuoteAction OnErrRtnQuoteAction_2;
        private QuantBox.CSharp2CTP.fnOnErrRtnQuoteInsert OnErrRtnQuoteInsert_2;
        private QuantBox.CSharp2CTP.fnOnRspOrderAction OnRspOrderAction_2;
        private QuantBox.CSharp2CTP.fnOnRspOrderInsert OnRspOrderInsert_2;
        private QuantBox.CSharp2CTP.fnOnRspQuoteAction OnRspQuoteAction_2;
        private QuantBox.CSharp2CTP.fnOnRspQuoteInsert OnRspQuoteInsert_2;
        private QuantBox.CSharp2CTP.fnOnRspQryDepthMarketData OnRspQryDepthMarketData_2;
        private QuantBox.CSharp2CTP.fnOnRspQryInstrument OnRspQryInstrument_2;
        private QuantBox.CSharp2CTP.fnOnRspQryInstrumentCommissionRate OnRspQryInstrumentCommissionRate_2;
        private QuantBox.CSharp2CTP.fnOnRspQryInstrumentMarginRate OnRspQryInstrumentMarginRate_2;
        private QuantBox.CSharp2CTP.fnOnRspQryInvestorPosition OnRspQryInvestorPosition_2;
        private QuantBox.CSharp2CTP.fnOnRspQryInvestorPositionDetail OnRspQryInvestorPositionDetail_2;
        private QuantBox.CSharp2CTP.fnOnRspQryOrder OnRspQryOrder_2;
        private QuantBox.CSharp2CTP.fnOnRspQryTrade OnRspQryTrade_2;
        private QuantBox.CSharp2CTP.fnOnRspQrySettlementInfo OnRspQrySettlementInfo_2;
        private QuantBox.CSharp2CTP.fnOnRspQryTradingAccount OnRspQryTradingAccount_2;
        private QuantBox.CSharp2CTP.fnOnRtnInstrumentStatus OnRtnInstrumentStatus_2;
        private QuantBox.CSharp2CTP.fnOnRtnOrder OnRtnOrder_2;
        private QuantBox.CSharp2CTP.fnOnRtnQuote OnRtnQuote_2;
        private QuantBox.CSharp2CTP.fnOnRtnTrade OnRtnTrade_2;

        public THOST_TE_RESUME_TYPE ResumeType = THOST_TE_RESUME_TYPE.THOST_TERT_QUICK;

        public fnOnErrRtnOrderAction OnErrRtnOrderAction
        {
            set
            {
                OnErrRtnOrderAction_1 = value;
                OnErrRtnOrderAction_2 = OnErrRtnOrderAction_3;
                TraderApi.CTP_RegOnErrRtnOrderAction(_MsgQueue.Queue, OnErrRtnOrderAction_2);
            }
        }
        private void OnErrRtnOrderAction_3(IntPtr pTraderApi, ref CThostFtdcOrderActionField pOrderAction, ref CThostFtdcRspInfoField pRspInfo)
        {
            OnErrRtnOrderAction_1(this, pTraderApi, ref pOrderAction, ref pRspInfo);
        }

        public fnOnErrRtnOrderInsert OnErrRtnOrderInsert
        {
            set
            {
                OnErrRtnOrderInsert_1 = value;
                OnErrRtnOrderInsert_2 = OnErrRtnOrderInsert_3;
                TraderApi.CTP_RegOnErrRtnOrderInsert(_MsgQueue.Queue, OnErrRtnOrderInsert_2);
            }
        }

        private void OnErrRtnOrderInsert_3(IntPtr pTraderApi, ref CThostFtdcInputOrderField pInputOrder, ref CThostFtdcRspInfoField pRspInfo)
        {
            OnErrRtnOrderInsert_1(this, pTraderApi, ref pInputOrder, ref pRspInfo);
        }

        public fnOnErrRtnQuoteAction OnErrRtnQuoteAction
        {
            set
            {
                OnErrRtnQuoteAction_1 = value;
                OnErrRtnQuoteAction_2 = OnErrRtnQuoteAction_3;
                TraderApi.CTP_RegOnErrRtnQuoteAction(_MsgQueue.Queue, OnErrRtnQuoteAction_2);
            }
        }

        private void OnErrRtnQuoteAction_3(IntPtr pTraderApi, ref CThostFtdcQuoteActionField pQuoteAction, ref CThostFtdcRspInfoField pRspInfo)
        {
            OnErrRtnQuoteAction_1(this, pTraderApi, ref pQuoteAction, ref pRspInfo);
        }
    

        public fnOnErrRtnQuoteInsert OnErrRtnQuoteInsert
        {
            set
            {
                OnErrRtnQuoteInsert_1 = value;
                OnErrRtnQuoteInsert_2 = OnErrRtnQuoteInsert_3;
                TraderApi.CTP_RegOnErrRtnQuoteInsert(_MsgQueue.Queue, OnErrRtnQuoteInsert_2);
            }
        }

        private void OnErrRtnQuoteInsert_3(IntPtr pTraderApi, ref CThostFtdcInputQuoteField pInputQuote, ref CThostFtdcRspInfoField pRspInfo)
        {
            OnErrRtnQuoteInsert_1(this, pTraderApi, ref pInputQuote, ref pRspInfo);
        }
    

        public fnOnRspOrderAction OnRspOrderAction
        {
            set
            {
                OnRspOrderAction_1 = value;
                OnRspOrderAction_2 = OnRspOrderAction_3;
                TraderApi.CTP_RegOnRspOrderAction(_MsgQueue.Queue, OnRspOrderAction_2);
            }
        }

        private void OnRspOrderAction_3(IntPtr pTraderApi, ref CThostFtdcInputOrderActionField pInputOrderAction, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            OnRspOrderAction_1(this, pTraderApi, ref pInputOrderAction, ref pRspInfo, nRequestID, bIsLast);
        }
    
        public fnOnRspOrderInsert OnRspOrderInsert
        {
            set
            {
                OnRspOrderInsert_1 = value;
                OnRspOrderInsert_2 = OnRspOrderInsert_3;
                TraderApi.CTP_RegOnRspOrderInsert(_MsgQueue.Queue, OnRspOrderInsert_2);
            }
        }

        private void OnRspOrderInsert_3(IntPtr pTraderApi, ref CThostFtdcInputOrderField pInputOrder, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            OnRspOrderInsert_1(this, pTraderApi, ref pInputOrder, ref pRspInfo, nRequestID, bIsLast);
        }
    

        public fnOnRspQuoteAction OnRspQuoteAction
        {
            set
            {
                OnRspQuoteAction_1 = value;
                OnRspQuoteAction_2 = OnRspQuoteAction_3;
                TraderApi.CTP_RegOnRspQuoteAction(_MsgQueue.Queue, OnRspQuoteAction_2);
            }
        }

        private void OnRspQuoteAction_3(IntPtr pTraderApi, ref CThostFtdcInputQuoteActionField pInputQuoteAction, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            OnRspQuoteAction_1(this, pTraderApi, ref pInputQuoteAction, ref pRspInfo, nRequestID, bIsLast);
        }
    
        public fnOnRspQuoteInsert OnRspQuoteInsert
        {
            set
            {
                OnRspQuoteInsert_1 = value;
                OnRspQuoteInsert_2 = OnRspQuoteInsert_3;
                TraderApi.CTP_RegOnRspQuoteInsert(_MsgQueue.Queue, OnRspQuoteInsert_2);
            }
        }

        private void OnRspQuoteInsert_3(IntPtr pTraderApi, ref CThostFtdcInputQuoteField pInputQuote, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            OnRspQuoteInsert_1(this, pTraderApi, ref pInputQuote, ref pRspInfo, nRequestID, bIsLast);
        }

        public fnOnRspQryDepthMarketData OnRspQryDepthMarketData
        {
            set
            {
                OnRspQryDepthMarketData_1 = value;
                OnRspQryDepthMarketData_2 = OnRspQryDepthMarketData_3;
                TraderApi.CTP_RegOnRspQryDepthMarketData(_MsgQueue.Queue, OnRspQryDepthMarketData_2);
            }
        }

        private void OnRspQryDepthMarketData_3(IntPtr pTraderApi, ref CThostFtdcDepthMarketDataField pDepthMarketData, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            OnRspQryDepthMarketData_1(this, pTraderApi, ref pDepthMarketData, ref pRspInfo, nRequestID, bIsLast);
        }
    
        public fnOnRspQryInstrument OnRspQryInstrument
        {
            set
            {
                OnRspQryInstrument_1 = value;
                OnRspQryInstrument_2 = OnRspQryInstrument_3;
                TraderApi.CTP_RegOnRspQryInstrument(_MsgQueue.Queue, OnRspQryInstrument_2);
            }
        }

        private void OnRspQryInstrument_3(IntPtr pTraderApi, ref CThostFtdcInstrumentField pInstrument, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            OnRspQryInstrument_1(this, pTraderApi, ref pInstrument, ref pRspInfo, nRequestID, bIsLast);
        }
    
        public fnOnRspQryInstrumentCommissionRate OnRspQryInstrumentCommissionRate
        {
            set
            {
                OnRspQryInstrumentCommissionRate_1 = value;
                OnRspQryInstrumentCommissionRate_2 = OnRspQryInstrumentCommissionRate_3;
                TraderApi.CTP_RegOnRspQryInstrumentCommissionRate(_MsgQueue.Queue, OnRspQryInstrumentCommissionRate_2);
            }
        }

        private void OnRspQryInstrumentCommissionRate_3(IntPtr pTraderApi, ref CThostFtdcInstrumentCommissionRateField pInstrumentCommissionRate, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            OnRspQryInstrumentCommissionRate_1(this, pTraderApi, ref pInstrumentCommissionRate, ref pRspInfo, nRequestID, bIsLast);
        }

        public fnOnRspQryInstrumentMarginRate OnRspQryInstrumentMarginRate
        {
            set
            {
                OnRspQryInstrumentMarginRate_1 = value;
                OnRspQryInstrumentMarginRate_2 = OnRspQryInstrumentMarginRate_3;
                TraderApi.CTP_RegOnRspQryInstrumentMarginRate(_MsgQueue.Queue, OnRspQryInstrumentMarginRate_2);
            }
        }

        private void OnRspQryInstrumentMarginRate_3(IntPtr pTraderApi, ref CThostFtdcInstrumentMarginRateField pInstrumentMarginRate, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            OnRspQryInstrumentMarginRate_1(this, pTraderApi, ref pInstrumentMarginRate, ref pRspInfo, nRequestID, bIsLast);
        }
    
        public fnOnRspQryInvestorPosition OnRspQryInvestorPosition
        {
            set
            {
                OnRspQryInvestorPosition_1 = value;
                OnRspQryInvestorPosition_2 = OnRspQryInvestorPosition_3;
                TraderApi.CTP_RegOnRspQryInvestorPosition(_MsgQueue.Queue, OnRspQryInvestorPosition_2);
            }
        }

        private void OnRspQryInvestorPosition_3(IntPtr pTraderApi, ref CThostFtdcInvestorPositionField pInvestorPosition, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            OnRspQryInvestorPosition_1(this, pTraderApi, ref pInvestorPosition, ref pRspInfo, nRequestID, bIsLast);
        }

        public fnOnRspQryInvestorPositionDetail OnRspQryInvestorPositionDetail
        {
            set
            {
                OnRspQryInvestorPositionDetail_1 = value;
                OnRspQryInvestorPositionDetail_2 = OnRspQryInvestorPositionDetail_3;
                TraderApi.CTP_RegOnRspQryInvestorPositionDetail(_MsgQueue.Queue, OnRspQryInvestorPositionDetail_2);
            }
        }

        private void OnRspQryInvestorPositionDetail_3(IntPtr pTraderApi, ref CThostFtdcInvestorPositionDetailField pInvestorPositionDetail, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            OnRspQryInvestorPositionDetail_1(this, pTraderApi, ref pInvestorPositionDetail, ref pRspInfo, nRequestID, bIsLast);
        }

        public fnOnRspQryOrder OnRspQryOrder
        {
            set
            {
                OnRspQryOrder_1 = value;
                OnRspQryOrder_2 = OnRspQryOrder_3;
                TraderApi.CTP_RegOnRspQryOrder(_MsgQueue.Queue, OnRspQryOrder_2);
            }
        }

        private void OnRspQryOrder_3(IntPtr pTraderApi, ref CThostFtdcOrderField pOrder, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            OnRspQryOrder_1(this, pTraderApi, ref pOrder, ref pRspInfo, nRequestID, bIsLast);
        }
    
        public fnOnRspQryTrade OnRspQryTrade
        {
            set
            {
                OnRspQryTrade_1 = value;
                OnRspQryTrade_2 = OnRspQryTrade_3;
                TraderApi.CTP_RegOnRspQryTrade(_MsgQueue.Queue, OnRspQryTrade_2);
            }
        }

        private void OnRspQryTrade_3(IntPtr pTraderApi, ref CThostFtdcTradeField pTrade, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            OnRspQryTrade_1(this, pTraderApi, ref pTrade, ref pRspInfo, nRequestID, bIsLast);
        }

        public fnOnRspQrySettlementInfo OnRspQrySettlementInfo
        {
            set
            {
                OnRspQrySettlementInfo_1 = value;
                OnRspQrySettlementInfo_2 = OnRspQrySettlementInfo_3;
                TraderApi.CTP_RegOnRspQrySettlementInfo(_MsgQueue.Queue, OnRspQrySettlementInfo_2);
            }
        }

        private void OnRspQrySettlementInfo_3(IntPtr pTraderApi, ref CThostFtdcSettlementInfoField pSettlementInfo, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            OnRspQrySettlementInfo_1(this, pTraderApi, ref pSettlementInfo, ref pRspInfo, nRequestID, bIsLast);
        }
    
        public fnOnRspQryTradingAccount OnRspQryTradingAccount
        {
            set
            {
                OnRspQryTradingAccount_1 = value;
                OnRspQryTradingAccount_2 = OnRspQryTradingAccount_3;
                TraderApi.CTP_RegOnRspQryTradingAccount(_MsgQueue.Queue, OnRspQryTradingAccount_2);
            }
        }

        private void OnRspQryTradingAccount_3(IntPtr pTraderApi, ref CThostFtdcTradingAccountField pTradingAccount, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            OnRspQryTradingAccount_1(this, pTraderApi, ref pTradingAccount, ref pRspInfo, nRequestID, bIsLast);
        }
    
        public fnOnRtnInstrumentStatus OnRtnInstrumentStatus
        {
            set
            {
                OnRtnInstrumentStatus_1 = value;
                OnRtnInstrumentStatus_2 = OnRtnInstrumentStatus_3;
                TraderApi.CTP_RegOnRtnInstrumentStatus(_MsgQueue.Queue, OnRtnInstrumentStatus_2);
            }
        }

        private void OnRtnInstrumentStatus_3(IntPtr pTraderApi, ref CThostFtdcInstrumentStatusField pInstrumentStatus)
        {
            OnRtnInstrumentStatus_1(this, pTraderApi, ref pInstrumentStatus);
        }
    
        public fnOnRtnOrder OnRtnOrder
        {
            set
            {
                OnRtnOrder_1 = value;
                OnRtnOrder_2 = OnRtnOrder_3;
                TraderApi.CTP_RegOnRtnOrder(_MsgQueue.Queue, OnRtnOrder_2);
            }
        }

        private void OnRtnOrder_3(IntPtr pTraderApi, ref CThostFtdcOrderField pOrder)
        {
            OnRtnOrder_1(this, pTraderApi, ref pOrder);
        }

        public fnOnRtnQuote OnRtnQuote
        {
            set
            {
                OnRtnQuote_1 = value;
                OnRtnQuote_2 = OnRtnQuote_3;
                TraderApi.CTP_RegOnRtnQuote(_MsgQueue.Queue, OnRtnQuote_2);
            }
        }

        private void OnRtnQuote_3(IntPtr pTraderApi, ref CThostFtdcQuoteField pQuote)
        {
            OnRtnQuote_1(this, pTraderApi, ref pQuote);
        }

        public fnOnRtnTrade OnRtnTrade
        {
            set
            {
                OnRtnTrade_1 = value;
                OnRtnTrade_2 = OnRtnTrade_3;
                TraderApi.CTP_RegOnRtnTrade(_MsgQueue.Queue, OnRtnTrade_2);
            }
        }

        private void OnRtnTrade_3(IntPtr pTraderApi, ref CThostFtdcTradeField pTrade)
        {
            OnRtnTrade_1(this, pTraderApi, ref pTrade);
        }

        protected override void OnConnect_3(IntPtr pApi, ref CThostFtdcRspUserLoginField pRspUserLogin, ConnectionStatus result)
        {
            IsConnected = false;
            if (result == ConnectionStatus.Confirmed)
            {
                IsConnected = true;
            }
            OnConnect_1(this, pApi, ref pRspUserLogin, result);
        }

        public TradeApi(MsgQueue msgQueue)
            : base(msgQueue)
        {
        }

        public override void Connect()
        {
            lock (locker)
            {
                base.Connect();

                IntPtrKey = TraderApi.TD_CreateTdApi();
                TraderApi.TD_RegMsgQueue2TdApi(IntPtrKey, _MsgQueue.Queue);

                TraderApi.TD_Connect(IntPtrKey, _TempPath,
                    _Front.TradeAddress, _Front.BrokerId,
                    _Account.InvestorId, _Account.Password,
                    ResumeType,
                    _Front.UserProductInfo, _Front.AuthCode);
            }
        }

        public override void Disconnect()
        {
            lock (locker)
            {
                if (null != IntPtrKey && IntPtr.Zero != IntPtrKey)
                {
                    TraderApi.TD_RegMsgQueue2TdApi(IntPtrKey, IntPtr.Zero);
                    TraderApi.TD_ReleaseTdApi(IntPtrKey);
                    IntPtrKey = IntPtr.Zero;
                }

                base.Disconnect();
            }
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
            if (null == IntPtrKey || IntPtr.Zero == IntPtrKey)
            {
                return 0;
            }

            return TraderApi.TD_SendOrder(
               IntPtrKey,
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
            if (null == IntPtrKey || IntPtr.Zero == IntPtrKey)
            {
                return;
            }

            TraderApi.TD_CancelOrder(IntPtrKey, ref pOrder);
        }

        public int SendQuote(
            int QuoteRef,
            string szInstrument,
            string szExchange,
            double AskPrice,
            double BidPrice,
            int AskVolume,
            int BidVolume,
            TThostFtdcOffsetFlagType AskOffsetFlag,
            TThostFtdcOffsetFlagType BidOffsetFlag,
            TThostFtdcHedgeFlagType AskHedgeFlag,
            TThostFtdcHedgeFlagType BidHedgeFlag)
        {
            if (null == IntPtrKey || IntPtr.Zero == IntPtrKey)
            {
                return 0;
            }

            return TraderApi.TD_SendQuote(
                IntPtrKey,
                QuoteRef,
                szInstrument,
                szExchange,
                AskPrice,
                BidPrice,
                AskVolume,
                BidVolume,
                AskOffsetFlag,
                BidOffsetFlag,
                AskHedgeFlag,
                BidHedgeFlag);
        }

        public void CancelQuote(ref CThostFtdcQuoteField pQuote)
        {
            if (null == IntPtrKey || IntPtr.Zero == IntPtrKey)
            {
                return;
            }

            TraderApi.TD_CancelQuote(IntPtrKey, ref pQuote);
        }

        public void ReqQryTradingAccount()
        {
            if (null == IntPtrKey || IntPtr.Zero == IntPtrKey)
            {
                return;
            }
            TraderApi.TD_ReqQryTradingAccount(IntPtrKey);
        }

        public void ReqQrySettlementInfo(string szTradingDay)
        {
            if (null == IntPtrKey || IntPtr.Zero == IntPtrKey)
            {
                return;
            }
            TraderApi.TD_ReqQrySettlementInfo(IntPtrKey, szTradingDay);
        }

        public void ReqQryInstrument(string szInstrument)
        {
            if (null == IntPtrKey || IntPtr.Zero == IntPtrKey)
            {
                return;
            }
            TraderApi.TD_ReqQryInstrument(IntPtrKey, szInstrument);
        }

        public void ReqQryInvestorPosition(string szInstrument)
        {
            if (null == IntPtrKey || IntPtr.Zero == IntPtrKey)
            {
                return;
            }
            TraderApi.TD_ReqQryInvestorPosition(IntPtrKey, szInstrument);
        }

        public void ReqQryInvestorPositionDetail(string szInstrument)
        {
            if (null == IntPtrKey || IntPtr.Zero == IntPtrKey)
            {
                return;
            }
            TraderApi.TD_ReqQryInvestorPositionDetail(IntPtrKey, szInstrument);
        }

        public void ReqQryInstrumentCommissionRate(string szInstrument)
        {
            if (null == IntPtrKey || IntPtr.Zero == IntPtrKey)
            {
                return;
            }
            TraderApi.TD_ReqQryInstrumentCommissionRate(IntPtrKey, szInstrument);
        }

        public void ReqQryInstrumentMarginRate(string szInstrument, TThostFtdcHedgeFlagType HedgeFlag)
        {
            if (null == IntPtrKey || IntPtr.Zero == IntPtrKey)
            {
                return;
            }
            TraderApi.TD_ReqQryInstrumentMarginRate(IntPtrKey, szInstrument, HedgeFlag);
        }
    }
}
