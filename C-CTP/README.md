# CTP的C接口

## 目的
CTP提供C++接口，用其它语言调用并不方便，提供C接口封装就是为了解决此问题。

## 设计思路
* 行情与交易分别封装成两个类，创建相应类的对象，将对象地址返回，当成句柄使用，后所有函数都指定句柄来进行操作，实现C++接口转C接口
* 提供了一个响应队列来临时保存响应，保证底层接口能得到快速返回
* 交易类中维护了一个请求队列，用于解决CTP的流控问题
* 将登录时的客户端软件认证、身份认证、结算单确认的连贯操作做在了底层，简化了登录操作
* 提供了推和拉两种事件触发模式，可以按照不同语言的特点或用户需求来使用相应的模式

## 如何使用它进行开发

1. 复制4个ThostFtdc*.*源文件
2. 复制2个thost*api.dll
3. 复制2个thost*api.lib
4. 复制QuantBox.C2CTP.h到项目中
5. 复制1个QuantBox.C2CTP.lib
6. 复制1个QuantBox.C2CTP.dll
7. 参照QuantBox.C2CTP.h中声明的回调函数定义自己需要的回调函数，例如：
<pre>
void CALLBACK OnConnect(void* pApi,CThostFtdcRspUserLoginField *pRspUserLogin,ConnectionStatus step)
{
        cout<< "nReason"<< step<< endl;
}
//
void CALLBACK OnRtnDepthMarketData(void* pMdUserApi,CThostFtdcDepthMarketDataField *pDepthMarketData)
{
        cout<< pDepthMarketData->InstrumentID<< pDepthMarketData->UpdateTime<< endl;
}
</pre>
8. 创建行情对象和消息队列
<pre>
void* pMsgQueue = CTP_CreateMsgQueue();
void* pMd = MD_CreateMdApi();
</pre>
9. 将行情对象、消息队列、回调函数串接起来
<pre>
CTP_RegOnConnect(pMsgQueue,OnConnect);
CTP_RegOnRtnDepthMarketData(pMsgQueue,OnRtnDepthMarketData);
//
MD_RegMsgQueue2MdApi(pMd,pMsgQueue);
</pre>
10. 连接行情服务器
<pre>
MD_Connect(pMd,"C:\\","tcp://asp-sim2-md1.financial-trading-platform.com:26213","2030","123456","888888");
</pre>
11. 订阅行情
<pre>
MD_Subscribe(pMd,"IF1207,IF1208,IF1212");
</pre>
12. 触发回调，有两种方式，选择最合适自己的
<pre>
//拉模式
while(true)
{
        Sleep(1);
        CTP_ProcessMsgQueue(pMsgQueue);
}
</pre>
<pre>
//推模式
CTP_StartMsgQueue(pMsgQueue);//启动推模式
</pre>
13. 结束
<pre>
MD_ReleaseMdApi(pMd);//销毁行情对象
CTP_StopMsgQueue(pMsgQueue);//结束推模式，没有使用推模式时调也无所谓
CTP_ReleaseMsgQueue(pMsgQueue);//销毁消息队列
</pre>
14. 交易，与行情的写法类似，主要参与头文件
<pre>
m_pApi = TD_CreateTdApi();
TD_RegMsgQueue2TdApi(m_pApi,m_pMsgQueue);
//
TD_Connect(m_pApi,"C:\\",
        "tcp://asp-sim2-front1.financial-trading-platform.com:26205",
        "2030","123456","888888",THOST_TERT_RESTART,"","");
//
TThostFtdcCombOffsetFlagType CombOffsetFlag = {THOST_FTDC_OF_Open,0};
TThostFtdcCombHedgeFlagType CombHedgeFlag = {THOST_FTDC_HF_Speculation,0};
//
TD_SendOrder(
        m_pApi,
        "IF1210",
        THOST_FTDC_D_Buy,
        CombOffsetFlag,
        CombHedgeFlag,
        1,
        2500,
        THOST_FTDC_OPT_LimitPrice,
        THOST_FTDC_TC_GFD,
        THOST_FTDC_CC_Immediately,
        0);
