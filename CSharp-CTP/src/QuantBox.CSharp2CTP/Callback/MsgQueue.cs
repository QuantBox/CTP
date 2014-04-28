using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuantBox.CSharp2CTP.Callback
{
    public class MsgQueue:IDisposable
    {
        public IntPtr Queue = IntPtr.Zero;
        public MsgQueue()
        {
            Queue = CommApi.CTP_CreateMsgQueue();
        }

        ~MsgQueue()
        {
            Dispose();
        }

        public void Start()
        {
            // 启动消息队列循环
            CommApi.CTP_StartMsgQueue(Queue);
        }

        public void Dispose()
        {
            //停止底层线程
            CommApi.CTP_StopMsgQueue(Queue);

            CommApi.CTP_ReleaseMsgQueue(Queue);
            Queue = IntPtr.Zero;
        }
    }
}
