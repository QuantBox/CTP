function OnRtnDepthMarketData(sender,arg)
% 行情回报

% 打印行情
disp(arg.pDepthMarketData.InstrumentID)
disp(arg.pDepthMarketData.LastPrice)

end
