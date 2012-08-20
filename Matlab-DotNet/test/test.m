NET.addAssembly('D:\test\QuantBox.CSharp2C.dll');
import QuantBox.CSharp2C.*;

pMsgQueue = CommApi.CTP_CreateMsgQueue();
pMdApi = MdApi.MD_CreateMdApi();

CommApi.CTP_RegOnConnect(pMsgQueue,@OnConnect);
MdApi.CTP_RegOnRtnDepthMarketData(pMsgQueue,@OnRtnDepthMarketData);

MdApi.MD_RegMsgQueue2MdApi(pMdApi,pMsgQueue);

MdApi.MD_Connect(pMdApi, 'D:\', 'tcp://asp-sim2-md1.financial-trading-platform.com:26213', '2030', '123456', '888888');
MdApi.MD_Subscribe(pMdApi, 'IF1208;IF1207');

t = timer('StartDelay',1,...
          'Period',0.001,...
          'ExecutionMode','fixedDelay');
t.TimerFcn = {@CTP_TimerFcn,pMsgQueue};
t.StopFcn = {@CTP_StopFcn,pMdApi,pMsgQueue};
start(t)
%可以使用stop(timerfind)或stop(t)来停止