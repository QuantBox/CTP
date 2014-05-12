using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuantBox.CSharp2CTP.Callback
{
    public class TradeApi:BaseApi
    {
        private fnOnErrRtnOrderAction _OnErrRtnOrderAction;
        private fnOnErrRtnOrderInsert _OnErrRtnOrderInsert;
        private fnOnErrRtnQuoteAction _OnErrRtnQuoteAction;
        private fnOnErrRtnQuoteInsert _OnErrRtnQuoteInsert;
        private fnOnRspOrderAction _OnRspOrderAction;
        private fnOnRspOrderInsert _OnRspOrderInsert;
        private fnOnRspQuoteAction _OnRspQuoteAction;
        private fnOnRspQuoteInsert _OnRspQuoteInsert;
        private fnOnRspQryDepthMarketData _OnRspQryDepthMarketData;
        private fnOnRspQryInstrument _OnRspQryInstrument;
        private fnOnRspQryInstrumentCommissionRate _OnRspQryInstrumentCommissionRate;
        private fnOnRspQryInstrumentMarginRate _OnRspQryInstrumentMarginRate;
        private fnOnRspQryInvestorPosition _OnRspQryInvestorPosition;
        private fnOnRspQryInvestorPositionDetail _OnRspQryInvestorPositionDetail;
        private fnOnRspQryOrder _OnRspQryOrder;
        private fnOnRspQryTrade _OnRspQryTrade;
        private fnOnRspQryTradingAccount _OnRspQryTradingAccount;
        private fnOnRtnInstrumentStatus _OnRtnInstrumentStatus;
        private fnOnRtnOrder _OnRtnOrder;
        private fnOnRtnQuote _OnRtnQuote;
        private fnOnRtnTrade _OnRtnTrade;

        public THOST_TE_RESUME_TYPE ResumeType = THOST_TE_RESUME_TYPE.THOST_TERT_QUICK;

        public fnOnErrRtnOrderAction OnErrRtnOrderAction
        {
            set
            {
                _OnErrRtnOrderAction = value;
                TraderApi.CTP_RegOnErrRtnOrderAction(_MsgQueue.Queue, __OnErrRtnOrderAction);
            }
        }
        private void __OnErrRtnOrderAction(IntPtr pTraderApi, ref CThostFtdcOrderActionField pOrderAction, ref CThostFtdcRspInfoField pRspInfo)
        {
            _OnErrRtnOrderAction(this, pTraderApi, ref pOrderAction, ref pRspInfo);
        }

        public fnOnErrRtnOrderInsert OnErrRtnOrderInsert
        {
            set
            {
                _OnErrRtnOrderInsert = value;
                TraderApi.CTP_RegOnErrRtnOrderInsert(_MsgQueue.Queue, __OnErrRtnOrderInsert);
            }
        }

        private void __OnErrRtnOrderInsert(IntPtr pTraderApi, ref CThostFtdcInputOrderField pInputOrder, ref CThostFtdcRspInfoField pRspInfo)
        {
            _OnErrRtnOrderInsert(this, pTraderApi, ref pInputOrder, ref pRspInfo);
        }

        public fnOnErrRtnQuoteAction OnErrRtnQuoteAction
        {
            set
            {
                _OnErrRtnQuoteAction = value;
                TraderApi.CTP_RegOnErrRtnQuoteAction(_MsgQueue.Queue, __OnErrRtnQuoteAction);
            }
        }

        private void __OnErrRtnQuoteAction(IntPtr pTraderApi, ref CThostFtdcQuoteActionField pQuoteAction, ref CThostFtdcRspInfoField pRspInfo)
        {
            _OnErrRtnQuoteAction(this, pTraderApi, ref pQuoteAction, ref pRspInfo);
        }
    

        public fnOnErrRtnQuoteInsert OnErrRtnQuoteInsert
        {
            set
            {
                _OnErrRtnQuoteInsert = value;
                TraderApi.CTP_RegOnErrRtnQuoteInsert(_MsgQueue.Queue, __OnErrRtnQuoteInsert);
            }
        }

        private void __OnErrRtnQuoteInsert(IntPtr pTraderApi, ref CThostFtdcInputQuoteField pInputQuote, ref CThostFtdcRspInfoField pRspInfo)
        {
            _OnErrRtnQuoteInsert(this, pTraderApi, ref pInputQuote, ref pRspInfo);
        }
    

        public fnOnRspOrderAction OnRspOrderAction
        {
            set
            {
                _OnRspOrderAction = value;
                TraderApi.CTP_RegOnRspOrderAction(_MsgQueue.Queue, __OnRspOrderAction);
            }
        }

        private void __OnRspOrderAction(IntPtr pTraderApi, ref CThostFtdcInputOrderActionField pInputOrderAction, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            _OnRspOrderAction(this, pTraderApi, ref pInputOrderAction, ref pRspInfo, nRequestID, bIsLast);
        }
    
        public fnOnRspOrderInsert OnRspOrderInsert
        {
            set
            {
                _OnRspOrderInsert = value;
                TraderApi.CTP_RegOnRspOrderInsert(_MsgQueue.Queue, __OnRspOrderInsert);
            }
        }

        private void __OnRspOrderInsert(IntPtr pTraderApi, ref CThostFtdcInputOrderField pInputOrder, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            _OnRspOrderInsert(this, pTraderApi, ref pInputOrder, ref pRspInfo, nRequestID, bIsLast);
        }
    

        public fnOnRspQuoteAction OnRspQuoteAction
        {
            set
            {
                _OnRspQuoteAction = value;
                TraderApi.CTP_RegOnRspQuoteAction(_MsgQueue.Queue, __OnRspQuoteAction);
            }
        }

        private void __OnRspQuoteAction(IntPtr pTraderApi, ref CThostFtdcInputQuoteActionField pInputQuoteAction, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            _OnRspQuoteAction(this, pTraderApi, ref pInputQuoteAction, ref pRspInfo, nRequestID, bIsLast);
        }
    
        public fnOnRspQuoteInsert OnRspQuoteInsert
        {
            set
            {
                _OnRspQuoteInsert = value;
                TraderApi.CTP_RegOnRspQuoteInsert(_MsgQueue.Queue, __OnRspQuoteInsert);
            }
        }

        private void __OnRspQuoteInsert(IntPtr pTraderApi, ref CThostFtdcInputQuoteField pInputQuote, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            _OnRspQuoteInsert(this, pTraderApi, ref pInputQuote, ref pRspInfo, nRequestID, bIsLast);
        }

        public fnOnRspQryDepthMarketData OnRspQryDepthMarketData
        {
            set
            {
                _OnRspQryDepthMarketData = value;
                TraderApi.CTP_RegOnRspQryDepthMarketData(_MsgQueue.Queue, __OnRspQryDepthMarketData);
            }
        }

        private void __OnRspQryDepthMarketData(IntPtr pTraderApi, ref CThostFtdcDepthMarketDataField pDepthMarketData, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            _OnRspQryDepthMarketData(this, pTraderApi, ref pDepthMarketData, ref pRspInfo, nRequestID, bIsLast);
        }
    
        public fnOnRspQryInstrument OnRspQryInstrument
        {
            set
            {
                _OnRspQryInstrument = value;
                TraderApi.CTP_RegOnRspQryInstrument(_MsgQueue.Queue, __OnRspQryInstrument);
            }
        }

        private void __OnRspQryInstrument(IntPtr pTraderApi, ref CThostFtdcInstrumentField pInstrument, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            _OnRspQryInstrument(this, pTraderApi, ref pInstrument, ref pRspInfo, nRequestID, bIsLast);
        }
    
        public fnOnRspQryInstrumentCommissionRate OnRspQryInstrumentCommissionRate
        {
            set
            {
                _OnRspQryInstrumentCommissionRate = value;
                TraderApi.CTP_RegOnRspQryInstrumentCommissionRate(_MsgQueue.Queue, __OnRspQryInstrumentCommissionRate);
            }
        }

        private void __OnRspQryInstrumentCommissionRate(IntPtr pTraderApi, ref CThostFtdcInstrumentCommissionRateField pInstrumentCommissionRate, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            _OnRspQryInstrumentCommissionRate(this, pTraderApi, ref pInstrumentCommissionRate, ref pRspInfo, nRequestID, bIsLast);
        }

        public fnOnRspQryInstrumentMarginRate OnRspQryInstrumentMarginRate
        {
            set
            {
                _OnRspQryInstrumentMarginRate = value;
                TraderApi.CTP_RegOnRspQryInstrumentMarginRate(_MsgQueue.Queue, __OnRspQryInstrumentMarginRate);
            }
        }

        private void __OnRspQryInstrumentMarginRate(IntPtr pTraderApi, ref CThostFtdcInstrumentMarginRateField pInstrumentMarginRate, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            _OnRspQryInstrumentMarginRate(this, pTraderApi, ref pInstrumentMarginRate, ref pRspInfo, nRequestID, bIsLast);
        }
    
        public fnOnRspQryInvestorPosition OnRspQryInvestorPosition
        {
            set
            {
                _OnRspQryInvestorPosition = value;
                TraderApi.CTP_RegOnRspQryInvestorPosition(_MsgQueue.Queue, __OnRspQryInvestorPosition);
            }
        }

        private void __OnRspQryInvestorPosition(IntPtr pTraderApi, ref CThostFtdcInvestorPositionField pInvestorPosition, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            _OnRspQryInvestorPosition(this, pTraderApi, ref pInvestorPosition, ref pRspInfo, nRequestID, bIsLast);
        }

        public fnOnRspQryInvestorPositionDetail OnRspQryInvestorPositionDetail
        {
            set
            {
                _OnRspQryInvestorPositionDetail = value;
                TraderApi.CTP_RegOnRspQryInvestorPositionDetail(_MsgQueue.Queue, __OnRspQryInvestorPositionDetail);
            }
        }

        private void __OnRspQryInvestorPositionDetail(IntPtr pTraderApi, ref CThostFtdcInvestorPositionDetailField pInvestorPositionDetail, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            _OnRspQryInvestorPositionDetail(this, pTraderApi, ref pInvestorPositionDetail, ref pRspInfo, nRequestID, bIsLast);
        }

        public fnOnRspQryOrder OnRspQryOrder
        {
            set
            {
                _OnRspQryOrder = value;
                TraderApi.CTP_RegOnRspQryOrder(_MsgQueue.Queue, __OnRspQryOrder);
            }
        }

        private void __OnRspQryOrder(IntPtr pTraderApi, ref CThostFtdcOrderField pOrder, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            _OnRspQryOrder(this, pTraderApi, ref pOrder, ref pRspInfo, nRequestID, bIsLast);
        }
    
        public fnOnRspQryTrade OnRspQryTrade
        {
            set
            {
                _OnRspQryTrade = value;
                TraderApi.CTP_RegOnRspQryTrade(_MsgQueue.Queue, __OnRspQryTrade);
            }
        }

        private void __OnRspQryTrade(IntPtr pTraderApi, ref CThostFtdcTradeField pTrade, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            _OnRspQryTrade(this, pTraderApi, ref pTrade, ref pRspInfo, nRequestID, bIsLast);
        }
    
        public fnOnRspQryTradingAccount OnRspQryTradingAccount
        {
            set
            {
                _OnRspQryTradingAccount = value;
                TraderApi.CTP_RegOnRspQryTradingAccount(_MsgQueue.Queue, __OnRspQryTradingAccount);
            }
        }

        private void __OnRspQryTradingAccount(IntPtr pTraderApi, ref CThostFtdcTradingAccountField pTradingAccount, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            _OnRspQryTradingAccount(this, pTraderApi, ref pTradingAccount, ref pRspInfo, nRequestID, bIsLast);
        }
    
        public fnOnRtnInstrumentStatus OnRtnInstrumentStatus
        {
            set
            {
                _OnRtnInstrumentStatus = value;
                TraderApi.CTP_RegOnRtnInstrumentStatus(_MsgQueue.Queue, __OnRtnInstrumentStatus);
            }
        }

        private void __OnRtnInstrumentStatus(IntPtr pTraderApi, ref CThostFtdcInstrumentStatusField pInstrumentStatus)
        {
            _OnRtnInstrumentStatus(this, pTraderApi, ref pInstrumentStatus);
        }
    
        public fnOnRtnOrder OnRtnOrder
        {
            set
            {
                _OnRtnOrder = value;
                TraderApi.CTP_RegOnRtnOrder(_MsgQueue.Queue, __OnRtnOrder);
            }
        }

        private void __OnRtnOrder(IntPtr pTraderApi, ref CThostFtdcOrderField pOrder)
        {
            _OnRtnOrder(this, pTraderApi, ref pOrder);
        }

        public fnOnRtnQuote OnRtnQuote
        {
            set
            {
                _OnRtnQuote = value;
                TraderApi.CTP_RegOnRtnQuote(_MsgQueue.Queue, __OnRtnQuote);
            }
        }

        private void __OnRtnQuote(IntPtr pTraderApi, ref CThostFtdcQuoteField pQuote)
        {
            _OnRtnQuote(this, pTraderApi, ref pQuote);
        }

        public fnOnRtnTrade OnRtnTrade
        {
            set
            {
                _OnRtnTrade = value;
                TraderApi.CTP_RegOnRtnTrade(_MsgQueue.Queue, __OnRtnTrade);
            }
        }

        private void __OnRtnTrade(IntPtr pTraderApi, ref CThostFtdcTradeField pTrade)
        {
            _OnRtnTrade(this, pTraderApi, ref pTrade);
        }

        public TradeApi(MsgQueue msgQueue)
            : base(msgQueue)
        {
        }

        public override void Connect()
        {
            lock(this)
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
            lock(this)
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
