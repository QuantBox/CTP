%% 交易连接回报
function OnMdConnect(sender,arg)

%行情状态到E_logined就表示登录成功
if arg.result == ConnectionStatus.E_logined
    global md;
	% 订阅行情，支持","分隔
    md.Subscribe('IF1305,IF1306,IF1309,IF1312');
end

end
