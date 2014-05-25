function OnRtnOrder(sender,arg)
% 委托回报
global orders;

% 打印内容
disp(arg)

% 使用OrderRef来记录订单，后期可用来撤单
orders{str2num(char(arg.pOrder.OrderRef))} = arg.pOrder;

end
