using System;
using System.Runtime.InteropServices;

namespace QuantBox.CSharp2C
{
    public class TraderApi
    {
        [DllImport(CommApi.DllFileName, EntryPoint = "CTP_RegOnErrRtnOrderAction")]
        public static extern void CTP_RegOnErrRtnOrderAction(IntPtr pMsgQueue, fnOnErrRtnOrderAction pCallback);

        [DllImport(CommApi.DllFileName, EntryPoint = "CTP_RegOnErrRtnOrderInsert")]
        public static extern void CTP_RegOnErrRtnOrderInsert(IntPtr pMsgQueue, fnOnErrRtnOrderInsert pCallback);

        [DllImport(CommApi.DllFileName, EntryPoint = "CTP_RegOnRspOrderAction")]
        public static extern void CTP_RegOnRspOrderAction(IntPtr pMsgQueue, fnOnRspOrderAction pCallback);

        [DllImport(CommApi.DllFileName, EntryPoint = "CTP_RegOnRspOrderInsert")]
        public static extern void CTP_RegOnRspOrderInsert(IntPtr pMsgQueue, fnOnRspOrderInsert pCallback);

        [DllImport(CommApi.DllFileName, EntryPoint = "CTP_RegOnRspQryInstrument")]
        public static extern void CTP_RegOnRspQryInstrument(IntPtr pMsgQueue, fnOnRspQryInstrument pCallback);

        [DllImport(CommApi.DllFileName, EntryPoint = "CTP_RegOnRspQryInvestorPosition")]
        public static extern void CTP_RegOnRspQryInvestorPosition(IntPtr pMsgQueue, fnOnRspQryInvestorPosition pCallback);

        [DllImport(CommApi.DllFileName, EntryPoint = "CTP_RegOnRspQryTradingAccount")]
        public static extern void CTP_RegOnRspQryTradingAccount(IntPtr pMsgQueue, fnOnRspQryTradingAccount pCallback);

        [DllImport(CommApi.DllFileName, EntryPoint = "CTP_RegOnRtnOrder")]
        public static extern void CTP_RegOnRtnOrder(IntPtr pMsgQueue, fnOnRtnOrder pCallback);

        [DllImport(CommApi.DllFileName, EntryPoint = "CTP_RegOnRtnTrade")]
        public static extern void CTP_RegOnRtnTrade(IntPtr pMsgQueue, fnOnRtnTrade pCallback);

        [DllImport(CommApi.DllFileName, EntryPoint = "TD_CreateTdApi")]
        public static extern IntPtr TD_CreateTdApi();

        [DllImport(CommApi.DllFileName, EntryPoint = "TD_RegMsgQueue2TdApi")]
        public static extern void TD_RegMsgQueue2TdApi(IntPtr pTraderApi, IntPtr pMsgQueue);

        [DllImport(CommApi.DllFileName, EntryPoint = "TD_Connect")]
        public static extern void TD_Connect(IntPtr pTraderApi,
            string szPath, string szAddresses,
            string szBrokerId, string szInvestorId, string szPassword,
            THOST_TE_RESUME_TYPE nResumeType,
            string szUserProductInfo, string szAuthCode);

        [DllImport(CommApi.DllFileName, EntryPoint = "TD_SendOrder")]
        public static extern int TD_SendOrder(IntPtr pTraderApi,
            string szInstrument,
            TThostFtdcDirectionType Direction,
            string szCombOffsetFlag,
            string szCombHedgeFlag,
            int VolumeTotalOriginal,
            double LimitPrice,
            TThostFtdcOrderPriceTypeType OrderPriceType,
            TThostFtdcTimeConditionType TimeCondition,
            TThostFtdcContingentConditionType ContingentCondition,
            double StopPrice);

        [DllImport(CommApi.DllFileName, EntryPoint = "TD_CancelOrder")]
        public static extern void TD_CancelOrder(IntPtr pTraderApi, ref CThostFtdcOrderField pOrder);

        [DllImport(CommApi.DllFileName, EntryPoint = "TD_ReleaseTdApi")]
        public static extern void TD_ReleaseTdApi(IntPtr pTraderApi);

        [DllImport(CommApi.DllFileName, EntryPoint = "TD_ReqQryInvestorPosition")]
        public static extern void TD_ReqQryInvestorPosition(IntPtr pTraderApi, string szInstrument);

        [DllImport(CommApi.DllFileName, EntryPoint = "TD_ReqQryTradingAccount")]
        public static extern void TD_ReqQryTradingAccount(IntPtr pTraderApi);

        [DllImport(CommApi.DllFileName, EntryPoint = "TD_ReqQryInstrument")]
        public static extern void TD_ReqQryInstrument(IntPtr pTraderApi, string szInstrument);
    }
}
