%% 导入C#库，请按自己目录进行调整
cd 'D:\Kan\Documents\GitHub\CTP\Matlab-DotNet\test\'
NET.addAssembly(fullfile(cd,'QuantBox.CSharp2CTP.dll'));
NET.addAssembly(fullfile(cd,'QuantBox.Libray.dll'));
import QuantBox.CSharp2CTP.*;
import QuantBox.CSharp2CTP.Event.*;
import QuantBox.Libray.*;

%% 行情
global md;
md =  MdApiWrapper();
addlistener(md,'OnConnect',@OnMdConnect);
addlistener(md,'OnDisconnect',@OnMdDisconnect);
addlistener(md,'OnRtnDepthMarketData',@OnRtnDepthMarketData);
md.Connect('D:\',... %行情流文件路径
    'tcp://ctpmn1-front1.citicsf.com:51213',... %行情服务器地址
    '1017',... %经纪公司代码
    '123456',... %用户代码
    '888888'); %密码

%% 交易
global orders;

global td;
td = TraderApiWrapper();
addlistener(td,'OnConnect',@OnTdConnect);
addlistener(td,'OnDisconnect',@OnTdDisconnect);
addlistener(td,'OnRtnOrder',@OnRtnOrder);

td.Connect('D:\',... %交易流文件路径
    'tcp://ctpmn1-front1.citicsf.com:51205',... %交易服务器地址
    '1017',... %经纪公司代码
    '00000015',... %用户代码
    '123456',... %密码
    THOST_TE_RESUME_TYPE.THOST_TERT_QUICK,... %流重传方式
    'MATLAB',... %用户端产品信息
    ''); %认证码

%% 下单
BuyLimit('IF1406',1,2500)
disp(orders{1}.OrderStatus)
disp(orders{1}.StatusMsg)

%% 撤单
Cancel(orders{1})
disp(orders{1}.OrderStatus)

%% 退出
% md.Disconnect() %行情退出
% td.Disconnect() %交易退出