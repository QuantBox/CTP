function CTP_StopFcn(obj, event,pMdApi,pMsgQueue)
QuantBox.CSharp2C.MdApi.MD_ReleaseMdApi(pMdApi);
QuantBox.CSharp2C.CommApi.CTP_ReleaseMsgQueue(pMsgQueue);
disp('Stop')
end