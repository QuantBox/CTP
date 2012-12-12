function OnMdConnect(sender,arg)

% 行情登录成功后订阅行情
if arg.result == QuantBox.CSharp2CTP.ConnectionStatus.E_logined
    global md;
    md.Subscribe('IF1212,IF1301,IF1303,IF1306');
end

end
