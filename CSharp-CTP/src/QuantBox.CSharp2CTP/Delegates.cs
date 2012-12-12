using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuantBox.CSharp2CTP
{
    public delegate void OnConnectHander(object sender, OnConnectArgs e);
    public delegate void OnDisconnectHander(object sender, OnDisconnectArgs e);
    public delegate void OnErrRtnOrderActionHander(object sender, OnErrRtnOrderActionArgs e);
    public delegate void OnErrRtnOrderInsertHander(object sender, OnErrRtnOrderInsertArgs e);
    public delegate void OnRspErrorHander(object sender, OnRspErrorArgs e);
    public delegate void OnRspOrderActionHander(object sender, OnRspOrderActionArgs e);
    public delegate void OnRspOrderInsertHander(object sender, OnRspOrderInsertArgs e);
    public delegate void OnRspQryDepthMarketDataHander(object sender, OnRspQryDepthMarketDataArgs e);
    public delegate void OnRspQryInstrumentHander(object sender, OnRspQryInstrumentArgs e);
    public delegate void OnRspQryInstrumentCommissionRateHander(object sender, OnRspQryInstrumentCommissionRateArgs e);
    public delegate void OnRspQryInstrumentMarginRateHander(object sender, OnRspQryInstrumentMarginRateArgs e);
    public delegate void OnRspQryInvestorPositionHander(object sender, OnRspQryInvestorPositionArgs e);
    public delegate void OnRspQryInvestorPositionDetailHander(object sender, OnRspQryInvestorPositionDetailArgs e);
    public delegate void OnRspQryOrderHander(object sender, OnRspQryOrderArgs e);
    public delegate void OnRspQryTradeHander(object sender, OnRspQryTradeArgs e);
    public delegate void OnRspQryTradingAccountHander(object sender, OnRspQryTradingAccountArgs e);
    public delegate void OnRtnDepthMarketDataHander(object sender, OnRtnDepthMarketDataArgs e);
    public delegate void OnRtnOrderHander(object sender, OnRtnOrderArgs e);
    public delegate void OnRtnTradeHander(object sender, OnRtnTradeArgs e);
}
