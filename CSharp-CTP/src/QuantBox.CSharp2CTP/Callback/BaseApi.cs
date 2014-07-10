using QuantBox.Library;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace QuantBox.CSharp2CTP.Callback
{
    public class BaseApi : KeyInfo
    {
        private object locker = new object();

        public bool IsConnected { get; protected set; }

        protected MsgQueue _MsgQueue;

        protected FrontInfo _Front;
        protected AccountInfo _Account;
        protected ConnectionInfo _Connection;

        protected fnOnConnect OnConnect_1;
        private fnOnDisconnect OnDisconnect_1;
        private fnOnRspError OnRspError_1;

        private QuantBox.CSharp2CTP.fnOnConnect OnConnect_2;
        private QuantBox.CSharp2CTP.fnOnDisconnect OnDisconnect_2;
        private QuantBox.CSharp2CTP.fnOnRspError OnRspError_2;

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
                OnConnect_1 = value;
                OnConnect_2 = OnConnect_3;
                CommApi.CTP_RegOnConnect(_MsgQueue.Queue, OnConnect_2);
            }
        }

        protected virtual void OnConnect_3(IntPtr pApi, ref CThostFtdcRspUserLoginField pRspUserLogin, ConnectionStatus result)
        {
            OnConnect_1(this, pApi, ref pRspUserLogin, result);
        }

        public fnOnDisconnect OnDisconnect
        {
            set
            {
                OnDisconnect_1 = value;
                OnDisconnect_2 = OnDisconnect_3;
                CommApi.CTP_RegOnDisconnect(_MsgQueue.Queue, OnDisconnect_2);
            }
        }
        private void OnDisconnect_3(IntPtr pApi, ref CThostFtdcRspInfoField pRspInfo, ConnectionStatus step)
        {
            IsConnected = false;
            OnDisconnect_1(this, pApi, ref pRspInfo, step);
        }

        public fnOnRspError OnRspError
        {
            set
            {
                OnRspError_1 = value;
                OnRspError_2 = OnRspError_3;
                CommApi.CTP_RegOnRspError(_MsgQueue.Queue, OnRspError_2);
            }
        }

        private void OnRspError_3(IntPtr pApi, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            OnRspError_1(this, pApi, ref pRspInfo, nRequestID, bIsLast);
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
            lock (locker)
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
            IsConnected = false;
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
