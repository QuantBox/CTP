using System;
using System.Runtime.InteropServices;

namespace QuantBox.CSharp2CTP
{
    public class CommApi
    {
        public const string DllFileName = "QuantBox.C2CTP.dll";

        [DllImport(CommApi.DllFileName, EntryPoint = "CTP_RegOnConnect")]
        public static extern void CTP_RegOnConnect(IntPtr pMsgQueue, fnOnConnect pCallback);

        [DllImport(CommApi.DllFileName, EntryPoint = "CTP_RegOnDisconnect")]
        public static extern void CTP_RegOnDisconnect(IntPtr pMsgQueue, fnOnDisconnect pCallback);

        [DllImport(CommApi.DllFileName, EntryPoint = "CTP_RegOnRspError")]
        public static extern void CTP_RegOnRspError(IntPtr pMsgQueue, fnOnRspError pCallback);

        [DllImport(CommApi.DllFileName, EntryPoint = "CTP_CreateMsgQueue")]
        public static extern IntPtr CTP_CreateMsgQueue();

        [DllImport(CommApi.DllFileName, EntryPoint = "CTP_ProcessMsgQueue")]
        public static extern bool CTP_ProcessMsgQueue(IntPtr pMsgQueue);

        [DllImport(CommApi.DllFileName, EntryPoint = "CTP_ReleaseMsgQueue")]
        public static extern void CTP_ReleaseMsgQueue(IntPtr pMsgQueue);

        [DllImport(CommApi.DllFileName, EntryPoint = "CTP_ClearMsgQueue")]
        public static extern void CTP_ClearMsgQueue(IntPtr pMsgQueue);

        [DllImport(CommApi.DllFileName, EntryPoint = "CTP_StartMsgQueue")]
        public static extern void CTP_StartMsgQueue(IntPtr pMsgQueue);

        [DllImport(CommApi.DllFileName, EntryPoint = "CTP_StopMsgQueue")]
        public static extern void CTP_StopMsgQueue(IntPtr pMsgQueue);

        //[DllImport(CommApi.DllFileName, EntryPoint = "CTP_EmitDirectly")]
        //public static extern void CTP_EmitDirectly(IntPtr pMsgQueue, bool bDirect);
    }
}
