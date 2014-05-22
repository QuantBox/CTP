function OnTdConnect(sender,arg)
% 交易连接回报

% 交易状态到Confirmed就表示登录并确认成功
if arg.result == QuantBox.Libray.ConnectionStatus.Confirmed
    
end

disp(arg.result);

end