</pre>

## 如何开发此接口

1. 打开QuantBox.C2CTP.sln
2. TraderApi是对CTP交易接口的封装、MdUserApi是对行情的封装
3. CTPMsgQueue是响应队列、QuantBox.C2CTP是C接口

### 以查合约列表举例

1. 实现底层能向CTP接口发送查合约请求，在TraderApi.h添加
<pre>
void ReqQryInstrument(const string& szInstrumentId);
</pre>
2. 在TraderApi.cpp中实现此函数，因为此函数的工作就是生成相应的数据包到请求队列，得定义下请求的数据包类型与格式，所以又回到TraderApi.h添加
<pre>
enum RequestType
{
        ......
        E_QryInstrumentField,
        ......
};
</pre>
<pre>
struct SRequest
{
        RequestType type;
        union{
                ......
                CThostFtdcQryInstrumentField    QryInstrumentField;
                ......
        };
};
</pre>
3. 请求已经添加到队列中了，接下来得让队列能正确调用对应的函数进行发送。TraderApi.cpp中的RunInThread()中补全
<pre>
switch(pRequest->type)
{
        .......
        case E_QryInstrumentField:
                iRet = m_pApi->ReqQryInstrument(&pRequest->QryInstrumentField,lRequest);
                break;
        .......
}
</pre>
4. 请求发送完后开始处理响应，在TraderApi.h声明接口方法
<pre>
virtual void OnRspQryInstrument(CThostFtdcInstrumentField *pInstrument, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
</pre>
5. 在TraderApi.h实现对应的定义
6. 由于将响应交给了对应的响应对列，所以得实现对应的接收响应到队列的方法，到CTPMsgQueue.h添加
<pre>
void Input_OnRspQryInstrument(void* pTraderApi,CThostFtdcInstrumentField *pInstrument, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
</pre>
7. 到CTPMsgQueue.cpp实现Input_OnRspQryInstrument方法，
8. 同样发现还得定义响应的的数据包类型与格式，回到CTPMsgQueue.h添加
<pre>
enum EnumMsgType
{
        ......
        E_fnOnRspQryInstrument,
        ......
};
</pre>
<pre>
struct SMsgItem
{
        ......
        union{
                ......
                CThostFtdcInstrumentField    Instrument;
                ......
        };
};
</pre>
9. 响应包已经放到队列中了，现在由外界来调用Process取用，_Output会被调用，同样补全数据类型实别的部分
<pre>
void CCTPMsgQueue::_Output(SMsgItem* pMsgItem)
{
        switch(pMsgItem->type)
        {
        ......
        case E_fnOnRspQryInstrument:
                Output_OnRspQryInstrument(pMsgItem);
                break;
        ......
    }
}
</pre>
10. CTPMsgQueue.h添加Output_OnRspQryInstrument定义
11. 判断了回调函数是否有效，得到QuantBox.C2CTP.h定义回调函数
<pre>
typedef void (__stdcall *fnOnRspQryInstrument)(void* pTraderApi,CThostFtdcInstrumentField *pInstrument, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
</pre>
12. CTPMsgQueue.h中注册回调函数的相关地方
定义回调函数指针
<pre>
fnOnRspQryInstrument    m_fnOnRspQryInstrument;
</pre>
初始化指针为空
<pre>
CCTPMsgQueue(void)
{
        ......
        m_fnOnRspQryInstrument = NULL;
        ......
}
</pre>
外部注入函数地址
<pre>
void RegisterCallback(fnOnRspQryInstrument pCallback){m_fnOnRspQryInstrument = pCallback;}
</pre>
13. 完成以上步骤后，交易的封装就完成了，现在得将C接口进行导出，在QuantBox.C2CTP.h中声明
<pre>
QUANTBOXC2CTP_API void __stdcall TD_ReqQryInstrument(void* pTraderApi,const char* szInstrumentId);
</pre>
14. 在QuantBox.C2CTP.cpp中实现TD_ReqQryInstrument
15. 同样实现CTP_RegOnRspQryInstrument，保证回调函数能得到注册
