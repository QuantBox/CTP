using System;
using System.Collections.Generic;
using System.Linq;

namespace QuantBox.CSharp2CTP
{
    public class MdApiWrapper : IDisposable
    {
        public event OnConnectHander OnConnect;
        public event OnDisconnectHander OnDisconnect;
        public event OnRspErrorHander OnRspError;
        public event OnRtnDepthMarketDataHander OnRtnDepthMarketData;

        private readonly fnOnConnect _fnOnConnect_Holder;
        private readonly fnOnDisconnect _fnOnDisconnect_Holder;
        private readonly fnOnRspError _fnOnRspError_Holder;
        private readonly fnOnRtnDepthMarketData _fnOnRtnDepthMarketData_Holder;

        private readonly object _lockMd = new object();
        private readonly object _lockMsgQueue = new object();

        private IntPtr m_pMdApi = IntPtr.Zero;
        private IntPtr m_pMsgQueue = IntPtr.Zero;
        private volatile bool _bMdConnected;

        private bool disposed;

        private string szPath;
        private string szAddresses;
        private string szBrokerId;
        private string szInvestorId;
        private string szPassword;

        public MdApiWrapper()
        {
            _fnOnConnect_Holder = OnConnect_callback;
            _fnOnDisconnect_Holder = OnDisconnect_callback;
            _fnOnRspError_Holder = OnRspError_callback;
            _fnOnRtnDepthMarketData_Holder = OnRtnDepthMarketData_callback;
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
        ~MdApiWrapper()
        {
            // Simply call Dispose(false).
            Dispose(false);
        }

        public void Connect(string szPath, string szAddresses, string szBrokerId, string szInvestorId, string szPassword)
        {
            this.szPath = szPath;
            this.szAddresses = szAddresses;
            this.szBrokerId = szBrokerId;
            this.szInvestorId = szInvestorId;
            this.szPassword = szPassword;

            Disconnect_MD();
            Connect_MsgQueue();
            Connect_MD();
        }

        public void Disconnect()
        {
            Disconnect_MD();
            Disconnect_MsgQueue();
        }

        //建立行情
        private void Connect_MD()
        {
            lock (_lockMd)
            {
                if (null == m_pMdApi || IntPtr.Zero == m_pMdApi)
                {
                    m_pMdApi = MdApi.MD_CreateMdApi();
                    MdApi.CTP_RegOnRtnDepthMarketData(m_pMsgQueue, _fnOnRtnDepthMarketData_Holder);
                    MdApi.MD_RegMsgQueue2MdApi(m_pMdApi, m_pMsgQueue);
                    MdApi.MD_Connect(m_pMdApi, szPath, szAddresses, szBrokerId, szInvestorId, szPassword);
                }
            }
        }

        private void Disconnect_MD()
        {
            lock (_lockMd)
            {
                if (null != m_pMdApi && IntPtr.Zero != m_pMdApi)
                {
                    MdApi.MD_RegMsgQueue2MdApi(m_pMdApi, IntPtr.Zero);
                    MdApi.MD_ReleaseMdApi(m_pMdApi);
                    m_pMdApi = IntPtr.Zero;
                }
                _bMdConnected = false;
            }
        }

        private void Connect_MsgQueue()
        {
            lock (_lockMsgQueue)
            {
                if (null == m_pMsgQueue || IntPtr.Zero == m_pMsgQueue)
                {
                    m_pMsgQueue = CommApi.CTP_CreateMsgQueue();

                    CommApi.CTP_RegOnConnect(m_pMsgQueue, _fnOnConnect_Holder);
                    CommApi.CTP_RegOnDisconnect(m_pMsgQueue, _fnOnDisconnect_Holder);
                    CommApi.CTP_RegOnRspError(m_pMsgQueue, _fnOnRspError_Holder);

                    //由底层启动线程
                    CommApi.CTP_StartMsgQueue(m_pMsgQueue);
                }
            }
        }

        private void Disconnect_MsgQueue()
        {
            lock (_lockMsgQueue)
            {
                if (null != m_pMsgQueue && IntPtr.Zero != m_pMsgQueue)
                {
                    //停止底层线程
                    CommApi.CTP_StopMsgQueue(m_pMsgQueue);

                    CommApi.CTP_ReleaseMsgQueue(m_pMsgQueue);
                    m_pMsgQueue = IntPtr.Zero;
                }
            }
        }

        public void Subscribe(string inst)
        {
            lock (_lockMd)
            {
                if (null != m_pMdApi && IntPtr.Zero != m_pMdApi)
                {
                    MdApi.MD_Subscribe(m_pMdApi, inst,null);
                }
            }
        }

        public void Unsubscribe(string inst)
        {
            lock (_lockMd)
            {
                if (null != m_pMdApi && IntPtr.Zero != m_pMdApi)
                {
                    MdApi.MD_Unsubscribe(m_pMdApi, inst,null);
                }
            }
        }

        private void OnConnect_callback(IntPtr pApi, ref CThostFtdcRspUserLoginField pRspUserLogin, ConnectionStatus result)
        {
            _bMdConnected = (ConnectionStatus.E_logined == result);

            if (null != OnConnect)
            {
                OnConnect(this, new OnConnectArgs(pApi, ref pRspUserLogin, result));
            }
        }

        private void OnDisconnect_callback(IntPtr pApi, ref CThostFtdcRspInfoField pRspInfo, ConnectionStatus step)
        {
            if (null != OnDisconnect)
            {
                OnDisconnect(this, new OnDisconnectArgs(pApi, ref pRspInfo, step));
            }
        }

        private void OnRspError_callback(IntPtr pApi, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            if (null != OnRspError)
            {
                OnRspError(this, new OnRspErrorArgs(pApi, ref pRspInfo, nRequestID, bIsLast));
            }
        }

        private void OnRtnDepthMarketData_callback(IntPtr pMdUserApi, ref CThostFtdcDepthMarketDataField pDepthMarketData)
        {
            if (null != OnRtnDepthMarketData)
            {
                OnRtnDepthMarketData(this, new OnRtnDepthMarketDataArgs(pMdUserApi, ref pDepthMarketData));
            }
        }
    }
}
