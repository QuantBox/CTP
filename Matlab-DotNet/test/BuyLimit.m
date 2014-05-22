function OrderRef = BuyLimit(Instrument,Qty,Price)
    global td;
    % 下单
    OrderRef = td.SendOrder(...
        -1,... %强行指定报单引用,-1表示由底层生成
        Instrument,... %合约
        QuantBox.CSharp2CTP.TThostFtdcDirectionType.Buy,... %买卖
        '0',... %开平标记
        '1',... %投机套保标记
        Qty,... %数量
        Price,... %价格
        QuantBox.CSharp2CTP.TThostFtdcOrderPriceTypeType.LimitPrice,... %价格类型
        QuantBox.CSharp2CTP.TThostFtdcTimeConditionType.GFD,... %时间类型
        QuantBox.CSharp2CTP.TThostFtdcContingentConditionType.Immediately,... %条件类型
        0,... % 止损价
        QuantBox.CSharp2CTP.TThostFtdcVolumeConditionType.AV); %成交量类型
    
end
