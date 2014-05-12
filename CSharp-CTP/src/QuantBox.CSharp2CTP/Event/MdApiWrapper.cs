using QuantBox.CSharp2CTP.Callback;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuantBox.CSharp2CTP.Event
{
    public class MdApiWrapper : IDisposable
    {
        public event OnConnectHandler OnConnect;
        public event OnDisconnectHandler OnDisconnect;
        public event OnRspErrorHandler OnRspError;
        public event OnRtnDepthMarketDataHandler OnRtnDepthMarketData;

        private volatile bool _bMdConnected;

        private bool disposed;

        private MsgQueue m_pMsgQueue;
        private MarketDataApi m_Api;

        public MdApiWrapper()
        {
            Init(new MsgQueue());
        }

        public MdApiWrapper(MsgQueue msgQueue)
        {
            Init(msgQueue);
        }

        private void Init(MsgQueue msgQueue)
        {
            m_pMsgQueue = msgQueue;
            m_Api = new MarketDataApi(m_pMsgQueue);
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
            m_Api.Connection = new ConnectionInfo()
            {
                TempPath = szPath,
            };

            m_Api.Front = new FrontInfo()
            {
                BrokerId = szBrokerId,
                MarketDataAddress = szAddresses,
            };

            m_Api.Account = new AccountInfo()
            {
                InvestorId = szInvestorId,
                Password = szPassword,
            };

            Disconnect_MD();
            Connect_MD();
        }

        public void Disconnect()
        {
            Disconnect_MD();
        }

        //建立行情
        private void Connect_MD()
        {
            lock(this)
            {
                m_Api.OnConnect = OnConnect_callback;
                m_Api.OnDisconnect = OnDisconnect_callback;
                m_Api.OnRspError = OnRspError_callback;

                m_Api.OnRtnDepthMarketData = OnRtnDepthMarketData_callback;

                m_Api.Connect();
            }
        }

        private void Disconnect_MD()
        {
            lock (this)
            {
                m_Api.Disconnect();
                _bMdConnected = false;
            }
        }

        public void Subscribe(string inst, string szExchange)
        {
            lock(this)
            {
                m_Api.Subscribe(inst, szExchange);
            }
        }

        public void Unsubscribe(string inst, string szExchange)
        {
            lock(this)
            {
                m_Api.Unsubscribe(inst, szExchange);
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
