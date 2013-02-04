# CTP的Java接口

## 目的
提供Java接口供程序调用

## 设计思路
* 直接调用CTP的C版本接口，所有使用方法与C接口完全一样
* 使用JNA技术，采用了JNAerator进行转换（感谢绿茶提供示例和指导）

## 如何转换C接口为Java接口
1. 复制C接口下的ThostFtdcUserApiDataType.h、ThostFtdcUserApiStruct.h、QuantBox.C2CTP.h三个文件到gen目录
2. 由于ThostFtdcUserApiDataType中有两大处枚举类型无法转成Java,手工修改成以下内容
> ///银行发起银行资金转期货<br>
\#define THOST_FTDC_VTC_BankBankToFuture '0'<br>
///银行发起期货资金转银行<br>
\#define THOST_FTDC_VTC_BankFutureToBank '1'<br>
///期货发起银行资金转期货<br>
\#define THOST_FTDC_VTC_FutureBankToFuture '2'<br>
///期货发起期货资金转银行<br>
\#define THOST_FTDC_VTC_FutureFutureToBank '3'<br><br>
///银行发起银行转期货<br>
\#define THOST_FTDC_FTC_BankLaunchBankToBroker '0'<br>
///期货发起银行转期货<br>
\#define THOST_FTDC_FTC_BrokerLaunchBankToBroker '1'<br>
///银行发起期货转银行<br>
\#define THOST_FTDC_FTC_BankLaunchBrokerToBank '2'<br>
///期货发起期货转银行<br>
\#define THOST_FTDC_FTC_BrokerLaunchBrokerToBank '3'<br>

3. 复制C接口的QuantBox.C2CTP.dll到gen目录
4. 到jnaerator上下载最新版的jar并放到gen目录[http://code.google.com/p/jnaerator/downloads/list](http://code.google.com/p/jnaerator/downloads/list)
5. 可能要修改jnaerator.bat中相应jar文件名
6. 运行jnaerator.bat，生成out.jar,解压jar,将其中的java文件全复制出来。
7. 将java添加到Eclipse项目中，修改QuantLibrary.java中JNA_LIBRARY_NAME = "QuantBox.C2CTP"
8. 将jna.jar添加到项目中[https://maven.java.net/content/repositories/releases/net/java/dev/jna/jna/](https://maven.java.net/content/repositories/releases/net/java/dev/jna/jna/)
9. 实际测试发现jna 3.4可以使用，但3.5就不行，所以在这使用的是3.4，欢迎大家帮修改成3.5
10. TraderApiWrapper与MdApiWrapper分别是交易与行情的示例,可运行