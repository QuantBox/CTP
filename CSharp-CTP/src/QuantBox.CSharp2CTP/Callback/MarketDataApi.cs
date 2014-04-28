using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuantBox.CSharp2CTP.Callback
{
    public class MarketDataApi : BaseApi
    {
        private SortedSet<string> _Instruments = new SortedSet<string>();
        public SortedSet<string> Instruments
        {
            get
            {
                lock (this)
                {
                    return _Instruments;
                }
            }
        }

        private fnOnRtnDepthMarketData _OnRtnDepthMarketData;
        private fnOnRtnForQuoteRsp _OnRtnForQuoteRsp;

        public fnOnRtnDepthMarketData OnRtnDepthMarketData
        {
            set
            {
                _OnRtnDepthMarketData = value;
                MdApi.CTP_RegOnRtnDepthMarketData(_MsgQueue.Queue, _OnRtnDepthMarketData);
            }
        }

        public fnOnRtnForQuoteRsp OnRtnForQuoteRsp
        {
            set
            {
                _OnRtnForQuoteRsp = value;
                MdApi.CTP_RegOnRtnForQuoteRsp(_MsgQueue.Queue, _OnRtnForQuoteRsp);
            }
        }

        public MarketDataApi(MsgQueue msgQueue)
            : base(msgQueue)
        {

        }

        public override void Connect()
        {
            lock(this)
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
            lock(this)
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
            lock (this)
            {
                MdApi.MD_Subscribe(IntPtrKey, inst, szExchange);
                inst.Split(new char[2] { ';', ',' }).ToList().ForEach(x =>
                {
                    if (!string.IsNullOrWhiteSpace(x))
                        _Instruments.Add(x);
                });
            }
        }

        public virtual void Unsubscribe(string inst, string szExchange)
        {
            lock (this)
            {
                MdApi.MD_Unsubscribe(IntPtrKey, inst, szExchange);
                inst.Split(new char[2] { ';', ',' }).ToList().ForEach(x =>
                    _Instruments.Remove(x)
                );
            }
        }
    }
}
