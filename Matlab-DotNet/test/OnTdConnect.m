function OnTdConnect(sender,arg)
% 交易连接回报

% 交易状态到E_confirmed就表示登录并确认成功
if arg.result == QuantBox.CSharp2CTP.ConnectionStatus.E_confirmed
    global td;
    % 下单
    td.SendOrder('IF1401',... %合约
        QuantBox.CSharp2CTP.TThostFtdcDirectionType.Buy,... %买卖
        '0',... %开平标记
        '1',... %投机套保标记
        1,... %数量
        2250,... %价格
        QuantBox.CSharp2CTP.TThostFtdcOrderPriceTypeType.LimitPrice,... %价格类型
        QuantBox.CSharp2CTP.TThostFtdcTimeConditionType.GFD,... %时间类型
        QuantBox.CSharp2CTP.TThostFtdcContingentConditionType.Immediately,... %条件类型
        0,... % 止损价
        QuantBox.CSharp2CTP.TThostFtdcVolumeConditionType.AV); %成交量类型
end

end
