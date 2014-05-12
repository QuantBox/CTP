using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace QuantBox.CSharp2CTP.Callback
{
    public class BaseApi : KeyInfo
    {
        public bool IsConnected;

        protected MsgQueue _MsgQueue;

        protected FrontInfo _Front;
        protected AccountInfo _Account;
        protected ConnectionInfo _Connection;

        private fnOnConnect _OnConnect;
        private fnOnDisconnect _OnDisconnect;
        private fnOnRspError _OnRspError;

        protected string _TempPath;

        public BaseApi(MsgQueue msgQueue)
        {
            // 传入消息队列的原因是为了队列使用单线程
            _MsgQueue = msgQueue;
        }

        private bool disposed;
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
        ~BaseApi()
        {
            // Simply call Dispose(false).
            Dispose(false);
        }

        public fnOnConnect OnConnect
        {
            set
            {
                _OnConnect = value;
                CommApi.CTP_RegOnConnect(_MsgQueue.Queue, __OnConnect);
            }
        }

        private void __OnConnect(IntPtr pApi, ref CThostFtdcRspUserLoginField pRspUserLogin, ConnectionStatus result)
        {
            _OnConnect(this, pApi, ref pRspUserLogin, result);
        }

        public fnOnDisconnect OnDisconnect
        {
            set
            {
                _OnDisconnect = value;
                CommApi.CTP_RegOnDisconnect(_MsgQueue.Queue, __OnDisconnect);
            }
        }
        private void __OnDisconnect(IntPtr pApi, ref CThostFtdcRspInfoField pRspInfo, ConnectionStatus step)
        {
            _OnDisconnect(this, pApi, ref pRspInfo, step);
        }

        public fnOnRspError OnRspError
        {
            set
            {
                _OnRspError = value;
                CommApi.CTP_RegOnRspError(_MsgQueue.Queue, __OnRspError);
            }
        }

        private void __OnRspError(IntPtr pApi, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            _OnRspError(this, pApi, ref pRspInfo, nRequestID, bIsLast);
        }

        public FrontInfo Front
        {
            get { return _Front; }
            set { _Front = value; }
        }

        public AccountInfo Account
        {
            get { return _Account; }
            set { _Account = value; }
        }
        public ConnectionInfo Connection
        {
            get { return _Connection; }
            set { _Connection = value; }
        }

        public virtual void Connect()
        {
            lock (this)
            {
                if (_Connection == null)
                    throw new ArgumentNullException("连接信息不能为空");

                if (_Front == null)
                    throw new ArgumentNullException("前置机参数不能为空");

                if (_Account == null)
                    throw new ArgumentNullException("账号不能为空");

                if (string.IsNullOrWhiteSpace(_Connection.StringKey))
                    _Connection.StringKey = Guid.NewGuid().ToString();

                //  生成temp目录，这个地址有问题
                _TempPath = Path.Combine(_Connection.TempPath,
                    "CTP",
                    _Connection.StringKey);

                Directory.CreateDirectory(_TempPath);

                _MsgQueue.Start();
            }
        }

        public virtual void Disconnect()
        {
            // 不在这里停止消息队列

            //if (null != _MsgQueue && IntPtr.Zero != _MsgQueue)
            //{
            //    CommApi.CTP_StopMsgQueue(_MsgQueue);

            //    CommApi.CTP_ReleaseMsgQueue(_MsgQueue);

            //    _MsgQueue = IntPtr.Zero;
            //}
        }
    }
}
