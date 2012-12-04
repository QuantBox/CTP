using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuantBox.CSharp2C
{
    class MdApiWrapper
    {
        IntPtr pMsgQueue;

        MdApiWrapper()
        {
            
        }



        fnOnRtnDepthMarketData _fnOnRtnDepthMarketData;
        public event fnOnRtnDepthMarketData OnRtnDepthMarketData
        {
            add { _fnOnRtnDepthMarketData += value; MdApi.CTP_RegOnRtnDepthMarketData(pMsgQueue, _fnOnRtnDepthMarketData); }
            remove { _fnOnRtnDepthMarketData -= value; MdApi.CTP_RegOnRtnDepthMarketData(pMsgQueue, _fnOnRtnDepthMarketData); }
        }
    }
}
