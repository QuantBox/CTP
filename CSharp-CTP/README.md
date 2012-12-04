# CTP的C#接口

## 目的
提供C#接口供程序调用

## 设计思路
* 直接调用CTP的C版本接口，所有使用方法与C接口完全一样
* 所有结构体、枚举进行相应的映射（感谢海风开源的类型转换工具）

## 如何使用它进行开发
1. 复制C接口下的thosttraderapi.dll、thostmduserapi.dll、QuantBox.C2CTP.dll三个文件到目标目录
2. 复制C#接口的QuantBox.CSharp2CTP.dll到相同
3. 引用QuantBox.CSharp2CTP
4. 创建消息队列
<pre>
IntPtr pMsgQueue = CommApi.CTP_CreateMsgQueue();
</pre>
5. 向消息队列中注入回调函数
<pre>
CommApi.CTP_RegOnConnect(pMsgQueue, OnConnect);
CommApi.CTP_RegOnDisconnect(pMsgQueue, OnDisconnect);
MdApi.CTP_RegOnRtnDepthMarketData(pMsgQueue, OnRtnDepthMarketData);
</pre>
<pre>
public static void OnRtnDepthMarketData(IntPtr pApi, ref CThostFtdcDepthMarketDataField pDepthMarketData)
{
	Console.WriteLine("{0} {1} {2}", pApi, pDepthMarketData.InstrumentID, pDepthMarketData.UpdateTime);
}
</pre>
6. 创建行情实例，并将消息队列对接上
<pre>
IntPtr pMdApi = MdApi.MD_CreateMdApi();
MdApi.MD_RegMsgQueue2MdApi(pMdApi, pMsgQueue);
</pre>
7. 连接并订阅
<pre>
MdApi.MD_Connect(pMdApi, "D:\\", "tcp://asp-sim2-md1.financial-trading-platform.com:26213", "2030", "123456", "888888");
MdApi.MD_Subscribe(pMdApi, "IF1208");
</pre>
8. 取数据
<pre>
while (true)
{
	CommApi.CTP_ProcessMsgQueue(pMsgQueue);
}
</pre>
9. 再细节的内容请查看C接口的说明与源码

## 如何开发此接口
1. 打开QuantBox.CSharp2CTP.sln
2. TraderApi、MdApi、CommApi是对应接口的调用
3. Callbacks.cs是回调函数声明