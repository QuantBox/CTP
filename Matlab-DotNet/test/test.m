%% 导入C#库，请按自己目录进行调整
cd 'C:\Users\wukan\Documents\GitHub\CTP\Matlab-DotNet\test'
NET.addAssembly(fullfile(cd,'QuantBox.CSharp2CTP.dll'));
import QuantBox.CSharp2CTP.*;

%% 行情
global md;
md =  MdApiWrapper();
addlistener(md,'OnConnect',@OnMdConnect);
addlistener(md,'OnDisconnect',@OnMdDisconnect);
addlistener(md,'OnRtnDepthMarketData',@OnRtnDepthMarketData);
md.Connect('D:\', 'tcp://asp-sim2-md1.financial-trading-platform.com:26213',...
    '2030', '123456', '888888');

%% 交易
global td;
td = TraderApiWrapper();
addlistener(td,'OnConnect',@OnTdConnect);
addlistener(td,'OnDisconnect',@OnTdDisconnect);
addlistener(td,'OnRtnOrder',@OnRtnOrder);

td.Connect('D:\', 'tcp://asp-sim2-front1.financial-trading-platform.com:26205',...
    '2030', '123456', '888888',...
    QuantBox.CSharp2CTP.THOST_TE_RESUME_TYPE.THOST_TERT_QUICK,'','');

%% 退出
% md.Disconnect()
% td.Disconnect()