%% 委托回报
function OnRtnOrder(sender,arg)
% 打印内容
disp(arg)

% 在某种情况下撤单，自己考虑各条件
if arg.pOrder.VolumeTotal>2
    global td;
    % 撤单
    td.CancelOrder(arg.pOrder);
end

end
