using QuantBox.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuantBox.CSharp2CTP.Callback
{
    public class MarketDataApi : BaseApi
    {
        private object locker = new object();

        private SortedSet<string> _SubscribedInstruments = new SortedSet<string>();
        public SortedSet<string> SubscribedInstruments
        {
            get
            {
                lock (locker)
                {
                    return _SubscribedInstruments;
                }
            }
        }

        private SortedSet<string> _SubscribedQuotes = new SortedSet<string>();
        public SortedSet<string> SubscribedQuotes
        {
            get
            {
                lock (locker)
                {
                    return _SubscribedQuotes;
                }
            }
        }

        private fnOnRtnDepthMarketData OnRtnDepthMarketData_1;
        private fnOnRtnForQuoteRsp OnRtnForQuoteRsp_1;

        private QuantBox.CSharp2CTP.fnOnRtnDepthMarketData OnRtnDepthMarketData_2;
        private QuantBox.CSharp2CTP.fnOnRtnForQuoteRsp OnRtnForQuoteRsp_2;

        public fnOnRtnDepthMarketData OnRtnDepthMarketData
        {
            set
            {
                OnRtnDepthMarketData_1 = value;
                OnRtnDepthMarketData_2 = OnRtnDepthMarketData_3;
                MdApi.CTP_RegOnRtnDepthMarketData(_MsgQueue.Queue, OnRtnDepthMarketData_2);
            }
        }

        private void OnRtnDepthMarketData_3(IntPtr pMdUserApi, ref CThostFtdcDepthMarketDataField pDepthMarketData)
        {
            OnRtnDepthMarketData_1(this, pMdUserApi, ref pDepthMarketData);
        }
    

        public fnOnRtnForQuoteRsp OnRtnForQuoteRsp
        {
            set
            {
                OnRtnForQuoteRsp_1 = value;
                OnRtnForQuoteRsp_2 = OnRtnForQuoteRsp_3;
                MdApi.CTP_RegOnRtnForQuoteRsp(_MsgQueue.Queue, OnRtnForQuoteRsp_2);
            }
        }

        private void OnRtnForQuoteRsp_3(IntPtr pMdUserApi, ref CThostFtdcForQuoteRspField pForQuoteRsp)
        {
            OnRtnForQuoteRsp_1(this, pMdUserApi, ref pForQuoteRsp);
        }

        protected override void OnConnect_3(IntPtr pApi, ref CThostFtdcRspUserLoginField pRspUserLogin, ConnectionStatus result)
        {
            IsConnected = false;
            if (result == ConnectionStatus.Logined)
            {
                IsConnected = true;
            }
            OnConnect_1(this, pApi, ref pRspUserLogin, result);
        }
    

        public MarketDataApi(MsgQueue msgQueue)
            : base(msgQueue)
        {

        }

        public override void Connect()
        {
            lock (locker)
            {
                base.Connect();

                IntPtrKey = MdApi.MD_CreateMdApi();
                MdApi.MD_RegMsgQueue2MdApi(IntPtrKey, _MsgQueue.Queue);

                MdApi.MD_Connect(IntPtrKey, _TempPath,
                    _Front.MarketDataAddress, _Front.BrokerId,
                    _Account.InvestorId, _Account.Password);
            }
        }

        public override void Disconnect()
        {
            lock (locker)
            {
                if (null != IntPtrKey && IntPtr.Zero != IntPtrKey)
                {
                    MdApi.MD_RegMsgQueue2MdApi(IntPtrKey, IntPtr.Zero);
                    MdApi.MD_ReleaseMdApi(IntPtrKey);
                    IntPtrKey = IntPtr.Zero;
                }

                base.Disconnect();
            }
        }

        public virtual void Subscribe(string inst, string szExchange)
        {
            lock (locker)
            {
                MdApi.MD_Subscribe(IntPtrKey, inst, szExchange);
                inst.Split(new char[2] { ';', ',' }).ToList().ForEach(x =>
                {
                    if (!string.IsNullOrWhiteSpace(x))
                        _SubscribedInstruments.Add(x);
                });
            }
        }

        public virtual void Unsubscribe(string inst, string szExchange)
        {
            lock (locker)
            {
                MdApi.MD_Unsubscribe(IntPtrKey, inst, szExchange);
                inst.Split(new char[2] { ';', ',' }).ToList().ForEach(x =>
                    _SubscribedInstruments.Remove(x)
                );
            }
        }

        public virtual void SubscribeQuote(string inst, string szExchange)
        {
            lock (locker)
            {
                MdApi.MD_SubscribeQuote(IntPtrKey, inst, szExchange);
                inst.Split(new char[2] { ';', ',' }).ToList().ForEach(x =>
                {
                    if (!string.IsNullOrWhiteSpace(x))
                        _SubscribedQuotes.Add(x);
                });
            }
        }

        public virtual void UnsubscribeQuote(string inst, string szExchange)
        {
            lock (locker)
            {
                MdApi.MD_UnsubscribeQuote(IntPtrKey, inst, szExchange);
                inst.Split(new char[2] { ';', ',' }).ToList().ForEach(x =>
                    _SubscribedQuotes.Remove(x)
                );
            }
        }
    }
}
