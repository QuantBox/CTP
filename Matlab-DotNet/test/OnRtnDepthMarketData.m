%% 行情回报
function OnRtnDepthMarketData(sender,arg)

% 打印行情
disp(arg.pDepthMarketData.InstrumentID)
disp(arg.pDepthMarketData.LastPrice)

end
