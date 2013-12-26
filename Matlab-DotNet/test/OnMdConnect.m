function OnMdConnect(sender,arg)
% 交易连接回报

% 行情状态到E_logined就表示登录成功
if arg.result == QuantBox.CSharp2CTP.ConnectionStatus.E_logined
    global md;
	% 订阅行情，支持","和";"分隔
    md.Subscribe('IF1401;IF1403,IF1409;IF1312');
else
    disp(arg.result);
end

end
