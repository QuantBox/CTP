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
                lock (_Instruments)
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
                MdApi.CTP_RegOnRtnDepthMarketData(_MsgQueue, _OnRtnDepthMarketData);
            }
        }

        public fnOnRtnForQuoteRsp OnRtnForQuoteRsp
        {
            set
            {
                _OnRtnForQuoteRsp = value;
                MdApi.CTP_RegOnRtnForQuoteRsp(_MsgQueue, _OnRtnForQuoteRsp);
            }
        }

        public MarketDataApi(IntPtr MsgQueue)
            : base(MsgQueue)
        {
            IntPtrKey = MdApi.MD_CreateMdApi();
            MdApi.MD_RegMsgQueue2MdApi(IntPtrKey, _MsgQueue);
        }

        public override void Connect()
        {
            base.Connect();

            MdApi.MD_Connect(IntPtrKey, _TempPath,
                _Front.MarketDataAddress, _Front.BrokerId,
                _Account.InvestorId, _Account.Password);
        }

        public override void Disconnect()
        {
            if (null != IntPtrKey && IntPtr.Zero != IntPtrKey)
            {
                MdApi.MD_RegMsgQueue2MdApi(IntPtrKey, IntPtr.Zero);
                MdApi.MD_ReleaseMdApi(IntPtrKey);
                IntPtrKey = IntPtr.Zero;
            }

            base.Disconnect();
        }

        public virtual void Subscribe(string inst, string szExchange)
        {
            lock (_Instruments)
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
            lock (_Instruments)
            {
                MdApi.MD_Unsubscribe(IntPtrKey, inst, szExchange);
                inst.Split(new char[2] { ';', ',' }).ToList().ForEach(x =>
                    _Instruments.Remove(x)
                );
            }
        }
    }
}
