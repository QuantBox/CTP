%% 交易连接回报
function OnTdConnect(sender,arg)

%交易状态到E_confirmed就表示登录并确认成功
if arg.result == ConnectionStatus.E_confirmed
    global td;
    % 下单
    td.SendOrder('IF1309',... %合约
        TThostFtdcDirectionType.Buy,... %买卖
        '0',... %开平标记
        '1',... %投机套保标记
        1,... %数量
		2250,... %价格
        TThostFtdcOrderPriceTypeType.LimitPrice,... %价格类型
        TThostFtdcTimeConditionType.GFD,... %时间类型
        TThostFtdcContingentConditionType.Immediately,... %条件类型
        0);
end

end
