function OnMdConnect(sender,arg)
% 交易连接回报

% 行情状态到Logined就表示登录成功
if arg.result == QuantBox.Libray.ConnectionStatus.Logined
    %global md;
	% 订阅行情，支持","和";"分隔
    %md.Subscribe('IF1406;IF1409,IF1412','');
end

disp(arg.result);

end
