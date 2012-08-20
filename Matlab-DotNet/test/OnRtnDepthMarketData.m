function pDepthMarketData = OnRtnDepthMarketData(varargin)
pDepthMarketData = varargin{2};
disp(pDepthMarketData.InstrumentID);
disp(pDepthMarketData.LastPrice);
end
