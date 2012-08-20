using System.Runtime.InteropServices;

namespace QuantBox.CSharp2C
{
    /// <summary>
    /// 信息分发
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcDisseminationField
    {
        /// <summary>
        /// 序列系列号
        /// </summary>
        public short SequenceSeries;
        /// <summary>
        /// 序列号
        /// </summary>
        public int SequenceNo;
    }

    /// <summary>
    /// 用户登录请求
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcReqUserLoginField
    {
        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        /// 密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        /// <summary>
        /// 用户端产品信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string UserProductInfo;
        /// <summary>
        /// 接口端产品信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string InterfaceProductInfo;
        /// <summary>
        /// 协议信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ProtocolInfo;
        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;
        /// <summary>
        /// 动态密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string OneTimePassword;
        /// <summary>
        /// 终端IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string ClientIPAddress;
    }

    /// <summary>
    /// 用户登录应答
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcRspUserLoginField
    {
        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        /// 登录成功时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string LoginTime;
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        /// 交易系统名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string SystemName;
        /// <summary>
        /// 前置编号
        /// </summary>
        public int FrontID;
        /// <summary>
        /// 会话编号
        /// </summary>
        public int SessionID;
        /// <summary>
        /// 最大报单引用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string MaxOrderRef;
        /// <summary>
        /// 上期所时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string SHFETime;
        /// <summary>
        /// 大商所时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string DCETime;
        /// <summary>
        /// 郑商所时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string CZCETime;
        /// <summary>
        /// 中金所时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string FFEXTime;
    }

    /// <summary>
    /// 用户登出请求
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcUserLogoutField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
    }

    /// <summary>
    /// 强制交易员退出
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcForceUserLogoutField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
    }

    /// <summary>
    /// 客户端认证请求
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcReqAuthenticateField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        /// 用户端产品信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string UserProductInfo;
        /// <summary>
        /// 认证码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string AuthCode;
    }

    /// <summary>
    /// 客户端认证响应
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcRspAuthenticateField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        /// 用户端产品信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string UserProductInfo;
    }

    /// <summary>
    /// 客户端认证信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcAuthenticationInfoField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        /// 用户端产品信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string UserProductInfo;
        /// <summary>
        /// 认证信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string AuthInfo;
        /// <summary>
        /// 是否为认证结果
        /// </summary>
        public int IsResult;
    }

    /// <summary>
    /// 银期转帐报文头
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcTransferHeaderField
    {
        /// <summary>
        /// 版本号，常量，1.0
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string Version;
        /// <summary>
        /// 交易代码，必填
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        /// <summary>
        /// 交易日期，必填，格式：yyyymmdd
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        /// <summary>
        /// 交易时间，必填，格式：hhmmss
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        /// <summary>
        /// 发起方流水号，N/A
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeSerial;
        /// <summary>
        /// 期货公司代码，必填
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string FutureID;
        /// <summary>
        /// 银行代码，根据查询银行得到，必填
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        /// <summary>
        /// 银行分中心代码，根据查询银行得到，必填
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBrchID;
        /// <summary>
        /// 操作员，N/A
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;
        /// <summary>
        /// 交易设备类型，N/A
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;
        /// <summary>
        /// 记录数，N/A
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string RecordNum;
        /// <summary>
        /// 会话编号，N/A
        /// </summary>
        public int SessionID;
        /// <summary>
        /// 请求编号，N/A
        /// </summary>
        public int RequestID;
    }

    /// <summary>
    /// 银行资金转期货请求，TradeCode=202001
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcTransferBankToFutureReqField
    {
        /// <summary>
        /// 期货资金账户
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string FutureAccount;
        /// <summary>
        /// 密码标志
        /// </summary>
        public TThostFtdcFuturePwdFlagType FuturePwdFlag;
        /// <summary>
        /// 密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string FutureAccPwd;
        /// <summary>
        /// 转账金额
        /// </summary>
        public double TradeAmt;
        /// <summary>
        /// 客户手续费
        /// </summary>
        public double CustFee;
        /// <summary>
        /// 币种：RMB-人民币 USD-美圆 HKD-港元
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyCode;
    }

    /// <summary>
    /// 银行资金转期货请求响应
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcTransferBankToFutureRspField
    {
        /// <summary>
        /// 响应代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string RetCode;
        /// <summary>
        /// 响应信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string RetInfo;
        /// <summary>
        /// 资金账户
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string FutureAccount;
        /// <summary>
        /// 转帐金额
        /// </summary>
        public double TradeAmt;
        /// <summary>
        /// 应收客户手续费
        /// </summary>
        public double CustFee;
        /// <summary>
        /// 币种
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyCode;
    }

    /// <summary>
    /// 期货资金转银行请求，TradeCode=202002
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcTransferFutureToBankReqField
    {
        /// <summary>
        /// 期货资金账户
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string FutureAccount;
        /// <summary>
        /// 密码标志
        /// </summary>
        public TThostFtdcFuturePwdFlagType FuturePwdFlag;
        /// <summary>
        /// 密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string FutureAccPwd;
        /// <summary>
        /// 转账金额
        /// </summary>
        public double TradeAmt;
        /// <summary>
        /// 客户手续费
        /// </summary>
        public double CustFee;
        /// <summary>
        /// 币种：RMB-人民币 USD-美圆 HKD-港元
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyCode;
    }

    /// <summary>
    /// 期货资金转银行请求响应
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcTransferFutureToBankRspField
    {
        /// <summary>
        /// 响应代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string RetCode;
        /// <summary>
        /// 响应信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string RetInfo;
        /// <summary>
        /// 资金账户
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string FutureAccount;
        /// <summary>
        /// 转帐金额
        /// </summary>
        public double TradeAmt;
        /// <summary>
        /// 应收客户手续费
        /// </summary>
        public double CustFee;
        /// <summary>
        /// 币种
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyCode;
    }

    /// <summary>
    /// 查询银行资金请求，TradeCode=204002
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcTransferQryBankReqField
    {
        /// <summary>
        /// 期货资金账户
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string FutureAccount;
        /// <summary>
        /// 密码标志
        /// </summary>
        public TThostFtdcFuturePwdFlagType FuturePwdFlag;
        /// <summary>
        /// 密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string FutureAccPwd;
        /// <summary>
        /// 币种：RMB-人民币 USD-美圆 HKD-港元
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyCode;
    }

    /// <summary>
    /// 查询银行资金请求响应
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcTransferQryBankRspField
    {
        /// <summary>
        /// 响应代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string RetCode;
        /// <summary>
        /// 响应信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string RetInfo;
        /// <summary>
        /// 资金账户
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string FutureAccount;
        /// <summary>
        /// 银行余额
        /// </summary>
        public double TradeAmt;
        /// <summary>
        /// 银行可用余额
        /// </summary>
        public double UseAmt;
        /// <summary>
        /// 银行可取余额
        /// </summary>
        public double FetchAmt;
        /// <summary>
        /// 币种
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyCode;
    }

    /// <summary>
    /// 查询银行交易明细请求，TradeCode=204999
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcTransferQryDetailReqField
    {
        /// <summary>
        /// 期货资金账户
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string FutureAccount;
    }

    /// <summary>
    /// 查询银行交易明细请求响应
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcTransferQryDetailRspField
    {
        /// <summary>
        /// 交易日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        /// <summary>
        /// 交易时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        /// <summary>
        /// 交易代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        /// <summary>
        /// 期货流水号
        /// </summary>
        public int FutureSerial;
        /// <summary>
        /// 期货公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string FutureID;
        /// <summary>
        /// 资金帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 22)]
        public string FutureAccount;
        /// <summary>
        /// 银行流水号
        /// </summary>
        public int BankSerial;
        /// <summary>
        /// 银行代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        /// <summary>
        /// 银行分中心代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBrchID;
        /// <summary>
        /// 银行账号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;
        /// <summary>
        /// 证件号码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string CertCode;
        /// <summary>
        /// 货币代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyCode;
        /// <summary>
        /// 发生金额
        /// </summary>
        public double TxAmount;
        /// <summary>
        /// 有效标志
        /// </summary>
        public TThostFtdcTransferValidFlagType Flag;
    }

    /// <summary>
    /// 响应信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcRspInfoField
    {
        /// <summary>
        /// 错误代码
        /// </summary>
        public int ErrorID;
        /// <summary>
        /// 错误信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;
    }

    /// <summary>
    /// 交易所
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcExchangeField
    {
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        /// 交易所名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeName;
        /// <summary>
        /// 交易所属性
        /// </summary>
        public TThostFtdcExchangePropertyType ExchangeProperty;
    }

    /// <summary>
    /// 产品
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcProductField
    {
        /// <summary>
        /// 产品代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ProductID;
        /// <summary>
        /// 产品名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string ProductName;
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        /// 产品类型
        /// </summary>
        public TThostFtdcProductClassType ProductClass;
        /// <summary>
        /// 合约数量乘数
        /// </summary>
        public int VolumeMultiple;
        /// <summary>
        /// 最小变动价位
        /// </summary>
        public double PriceTick;
        /// <summary>
        /// 市价单最大下单量
        /// </summary>
        public int MaxMarketOrderVolume;
        /// <summary>
        /// 市价单最小下单量
        /// </summary>
        public int MinMarketOrderVolume;
        /// <summary>
        /// 限价单最大下单量
        /// </summary>
        public int MaxLimitOrderVolume;
        /// <summary>
        /// 限价单最小下单量
        /// </summary>
        public int MinLimitOrderVolume;
        /// <summary>
        /// 持仓类型
        /// </summary>
        public TThostFtdcPositionTypeType PositionType;
        /// <summary>
        /// 持仓日期类型
        /// </summary>
        public TThostFtdcPositionDateTypeType PositionDateType;
    }

    /// <summary>
    /// 合约
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcInstrumentField
    {
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        /// 合约名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string InstrumentName;
        /// <summary>
        /// 合约在交易所的代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;
        /// <summary>
        /// 产品代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ProductID;
        /// <summary>
        /// 产品类型
        /// </summary>
        public TThostFtdcProductClassType ProductClass;
        /// <summary>
        /// 交割年份
        /// </summary>
        public int DeliveryYear;
        /// <summary>
        /// 交割月
        /// </summary>
        public int DeliveryMonth;
        /// <summary>
        /// 市价单最大下单量
        /// </summary>
        public int MaxMarketOrderVolume;
        /// <summary>
        /// 市价单最小下单量
        /// </summary>
        public int MinMarketOrderVolume;
        /// <summary>
        /// 限价单最大下单量
        /// </summary>
        public int MaxLimitOrderVolume;
        /// <summary>
        /// 限价单最小下单量
        /// </summary>
        public int MinLimitOrderVolume;
        /// <summary>
        /// 合约数量乘数
        /// </summary>
        public int VolumeMultiple;
        /// <summary>
        /// 最小变动价位
        /// </summary>
        public double PriceTick;
        /// <summary>
        /// 创建日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string CreateDate;
        /// <summary>
        /// 上市日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string OpenDate;
        /// <summary>
        /// 到期日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExpireDate;
        /// <summary>
        /// 开始交割日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string StartDelivDate;
        /// <summary>
        /// 结束交割日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string EndDelivDate;
        /// <summary>
        /// 合约生命周期状态
        /// </summary>
        public TThostFtdcInstLifePhaseType InstLifePhase;
        /// <summary>
        /// 当前是否交易
        /// </summary>
        public int IsTrading;
        /// <summary>
        /// 持仓类型
        /// </summary>
        public TThostFtdcPositionTypeType PositionType;
        /// <summary>
        /// 持仓日期类型
        /// </summary>
        public TThostFtdcPositionDateTypeType PositionDateType;
        /// <summary>
        /// 多头保证金率
        /// </summary>
        public double LongMarginRatio;
        /// <summary>
        /// 空头保证金率
        /// </summary>
        public double ShortMarginRatio;
    }

    /// <summary>
    /// 经纪公司
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcBrokerField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 经纪公司简称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string BrokerAbbr;
        /// <summary>
        /// 经纪公司名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string BrokerName;
        /// <summary>
        /// 是否活跃
        /// </summary>
        public int IsActive;
    }

    /// <summary>
    /// 交易所交易员
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcTraderField
    {
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        /// <summary>
        /// 密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        /// <summary>
        /// 安装数量
        /// </summary>
        public int InstallCount;
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
    }

    /// <summary>
    /// 投资者
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcInvestorField
    {
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者分组代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorGroupID;
        /// <summary>
        /// 投资者名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string InvestorName;
        /// <summary>
        /// 证件类型
        /// </summary>
        public TThostFtdcIdCardTypeType IdentifiedCardType;
        /// <summary>
        /// 证件号码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;
        /// <summary>
        /// 是否活跃
        /// </summary>
        public int IsActive;
        /// <summary>
        /// 联系电话
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Telephone;
        /// <summary>
        /// 通讯地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
        public string Address;
        /// <summary>
        /// 开户日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string OpenDate;
        /// <summary>
        /// 手机
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Mobile;
        /// <summary>
        /// 手续费率模板代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string CommModelID;
    }

    /// <summary>
    /// 交易编码
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcTradingCodeField
    {
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;
        /// <summary>
        /// 是否活跃
        /// </summary>
        public int IsActive;
        /// <summary>
        /// 交易编码类型
        /// </summary>
        public TThostFtdcClientIDTypeType ClientIDType;
    }

    /// <summary>
    /// 会员编码和经纪公司编码对照表
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcPartBrokerField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        /// <summary>
        /// 是否活跃
        /// </summary>
        public int IsActive;
    }

    /// <summary>
    /// 管理用户
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcSuperUserField
    {
        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        /// 用户名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string UserName;
        /// <summary>
        /// 密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        /// <summary>
        /// 是否活跃
        /// </summary>
        public int IsActive;
    }

    /// <summary>
    /// 管理用户功能权限
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcSuperUserFunctionField
    {
        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        /// 功能代码
        /// </summary>
        public TThostFtdcFunctionCodeType FunctionCode;
    }

    /// <summary>
    /// 投资者组
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcInvestorGroupField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者分组代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorGroupID;
        /// <summary>
        /// 投资者分组名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string InvestorGroupName;
    }

    /// <summary>
    /// 资金账户
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcTradingAccountField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        /// <summary>
        /// 上次质押金额
        /// </summary>
        public double PreMortgage;
        /// <summary>
        /// 上次信用额度
        /// </summary>
        public double PreCredit;
        /// <summary>
        /// 上次存款额
        /// </summary>
        public double PreDeposit;
        /// <summary>
        /// 上次结算准备金
        /// </summary>
        public double PreBalance;
        /// <summary>
        /// 上次占用的保证金
        /// </summary>
        public double PreMargin;
        /// <summary>
        /// 利息基数
        /// </summary>
        public double InterestBase;
        /// <summary>
        /// 利息收入
        /// </summary>
        public double Interest;
        /// <summary>
        /// 入金金额
        /// </summary>
        public double Deposit;
        /// <summary>
        /// 出金金额
        /// </summary>
        public double Withdraw;
        /// <summary>
        /// 冻结的保证金
        /// </summary>
        public double FrozenMargin;
        /// <summary>
        /// 冻结的资金
        /// </summary>
        public double FrozenCash;
        /// <summary>
        /// 冻结的手续费
        /// </summary>
        public double FrozenCommission;
        /// <summary>
        /// 当前保证金总额
        /// </summary>
        public double CurrMargin;
        /// <summary>
        /// 资金差额
        /// </summary>
        public double CashIn;
        /// <summary>
        /// 手续费
        /// </summary>
        public double Commission;
        /// <summary>
        /// 平仓盈亏
        /// </summary>
        public double CloseProfit;
        /// <summary>
        /// 持仓盈亏
        /// </summary>
        public double PositionProfit;
        /// <summary>
        /// 期货结算准备金
        /// </summary>
        public double Balance;
        /// <summary>
        /// 可用资金
        /// </summary>
        public double Available;
        /// <summary>
        /// 可取资金
        /// </summary>
        public double WithdrawQuota;
        /// <summary>
        /// 基本准备金
        /// </summary>
        public double Reserve;
        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        /// 结算编号
        /// </summary>
        public int SettlementID;
        /// <summary>
        /// 信用额度
        /// </summary>
        public double Credit;
        /// <summary>
        /// 质押金额
        /// </summary>
        public double Mortgage;
        /// <summary>
        /// 交易所保证金
        /// </summary>
        public double ExchangeMargin;
        /// <summary>
        /// 投资者交割保证金
        /// </summary>
        public double DeliveryMargin;
        /// <summary>
        /// 交易所交割保证金
        /// </summary>
        public double ExchangeDeliveryMargin;
    }

    /// <summary>
    /// 投资者持仓
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcInvestorPositionField
    {
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        /// 持仓多空方向
        /// </summary>
        public TThostFtdcPosiDirectionType PosiDirection;
        /// <summary>
        /// 投机套保标志
        /// </summary>
        public TThostFtdcHedgeFlagType HedgeFlag;
        /// <summary>
        /// 持仓日期
        /// </summary>
        public TThostFtdcPositionDateType PositionDate;
        /// <summary>
        /// 上日持仓
        /// </summary>
        public int YdPosition;
        /// <summary>
        /// 今日持仓
        /// </summary>
        public int Position;
        /// <summary>
        /// 多头冻结
        /// </summary>
        public int LongFrozen;
        /// <summary>
        /// 空头冻结
        /// </summary>
        public int ShortFrozen;
        /// <summary>
        /// 开仓冻结金额
        /// </summary>
        public double LongFrozenAmount;
        /// <summary>
        /// 开仓冻结金额
        /// </summary>
        public double ShortFrozenAmount;
        /// <summary>
        /// 开仓量
        /// </summary>
        public int OpenVolume;
        /// <summary>
        /// 平仓量
        /// </summary>
        public int CloseVolume;
        /// <summary>
        /// 开仓金额
        /// </summary>
        public double OpenAmount;
        /// <summary>
        /// 平仓金额
        /// </summary>
        public double CloseAmount;
        /// <summary>
        /// 持仓成本
        /// </summary>
        public double PositionCost;
        /// <summary>
        /// 上次占用的保证金
        /// </summary>
        public double PreMargin;
        /// <summary>
        /// 占用的保证金
        /// </summary>
        public double UseMargin;
        /// <summary>
        /// 冻结的保证金
        /// </summary>
        public double FrozenMargin;
        /// <summary>
        /// 冻结的资金
        /// </summary>
        public double FrozenCash;
        /// <summary>
        /// 冻结的手续费
        /// </summary>
        public double FrozenCommission;
        /// <summary>
        /// 资金差额
        /// </summary>
        public double CashIn;
        /// <summary>
        /// 手续费
        /// </summary>
        public double Commission;
        /// <summary>
        /// 平仓盈亏
        /// </summary>
        public double CloseProfit;
        /// <summary>
        /// 持仓盈亏
        /// </summary>
        public double PositionProfit;
        /// <summary>
        /// 上次结算价
        /// </summary>
        public double PreSettlementPrice;
        /// <summary>
        /// 本次结算价
        /// </summary>
        public double SettlementPrice;
        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        /// 结算编号
        /// </summary>
        public int SettlementID;
        /// <summary>
        /// 开仓成本
        /// </summary>
        public double OpenCost;
        /// <summary>
        /// 交易所保证金
        /// </summary>
        public double ExchangeMargin;
        /// <summary>
        /// 组合成交形成的持仓
        /// </summary>
        public int CombPosition;
        /// <summary>
        /// 组合多头冻结
        /// </summary>
        public int CombLongFrozen;
        /// <summary>
        /// 组合空头冻结
        /// </summary>
        public int CombShortFrozen;
        /// <summary>
        /// 逐日盯市平仓盈亏
        /// </summary>
        public double CloseProfitByDate;
        /// <summary>
        /// 逐笔对冲平仓盈亏
        /// </summary>
        public double CloseProfitByTrade;
        /// <summary>
        /// 今日持仓
        /// </summary>
        public int TodayPosition;
        /// <summary>
        /// 保证金率
        /// </summary>
        public double MarginRateByMoney;
        /// <summary>
        /// 保证金率(按手数)
        /// </summary>
        public double MarginRateByVolume;
    }

    /// <summary>
    /// 合约保证金率
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcInstrumentMarginRateField
    {
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        /// 投资者范围
        /// </summary>
        public TThostFtdcInvestorRangeType InvestorRange;
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        /// 投机套保标志
        /// </summary>
        public TThostFtdcHedgeFlagType HedgeFlag;
        /// <summary>
        /// 多头保证金率
        /// </summary>
        public double LongMarginRatioByMoney;
        /// <summary>
        /// 多头保证金费
        /// </summary>
        public double LongMarginRatioByVolume;
        /// <summary>
        /// 空头保证金率
        /// </summary>
        public double ShortMarginRatioByMoney;
        /// <summary>
        /// 空头保证金费
        /// </summary>
        public double ShortMarginRatioByVolume;
        /// <summary>
        /// 是否相对交易所收取
        /// </summary>
        public int IsRelative;
    }

    /// <summary>
    /// 合约手续费率
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcInstrumentCommissionRateField
    {
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        /// 投资者范围
        /// </summary>
        public TThostFtdcInvestorRangeType InvestorRange;
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        /// 开仓手续费率
        /// </summary>
        public double OpenRatioByMoney;
        /// <summary>
        /// 开仓手续费
        /// </summary>
        public double OpenRatioByVolume;
        /// <summary>
        /// 平仓手续费率
        /// </summary>
        public double CloseRatioByMoney;
        /// <summary>
        /// 平仓手续费
        /// </summary>
        public double CloseRatioByVolume;
        /// <summary>
        /// 平今手续费率
        /// </summary>
        public double CloseTodayRatioByMoney;
        /// <summary>
        /// 平今手续费
        /// </summary>
        public double CloseTodayRatioByVolume;
    }

    /// <summary>
    /// 深度行情
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcDepthMarketDataField
    {
        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        /// 合约在交易所的代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;
        /// <summary>
        /// 最新价
        /// </summary>
        public double LastPrice;
        /// <summary>
        /// 上次结算价
        /// </summary>
        public double PreSettlementPrice;
        /// <summary>
        /// 昨收盘
        /// </summary>
        public double PreClosePrice;
        /// <summary>
        /// 昨持仓量
        /// </summary>
        public double PreOpenInterest;
        /// <summary>
        /// 今开盘
        /// </summary>
        public double OpenPrice;
        /// <summary>
        /// 最高价
        /// </summary>
        public double HighestPrice;
        /// <summary>
        /// 最低价
        /// </summary>
        public double LowestPrice;
        /// <summary>
        /// 数量
        /// </summary>
        public int Volume;
        /// <summary>
        /// 成交金额
        /// </summary>
        public double Turnover;
        /// <summary>
        /// 持仓量
        /// </summary>
        public double OpenInterest;
        /// <summary>
        /// 今收盘
        /// </summary>
        public double ClosePrice;
        /// <summary>
        /// 本次结算价
        /// </summary>
        public double SettlementPrice;
        /// <summary>
        /// 涨停板价
        /// </summary>
        public double UpperLimitPrice;
        /// <summary>
        /// 跌停板价
        /// </summary>
        public double LowerLimitPrice;
        /// <summary>
        /// 昨虚实度
        /// </summary>
        public double PreDelta;
        /// <summary>
        /// 今虚实度
        /// </summary>
        public double CurrDelta;
        /// <summary>
        /// 最后修改时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string UpdateTime;
        /// <summary>
        /// 最后修改毫秒
        /// </summary>
        public int UpdateMillisec;
        /// <summary>
        /// 申买价一
        /// </summary>
        public double BidPrice1;
        /// <summary>
        /// 申买量一
        /// </summary>
        public int BidVolume1;
        /// <summary>
        /// 申卖价一
        /// </summary>
        public double AskPrice1;
        /// <summary>
        /// 申卖量一
        /// </summary>
        public int AskVolume1;
        /// <summary>
        /// 申买价二
        /// </summary>
        public double BidPrice2;
        /// <summary>
        /// 申买量二
        /// </summary>
        public int BidVolume2;
        /// <summary>
        /// 申卖价二
        /// </summary>
        public double AskPrice2;
        /// <summary>
        /// 申卖量二
        /// </summary>
        public int AskVolume2;
        /// <summary>
        /// 申买价三
        /// </summary>
        public double BidPrice3;
        /// <summary>
        /// 申买量三
        /// </summary>
        public int BidVolume3;
        /// <summary>
        /// 申卖价三
        /// </summary>
        public double AskPrice3;
        /// <summary>
        /// 申卖量三
        /// </summary>
        public int AskVolume3;
        /// <summary>
        /// 申买价四
        /// </summary>
        public double BidPrice4;
        /// <summary>
        /// 申买量四
        /// </summary>
        public int BidVolume4;
        /// <summary>
        /// 申卖价四
        /// </summary>
        public double AskPrice4;
        /// <summary>
        /// 申卖量四
        /// </summary>
        public int AskVolume4;
        /// <summary>
        /// 申买价五
        /// </summary>
        public double BidPrice5;
        /// <summary>
        /// 申买量五
        /// </summary>
        public int BidVolume5;
        /// <summary>
        /// 申卖价五
        /// </summary>
        public double AskPrice5;
        /// <summary>
        /// 申卖量五
        /// </summary>
        public int AskVolume5;
        /// <summary>
        /// 当日均价
        /// </summary>
        public double AveragePrice;
    }

    /// <summary>
    /// 投资者合约交易权限
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcInstrumentTradingRightField
    {
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        /// 投资者范围
        /// </summary>
        public TThostFtdcInvestorRangeType InvestorRange;
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        /// 交易权限
        /// </summary>
        public TThostFtdcTradingRightType TradingRight;
    }

    /// <summary>
    /// 经纪公司用户
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcBrokerUserField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        /// 用户名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string UserName;
        /// <summary>
        /// 用户类型
        /// </summary>
        public TThostFtdcUserTypeType UserType;
        /// <summary>
        /// 是否活跃
        /// </summary>
        public int IsActive;
        /// <summary>
        /// 是否使用令牌
        /// </summary>
        public int IsUsingOTP;
    }

    /// <summary>
    /// 经纪公司用户口令
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcBrokerUserPasswordField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        /// 密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
    }

    /// <summary>
    /// 经纪公司用户功能权限
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcBrokerUserFunctionField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        /// 经纪公司功能代码
        /// </summary>
        public TThostFtdcBrokerFunctionCodeType BrokerFunctionCode;
    }

    /// <summary>
    /// 交易所交易员报盘机
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcTraderOfferField
    {
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        /// <summary>
        /// 密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;
        /// <summary>
        /// 本地报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderLocalID;
        /// <summary>
        /// 交易所交易员连接状态
        /// </summary>
        public TThostFtdcTraderConnectStatusType TraderConnectStatus;
        /// <summary>
        /// 发出连接请求的日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ConnectRequestDate;
        /// <summary>
        /// 发出连接请求的时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ConnectRequestTime;
        /// <summary>
        /// 上次报告日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string LastReportDate;
        /// <summary>
        /// 上次报告时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string LastReportTime;
        /// <summary>
        /// 完成连接日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ConnectDate;
        /// <summary>
        /// 完成连接时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ConnectTime;
        /// <summary>
        /// 启动日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string StartDate;
        /// <summary>
        /// 启动时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string StartTime;
        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 本席位最大成交编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MaxTradeID;
        /// <summary>
        /// 本席位最大报单备拷
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string MaxOrderMessageReference;
    }

    /// <summary>
    /// 投资者结算结果
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcSettlementInfoField
    {
        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        /// 结算编号
        /// </summary>
        public int SettlementID;
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        /// 序号
        /// </summary>
        public int SequenceNo;
        /// <summary>
        /// 消息正文
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 501)]
        public string Content;
    }

    /// <summary>
    /// 合约保证金率调整
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcInstrumentMarginRateAdjustField
    {
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        /// 投资者范围
        /// </summary>
        public TThostFtdcInvestorRangeType InvestorRange;
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        /// 投机套保标志
        /// </summary>
        public TThostFtdcHedgeFlagType HedgeFlag;
        /// <summary>
        /// 多头保证金率
        /// </summary>
        public double LongMarginRatioByMoney;
        /// <summary>
        /// 多头保证金费
        /// </summary>
        public double LongMarginRatioByVolume;
        /// <summary>
        /// 空头保证金率
        /// </summary>
        public double ShortMarginRatioByMoney;
        /// <summary>
        /// 空头保证金费
        /// </summary>
        public double ShortMarginRatioByVolume;
        /// <summary>
        /// 是否相对交易所收取
        /// </summary>
        public int IsRelative;
    }

    /// <summary>
    /// 交易所保证金率
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcExchangeMarginRateField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        /// 投机套保标志
        /// </summary>
        public TThostFtdcHedgeFlagType HedgeFlag;
        /// <summary>
        /// 多头保证金率
        /// </summary>
        public double LongMarginRatioByMoney;
        /// <summary>
        /// 多头保证金费
        /// </summary>
        public double LongMarginRatioByVolume;
        /// <summary>
        /// 空头保证金率
        /// </summary>
        public double ShortMarginRatioByMoney;
        /// <summary>
        /// 空头保证金费
        /// </summary>
        public double ShortMarginRatioByVolume;
    }

    /// <summary>
    /// 交易所保证金率调整
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcExchangeMarginRateAdjustField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        /// 投机套保标志
        /// </summary>
        public TThostFtdcHedgeFlagType HedgeFlag;
        /// <summary>
        /// 跟随交易所投资者多头保证金率
        /// </summary>
        public double LongMarginRatioByMoney;
        /// <summary>
        /// 跟随交易所投资者多头保证金费
        /// </summary>
        public double LongMarginRatioByVolume;
        /// <summary>
        /// 跟随交易所投资者空头保证金率
        /// </summary>
        public double ShortMarginRatioByMoney;
        /// <summary>
        /// 跟随交易所投资者空头保证金费
        /// </summary>
        public double ShortMarginRatioByVolume;
        /// <summary>
        /// 交易所多头保证金率
        /// </summary>
        public double ExchLongMarginRatioByMoney;
        /// <summary>
        /// 交易所多头保证金费
        /// </summary>
        public double ExchLongMarginRatioByVolume;
        /// <summary>
        /// 交易所空头保证金率
        /// </summary>
        public double ExchShortMarginRatioByMoney;
        /// <summary>
        /// 交易所空头保证金费
        /// </summary>
        public double ExchShortMarginRatioByVolume;
        /// <summary>
        /// 不跟随交易所投资者多头保证金率
        /// </summary>
        public double NoLongMarginRatioByMoney;
        /// <summary>
        /// 不跟随交易所投资者多头保证金费
        /// </summary>
        public double NoLongMarginRatioByVolume;
        /// <summary>
        /// 不跟随交易所投资者空头保证金率
        /// </summary>
        public double NoShortMarginRatioByMoney;
        /// <summary>
        /// 不跟随交易所投资者空头保证金费
        /// </summary>
        public double NoShortMarginRatioByVolume;
    }

    /// <summary>
    /// 结算引用
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcSettlementRefField
    {
        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        /// 结算编号
        /// </summary>
        public int SettlementID;
    }

    /// <summary>
    /// 当前时间
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcCurrentTimeField
    {
        /// <summary>
        /// 当前日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string CurrDate;
        /// <summary>
        /// 当前时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string CurrTime;
        /// <summary>
        /// 当前时间（毫秒）
        /// </summary>
        public int CurrMillisec;
    }

    /// <summary>
    /// 通讯阶段
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcCommPhaseField
    {
        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        /// 通讯时段编号
        /// </summary>
        public short CommPhaseNo;
    }

    /// <summary>
    /// 登录信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcLoginInfoField
    {
        /// <summary>
        /// 前置编号
        /// </summary>
        public int FrontID;
        /// <summary>
        /// 会话编号
        /// </summary>
        public int SessionID;
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        /// 登录日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string LoginDate;
        /// <summary>
        /// 登录时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string LoginTime;
        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;
        /// <summary>
        /// 用户端产品信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string UserProductInfo;
        /// <summary>
        /// 接口端产品信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string InterfaceProductInfo;
        /// <summary>
        /// 协议信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ProtocolInfo;
        /// <summary>
        /// 系统名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string SystemName;
        /// <summary>
        /// 密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        /// <summary>
        /// 最大报单引用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string MaxOrderRef;
        /// <summary>
        /// 上期所时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string SHFETime;
        /// <summary>
        /// 大商所时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string DCETime;
        /// <summary>
        /// 郑商所时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string CZCETime;
        /// <summary>
        /// 中金所时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string FFEXTime;
        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;
        /// <summary>
        /// 动态密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string OneTimePassword;
    }

    /// <summary>
    /// 登录信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcLogoutAllField
    {
        /// <summary>
        /// 前置编号
        /// </summary>
        public int FrontID;
        /// <summary>
        /// 会话编号
        /// </summary>
        public int SessionID;
        /// <summary>
        /// 系统名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string SystemName;
    }

    /// <summary>
    /// 前置状态
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcFrontStatusField
    {
        /// <summary>
        /// 前置编号
        /// </summary>
        public int FrontID;
        /// <summary>
        /// 上次报告日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string LastReportDate;
        /// <summary>
        /// 上次报告时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string LastReportTime;
        /// <summary>
        /// 是否活跃
        /// </summary>
        public int IsActive;
    }

    /// <summary>
    /// 用户口令变更
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcUserPasswordUpdateField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        /// 原来的口令
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string OldPassword;
        /// <summary>
        /// 新的口令
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string NewPassword;
    }

    /// <summary>
    /// 输入报单
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcInputOrderField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        /// 报单引用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderRef;
        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        /// 报单价格条件
        /// </summary>
        public TThostFtdcOrderPriceTypeType OrderPriceType;
        /// <summary>
        /// 买卖方向
        /// </summary>
        public TThostFtdcDirectionType Direction;
        /// <summary>
        /// 组合开平标志
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string CombOffsetFlag;
        /// <summary>
        /// 组合投机套保标志
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string CombHedgeFlag;
        /// <summary>
        /// 价格
        /// </summary>
        public double LimitPrice;
        /// <summary>
        /// 数量
        /// </summary>
        public int VolumeTotalOriginal;
        /// <summary>
        /// 有效期类型
        /// </summary>
        public TThostFtdcTimeConditionType TimeCondition;
        /// <summary>
        /// GTD日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string GTDDate;
        /// <summary>
        /// 成交量类型
        /// </summary>
        public TThostFtdcVolumeConditionType VolumeCondition;
        /// <summary>
        /// 最小成交量
        /// </summary>
        public int MinVolume;
        /// <summary>
        /// 触发条件
        /// </summary>
        public TThostFtdcContingentConditionType ContingentCondition;
        /// <summary>
        /// 止损价
        /// </summary>
        public double StopPrice;
        /// <summary>
        /// 强平原因
        /// </summary>
        public TThostFtdcForceCloseReasonType ForceCloseReason;
        /// <summary>
        /// 自动挂起标志
        /// </summary>
        public int IsAutoSuspend;
        /// <summary>
        /// 业务单元
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;
        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;
        /// <summary>
        /// 用户强评标志
        /// </summary>
        public int UserForceClose;
    }

    /// <summary>
    /// 报单
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcOrderField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        /// 报单引用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderRef;
        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        /// 报单价格条件
        /// </summary>
        public TThostFtdcOrderPriceTypeType OrderPriceType;
        /// <summary>
        /// 买卖方向
        /// </summary>
        public TThostFtdcDirectionType Direction;
        /// <summary>
        /// 组合开平标志
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string CombOffsetFlag;
        /// <summary>
        /// 组合投机套保标志
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string CombHedgeFlag;
        /// <summary>
        /// 价格
        /// </summary>
        public double LimitPrice;
        /// <summary>
        /// 数量
        /// </summary>
        public int VolumeTotalOriginal;
        /// <summary>
        /// 有效期类型
        /// </summary>
        public TThostFtdcTimeConditionType TimeCondition;
        /// <summary>
        /// GTD日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string GTDDate;
        /// <summary>
        /// 成交量类型
        /// </summary>
        public TThostFtdcVolumeConditionType VolumeCondition;
        /// <summary>
        /// 最小成交量
        /// </summary>
        public int MinVolume;
        /// <summary>
        /// 触发条件
        /// </summary>
        public TThostFtdcContingentConditionType ContingentCondition;
        /// <summary>
        /// 止损价
        /// </summary>
        public double StopPrice;
        /// <summary>
        /// 强平原因
        /// </summary>
        public TThostFtdcForceCloseReasonType ForceCloseReason;
        /// <summary>
        /// 自动挂起标志
        /// </summary>
        public int IsAutoSuspend;
        /// <summary>
        /// 业务单元
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;
        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;
        /// <summary>
        /// 本地报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderLocalID;
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;
        /// <summary>
        /// 合约在交易所的代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;
        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;
        /// <summary>
        /// 报单提交状态
        /// </summary>
        public TThostFtdcOrderSubmitStatusType OrderSubmitStatus;
        /// <summary>
        /// 报单提示序号
        /// </summary>
        public int NotifySequence;
        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        /// 结算编号
        /// </summary>
        public int SettlementID;
        /// <summary>
        /// 报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OrderSysID;
        /// <summary>
        /// 报单来源
        /// </summary>
        public TThostFtdcOrderSourceType OrderSource;
        /// <summary>
        /// 报单状态
        /// </summary>
        public TThostFtdcOrderStatusType OrderStatus;
        /// <summary>
        /// 报单类型
        /// </summary>
        public TThostFtdcOrderTypeType OrderType;
        /// <summary>
        /// 今成交数量
        /// </summary>
        public int VolumeTraded;
        /// <summary>
        /// 剩余数量
        /// </summary>
        public int VolumeTotal;
        /// <summary>
        /// 报单日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertDate;
        /// <summary>
        /// 委托时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTime;
        /// <summary>
        /// 激活时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActiveTime;
        /// <summary>
        /// 挂起时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string SuspendTime;
        /// <summary>
        /// 最后修改时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string UpdateTime;
        /// <summary>
        /// 撤销时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string CancelTime;
        /// <summary>
        /// 最后修改交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string ActiveTraderID;
        /// <summary>
        /// 结算会员编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClearingPartID;
        /// <summary>
        /// 序号
        /// </summary>
        public int SequenceNo;
        /// <summary>
        /// 前置编号
        /// </summary>
        public int FrontID;
        /// <summary>
        /// 会话编号
        /// </summary>
        public int SessionID;
        /// <summary>
        /// 用户端产品信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string UserProductInfo;
        /// <summary>
        /// 状态信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string StatusMsg;
        /// <summary>
        /// 用户强评标志
        /// </summary>
        public int UserForceClose;
        /// <summary>
        /// 操作用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string ActiveUserID;
        /// <summary>
        /// 经纪公司报单编号
        /// </summary>
        public int BrokerOrderSeq;
        /// <summary>
        /// 相关报单
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string RelativeOrderSysID;
    }

    /// <summary>
    /// 交易所报单
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcExchangeOrderField
    {
        /// <summary>
        /// 报单价格条件
        /// </summary>
        public TThostFtdcOrderPriceTypeType OrderPriceType;
        /// <summary>
        /// 买卖方向
        /// </summary>
        public TThostFtdcDirectionType Direction;
        /// <summary>
        /// 组合开平标志
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string CombOffsetFlag;
        /// <summary>
        /// 组合投机套保标志
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string CombHedgeFlag;
        /// <summary>
        /// 价格
        /// </summary>
        public double LimitPrice;
        /// <summary>
        /// 数量
        /// </summary>
        public int VolumeTotalOriginal;
        /// <summary>
        /// 有效期类型
        /// </summary>
        public TThostFtdcTimeConditionType TimeCondition;
        /// <summary>
        /// GTD日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string GTDDate;
        /// <summary>
        /// 成交量类型
        /// </summary>
        public TThostFtdcVolumeConditionType VolumeCondition;
        /// <summary>
        /// 最小成交量
        /// </summary>
        public int MinVolume;
        /// <summary>
        /// 触发条件
        /// </summary>
        public TThostFtdcContingentConditionType ContingentCondition;
        /// <summary>
        /// 止损价
        /// </summary>
        public double StopPrice;
        /// <summary>
        /// 强平原因
        /// </summary>
        public TThostFtdcForceCloseReasonType ForceCloseReason;
        /// <summary>
        /// 自动挂起标志
        /// </summary>
        public int IsAutoSuspend;
        /// <summary>
        /// 业务单元
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;
        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;
        /// <summary>
        /// 本地报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderLocalID;
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;
        /// <summary>
        /// 合约在交易所的代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;
        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;
        /// <summary>
        /// 报单提交状态
        /// </summary>
        public TThostFtdcOrderSubmitStatusType OrderSubmitStatus;
        /// <summary>
        /// 报单提示序号
        /// </summary>
        public int NotifySequence;
        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        /// 结算编号
        /// </summary>
        public int SettlementID;
        /// <summary>
        /// 报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OrderSysID;
        /// <summary>
        /// 报单来源
        /// </summary>
        public TThostFtdcOrderSourceType OrderSource;
        /// <summary>
        /// 报单状态
        /// </summary>
        public TThostFtdcOrderStatusType OrderStatus;
        /// <summary>
        /// 报单类型
        /// </summary>
        public TThostFtdcOrderTypeType OrderType;
        /// <summary>
        /// 今成交数量
        /// </summary>
        public int VolumeTraded;
        /// <summary>
        /// 剩余数量
        /// </summary>
        public int VolumeTotal;
        /// <summary>
        /// 报单日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertDate;
        /// <summary>
        /// 委托时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTime;
        /// <summary>
        /// 激活时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActiveTime;
        /// <summary>
        /// 挂起时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string SuspendTime;
        /// <summary>
        /// 最后修改时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string UpdateTime;
        /// <summary>
        /// 撤销时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string CancelTime;
        /// <summary>
        /// 最后修改交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string ActiveTraderID;
        /// <summary>
        /// 结算会员编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClearingPartID;
        /// <summary>
        /// 序号
        /// </summary>
        public int SequenceNo;
    }

    /// <summary>
    /// 交易所报单插入失败
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcExchangeOrderInsertErrorField
    {
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;
        /// <summary>
        /// 本地报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderLocalID;
        /// <summary>
        /// 错误代码
        /// </summary>
        public int ErrorID;
        /// <summary>
        /// 错误信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;
    }

    /// <summary>
    /// 输入报单操作
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcInputOrderActionField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        /// 报单操作引用
        /// </summary>
        public int OrderActionRef;
        /// <summary>
        /// 报单引用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderRef;
        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;
        /// <summary>
        /// 前置编号
        /// </summary>
        public int FrontID;
        /// <summary>
        /// 会话编号
        /// </summary>
        public int SessionID;
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        /// 报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OrderSysID;
        /// <summary>
        /// 操作标志
        /// </summary>
        public TThostFtdcActionFlagType ActionFlag;
        /// <summary>
        /// 价格
        /// </summary>
        public double LimitPrice;
        /// <summary>
        /// 数量变化
        /// </summary>
        public int VolumeChange;
        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
    }

    /// <summary>
    /// 报单操作
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcOrderActionField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        /// 报单操作引用
        /// </summary>
        public int OrderActionRef;
        /// <summary>
        /// 报单引用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderRef;
        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;
        /// <summary>
        /// 前置编号
        /// </summary>
        public int FrontID;
        /// <summary>
        /// 会话编号
        /// </summary>
        public int SessionID;
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        /// 报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OrderSysID;
        /// <summary>
        /// 操作标志
        /// </summary>
        public TThostFtdcActionFlagType ActionFlag;
        /// <summary>
        /// 价格
        /// </summary>
        public double LimitPrice;
        /// <summary>
        /// 数量变化
        /// </summary>
        public int VolumeChange;
        /// <summary>
        /// 操作日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionDate;
        /// <summary>
        /// 操作时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionTime;
        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;
        /// <summary>
        /// 本地报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderLocalID;
        /// <summary>
        /// 操作本地编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ActionLocalID;
        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;
        /// <summary>
        /// 业务单元
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;
        /// <summary>
        /// 报单操作状态
        /// </summary>
        public TThostFtdcOrderActionStatusType OrderActionStatus;
        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        /// 状态信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string StatusMsg;
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
    }

    /// <summary>
    /// 交易所报单操作
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcExchangeOrderActionField
    {
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        /// 报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OrderSysID;
        /// <summary>
        /// 操作标志
        /// </summary>
        public TThostFtdcActionFlagType ActionFlag;
        /// <summary>
        /// 价格
        /// </summary>
        public double LimitPrice;
        /// <summary>
        /// 数量变化
        /// </summary>
        public int VolumeChange;
        /// <summary>
        /// 操作日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionDate;
        /// <summary>
        /// 操作时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionTime;
        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;
        /// <summary>
        /// 本地报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderLocalID;
        /// <summary>
        /// 操作本地编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ActionLocalID;
        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;
        /// <summary>
        /// 业务单元
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;
        /// <summary>
        /// 报单操作状态
        /// </summary>
        public TThostFtdcOrderActionStatusType OrderActionStatus;
        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
    }

    /// <summary>
    /// 交易所报单操作失败
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcExchangeOrderActionErrorField
    {
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        /// 报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OrderSysID;
        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;
        /// <summary>
        /// 本地报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderLocalID;
        /// <summary>
        /// 操作本地编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ActionLocalID;
        /// <summary>
        /// 错误代码
        /// </summary>
        public int ErrorID;
        /// <summary>
        /// 错误信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;
    }

    /// <summary>
    /// 交易所成交
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcExchangeTradeField
    {
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        /// 成交编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TradeID;
        /// <summary>
        /// 买卖方向
        /// </summary>
        public TThostFtdcDirectionType Direction;
        /// <summary>
        /// 报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OrderSysID;
        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;
        /// <summary>
        /// 交易角色
        /// </summary>
        public TThostFtdcTradingRoleType TradingRole;
        /// <summary>
        /// 合约在交易所的代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;
        /// <summary>
        /// 开平标志
        /// </summary>
        public TThostFtdcOffsetFlagType OffsetFlag;
        /// <summary>
        /// 投机套保标志
        /// </summary>
        public TThostFtdcHedgeFlagType HedgeFlag;
        /// <summary>
        /// 价格
        /// </summary>
        public double Price;
        /// <summary>
        /// 数量
        /// </summary>
        public int Volume;
        /// <summary>
        /// 成交时期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        /// <summary>
        /// 成交时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        /// <summary>
        /// 成交类型
        /// </summary>
        public TThostFtdcTradeTypeType TradeType;
        /// <summary>
        /// 成交价来源
        /// </summary>
        public TThostFtdcPriceSourceType PriceSource;
        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
        /// <summary>
        /// 本地报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderLocalID;
        /// <summary>
        /// 结算会员编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClearingPartID;
        /// <summary>
        /// 业务单元
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;
        /// <summary>
        /// 序号
        /// </summary>
        public int SequenceNo;
        /// <summary>
        /// 成交来源
        /// </summary>
        public TThostFtdcTradeSourceType TradeSource;
    }

    /// <summary>
    /// 成交
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcTradeField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        /// 报单引用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderRef;
        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        /// 成交编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TradeID;
        /// <summary>
        /// 买卖方向
        /// </summary>
        public TThostFtdcDirectionType Direction;
        /// <summary>
        /// 报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OrderSysID;
        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;
        /// <summary>
        /// 交易角色
        /// </summary>
        public TThostFtdcTradingRoleType TradingRole;
        /// <summary>
        /// 合约在交易所的代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;
        /// <summary>
        /// 开平标志
        /// </summary>
        public TThostFtdcOffsetFlagType OffsetFlag;
        /// <summary>
        /// 投机套保标志
        /// </summary>
        public TThostFtdcHedgeFlagType HedgeFlag;
        /// <summary>
        /// 价格
        /// </summary>
        public double Price;
        /// <summary>
        /// 数量
        /// </summary>
        public int Volume;
        /// <summary>
        /// 成交时期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        /// <summary>
        /// 成交时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        /// <summary>
        /// 成交类型
        /// </summary>
        public TThostFtdcTradeTypeType TradeType;
        /// <summary>
        /// 成交价来源
        /// </summary>
        public TThostFtdcPriceSourceType PriceSource;
        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
        /// <summary>
        /// 本地报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderLocalID;
        /// <summary>
        /// 结算会员编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClearingPartID;
        /// <summary>
        /// 业务单元
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;
        /// <summary>
        /// 序号
        /// </summary>
        public int SequenceNo;
        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        /// 结算编号
        /// </summary>
        public int SettlementID;
        /// <summary>
        /// 经纪公司报单编号
        /// </summary>
        public int BrokerOrderSeq;
        /// <summary>
        /// 成交来源
        /// </summary>
        public TThostFtdcTradeSourceType TradeSource;
    }

    /// <summary>
    /// 用户会话
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcUserSessionField
    {
        /// <summary>
        /// 前置编号
        /// </summary>
        public int FrontID;
        /// <summary>
        /// 会话编号
        /// </summary>
        public int SessionID;
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        /// 登录日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string LoginDate;
        /// <summary>
        /// 登录时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string LoginTime;
        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;
        /// <summary>
        /// 用户端产品信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string UserProductInfo;
        /// <summary>
        /// 接口端产品信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string InterfaceProductInfo;
        /// <summary>
        /// 协议信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ProtocolInfo;
        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;
    }

    /// <summary>
    /// 查询最大报单数量
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQueryMaxOrderVolumeField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        /// 买卖方向
        /// </summary>
        public TThostFtdcDirectionType Direction;
        /// <summary>
        /// 开平标志
        /// </summary>
        public TThostFtdcOffsetFlagType OffsetFlag;
        /// <summary>
        /// 投机套保标志
        /// </summary>
        public TThostFtdcHedgeFlagType HedgeFlag;
        /// <summary>
        /// 最大允许报单数量
        /// </summary>
        public int MaxVolume;
    }

    /// <summary>
    /// 投资者结算结果确认信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcSettlementInfoConfirmField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        /// 确认日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ConfirmDate;
        /// <summary>
        /// 确认时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ConfirmTime;
    }

    /// <summary>
    /// 出入金同步
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcSyncDepositField
    {
        /// <summary>
        /// 出入金流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
        public string DepositSeqNo;
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        /// 入金金额
        /// </summary>
        public double Deposit;
        /// <summary>
        /// 是否强制进行
        /// </summary>
        public int IsForce;
    }

    /// <summary>
    /// 经纪公司同步
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcBrokerSyncField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
    }

    /// <summary>
    /// 正在同步中的投资者
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcSyncingInvestorField
    {
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者分组代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorGroupID;
        /// <summary>
        /// 投资者名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string InvestorName;
        /// <summary>
        /// 证件类型
        /// </summary>
        public TThostFtdcIdCardTypeType IdentifiedCardType;
        /// <summary>
        /// 证件号码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;
        /// <summary>
        /// 是否活跃
        /// </summary>
        public int IsActive;
        /// <summary>
        /// 联系电话
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Telephone;
        /// <summary>
        /// 通讯地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
        public string Address;
        /// <summary>
        /// 开户日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string OpenDate;
        /// <summary>
        /// 手机
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Mobile;
        /// <summary>
        /// 手续费率模板代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string CommModelID;
    }

    /// <summary>
    /// 正在同步中的交易代码
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcSyncingTradingCodeField
    {
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;
        /// <summary>
        /// 是否活跃
        /// </summary>
        public int IsActive;
        /// <summary>
        /// 交易编码类型
        /// </summary>
        public TThostFtdcClientIDTypeType ClientIDType;
    }

    /// <summary>
    /// 正在同步中的投资者分组
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcSyncingInvestorGroupField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者分组代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorGroupID;
        /// <summary>
        /// 投资者分组名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string InvestorGroupName;
    }

    /// <summary>
    /// 正在同步中的交易账号
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcSyncingTradingAccountField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        /// <summary>
        /// 上次质押金额
        /// </summary>
        public double PreMortgage;
        /// <summary>
        /// 上次信用额度
        /// </summary>
        public double PreCredit;
        /// <summary>
        /// 上次存款额
        /// </summary>
        public double PreDeposit;
        /// <summary>
        /// 上次结算准备金
        /// </summary>
        public double PreBalance;
        /// <summary>
        /// 上次占用的保证金
        /// </summary>
        public double PreMargin;
        /// <summary>
        /// 利息基数
        /// </summary>
        public double InterestBase;
        /// <summary>
        /// 利息收入
        /// </summary>
        public double Interest;
        /// <summary>
        /// 入金金额
        /// </summary>
        public double Deposit;
        /// <summary>
        /// 出金金额
        /// </summary>
        public double Withdraw;
        /// <summary>
        /// 冻结的保证金
        /// </summary>
        public double FrozenMargin;
        /// <summary>
        /// 冻结的资金
        /// </summary>
        public double FrozenCash;
        /// <summary>
        /// 冻结的手续费
        /// </summary>
        public double FrozenCommission;
        /// <summary>
        /// 当前保证金总额
        /// </summary>
        public double CurrMargin;
        /// <summary>
        /// 资金差额
        /// </summary>
        public double CashIn;
        /// <summary>
        /// 手续费
        /// </summary>
        public double Commission;
        /// <summary>
        /// 平仓盈亏
        /// </summary>
        public double CloseProfit;
        /// <summary>
        /// 持仓盈亏
        /// </summary>
        public double PositionProfit;
        /// <summary>
        /// 期货结算准备金
        /// </summary>
        public double Balance;
        /// <summary>
        /// 可用资金
        /// </summary>
        public double Available;
        /// <summary>
        /// 可取资金
        /// </summary>
        public double WithdrawQuota;
        /// <summary>
        /// 基本准备金
        /// </summary>
        public double Reserve;
        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        /// 结算编号
        /// </summary>
        public int SettlementID;
        /// <summary>
        /// 信用额度
        /// </summary>
        public double Credit;
        /// <summary>
        /// 质押金额
        /// </summary>
        public double Mortgage;
        /// <summary>
        /// 交易所保证金
        /// </summary>
        public double ExchangeMargin;
        /// <summary>
        /// 投资者交割保证金
        /// </summary>
        public double DeliveryMargin;
        /// <summary>
        /// 交易所交割保证金
        /// </summary>
        public double ExchangeDeliveryMargin;
    }

    /// <summary>
    /// 正在同步中的投资者持仓
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcSyncingInvestorPositionField
    {
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        /// 持仓多空方向
        /// </summary>
        public TThostFtdcPosiDirectionType PosiDirection;
        /// <summary>
        /// 投机套保标志
        /// </summary>
        public TThostFtdcHedgeFlagType HedgeFlag;
        /// <summary>
        /// 持仓日期
        /// </summary>
        public TThostFtdcPositionDateType PositionDate;
        /// <summary>
        /// 上日持仓
        /// </summary>
        public int YdPosition;
        /// <summary>
        /// 今日持仓
        /// </summary>
        public int Position;
        /// <summary>
        /// 多头冻结
        /// </summary>
        public int LongFrozen;
        /// <summary>
        /// 空头冻结
        /// </summary>
        public int ShortFrozen;
        /// <summary>
        /// 开仓冻结金额
        /// </summary>
        public double LongFrozenAmount;
        /// <summary>
        /// 开仓冻结金额
        /// </summary>
        public double ShortFrozenAmount;
        /// <summary>
        /// 开仓量
        /// </summary>
        public int OpenVolume;
        /// <summary>
        /// 平仓量
        /// </summary>
        public int CloseVolume;
        /// <summary>
        /// 开仓金额
        /// </summary>
        public double OpenAmount;
        /// <summary>
        /// 平仓金额
        /// </summary>
        public double CloseAmount;
        /// <summary>
        /// 持仓成本
        /// </summary>
        public double PositionCost;
        /// <summary>
        /// 上次占用的保证金
        /// </summary>
        public double PreMargin;
        /// <summary>
        /// 占用的保证金
        /// </summary>
        public double UseMargin;
        /// <summary>
        /// 冻结的保证金
        /// </summary>
        public double FrozenMargin;
        /// <summary>
        /// 冻结的资金
        /// </summary>
        public double FrozenCash;
        /// <summary>
        /// 冻结的手续费
        /// </summary>
        public double FrozenCommission;
        /// <summary>
        /// 资金差额
        /// </summary>
        public double CashIn;
        /// <summary>
        /// 手续费
        /// </summary>
        public double Commission;
        /// <summary>
        /// 平仓盈亏
        /// </summary>
        public double CloseProfit;
        /// <summary>
        /// 持仓盈亏
        /// </summary>
        public double PositionProfit;
        /// <summary>
        /// 上次结算价
        /// </summary>
        public double PreSettlementPrice;
        /// <summary>
        /// 本次结算价
        /// </summary>
        public double SettlementPrice;
        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        /// 结算编号
        /// </summary>
        public int SettlementID;
        /// <summary>
        /// 开仓成本
        /// </summary>
        public double OpenCost;
        /// <summary>
        /// 交易所保证金
        /// </summary>
        public double ExchangeMargin;
        /// <summary>
        /// 组合成交形成的持仓
        /// </summary>
        public int CombPosition;
        /// <summary>
        /// 组合多头冻结
        /// </summary>
        public int CombLongFrozen;
        /// <summary>
        /// 组合空头冻结
        /// </summary>
        public int CombShortFrozen;
        /// <summary>
        /// 逐日盯市平仓盈亏
        /// </summary>
        public double CloseProfitByDate;
        /// <summary>
        /// 逐笔对冲平仓盈亏
        /// </summary>
        public double CloseProfitByTrade;
        /// <summary>
        /// 今日持仓
        /// </summary>
        public int TodayPosition;
        /// <summary>
        /// 保证金率
        /// </summary>
        public double MarginRateByMoney;
        /// <summary>
        /// 保证金率(按手数)
        /// </summary>
        public double MarginRateByVolume;
    }

    /// <summary>
    /// 正在同步中的合约保证金率
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcSyncingInstrumentMarginRateField
    {
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        /// 投资者范围
        /// </summary>
        public TThostFtdcInvestorRangeType InvestorRange;
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        /// 投机套保标志
        /// </summary>
        public TThostFtdcHedgeFlagType HedgeFlag;
        /// <summary>
        /// 多头保证金率
        /// </summary>
        public double LongMarginRatioByMoney;
        /// <summary>
        /// 多头保证金费
        /// </summary>
        public double LongMarginRatioByVolume;
        /// <summary>
        /// 空头保证金率
        /// </summary>
        public double ShortMarginRatioByMoney;
        /// <summary>
        /// 空头保证金费
        /// </summary>
        public double ShortMarginRatioByVolume;
        /// <summary>
        /// 是否相对交易所收取
        /// </summary>
        public int IsRelative;
    }

    /// <summary>
    /// 正在同步中的合约手续费率
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcSyncingInstrumentCommissionRateField
    {
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        /// 投资者范围
        /// </summary>
        public TThostFtdcInvestorRangeType InvestorRange;
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        /// 开仓手续费率
        /// </summary>
        public double OpenRatioByMoney;
        /// <summary>
        /// 开仓手续费
        /// </summary>
        public double OpenRatioByVolume;
        /// <summary>
        /// 平仓手续费率
        /// </summary>
        public double CloseRatioByMoney;
        /// <summary>
        /// 平仓手续费
        /// </summary>
        public double CloseRatioByVolume;
        /// <summary>
        /// 平今手续费率
        /// </summary>
        public double CloseTodayRatioByMoney;
        /// <summary>
        /// 平今手续费
        /// </summary>
        public double CloseTodayRatioByVolume;
    }

    /// <summary>
    /// 正在同步中的合约交易权限
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcSyncingInstrumentTradingRightField
    {
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        /// 投资者范围
        /// </summary>
        public TThostFtdcInvestorRangeType InvestorRange;
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        /// 交易权限
        /// </summary>
        public TThostFtdcTradingRightType TradingRight;
    }

    /// <summary>
    /// 查询报单
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryOrderField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        /// 报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OrderSysID;
        /// <summary>
        /// 开始时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTimeStart;
        /// <summary>
        /// 结束时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTimeEnd;
    }

    /// <summary>
    /// 查询成交
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryTradeField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        /// 成交编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TradeID;
        /// <summary>
        /// 开始时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTimeStart;
        /// <summary>
        /// 结束时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTimeEnd;
    }

    /// <summary>
    /// 查询投资者持仓
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryInvestorPositionField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
    }

    /// <summary>
    /// 查询资金账户
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryTradingAccountField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
    }

    /// <summary>
    /// 查询投资者
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryInvestorField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
    }

    /// <summary>
    /// 查询交易编码
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryTradingCodeField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;
        /// <summary>
        /// 交易编码类型
        /// </summary>
        public TThostFtdcClientIDTypeType ClientIDType;
    }

    /// <summary>
    /// 查询交易编码
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryInvestorGroupField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
    }

    /// <summary>
    /// 查询交易编码
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryInstrumentMarginRateField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        /// 投机套保标志
        /// </summary>
        public TThostFtdcHedgeFlagType HedgeFlag;
    }

    /// <summary>
    /// 查询交易编码
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryInstrumentCommissionRateField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
    }

    /// <summary>
    /// 查询交易编码
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryInstrumentTradingRightField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
    }

    /// <summary>
    /// 查询经纪公司
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryBrokerField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
    }

    /// <summary>
    /// 查询交易员
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryTraderField
    {
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
    }

    /// <summary>
    /// 查询经纪公司会员代码
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryPartBrokerField
    {
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
    }

    /// <summary>
    /// 查询管理用户功能权限
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQrySuperUserFunctionField
    {
        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
    }

    /// <summary>
    /// 查询用户会话
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryUserSessionField
    {
        /// <summary>
        /// 前置编号
        /// </summary>
        public int FrontID;
        /// <summary>
        /// 会话编号
        /// </summary>
        public int SessionID;
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
    }

    /// <summary>
    /// 查询前置状态
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryFrontStatusField
    {
        /// <summary>
        /// 前置编号
        /// </summary>
        public int FrontID;
    }

    /// <summary>
    /// 查询交易所报单
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryExchangeOrderField
    {
        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;
        /// <summary>
        /// 合约在交易所的代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
    }

    /// <summary>
    /// 查询报单操作
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryOrderActionField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
    }

    /// <summary>
    /// 查询交易所报单操作
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryExchangeOrderActionField
    {
        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
    }

    /// <summary>
    /// 查询管理用户
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQrySuperUserField
    {
        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
    }

    /// <summary>
    /// 查询交易所
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryExchangeField
    {
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
    }

    /// <summary>
    /// 查询产品
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryProductField
    {
        /// <summary>
        /// 产品代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ProductID;
    }

    /// <summary>
    /// 查询合约
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryInstrumentField
    {
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        /// 合约在交易所的代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;
        /// <summary>
        /// 产品代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ProductID;
    }

    /// <summary>
    /// 查询行情
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryDepthMarketDataField
    {
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
    }

    /// <summary>
    /// 查询经纪公司用户
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryBrokerUserField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
    }

    /// <summary>
    /// 查询经纪公司用户权限
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryBrokerUserFunctionField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
    }

    /// <summary>
    /// 查询交易员报盘机
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryTraderOfferField
    {
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
    }

    /// <summary>
    /// 查询出入金流水
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQrySyncDepositField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 出入金流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
        public string DepositSeqNo;
    }

    /// <summary>
    /// 查询投资者结算结果
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQrySettlementInfoField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
    }

    /// <summary>
    /// 查询报单
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryHisOrderField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        /// 报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OrderSysID;
        /// <summary>
        /// 开始时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTimeStart;
        /// <summary>
        /// 结束时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTimeEnd;
        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        /// 结算编号
        /// </summary>
        public int SettlementID;
    }

    /// <summary>
    /// 市场行情
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcMarketDataField
    {
        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        /// 合约在交易所的代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;
        /// <summary>
        /// 最新价
        /// </summary>
        public double LastPrice;
        /// <summary>
        /// 上次结算价
        /// </summary>
        public double PreSettlementPrice;
        /// <summary>
        /// 昨收盘
        /// </summary>
        public double PreClosePrice;
        /// <summary>
        /// 昨持仓量
        /// </summary>
        public double PreOpenInterest;
        /// <summary>
        /// 今开盘
        /// </summary>
        public double OpenPrice;
        /// <summary>
        /// 最高价
        /// </summary>
        public double HighestPrice;
        /// <summary>
        /// 最低价
        /// </summary>
        public double LowestPrice;
        /// <summary>
        /// 数量
        /// </summary>
        public int Volume;
        /// <summary>
        /// 成交金额
        /// </summary>
        public double Turnover;
        /// <summary>
        /// 持仓量
        /// </summary>
        public double OpenInterest;
        /// <summary>
        /// 今收盘
        /// </summary>
        public double ClosePrice;
        /// <summary>
        /// 本次结算价
        /// </summary>
        public double SettlementPrice;
        /// <summary>
        /// 涨停板价
        /// </summary>
        public double UpperLimitPrice;
        /// <summary>
        /// 跌停板价
        /// </summary>
        public double LowerLimitPrice;
        /// <summary>
        /// 昨虚实度
        /// </summary>
        public double PreDelta;
        /// <summary>
        /// 今虚实度
        /// </summary>
        public double CurrDelta;
        /// <summary>
        /// 最后修改时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string UpdateTime;
        /// <summary>
        /// 最后修改毫秒
        /// </summary>
        public int UpdateMillisec;
    }

    /// <summary>
    /// 行情基础属性
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcMarketDataBaseField
    {
        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        /// 上次结算价
        /// </summary>
        public double PreSettlementPrice;
        /// <summary>
        /// 昨收盘
        /// </summary>
        public double PreClosePrice;
        /// <summary>
        /// 昨持仓量
        /// </summary>
        public double PreOpenInterest;
        /// <summary>
        /// 昨虚实度
        /// </summary>
        public double PreDelta;
    }

    /// <summary>
    /// 行情静态属性
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcMarketDataStaticField
    {
        /// <summary>
        /// 今开盘
        /// </summary>
        public double OpenPrice;
        /// <summary>
        /// 最高价
        /// </summary>
        public double HighestPrice;
        /// <summary>
        /// 最低价
        /// </summary>
        public double LowestPrice;
        /// <summary>
        /// 今收盘
        /// </summary>
        public double ClosePrice;
        /// <summary>
        /// 涨停板价
        /// </summary>
        public double UpperLimitPrice;
        /// <summary>
        /// 跌停板价
        /// </summary>
        public double LowerLimitPrice;
        /// <summary>
        /// 本次结算价
        /// </summary>
        public double SettlementPrice;
        /// <summary>
        /// 今虚实度
        /// </summary>
        public double CurrDelta;
    }

    /// <summary>
    /// 行情最新成交属性
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcMarketDataLastMatchField
    {
        /// <summary>
        /// 最新价
        /// </summary>
        public double LastPrice;
        /// <summary>
        /// 数量
        /// </summary>
        public int Volume;
        /// <summary>
        /// 成交金额
        /// </summary>
        public double Turnover;
        /// <summary>
        /// 持仓量
        /// </summary>
        public double OpenInterest;
    }

    /// <summary>
    /// 行情最优价属性
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcMarketDataBestPriceField
    {
        /// <summary>
        /// 申买价一
        /// </summary>
        public double BidPrice1;
        /// <summary>
        /// 申买量一
        /// </summary>
        public int BidVolume1;
        /// <summary>
        /// 申卖价一
        /// </summary>
        public double AskPrice1;
        /// <summary>
        /// 申卖量一
        /// </summary>
        public int AskVolume1;
    }

    /// <summary>
    /// 行情申买二、三属性
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcMarketDataBid23Field
    {
        /// <summary>
        /// 申买价二
        /// </summary>
        public double BidPrice2;
        /// <summary>
        /// 申买量二
        /// </summary>
        public int BidVolume2;
        /// <summary>
        /// 申买价三
        /// </summary>
        public double BidPrice3;
        /// <summary>
        /// 申买量三
        /// </summary>
        public int BidVolume3;
    }

    /// <summary>
    /// 行情申卖二、三属性
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcMarketDataAsk23Field
    {
        /// <summary>
        /// 申卖价二
        /// </summary>
        public double AskPrice2;
        /// <summary>
        /// 申卖量二
        /// </summary>
        public int AskVolume2;
        /// <summary>
        /// 申卖价三
        /// </summary>
        public double AskPrice3;
        /// <summary>
        /// 申卖量三
        /// </summary>
        public int AskVolume3;
    }

    /// <summary>
    /// 行情申买四、五属性
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcMarketDataBid45Field
    {
        /// <summary>
        /// 申买价四
        /// </summary>
        public double BidPrice4;
        /// <summary>
        /// 申买量四
        /// </summary>
        public int BidVolume4;
        /// <summary>
        /// 申买价五
        /// </summary>
        public double BidPrice5;
        /// <summary>
        /// 申买量五
        /// </summary>
        public int BidVolume5;
    }

    /// <summary>
    /// 行情申卖四、五属性
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcMarketDataAsk45Field
    {
        /// <summary>
        /// 申卖价四
        /// </summary>
        public double AskPrice4;
        /// <summary>
        /// 申卖量四
        /// </summary>
        public int AskVolume4;
        /// <summary>
        /// 申卖价五
        /// </summary>
        public double AskPrice5;
        /// <summary>
        /// 申卖量五
        /// </summary>
        public int AskVolume5;
    }

    /// <summary>
    /// 行情更新时间属性
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcMarketDataUpdateTimeField
    {
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        /// 最后修改时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string UpdateTime;
        /// <summary>
        /// 最后修改毫秒
        /// </summary>
        public int UpdateMillisec;
    }

    /// <summary>
    /// 行情交易所代码属性
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcMarketDataExchangeField
    {
        /// <summary>
        /// 交易所代码
        /// </summary>
        public double ExchangeID;
    }

    /// <summary>
    /// 指定的合约
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcSpecificInstrumentField
    {
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
    }

    /// <summary>
    /// 合约状态
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcInstrumentStatusField
    {
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        /// 合约在交易所的代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;
        /// <summary>
        /// 结算组代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string SettlementGroupID;
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        /// 合约交易状态
        /// </summary>
        public TThostFtdcInstrumentStatusType InstrumentStatus;
        /// <summary>
        /// 交易阶段编号
        /// </summary>
        public int TradingSegmentSN;
        /// <summary>
        /// 进入本状态时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string EnterTime;
        /// <summary>
        /// 进入本状态原因
        /// </summary>
        public TThostFtdcInstStatusEnterReasonType EnterReason;
    }

    /// <summary>
    /// 查询合约状态
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryInstrumentStatusField
    {
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        /// 合约在交易所的代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;
    }

    /// <summary>
    /// 投资者账户
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcInvestorAccountField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        /// 投资者帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
    }

    /// <summary>
    /// 浮动盈亏算法
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcPositionProfitAlgorithmField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        /// <summary>
        /// 盈亏算法
        /// </summary>
        public TThostFtdcAlgorithmType Algorithm;
        /// <summary>
        /// 备注
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
        public string Memo;
    }

    /// <summary>
    /// 会员资金折扣
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcDiscountField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者范围
        /// </summary>
        public TThostFtdcInvestorRangeType InvestorRange;
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        /// 资金折扣比例
        /// </summary>
        public double Discount;
    }

    /// <summary>
    /// 查询转帐银行
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryTransferBankField
    {
        /// <summary>
        /// 银行代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        /// <summary>
        /// 银行分中心代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBrchID;
    }

    /// <summary>
    /// 转帐银行
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcTransferBankField
    {
        /// <summary>
        /// 银行代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        /// <summary>
        /// 银行分中心代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBrchID;
        /// <summary>
        /// 银行名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
        public string BankName;
        /// <summary>
        /// 是否活跃
        /// </summary>
        public int IsActive;
    }

    /// <summary>
    /// 查询投资者持仓明细
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryInvestorPositionDetailField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
    }

    /// <summary>
    /// 投资者持仓明细
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcInvestorPositionDetailField
    {
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        /// 投机套保标志
        /// </summary>
        public TThostFtdcHedgeFlagType HedgeFlag;
        /// <summary>
        /// 买卖
        /// </summary>
        public TThostFtdcDirectionType Direction;
        /// <summary>
        /// 开仓日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string OpenDate;
        /// <summary>
        /// 成交编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TradeID;
        /// <summary>
        /// 数量
        /// </summary>
        public int Volume;
        /// <summary>
        /// 开仓价
        /// </summary>
        public double OpenPrice;
        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        /// 结算编号
        /// </summary>
        public int SettlementID;
        /// <summary>
        /// 成交类型
        /// </summary>
        public TThostFtdcTradeTypeType TradeType;
        /// <summary>
        /// 组合合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string CombInstrumentID;
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        /// 逐日盯市平仓盈亏
        /// </summary>
        public double CloseProfitByDate;
        /// <summary>
        /// 逐笔对冲平仓盈亏
        /// </summary>
        public double CloseProfitByTrade;
        /// <summary>
        /// 逐日盯市持仓盈亏
        /// </summary>
        public double PositionProfitByDate;
        /// <summary>
        /// 逐笔对冲持仓盈亏
        /// </summary>
        public double PositionProfitByTrade;
        /// <summary>
        /// 投资者保证金
        /// </summary>
        public double Margin;
        /// <summary>
        /// 交易所保证金
        /// </summary>
        public double ExchMargin;
        /// <summary>
        /// 保证金率
        /// </summary>
        public double MarginRateByMoney;
        /// <summary>
        /// 保证金率(按手数)
        /// </summary>
        public double MarginRateByVolume;
        /// <summary>
        /// 昨结算价
        /// </summary>
        public double LastSettlementPrice;
        /// <summary>
        /// 结算价
        /// </summary>
        public double SettlementPrice;
        /// <summary>
        /// 平仓量
        /// </summary>
        public int CloseVolume;
        /// <summary>
        /// 平仓金额
        /// </summary>
        public double CloseAmount;
    }

    /// <summary>
    /// 资金账户口令域
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcTradingAccountPasswordField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        /// <summary>
        /// 密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
    }

    /// <summary>
    /// 交易所行情报盘机
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcMDTraderOfferField
    {
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        /// <summary>
        /// 密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;
        /// <summary>
        /// 本地报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderLocalID;
        /// <summary>
        /// 交易所交易员连接状态
        /// </summary>
        public TThostFtdcTraderConnectStatusType TraderConnectStatus;
        /// <summary>
        /// 发出连接请求的日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ConnectRequestDate;
        /// <summary>
        /// 发出连接请求的时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ConnectRequestTime;
        /// <summary>
        /// 上次报告日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string LastReportDate;
        /// <summary>
        /// 上次报告时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string LastReportTime;
        /// <summary>
        /// 完成连接日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ConnectDate;
        /// <summary>
        /// 完成连接时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ConnectTime;
        /// <summary>
        /// 启动日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string StartDate;
        /// <summary>
        /// 启动时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string StartTime;
        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 本席位最大成交编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MaxTradeID;
        /// <summary>
        /// 本席位最大报单备拷
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string MaxOrderMessageReference;
    }

    /// <summary>
    /// 查询行情报盘机
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryMDTraderOfferField
    {
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
    }

    /// <summary>
    /// 查询客户通知
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryNoticeField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
    }

    /// <summary>
    /// 客户通知
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcNoticeField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 消息正文
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 501)]
        public string Content;
        /// <summary>
        /// 经纪公司通知内容序列号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
        public string SequenceLabel;
    }

    /// <summary>
    /// 用户权限
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcUserRightField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        /// 客户权限类型
        /// </summary>
        public TThostFtdcUserRightTypeType UserRightType;
        /// <summary>
        /// 是否禁止
        /// </summary>
        public int IsForbidden;
    }

    /// <summary>
    /// 查询结算信息确认域
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQrySettlementInfoConfirmField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
    }

    /// <summary>
    /// 装载结算信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcLoadSettlementInfoField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
    }

    /// <summary>
    /// 经纪公司可提资金算法表
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcBrokerWithdrawAlgorithmField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 可提资金算法
        /// </summary>
        public TThostFtdcAlgorithmType WithdrawAlgorithm;
        /// <summary>
        /// 资金使用率
        /// </summary>
        public double UsingRatio;
        /// <summary>
        /// 可提是否包含平仓盈利
        /// </summary>
        public TThostFtdcIncludeCloseProfitType IncludeCloseProfit;
        /// <summary>
        /// 本日无仓且无成交客户是否受可提比例限制
        /// </summary>
        public TThostFtdcAllWithoutTradeType AllWithoutTrade;
        /// <summary>
        /// 可用是否包含平仓盈利
        /// </summary>
        public TThostFtdcIncludeCloseProfitType AvailIncludeCloseProfit;
        /// <summary>
        /// 是否启用用户事件
        /// </summary>
        public int IsBrokerUserEvent;
    }

    /// <summary>
    /// 资金账户口令变更域
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcTradingAccountPasswordUpdateV1Field
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        /// 原来的口令
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string OldPassword;
        /// <summary>
        /// 新的口令
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string NewPassword;
    }

    /// <summary>
    /// 资金账户口令变更域
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcTradingAccountPasswordUpdateField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        /// <summary>
        /// 原来的口令
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string OldPassword;
        /// <summary>
        /// 新的口令
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string NewPassword;
    }

    /// <summary>
    /// 查询组合合约分腿
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryCombinationLegField
    {
        /// <summary>
        /// 组合合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string CombInstrumentID;
        /// <summary>
        /// 单腿编号
        /// </summary>
        public int LegID;
        /// <summary>
        /// 单腿合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string LegInstrumentID;
    }

    /// <summary>
    /// 查询组合合约分腿
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQrySyncStatusField
    {
        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
    }

    /// <summary>
    /// 组合交易合约的单腿
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcCombinationLegField
    {
        /// <summary>
        /// 组合合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string CombInstrumentID;
        /// <summary>
        /// 单腿编号
        /// </summary>
        public int LegID;
        /// <summary>
        /// 单腿合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string LegInstrumentID;
        /// <summary>
        /// 买卖方向
        /// </summary>
        public TThostFtdcDirectionType Direction;
        /// <summary>
        /// 单腿乘数
        /// </summary>
        public int LegMultiple;
        /// <summary>
        /// 派生层数
        /// </summary>
        public int ImplyLevel;
    }

    /// <summary>
    /// 数据同步状态
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcSyncStatusField
    {
        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        /// 数据同步状态
        /// </summary>
        public TThostFtdcDataSyncStatusType DataSyncStatus;
    }

    /// <summary>
    /// 查询联系人
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryLinkManField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
    }

    /// <summary>
    /// 联系人
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcLinkManField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        /// 联系人类型
        /// </summary>
        public TThostFtdcPersonTypeType PersonType;
        /// <summary>
        /// 证件类型
        /// </summary>
        public TThostFtdcIdCardTypeType IdentifiedCardType;
        /// <summary>
        /// 证件号码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;
        /// <summary>
        /// 名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string PersonName;
        /// <summary>
        /// 联系电话
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Telephone;
        /// <summary>
        /// 通讯地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
        public string Address;
        /// <summary>
        /// 邮政编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string ZipCode;
        /// <summary>
        /// 优先级
        /// </summary>
        public int Priority;
    }

    /// <summary>
    /// 查询经纪公司用户事件
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryBrokerUserEventField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        /// 用户事件类型
        /// </summary>
        public TThostFtdcUserEventTypeType UserEventType;
    }

    /// <summary>
    /// 查询经纪公司用户事件
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcBrokerUserEventField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        /// 用户事件类型
        /// </summary>
        public TThostFtdcUserEventTypeType UserEventType;
        /// <summary>
        /// 用户事件序号
        /// </summary>
        public int EventSequenceNo;
        /// <summary>
        /// 事件发生日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string EventDate;
        /// <summary>
        /// 事件发生时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string EventTime;
        /// <summary>
        /// 用户事件信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1025)]
        public string UserEventInfo;
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
    }

    /// <summary>
    /// 查询签约银行请求
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryContractBankField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 银行代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        /// <summary>
        /// 银行分中心代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBrchID;
    }

    /// <summary>
    /// 查询签约银行响应
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcContractBankField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 银行代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        /// <summary>
        /// 银行分中心代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBrchID;
        /// <summary>
        /// 银行名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
        public string BankName;
    }

    /// <summary>
    /// 投资者组合持仓明细
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcInvestorPositionCombineDetailField
    {
        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        /// 开仓日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string OpenDate;
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        /// 结算编号
        /// </summary>
        public int SettlementID;
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        /// 组合编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string ComTradeID;
        /// <summary>
        /// 撮合编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TradeID;
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        /// 投机套保标志
        /// </summary>
        public TThostFtdcHedgeFlagType HedgeFlag;
        /// <summary>
        /// 买卖
        /// </summary>
        public TThostFtdcDirectionType Direction;
        /// <summary>
        /// 持仓量
        /// </summary>
        public int TotalAmt;
        /// <summary>
        /// 投资者保证金
        /// </summary>
        public double Margin;
        /// <summary>
        /// 交易所保证金
        /// </summary>
        public double ExchMargin;
        /// <summary>
        /// 保证金率
        /// </summary>
        public double MarginRateByMoney;
        /// <summary>
        /// 保证金率(按手数)
        /// </summary>
        public double MarginRateByVolume;
        /// <summary>
        /// 单腿编号
        /// </summary>
        public int LegID;
        /// <summary>
        /// 单腿乘数
        /// </summary>
        public int LegMultiple;
        /// <summary>
        /// 组合持仓合约编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string CombInstrumentID;
    }

    /// <summary>
    /// 预埋单
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcParkedOrderField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        /// 报单引用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderRef;
        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        /// 报单价格条件
        /// </summary>
        public TThostFtdcOrderPriceTypeType OrderPriceType;
        /// <summary>
        /// 买卖方向
        /// </summary>
        public TThostFtdcDirectionType Direction;
        /// <summary>
        /// 组合开平标志
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string CombOffsetFlag;
        /// <summary>
        /// 组合投机套保标志
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string CombHedgeFlag;
        /// <summary>
        /// 价格
        /// </summary>
        public double LimitPrice;
        /// <summary>
        /// 数量
        /// </summary>
        public int VolumeTotalOriginal;
        /// <summary>
        /// 有效期类型
        /// </summary>
        public TThostFtdcTimeConditionType TimeCondition;
        /// <summary>
        /// GTD日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string GTDDate;
        /// <summary>
        /// 成交量类型
        /// </summary>
        public TThostFtdcVolumeConditionType VolumeCondition;
        /// <summary>
        /// 最小成交量
        /// </summary>
        public int MinVolume;
        /// <summary>
        /// 触发条件
        /// </summary>
        public TThostFtdcContingentConditionType ContingentCondition;
        /// <summary>
        /// 止损价
        /// </summary>
        public double StopPrice;
        /// <summary>
        /// 强平原因
        /// </summary>
        public TThostFtdcForceCloseReasonType ForceCloseReason;
        /// <summary>
        /// 自动挂起标志
        /// </summary>
        public int IsAutoSuspend;
        /// <summary>
        /// 业务单元
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;
        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;
        /// <summary>
        /// 用户强评标志
        /// </summary>
        public int UserForceClose;
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        /// 预埋报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ParkedOrderID;
        /// <summary>
        /// 用户类型
        /// </summary>
        public TThostFtdcUserTypeType UserType;
        /// <summary>
        /// 预埋单状态
        /// </summary>
        public TThostFtdcParkedOrderStatusType Status;
        /// <summary>
        /// 错误代码
        /// </summary>
        public int ErrorID;
        /// <summary>
        /// 错误信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;
    }

    /// <summary>
    /// 输入预埋单操作
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcParkedOrderActionField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        /// 报单操作引用
        /// </summary>
        public int OrderActionRef;
        /// <summary>
        /// 报单引用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderRef;
        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;
        /// <summary>
        /// 前置编号
        /// </summary>
        public int FrontID;
        /// <summary>
        /// 会话编号
        /// </summary>
        public int SessionID;
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        /// 报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OrderSysID;
        /// <summary>
        /// 操作标志
        /// </summary>
        public TThostFtdcActionFlagType ActionFlag;
        /// <summary>
        /// 价格
        /// </summary>
        public double LimitPrice;
        /// <summary>
        /// 数量变化
        /// </summary>
        public int VolumeChange;
        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        /// 预埋撤单单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ParkedOrderActionID;
        /// <summary>
        /// 用户类型
        /// </summary>
        public TThostFtdcUserTypeType UserType;
        /// <summary>
        /// 预埋撤单状态
        /// </summary>
        public TThostFtdcParkedOrderStatusType Status;
        /// <summary>
        /// 错误代码
        /// </summary>
        public int ErrorID;
        /// <summary>
        /// 错误信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;
    }

    /// <summary>
    /// 查询预埋单
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryParkedOrderField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
    }

    /// <summary>
    /// 查询预埋撤单
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryParkedOrderActionField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
    }

    /// <summary>
    /// 删除预埋单
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcRemoveParkedOrderField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        /// 预埋报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ParkedOrderID;
    }

    /// <summary>
    /// 删除预埋撤单
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcRemoveParkedOrderActionField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        /// 预埋撤单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ParkedOrderActionID;
    }

    /// <summary>
    /// 经纪公司可提资金算法表
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcInvestorWithdrawAlgorithmField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者范围
        /// </summary>
        public TThostFtdcInvestorRangeType InvestorRange;
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        /// 可提资金比例
        /// </summary>
        public double UsingRatio;
    }

    /// <summary>
    /// 查询组合持仓明细
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryInvestorPositionCombineDetailField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        /// 组合持仓合约编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string CombInstrumentID;
    }

    /// <summary>
    /// 成交均价
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcMarketDataAveragePriceField
    {
        /// <summary>
        /// 当日均价
        /// </summary>
        public double AveragePrice;
    }

    /// <summary>
    /// 校验投资者密码
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcVerifyInvestorPasswordField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        /// 密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
    }

    /// <summary>
    /// 用户IP
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcUserIPField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;
        /// <summary>
        /// IP地址掩码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPMask;
        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;
    }

    /// <summary>
    /// 用户事件通知信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcTradingNoticeInfoField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        /// 发送时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string SendTime;
        /// <summary>
        /// 消息正文
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 501)]
        public string FieldContent;
        /// <summary>
        /// 序列系列号
        /// </summary>
        public short SequenceSeries;
        /// <summary>
        /// 序列号
        /// </summary>
        public int SequenceNo;
    }

    /// <summary>
    /// 用户事件通知
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcTradingNoticeField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者范围
        /// </summary>
        public TThostFtdcInvestorRangeType InvestorRange;
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        /// 序列系列号
        /// </summary>
        public short SequenceSeries;
        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        /// 发送时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string SendTime;
        /// <summary>
        /// 序列号
        /// </summary>
        public int SequenceNo;
        /// <summary>
        /// 消息正文
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 501)]
        public string FieldContent;
    }

    /// <summary>
    /// 查询交易事件通知
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryTradingNoticeField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
    }

    /// <summary>
    /// 查询错误报单
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryErrOrderField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
    }

    /// <summary>
    /// 错误报单
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcErrOrderField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        /// 报单引用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderRef;
        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        /// 报单价格条件
        /// </summary>
        public TThostFtdcOrderPriceTypeType OrderPriceType;
        /// <summary>
        /// 买卖方向
        /// </summary>
        public TThostFtdcDirectionType Direction;
        /// <summary>
        /// 组合开平标志
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string CombOffsetFlag;
        /// <summary>
        /// 组合投机套保标志
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string CombHedgeFlag;
        /// <summary>
        /// 价格
        /// </summary>
        public double LimitPrice;
        /// <summary>
        /// 数量
        /// </summary>
        public int VolumeTotalOriginal;
        /// <summary>
        /// 有效期类型
        /// </summary>
        public TThostFtdcTimeConditionType TimeCondition;
        /// <summary>
        /// GTD日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string GTDDate;
        /// <summary>
        /// 成交量类型
        /// </summary>
        public TThostFtdcVolumeConditionType VolumeCondition;
        /// <summary>
        /// 最小成交量
        /// </summary>
        public int MinVolume;
        /// <summary>
        /// 触发条件
        /// </summary>
        public TThostFtdcContingentConditionType ContingentCondition;
        /// <summary>
        /// 止损价
        /// </summary>
        public double StopPrice;
        /// <summary>
        /// 强平原因
        /// </summary>
        public TThostFtdcForceCloseReasonType ForceCloseReason;
        /// <summary>
        /// 自动挂起标志
        /// </summary>
        public int IsAutoSuspend;
        /// <summary>
        /// 业务单元
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;
        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;
        /// <summary>
        /// 用户强评标志
        /// </summary>
        public int UserForceClose;
        /// <summary>
        /// 错误代码
        /// </summary>
        public int ErrorID;
        /// <summary>
        /// 错误信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;
    }

    /// <summary>
    /// 查询错误报单操作
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcErrorConditionalOrderField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        /// 报单引用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderRef;
        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        /// 报单价格条件
        /// </summary>
        public TThostFtdcOrderPriceTypeType OrderPriceType;
        /// <summary>
        /// 买卖方向
        /// </summary>
        public TThostFtdcDirectionType Direction;
        /// <summary>
        /// 组合开平标志
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string CombOffsetFlag;
        /// <summary>
        /// 组合投机套保标志
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string CombHedgeFlag;
        /// <summary>
        /// 价格
        /// </summary>
        public double LimitPrice;
        /// <summary>
        /// 数量
        /// </summary>
        public int VolumeTotalOriginal;
        /// <summary>
        /// 有效期类型
        /// </summary>
        public TThostFtdcTimeConditionType TimeCondition;
        /// <summary>
        /// GTD日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string GTDDate;
        /// <summary>
        /// 成交量类型
        /// </summary>
        public TThostFtdcVolumeConditionType VolumeCondition;
        /// <summary>
        /// 最小成交量
        /// </summary>
        public int MinVolume;
        /// <summary>
        /// 触发条件
        /// </summary>
        public TThostFtdcContingentConditionType ContingentCondition;
        /// <summary>
        /// 止损价
        /// </summary>
        public double StopPrice;
        /// <summary>
        /// 强平原因
        /// </summary>
        public TThostFtdcForceCloseReasonType ForceCloseReason;
        /// <summary>
        /// 自动挂起标志
        /// </summary>
        public int IsAutoSuspend;
        /// <summary>
        /// 业务单元
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;
        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;
        /// <summary>
        /// 本地报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderLocalID;
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;
        /// <summary>
        /// 合约在交易所的代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;
        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;
        /// <summary>
        /// 报单提交状态
        /// </summary>
        public TThostFtdcOrderSubmitStatusType OrderSubmitStatus;
        /// <summary>
        /// 报单提示序号
        /// </summary>
        public int NotifySequence;
        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        /// 结算编号
        /// </summary>
        public int SettlementID;
        /// <summary>
        /// 报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OrderSysID;
        /// <summary>
        /// 报单来源
        /// </summary>
        public TThostFtdcOrderSourceType OrderSource;
        /// <summary>
        /// 报单状态
        /// </summary>
        public TThostFtdcOrderStatusType OrderStatus;
        /// <summary>
        /// 报单类型
        /// </summary>
        public TThostFtdcOrderTypeType OrderType;
        /// <summary>
        /// 今成交数量
        /// </summary>
        public int VolumeTraded;
        /// <summary>
        /// 剩余数量
        /// </summary>
        public int VolumeTotal;
        /// <summary>
        /// 报单日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertDate;
        /// <summary>
        /// 委托时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTime;
        /// <summary>
        /// 激活时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActiveTime;
        /// <summary>
        /// 挂起时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string SuspendTime;
        /// <summary>
        /// 最后修改时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string UpdateTime;
        /// <summary>
        /// 撤销时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string CancelTime;
        /// <summary>
        /// 最后修改交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string ActiveTraderID;
        /// <summary>
        /// 结算会员编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClearingPartID;
        /// <summary>
        /// 序号
        /// </summary>
        public int SequenceNo;
        /// <summary>
        /// 前置编号
        /// </summary>
        public int FrontID;
        /// <summary>
        /// 会话编号
        /// </summary>
        public int SessionID;
        /// <summary>
        /// 用户端产品信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string UserProductInfo;
        /// <summary>
        /// 状态信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string StatusMsg;
        /// <summary>
        /// 用户强评标志
        /// </summary>
        public int UserForceClose;
        /// <summary>
        /// 操作用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string ActiveUserID;
        /// <summary>
        /// 经纪公司报单编号
        /// </summary>
        public int BrokerOrderSeq;
        /// <summary>
        /// 相关报单
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string RelativeOrderSysID;
        /// <summary>
        /// 错误代码
        /// </summary>
        public int ErrorID;
        /// <summary>
        /// 错误信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;
    }

    /// <summary>
    /// 查询错误报单操作
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryErrOrderActionField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
    }

    /// <summary>
    /// 错误报单操作
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcErrOrderActionField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        /// 报单操作引用
        /// </summary>
        public int OrderActionRef;
        /// <summary>
        /// 报单引用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderRef;
        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;
        /// <summary>
        /// 前置编号
        /// </summary>
        public int FrontID;
        /// <summary>
        /// 会话编号
        /// </summary>
        public int SessionID;
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        /// 报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OrderSysID;
        /// <summary>
        /// 操作标志
        /// </summary>
        public TThostFtdcActionFlagType ActionFlag;
        /// <summary>
        /// 价格
        /// </summary>
        public double LimitPrice;
        /// <summary>
        /// 数量变化
        /// </summary>
        public int VolumeChange;
        /// <summary>
        /// 操作日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionDate;
        /// <summary>
        /// 操作时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionTime;
        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;
        /// <summary>
        /// 本地报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderLocalID;
        /// <summary>
        /// 操作本地编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ActionLocalID;
        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;
        /// <summary>
        /// 业务单元
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;
        /// <summary>
        /// 报单操作状态
        /// </summary>
        public TThostFtdcOrderActionStatusType OrderActionStatus;
        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        /// 状态信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string StatusMsg;
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        /// 错误代码
        /// </summary>
        public int ErrorID;
        /// <summary>
        /// 错误信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;
    }

    /// <summary>
    /// 查询交易所状态
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryExchangeSequenceField
    {
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
    }

    /// <summary>
    /// 交易所状态
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcExchangeSequenceField
    {
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        /// 序号
        /// </summary>
        public int SequenceNo;
        /// <summary>
        /// 合约交易状态
        /// </summary>
        public TThostFtdcInstrumentStatusType MarketStatus;
    }

    /// <summary>
    /// 根据价格查询最大报单数量
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQueryMaxOrderVolumeWithPriceField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        /// 买卖方向
        /// </summary>
        public TThostFtdcDirectionType Direction;
        /// <summary>
        /// 开平标志
        /// </summary>
        public TThostFtdcOffsetFlagType OffsetFlag;
        /// <summary>
        /// 投机套保标志
        /// </summary>
        public TThostFtdcHedgeFlagType HedgeFlag;
        /// <summary>
        /// 最大允许报单数量
        /// </summary>
        public int MaxVolume;
        /// <summary>
        /// 报单价格
        /// </summary>
        public double Price;
    }

    /// <summary>
    /// 查询经纪公司交易参数
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryBrokerTradingParamsField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
    }

    /// <summary>
    /// 经纪公司交易参数
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcBrokerTradingParamsField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        /// 保证金价格类型
        /// </summary>
        public TThostFtdcMarginPriceTypeType MarginPriceType;
        /// <summary>
        /// 盈亏算法
        /// </summary>
        public TThostFtdcAlgorithmType Algorithm;
        /// <summary>
        /// 可用是否包含平仓盈利
        /// </summary>
        public TThostFtdcIncludeCloseProfitType AvailIncludeCloseProfit;
    }

    /// <summary>
    /// 查询经纪公司交易算法
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryBrokerTradingAlgosField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
    }

    /// <summary>
    /// 经纪公司交易算法
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcBrokerTradingAlgosField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        /// 持仓处理算法编号
        /// </summary>
        public TThostFtdcHandlePositionAlgoIDType HandlePositionAlgoID;
        /// <summary>
        /// 寻找保证金率算法编号
        /// </summary>
        public TThostFtdcFindMarginRateAlgoIDType FindMarginRateAlgoID;
        /// <summary>
        /// 资金处理算法编号
        /// </summary>
        public TThostFtdcHandleTradingAccountAlgoIDType HandleTradingAccountAlgoID;
    }

    /// <summary>
    /// 查询经纪公司资金
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQueryBrokerDepositField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
    }

    /// <summary>
    /// 经纪公司资金
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcBrokerDepositField
    {
        /// <summary>
        /// 交易日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        /// 上次结算准备金
        /// </summary>
        public double PreBalance;
        /// <summary>
        /// 当前保证金总额
        /// </summary>
        public double CurrMargin;
        /// <summary>
        /// 平仓盈亏
        /// </summary>
        public double CloseProfit;
        /// <summary>
        /// 期货结算准备金
        /// </summary>
        public double Balance;
        /// <summary>
        /// 入金金额
        /// </summary>
        public double Deposit;
        /// <summary>
        /// 出金金额
        /// </summary>
        public double Withdraw;
        /// <summary>
        /// 可提资金
        /// </summary>
        public double Available;
        /// <summary>
        /// 基本准备金
        /// </summary>
        public double Reserve;
        /// <summary>
        /// 冻结的保证金
        /// </summary>
        public double FrozenMargin;
    }

    /// <summary>
    /// 查询保证金监管系统经纪公司密钥
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryCFMMCBrokerKeyField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
    }

    /// <summary>
    /// 保证金监管系统经纪公司密钥
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcCFMMCBrokerKeyField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 经纪公司统一编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        /// <summary>
        /// 密钥生成日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string CreateDate;
        /// <summary>
        /// 密钥生成时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string CreateTime;
        /// <summary>
        /// 密钥编号
        /// </summary>
        public int KeyID;
        /// <summary>
        /// 动态密钥
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string CurrentKey;
        /// <summary>
        /// 动态密钥类型
        /// </summary>
        public TThostFtdcCFMMCKeyKindType KeyKind;
    }

    /// <summary>
    /// 保证金监管系统经纪公司资金账户密钥
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcCFMMCTradingAccountKeyField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 经纪公司统一编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        /// <summary>
        /// 投资者帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        /// <summary>
        /// 密钥编号
        /// </summary>
        public int KeyID;
        /// <summary>
        /// 动态密钥
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string CurrentKey;
    }

    /// <summary>
    /// 请求查询保证金监管系统经纪公司资金账户密钥
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryCFMMCTradingAccountKeyField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
    }

    /// <summary>
    /// 用户动态令牌参数
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcBrokerUserOTPParamField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        /// 动态令牌提供商
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
        public string OTPVendorsID;
        /// <summary>
        /// 动态令牌序列号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string SerialNumber;
        /// <summary>
        /// 令牌密钥
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string AuthKey;
        /// <summary>
        /// 漂移值
        /// </summary>
        public int LastDrift;
        /// <summary>
        /// 成功值
        /// </summary>
        public int LastSuccess;
        /// <summary>
        /// 动态令牌类型
        /// </summary>
        public TThostFtdcOTPTypeType OTPType;
    }

    /// <summary>
    /// 手工同步用户动态令牌
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcManualSyncBrokerUserOTPField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        /// 动态令牌类型
        /// </summary>
        public TThostFtdcOTPTypeType OTPType;
        /// <summary>
        /// 第一个动态密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string FirstOTP;
        /// <summary>
        /// 第二个动态密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string SecondOTP;
    }

    /// <summary>
    /// 投资者手续费率模板
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcCommRateModelField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 手续费率模板代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string CommModelID;
        /// <summary>
        /// 模板名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
        public string CommModelName;
    }

    /// <summary>
    /// 请求查询投资者手续费率模板
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryCommRateModelField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 手续费率模板代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string CommModelID;
    }

    /// <summary>
    /// 仓单折抵信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcEWarrantOffsetField
    {
        /// <summary>
        /// 交易日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        /// 买卖方向
        /// </summary>
        public TThostFtdcDirectionType Direction;
        /// <summary>
        /// 投机套保标志
        /// </summary>
        public TThostFtdcHedgeFlagType HedgeFlag;
        /// <summary>
        /// 数量
        /// </summary>
        public int Volume;
    }

    /// <summary>
    /// 查询仓单折抵信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryEWarrantOffsetField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
    }

    /// <summary>
    /// 转帐开户请求
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcReqOpenAccountField
    {
        /// <summary>
        /// 业务功能码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        /// <summary>
        /// 银行代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        /// <summary>
        /// 银行分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        /// <summary>
        /// 期商代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 期商分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        /// <summary>
        /// 交易日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        /// <summary>
        /// 交易时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        /// <summary>
        /// 银行流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        /// <summary>
        /// 交易系统日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        /// 银期平台消息流水号
        /// </summary>
        public int PlateSerial;
        /// <summary>
        /// 最后分片标志
        /// </summary>
        public TThostFtdcLastFragmentType LastFragment;
        /// <summary>
        /// 会话号
        /// </summary>
        public int SessionID;
        /// <summary>
        /// 客户姓名
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string CustomerName;
        /// <summary>
        /// 证件类型
        /// </summary>
        public TThostFtdcIdCardTypeType IdCardType;
        /// <summary>
        /// 证件号码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;
        /// <summary>
        /// 性别
        /// </summary>
        public TThostFtdcGenderType Gender;
        /// <summary>
        /// 国家代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string CountryCode;
        /// <summary>
        /// 客户类型
        /// </summary>
        public TThostFtdcCustTypeType CustType;
        /// <summary>
        /// 地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
        public string Address;
        /// <summary>
        /// 邮编
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string ZipCode;
        /// <summary>
        /// 电话号码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Telephone;
        /// <summary>
        /// 手机
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MobilePhone;
        /// <summary>
        /// 传真
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Fax;
        /// <summary>
        /// 电子邮件
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string EMail;
        /// <summary>
        /// 资金账户状态
        /// </summary>
        public TThostFtdcMoneyAccountStatusType MoneyAccountStatus;
        /// <summary>
        /// 银行帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;
        /// <summary>
        /// 银行密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankPassWord;
        /// <summary>
        /// 投资者帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        /// <summary>
        /// 期货密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;
        /// <summary>
        /// 验证客户证件号码标志
        /// </summary>
        public TThostFtdcYesNoIndicatorType VerifyCertNoFlag;
        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        /// <summary>
        /// 汇钞标志
        /// </summary>
        public TThostFtdcCashExchangeCodeType CashExchangeCode;
        /// <summary>
        /// 摘要
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;
        /// <summary>
        /// 银行帐号类型
        /// </summary>
        public TThostFtdcBankAccTypeType BankAccType;
        /// <summary>
        /// 渠道标志
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;
        /// <summary>
        /// 期货单位帐号类型
        /// </summary>
        public TThostFtdcBankAccTypeType BankSecuAccType;
        /// <summary>
        /// 期货公司银行编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;
        /// <summary>
        /// 期货单位帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankSecuAcc;
        /// <summary>
        /// 银行密码标志
        /// </summary>
        public TThostFtdcPwdFlagType BankPwdFlag;
        /// <summary>
        /// 期货资金密码核对标志
        /// </summary>
        public TThostFtdcPwdFlagType SecuPwdFlag;
        /// <summary>
        /// 交易柜员
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;
        /// <summary>
        /// 交易ID
        /// </summary>
        public int TID;
    }

    /// <summary>
    /// 转帐销户请求
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcReqCancelAccountField
    {
        /// <summary>
        /// 业务功能码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        /// <summary>
        /// 银行代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        /// <summary>
        /// 银行分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        /// <summary>
        /// 期商代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 期商分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        /// <summary>
        /// 交易日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        /// <summary>
        /// 交易时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        /// <summary>
        /// 银行流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        /// <summary>
        /// 交易系统日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        /// 银期平台消息流水号
        /// </summary>
        public int PlateSerial;
        /// <summary>
        /// 最后分片标志
        /// </summary>
        public TThostFtdcLastFragmentType LastFragment;
        /// <summary>
        /// 会话号
        /// </summary>
        public int SessionID;
        /// <summary>
        /// 客户姓名
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string CustomerName;
        /// <summary>
        /// 证件类型
        /// </summary>
        public TThostFtdcIdCardTypeType IdCardType;
        /// <summary>
        /// 证件号码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;
        /// <summary>
        /// 性别
        /// </summary>
        public TThostFtdcGenderType Gender;
        /// <summary>
        /// 国家代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string CountryCode;
        /// <summary>
        /// 客户类型
        /// </summary>
        public TThostFtdcCustTypeType CustType;
        /// <summary>
        /// 地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
        public string Address;
        /// <summary>
        /// 邮编
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string ZipCode;
        /// <summary>
        /// 电话号码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Telephone;
        /// <summary>
        /// 手机
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MobilePhone;
        /// <summary>
        /// 传真
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Fax;
        /// <summary>
        /// 电子邮件
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string EMail;
        /// <summary>
        /// 资金账户状态
        /// </summary>
        public TThostFtdcMoneyAccountStatusType MoneyAccountStatus;
        /// <summary>
        /// 银行帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;
        /// <summary>
        /// 银行密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankPassWord;
        /// <summary>
        /// 投资者帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        /// <summary>
        /// 期货密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;
        /// <summary>
        /// 验证客户证件号码标志
        /// </summary>
        public TThostFtdcYesNoIndicatorType VerifyCertNoFlag;
        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        /// <summary>
        /// 汇钞标志
        /// </summary>
        public TThostFtdcCashExchangeCodeType CashExchangeCode;
        /// <summary>
        /// 摘要
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;
        /// <summary>
        /// 银行帐号类型
        /// </summary>
        public TThostFtdcBankAccTypeType BankAccType;
        /// <summary>
        /// 渠道标志
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;
        /// <summary>
        /// 期货单位帐号类型
        /// </summary>
        public TThostFtdcBankAccTypeType BankSecuAccType;
        /// <summary>
        /// 期货公司银行编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;
        /// <summary>
        /// 期货单位帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankSecuAcc;
        /// <summary>
        /// 银行密码标志
        /// </summary>
        public TThostFtdcPwdFlagType BankPwdFlag;
        /// <summary>
        /// 期货资金密码核对标志
        /// </summary>
        public TThostFtdcPwdFlagType SecuPwdFlag;
        /// <summary>
        /// 交易柜员
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;
        /// <summary>
        /// 交易ID
        /// </summary>
        public int TID;
    }

    /// <summary>
    /// 变更银行账户请求
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcReqChangeAccountField
    {
        /// <summary>
        /// 业务功能码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        /// <summary>
        /// 银行代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        /// <summary>
        /// 银行分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        /// <summary>
        /// 期商代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 期商分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        /// <summary>
        /// 交易日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        /// <summary>
        /// 交易时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        /// <summary>
        /// 银行流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        /// <summary>
        /// 交易系统日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        /// 银期平台消息流水号
        /// </summary>
        public int PlateSerial;
        /// <summary>
        /// 最后分片标志
        /// </summary>
        public TThostFtdcLastFragmentType LastFragment;
        /// <summary>
        /// 会话号
        /// </summary>
        public int SessionID;
        /// <summary>
        /// 客户姓名
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string CustomerName;
        /// <summary>
        /// 证件类型
        /// </summary>
        public TThostFtdcIdCardTypeType IdCardType;
        /// <summary>
        /// 证件号码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;
        /// <summary>
        /// 性别
        /// </summary>
        public TThostFtdcGenderType Gender;
        /// <summary>
        /// 国家代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string CountryCode;
        /// <summary>
        /// 客户类型
        /// </summary>
        public TThostFtdcCustTypeType CustType;
        /// <summary>
        /// 地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
        public string Address;
        /// <summary>
        /// 邮编
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string ZipCode;
        /// <summary>
        /// 电话号码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Telephone;
        /// <summary>
        /// 手机
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MobilePhone;
        /// <summary>
        /// 传真
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Fax;
        /// <summary>
        /// 电子邮件
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string EMail;
        /// <summary>
        /// 资金账户状态
        /// </summary>
        public TThostFtdcMoneyAccountStatusType MoneyAccountStatus;
        /// <summary>
        /// 银行帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;
        /// <summary>
        /// 银行密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankPassWord;
        /// <summary>
        /// 新银行帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string NewBankAccount;
        /// <summary>
        /// 新银行密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string NewBankPassWord;
        /// <summary>
        /// 投资者帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        /// <summary>
        /// 期货密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        /// <summary>
        /// 银行帐号类型
        /// </summary>
        public TThostFtdcBankAccTypeType BankAccType;
        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;
        /// <summary>
        /// 验证客户证件号码标志
        /// </summary>
        public TThostFtdcYesNoIndicatorType VerifyCertNoFlag;
        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        /// <summary>
        /// 期货公司银行编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;
        /// <summary>
        /// 银行密码标志
        /// </summary>
        public TThostFtdcPwdFlagType BankPwdFlag;
        /// <summary>
        /// 期货资金密码核对标志
        /// </summary>
        public TThostFtdcPwdFlagType SecuPwdFlag;
        /// <summary>
        /// 交易ID
        /// </summary>
        public int TID;
        /// <summary>
        /// 摘要
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;
    }

    /// <summary>
    /// 转账请求
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcReqTransferField
    {
        /// <summary>
        /// 业务功能码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        /// <summary>
        /// 银行代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        /// <summary>
        /// 银行分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        /// <summary>
        /// 期商代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 期商分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        /// <summary>
        /// 交易日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        /// <summary>
        /// 交易时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        /// <summary>
        /// 银行流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        /// <summary>
        /// 交易系统日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        /// 银期平台消息流水号
        /// </summary>
        public int PlateSerial;
        /// <summary>
        /// 最后分片标志
        /// </summary>
        public TThostFtdcLastFragmentType LastFragment;
        /// <summary>
        /// 会话号
        /// </summary>
        public int SessionID;
        /// <summary>
        /// 客户姓名
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string CustomerName;
        /// <summary>
        /// 证件类型
        /// </summary>
        public TThostFtdcIdCardTypeType IdCardType;
        /// <summary>
        /// 证件号码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;
        /// <summary>
        /// 客户类型
        /// </summary>
        public TThostFtdcCustTypeType CustType;
        /// <summary>
        /// 银行帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;
        /// <summary>
        /// 银行密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankPassWord;
        /// <summary>
        /// 投资者帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        /// <summary>
        /// 期货密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;
        /// <summary>
        /// 期货公司流水号
        /// </summary>
        public int FutureSerial;
        /// <summary>
        /// 用户标识
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        /// 验证客户证件号码标志
        /// </summary>
        public TThostFtdcYesNoIndicatorType VerifyCertNoFlag;
        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        /// <summary>
        /// 转帐金额
        /// </summary>
        public double TradeAmount;
        /// <summary>
        /// 期货可取金额
        /// </summary>
        public double FutureFetchAmount;
        /// <summary>
        /// 费用支付标志
        /// </summary>
        public TThostFtdcFeePayFlagType FeePayFlag;
        /// <summary>
        /// 应收客户费用
        /// </summary>
        public double CustFee;
        /// <summary>
        /// 应收期货公司费用
        /// </summary>
        public double BrokerFee;
        /// <summary>
        /// 发送方给接收方的消息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string Message;
        /// <summary>
        /// 摘要
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;
        /// <summary>
        /// 银行帐号类型
        /// </summary>
        public TThostFtdcBankAccTypeType BankAccType;
        /// <summary>
        /// 渠道标志
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;
        /// <summary>
        /// 期货单位帐号类型
        /// </summary>
        public TThostFtdcBankAccTypeType BankSecuAccType;
        /// <summary>
        /// 期货公司银行编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;
        /// <summary>
        /// 期货单位帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankSecuAcc;
        /// <summary>
        /// 银行密码标志
        /// </summary>
        public TThostFtdcPwdFlagType BankPwdFlag;
        /// <summary>
        /// 期货资金密码核对标志
        /// </summary>
        public TThostFtdcPwdFlagType SecuPwdFlag;
        /// <summary>
        /// 交易柜员
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;
        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;
        /// <summary>
        /// 交易ID
        /// </summary>
        public int TID;
        /// <summary>
        /// 转账交易状态
        /// </summary>
        public TThostFtdcTransferStatusType TransferStatus;
    }

    /// <summary>
    /// 银行发起银行资金转期货响应
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcRspTransferField
    {
        /// <summary>
        /// 业务功能码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        /// <summary>
        /// 银行代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        /// <summary>
        /// 银行分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        /// <summary>
        /// 期商代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 期商分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        /// <summary>
        /// 交易日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        /// <summary>
        /// 交易时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        /// <summary>
        /// 银行流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        /// <summary>
        /// 交易系统日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        /// 银期平台消息流水号
        /// </summary>
        public int PlateSerial;
        /// <summary>
        /// 最后分片标志
        /// </summary>
        public TThostFtdcLastFragmentType LastFragment;
        /// <summary>
        /// 会话号
        /// </summary>
        public int SessionID;
        /// <summary>
        /// 客户姓名
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string CustomerName;
        /// <summary>
        /// 证件类型
        /// </summary>
        public TThostFtdcIdCardTypeType IdCardType;
        /// <summary>
        /// 证件号码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;
        /// <summary>
        /// 客户类型
        /// </summary>
        public TThostFtdcCustTypeType CustType;
        /// <summary>
        /// 银行帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;
        /// <summary>
        /// 银行密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankPassWord;
        /// <summary>
        /// 投资者帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        /// <summary>
        /// 期货密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;
        /// <summary>
        /// 期货公司流水号
        /// </summary>
        public int FutureSerial;
        /// <summary>
        /// 用户标识
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        /// 验证客户证件号码标志
        /// </summary>
        public TThostFtdcYesNoIndicatorType VerifyCertNoFlag;
        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        /// <summary>
        /// 转帐金额
        /// </summary>
        public double TradeAmount;
        /// <summary>
        /// 期货可取金额
        /// </summary>
        public double FutureFetchAmount;
        /// <summary>
        /// 费用支付标志
        /// </summary>
        public TThostFtdcFeePayFlagType FeePayFlag;
        /// <summary>
        /// 应收客户费用
        /// </summary>
        public double CustFee;
        /// <summary>
        /// 应收期货公司费用
        /// </summary>
        public double BrokerFee;
        /// <summary>
        /// 发送方给接收方的消息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string Message;
        /// <summary>
        /// 摘要
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;
        /// <summary>
        /// 银行帐号类型
        /// </summary>
        public TThostFtdcBankAccTypeType BankAccType;
        /// <summary>
        /// 渠道标志
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;
        /// <summary>
        /// 期货单位帐号类型
        /// </summary>
        public TThostFtdcBankAccTypeType BankSecuAccType;
        /// <summary>
        /// 期货公司银行编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;
        /// <summary>
        /// 期货单位帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankSecuAcc;
        /// <summary>
        /// 银行密码标志
        /// </summary>
        public TThostFtdcPwdFlagType BankPwdFlag;
        /// <summary>
        /// 期货资金密码核对标志
        /// </summary>
        public TThostFtdcPwdFlagType SecuPwdFlag;
        /// <summary>
        /// 交易柜员
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;
        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;
        /// <summary>
        /// 交易ID
        /// </summary>
        public int TID;
        /// <summary>
        /// 转账交易状态
        /// </summary>
        public TThostFtdcTransferStatusType TransferStatus;
        /// <summary>
        /// 错误代码
        /// </summary>
        public int ErrorID;
        /// <summary>
        /// 错误信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;
    }

    /// <summary>
    /// 冲正请求
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcReqRepealField
    {
        /// <summary>
        /// 冲正时间间隔
        /// </summary>
        public int RepealTimeInterval;
        /// <summary>
        /// 已经冲正次数
        /// </summary>
        public int RepealedTimes;
        /// <summary>
        /// 银行冲正标志
        /// </summary>
        public TThostFtdcBankRepealFlagType BankRepealFlag;
        /// <summary>
        /// 期商冲正标志
        /// </summary>
        public TThostFtdcBrokerRepealFlagType BrokerRepealFlag;
        /// <summary>
        /// 被冲正平台流水号
        /// </summary>
        public int PlateRepealSerial;
        /// <summary>
        /// 被冲正银行流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankRepealSerial;
        /// <summary>
        /// 被冲正期货流水号
        /// </summary>
        public int FutureRepealSerial;
        /// <summary>
        /// 业务功能码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        /// <summary>
        /// 银行代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        /// <summary>
        /// 银行分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        /// <summary>
        /// 期商代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 期商分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        /// <summary>
        /// 交易日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        /// <summary>
        /// 交易时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        /// <summary>
        /// 银行流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        /// <summary>
        /// 交易系统日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        /// 银期平台消息流水号
        /// </summary>
        public int PlateSerial;
        /// <summary>
        /// 最后分片标志
        /// </summary>
        public TThostFtdcLastFragmentType LastFragment;
        /// <summary>
        /// 会话号
        /// </summary>
        public int SessionID;
        /// <summary>
        /// 客户姓名
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string CustomerName;
        /// <summary>
        /// 证件类型
        /// </summary>
        public TThostFtdcIdCardTypeType IdCardType;
        /// <summary>
        /// 证件号码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;
        /// <summary>
        /// 客户类型
        /// </summary>
        public TThostFtdcCustTypeType CustType;
        /// <summary>
        /// 银行帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;
        /// <summary>
        /// 银行密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankPassWord;
        /// <summary>
        /// 投资者帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        /// <summary>
        /// 期货密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;
        /// <summary>
        /// 期货公司流水号
        /// </summary>
        public int FutureSerial;
        /// <summary>
        /// 用户标识
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        /// 验证客户证件号码标志
        /// </summary>
        public TThostFtdcYesNoIndicatorType VerifyCertNoFlag;
        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        /// <summary>
        /// 转帐金额
        /// </summary>
        public double TradeAmount;
        /// <summary>
        /// 期货可取金额
        /// </summary>
        public double FutureFetchAmount;
        /// <summary>
        /// 费用支付标志
        /// </summary>
        public TThostFtdcFeePayFlagType FeePayFlag;
        /// <summary>
        /// 应收客户费用
        /// </summary>
        public double CustFee;
        /// <summary>
        /// 应收期货公司费用
        /// </summary>
        public double BrokerFee;
        /// <summary>
        /// 发送方给接收方的消息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string Message;
        /// <summary>
        /// 摘要
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;
        /// <summary>
        /// 银行帐号类型
        /// </summary>
        public TThostFtdcBankAccTypeType BankAccType;
        /// <summary>
        /// 渠道标志
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;
        /// <summary>
        /// 期货单位帐号类型
        /// </summary>
        public TThostFtdcBankAccTypeType BankSecuAccType;
        /// <summary>
        /// 期货公司银行编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;
        /// <summary>
        /// 期货单位帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankSecuAcc;
        /// <summary>
        /// 银行密码标志
        /// </summary>
        public TThostFtdcPwdFlagType BankPwdFlag;
        /// <summary>
        /// 期货资金密码核对标志
        /// </summary>
        public TThostFtdcPwdFlagType SecuPwdFlag;
        /// <summary>
        /// 交易柜员
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;
        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;
        /// <summary>
        /// 交易ID
        /// </summary>
        public int TID;
        /// <summary>
        /// 转账交易状态
        /// </summary>
        public TThostFtdcTransferStatusType TransferStatus;
    }

    /// <summary>
    /// 冲正响应
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcRspRepealField
    {
        /// <summary>
        /// 冲正时间间隔
        /// </summary>
        public int RepealTimeInterval;
        /// <summary>
        /// 已经冲正次数
        /// </summary>
        public int RepealedTimes;
        /// <summary>
        /// 银行冲正标志
        /// </summary>
        public TThostFtdcBankRepealFlagType BankRepealFlag;
        /// <summary>
        /// 期商冲正标志
        /// </summary>
        public TThostFtdcBrokerRepealFlagType BrokerRepealFlag;
        /// <summary>
        /// 被冲正平台流水号
        /// </summary>
        public int PlateRepealSerial;
        /// <summary>
        /// 被冲正银行流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankRepealSerial;
        /// <summary>
        /// 被冲正期货流水号
        /// </summary>
        public int FutureRepealSerial;
        /// <summary>
        /// 业务功能码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        /// <summary>
        /// 银行代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        /// <summary>
        /// 银行分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        /// <summary>
        /// 期商代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 期商分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        /// <summary>
        /// 交易日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        /// <summary>
        /// 交易时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        /// <summary>
        /// 银行流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        /// <summary>
        /// 交易系统日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        /// 银期平台消息流水号
        /// </summary>
        public int PlateSerial;
        /// <summary>
        /// 最后分片标志
        /// </summary>
        public TThostFtdcLastFragmentType LastFragment;
        /// <summary>
        /// 会话号
        /// </summary>
        public int SessionID;
        /// <summary>
        /// 客户姓名
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string CustomerName;
        /// <summary>
        /// 证件类型
        /// </summary>
        public TThostFtdcIdCardTypeType IdCardType;
        /// <summary>
        /// 证件号码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;
        /// <summary>
        /// 客户类型
        /// </summary>
        public TThostFtdcCustTypeType CustType;
        /// <summary>
        /// 银行帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;
        /// <summary>
        /// 银行密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankPassWord;
        /// <summary>
        /// 投资者帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        /// <summary>
        /// 期货密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;
        /// <summary>
        /// 期货公司流水号
        /// </summary>
        public int FutureSerial;
        /// <summary>
        /// 用户标识
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        /// 验证客户证件号码标志
        /// </summary>
        public TThostFtdcYesNoIndicatorType VerifyCertNoFlag;
        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        /// <summary>
        /// 转帐金额
        /// </summary>
        public double TradeAmount;
        /// <summary>
        /// 期货可取金额
        /// </summary>
        public double FutureFetchAmount;
        /// <summary>
        /// 费用支付标志
        /// </summary>
        public TThostFtdcFeePayFlagType FeePayFlag;
        /// <summary>
        /// 应收客户费用
        /// </summary>
        public double CustFee;
        /// <summary>
        /// 应收期货公司费用
        /// </summary>
        public double BrokerFee;
        /// <summary>
        /// 发送方给接收方的消息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string Message;
        /// <summary>
        /// 摘要
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;
        /// <summary>
        /// 银行帐号类型
        /// </summary>
        public TThostFtdcBankAccTypeType BankAccType;
        /// <summary>
        /// 渠道标志
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;
        /// <summary>
        /// 期货单位帐号类型
        /// </summary>
        public TThostFtdcBankAccTypeType BankSecuAccType;
        /// <summary>
        /// 期货公司银行编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;
        /// <summary>
        /// 期货单位帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankSecuAcc;
        /// <summary>
        /// 银行密码标志
        /// </summary>
        public TThostFtdcPwdFlagType BankPwdFlag;
        /// <summary>
        /// 期货资金密码核对标志
        /// </summary>
        public TThostFtdcPwdFlagType SecuPwdFlag;
        /// <summary>
        /// 交易柜员
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;
        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;
        /// <summary>
        /// 交易ID
        /// </summary>
        public int TID;
        /// <summary>
        /// 转账交易状态
        /// </summary>
        public TThostFtdcTransferStatusType TransferStatus;
        /// <summary>
        /// 错误代码
        /// </summary>
        public int ErrorID;
        /// <summary>
        /// 错误信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;
    }

    /// <summary>
    /// 查询账户信息请求
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcReqQueryAccountField
    {
        /// <summary>
        /// 业务功能码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        /// <summary>
        /// 银行代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        /// <summary>
        /// 银行分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        /// <summary>
        /// 期商代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 期商分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        /// <summary>
        /// 交易日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        /// <summary>
        /// 交易时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        /// <summary>
        /// 银行流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        /// <summary>
        /// 交易系统日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        /// 银期平台消息流水号
        /// </summary>
        public int PlateSerial;
        /// <summary>
        /// 最后分片标志
        /// </summary>
        public TThostFtdcLastFragmentType LastFragment;
        /// <summary>
        /// 会话号
        /// </summary>
        public int SessionID;
        /// <summary>
        /// 客户姓名
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string CustomerName;
        /// <summary>
        /// 证件类型
        /// </summary>
        public TThostFtdcIdCardTypeType IdCardType;
        /// <summary>
        /// 证件号码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;
        /// <summary>
        /// 客户类型
        /// </summary>
        public TThostFtdcCustTypeType CustType;
        /// <summary>
        /// 银行帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;
        /// <summary>
        /// 银行密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankPassWord;
        /// <summary>
        /// 投资者帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        /// <summary>
        /// 期货密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        /// <summary>
        /// 期货公司流水号
        /// </summary>
        public int FutureSerial;
        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;
        /// <summary>
        /// 用户标识
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        /// 验证客户证件号码标志
        /// </summary>
        public TThostFtdcYesNoIndicatorType VerifyCertNoFlag;
        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        /// <summary>
        /// 摘要
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;
        /// <summary>
        /// 银行帐号类型
        /// </summary>
        public TThostFtdcBankAccTypeType BankAccType;
        /// <summary>
        /// 渠道标志
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;
        /// <summary>
        /// 期货单位帐号类型
        /// </summary>
        public TThostFtdcBankAccTypeType BankSecuAccType;
        /// <summary>
        /// 期货公司银行编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;
        /// <summary>
        /// 期货单位帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankSecuAcc;
        /// <summary>
        /// 银行密码标志
        /// </summary>
        public TThostFtdcPwdFlagType BankPwdFlag;
        /// <summary>
        /// 期货资金密码核对标志
        /// </summary>
        public TThostFtdcPwdFlagType SecuPwdFlag;
        /// <summary>
        /// 交易柜员
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;
        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;
        /// <summary>
        /// 交易ID
        /// </summary>
        public int TID;
    }

    /// <summary>
    /// 查询账户信息响应
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcRspQueryAccountField
    {
        /// <summary>
        /// 业务功能码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        /// <summary>
        /// 银行代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        /// <summary>
        /// 银行分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        /// <summary>
        /// 期商代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 期商分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        /// <summary>
        /// 交易日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        /// <summary>
        /// 交易时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        /// <summary>
        /// 银行流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        /// <summary>
        /// 交易系统日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        /// 银期平台消息流水号
        /// </summary>
        public int PlateSerial;
        /// <summary>
        /// 最后分片标志
        /// </summary>
        public TThostFtdcLastFragmentType LastFragment;
        /// <summary>
        /// 会话号
        /// </summary>
        public int SessionID;
        /// <summary>
        /// 客户姓名
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string CustomerName;
        /// <summary>
        /// 证件类型
        /// </summary>
        public TThostFtdcIdCardTypeType IdCardType;
        /// <summary>
        /// 证件号码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;
        /// <summary>
        /// 客户类型
        /// </summary>
        public TThostFtdcCustTypeType CustType;
        /// <summary>
        /// 银行帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;
        /// <summary>
        /// 银行密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankPassWord;
        /// <summary>
        /// 投资者帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        /// <summary>
        /// 期货密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        /// <summary>
        /// 期货公司流水号
        /// </summary>
        public int FutureSerial;
        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;
        /// <summary>
        /// 用户标识
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        /// 验证客户证件号码标志
        /// </summary>
        public TThostFtdcYesNoIndicatorType VerifyCertNoFlag;
        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        /// <summary>
        /// 摘要
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;
        /// <summary>
        /// 银行帐号类型
        /// </summary>
        public TThostFtdcBankAccTypeType BankAccType;
        /// <summary>
        /// 渠道标志
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;
        /// <summary>
        /// 期货单位帐号类型
        /// </summary>
        public TThostFtdcBankAccTypeType BankSecuAccType;
        /// <summary>
        /// 期货公司银行编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;
        /// <summary>
        /// 期货单位帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankSecuAcc;
        /// <summary>
        /// 银行密码标志
        /// </summary>
        public TThostFtdcPwdFlagType BankPwdFlag;
        /// <summary>
        /// 期货资金密码核对标志
        /// </summary>
        public TThostFtdcPwdFlagType SecuPwdFlag;
        /// <summary>
        /// 交易柜员
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;
        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;
        /// <summary>
        /// 交易ID
        /// </summary>
        public int TID;
        /// <summary>
        /// 银行可用金额
        /// </summary>
        public double BankUseAmount;
        /// <summary>
        /// 银行可取金额
        /// </summary>
        public double BankFetchAmount;
    }

    /// <summary>
    /// 期商签到签退
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcFutureSignIOField
    {
        /// <summary>
        /// 业务功能码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        /// <summary>
        /// 银行代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        /// <summary>
        /// 银行分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        /// <summary>
        /// 期商代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 期商分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        /// <summary>
        /// 交易日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        /// <summary>
        /// 交易时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        /// <summary>
        /// 银行流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        /// <summary>
        /// 交易系统日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        /// 银期平台消息流水号
        /// </summary>
        public int PlateSerial;
        /// <summary>
        /// 最后分片标志
        /// </summary>
        public TThostFtdcLastFragmentType LastFragment;
        /// <summary>
        /// 会话号
        /// </summary>
        public int SessionID;
        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;
        /// <summary>
        /// 用户标识
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        /// 摘要
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;
        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        /// <summary>
        /// 渠道标志
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;
        /// <summary>
        /// 期货公司银行编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;
        /// <summary>
        /// 交易柜员
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;
        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;
        /// <summary>
        /// 交易ID
        /// </summary>
        public int TID;
    }

    /// <summary>
    /// 期商签到响应
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcRspFutureSignInField
    {
        /// <summary>
        /// 业务功能码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        /// <summary>
        /// 银行代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        /// <summary>
        /// 银行分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        /// <summary>
        /// 期商代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 期商分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        /// <summary>
        /// 交易日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        /// <summary>
        /// 交易时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        /// <summary>
        /// 银行流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        /// <summary>
        /// 交易系统日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        /// 银期平台消息流水号
        /// </summary>
        public int PlateSerial;
        /// <summary>
        /// 最后分片标志
        /// </summary>
        public TThostFtdcLastFragmentType LastFragment;
        /// <summary>
        /// 会话号
        /// </summary>
        public int SessionID;
        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;
        /// <summary>
        /// 用户标识
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        /// 摘要
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;
        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        /// <summary>
        /// 渠道标志
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;
        /// <summary>
        /// 期货公司银行编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;
        /// <summary>
        /// 交易柜员
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;
        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;
        /// <summary>
        /// 交易ID
        /// </summary>
        public int TID;
        /// <summary>
        /// 错误代码
        /// </summary>
        public int ErrorID;
        /// <summary>
        /// 错误信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;
        /// <summary>
        /// PIN密钥
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string PinKey;
        /// <summary>
        /// MAC密钥
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string MacKey;
    }

    /// <summary>
    /// 期商签退请求
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcReqFutureSignOutField
    {
        /// <summary>
        /// 业务功能码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        /// <summary>
        /// 银行代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        /// <summary>
        /// 银行分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        /// <summary>
        /// 期商代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 期商分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        /// <summary>
        /// 交易日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        /// <summary>
        /// 交易时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        /// <summary>
        /// 银行流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        /// <summary>
        /// 交易系统日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        /// 银期平台消息流水号
        /// </summary>
        public int PlateSerial;
        /// <summary>
        /// 最后分片标志
        /// </summary>
        public TThostFtdcLastFragmentType LastFragment;
        /// <summary>
        /// 会话号
        /// </summary>
        public int SessionID;
        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;
        /// <summary>
        /// 用户标识
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        /// 摘要
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;
        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        /// <summary>
        /// 渠道标志
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;
        /// <summary>
        /// 期货公司银行编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;
        /// <summary>
        /// 交易柜员
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;
        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;
        /// <summary>
        /// 交易ID
        /// </summary>
        public int TID;
    }

    /// <summary>
    /// 期商签退响应
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcRspFutureSignOutField
    {
        /// <summary>
        /// 业务功能码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        /// <summary>
        /// 银行代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        /// <summary>
        /// 银行分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        /// <summary>
        /// 期商代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 期商分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        /// <summary>
        /// 交易日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        /// <summary>
        /// 交易时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        /// <summary>
        /// 银行流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        /// <summary>
        /// 交易系统日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        /// 银期平台消息流水号
        /// </summary>
        public int PlateSerial;
        /// <summary>
        /// 最后分片标志
        /// </summary>
        public TThostFtdcLastFragmentType LastFragment;
        /// <summary>
        /// 会话号
        /// </summary>
        public int SessionID;
        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;
        /// <summary>
        /// 用户标识
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        /// 摘要
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;
        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        /// <summary>
        /// 渠道标志
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;
        /// <summary>
        /// 期货公司银行编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;
        /// <summary>
        /// 交易柜员
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;
        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;
        /// <summary>
        /// 交易ID
        /// </summary>
        public int TID;
        /// <summary>
        /// 错误代码
        /// </summary>
        public int ErrorID;
        /// <summary>
        /// 错误信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;
    }

    /// <summary>
    /// 查询指定流水号的交易结果请求
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcReqQueryTradeResultBySerialField
    {
        /// <summary>
        /// 业务功能码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        /// <summary>
        /// 银行代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        /// <summary>
        /// 银行分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        /// <summary>
        /// 期商代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 期商分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        /// <summary>
        /// 交易日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        /// <summary>
        /// 交易时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        /// <summary>
        /// 银行流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        /// <summary>
        /// 交易系统日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        /// 银期平台消息流水号
        /// </summary>
        public int PlateSerial;
        /// <summary>
        /// 最后分片标志
        /// </summary>
        public TThostFtdcLastFragmentType LastFragment;
        /// <summary>
        /// 会话号
        /// </summary>
        public int SessionID;
        /// <summary>
        /// 流水号
        /// </summary>
        public int Reference;
        /// <summary>
        /// 本流水号发布者的机构类型
        /// </summary>
        public TThostFtdcInstitutionTypeType RefrenceIssureType;
        /// <summary>
        /// 本流水号发布者机构编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string RefrenceIssure;
        /// <summary>
        /// 客户姓名
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string CustomerName;
        /// <summary>
        /// 证件类型
        /// </summary>
        public TThostFtdcIdCardTypeType IdCardType;
        /// <summary>
        /// 证件号码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;
        /// <summary>
        /// 客户类型
        /// </summary>
        public TThostFtdcCustTypeType CustType;
        /// <summary>
        /// 银行帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;
        /// <summary>
        /// 银行密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankPassWord;
        /// <summary>
        /// 投资者帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        /// <summary>
        /// 期货密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        /// <summary>
        /// 转帐金额
        /// </summary>
        public double TradeAmount;
        /// <summary>
        /// 摘要
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;
    }

    /// <summary>
    /// 查询指定流水号的交易结果响应
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcRspQueryTradeResultBySerialField
    {
        /// <summary>
        /// 业务功能码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        /// <summary>
        /// 银行代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        /// <summary>
        /// 银行分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        /// <summary>
        /// 期商代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 期商分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        /// <summary>
        /// 交易日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        /// <summary>
        /// 交易时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        /// <summary>
        /// 银行流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        /// <summary>
        /// 交易系统日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        /// 银期平台消息流水号
        /// </summary>
        public int PlateSerial;
        /// <summary>
        /// 最后分片标志
        /// </summary>
        public TThostFtdcLastFragmentType LastFragment;
        /// <summary>
        /// 会话号
        /// </summary>
        public int SessionID;
        /// <summary>
        /// 错误代码
        /// </summary>
        public int ErrorID;
        /// <summary>
        /// 错误信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;
        /// <summary>
        /// 流水号
        /// </summary>
        public int Reference;
        /// <summary>
        /// 本流水号发布者的机构类型
        /// </summary>
        public TThostFtdcInstitutionTypeType RefrenceIssureType;
        /// <summary>
        /// 本流水号发布者机构编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string RefrenceIssure;
        /// <summary>
        /// 原始返回代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string OriginReturnCode;
        /// <summary>
        /// 原始返回码描述
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string OriginDescrInfoForReturnCode;
        /// <summary>
        /// 银行帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;
        /// <summary>
        /// 银行密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankPassWord;
        /// <summary>
        /// 投资者帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        /// <summary>
        /// 期货密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        /// <summary>
        /// 转帐金额
        /// </summary>
        public double TradeAmount;
        /// <summary>
        /// 摘要
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;
    }

    /// <summary>
    /// 日终文件就绪请求
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcReqDayEndFileReadyField
    {
        /// <summary>
        /// 业务功能码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        /// <summary>
        /// 银行代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        /// <summary>
        /// 银行分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        /// <summary>
        /// 期商代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 期商分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        /// <summary>
        /// 交易日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        /// <summary>
        /// 交易时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        /// <summary>
        /// 银行流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        /// <summary>
        /// 交易系统日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        /// 银期平台消息流水号
        /// </summary>
        public int PlateSerial;
        /// <summary>
        /// 最后分片标志
        /// </summary>
        public TThostFtdcLastFragmentType LastFragment;
        /// <summary>
        /// 会话号
        /// </summary>
        public int SessionID;
        /// <summary>
        /// 文件业务功能
        /// </summary>
        public TThostFtdcFileBusinessCodeType FileBusinessCode;
        /// <summary>
        /// 摘要
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;
    }

    /// <summary>
    /// 返回结果
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcReturnResultField
    {
        /// <summary>
        /// 返回代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string ReturnCode;
        /// <summary>
        /// 返回码描述
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string DescrInfoForReturnCode;
    }

    /// <summary>
    /// 验证期货资金密码
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcVerifyFuturePasswordField
    {
        /// <summary>
        /// 业务功能码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        /// <summary>
        /// 银行代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        /// <summary>
        /// 银行分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        /// <summary>
        /// 期商代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 期商分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        /// <summary>
        /// 交易日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        /// <summary>
        /// 交易时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        /// <summary>
        /// 银行流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        /// <summary>
        /// 交易系统日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        /// 银期平台消息流水号
        /// </summary>
        public int PlateSerial;
        /// <summary>
        /// 最后分片标志
        /// </summary>
        public TThostFtdcLastFragmentType LastFragment;
        /// <summary>
        /// 会话号
        /// </summary>
        public int SessionID;
        /// <summary>
        /// 投资者帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        /// <summary>
        /// 期货密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        /// <summary>
        /// 银行帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;
        /// <summary>
        /// 银行密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankPassWord;
        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;
        /// <summary>
        /// 交易ID
        /// </summary>
        public int TID;
    }

    /// <summary>
    /// 验证客户信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcVerifyCustInfoField
    {
        /// <summary>
        /// 客户姓名
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string CustomerName;
        /// <summary>
        /// 证件类型
        /// </summary>
        public TThostFtdcIdCardTypeType IdCardType;
        /// <summary>
        /// 证件号码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;
        /// <summary>
        /// 客户类型
        /// </summary>
        public TThostFtdcCustTypeType CustType;
    }

    /// <summary>
    /// 验证期货资金密码和客户信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcVerifyFuturePasswordAndCustInfoField
    {
        /// <summary>
        /// 客户姓名
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string CustomerName;
        /// <summary>
        /// 证件类型
        /// </summary>
        public TThostFtdcIdCardTypeType IdCardType;
        /// <summary>
        /// 证件号码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;
        /// <summary>
        /// 客户类型
        /// </summary>
        public TThostFtdcCustTypeType CustType;
        /// <summary>
        /// 投资者帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        /// <summary>
        /// 期货密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
    }

    /// <summary>
    /// 验证期货资金密码和客户信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcDepositResultInformField
    {
        /// <summary>
        /// 出入金流水号，该流水号为银期报盘返回的流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
        public string DepositSeqNo;
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        /// 入金金额
        /// </summary>
        public double Deposit;
        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;
        /// <summary>
        /// 返回代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string ReturnCode;
        /// <summary>
        /// 返回码描述
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string DescrInfoForReturnCode;
    }

    /// <summary>
    /// 交易核心向银期报盘发出密钥同步请求
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcReqSyncKeyField
    {
        /// <summary>
        /// 业务功能码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        /// <summary>
        /// 银行代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        /// <summary>
        /// 银行分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        /// <summary>
        /// 期商代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 期商分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        /// <summary>
        /// 交易日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        /// <summary>
        /// 交易时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        /// <summary>
        /// 银行流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        /// <summary>
        /// 交易系统日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        /// 银期平台消息流水号
        /// </summary>
        public int PlateSerial;
        /// <summary>
        /// 最后分片标志
        /// </summary>
        public TThostFtdcLastFragmentType LastFragment;
        /// <summary>
        /// 会话号
        /// </summary>
        public int SessionID;
        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;
        /// <summary>
        /// 用户标识
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        /// 交易核心给银期报盘的消息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string Message;
        /// <summary>
        /// 渠道标志
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;
        /// <summary>
        /// 期货公司银行编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;
        /// <summary>
        /// 交易柜员
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;
        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;
        /// <summary>
        /// 交易ID
        /// </summary>
        public int TID;
    }

    /// <summary>
    /// 交易核心向银期报盘发出密钥同步响应
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcRspSyncKeyField
    {
        /// <summary>
        /// 业务功能码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        /// <summary>
        /// 银行代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        /// <summary>
        /// 银行分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        /// <summary>
        /// 期商代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 期商分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        /// <summary>
        /// 交易日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        /// <summary>
        /// 交易时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        /// <summary>
        /// 银行流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        /// <summary>
        /// 交易系统日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        /// 银期平台消息流水号
        /// </summary>
        public int PlateSerial;
        /// <summary>
        /// 最后分片标志
        /// </summary>
        public TThostFtdcLastFragmentType LastFragment;
        /// <summary>
        /// 会话号
        /// </summary>
        public int SessionID;
        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;
        /// <summary>
        /// 用户标识
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        /// 交易核心给银期报盘的消息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string Message;
        /// <summary>
        /// 渠道标志
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;
        /// <summary>
        /// 期货公司银行编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;
        /// <summary>
        /// 交易柜员
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;
        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;
        /// <summary>
        /// 交易ID
        /// </summary>
        public int TID;
        /// <summary>
        /// 错误代码
        /// </summary>
        public int ErrorID;
        /// <summary>
        /// 错误信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;
    }

    /// <summary>
    /// 查询账户信息通知
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcNotifyQueryAccountField
    {
        /// <summary>
        /// 业务功能码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        /// <summary>
        /// 银行代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        /// <summary>
        /// 银行分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        /// <summary>
        /// 期商代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 期商分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        /// <summary>
        /// 交易日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        /// <summary>
        /// 交易时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        /// <summary>
        /// 银行流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        /// <summary>
        /// 交易系统日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        /// 银期平台消息流水号
        /// </summary>
        public int PlateSerial;
        /// <summary>
        /// 最后分片标志
        /// </summary>
        public TThostFtdcLastFragmentType LastFragment;
        /// <summary>
        /// 会话号
        /// </summary>
        public int SessionID;
        /// <summary>
        /// 客户姓名
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string CustomerName;
        /// <summary>
        /// 证件类型
        /// </summary>
        public TThostFtdcIdCardTypeType IdCardType;
        /// <summary>
        /// 证件号码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;
        /// <summary>
        /// 客户类型
        /// </summary>
        public TThostFtdcCustTypeType CustType;
        /// <summary>
        /// 银行帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;
        /// <summary>
        /// 银行密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankPassWord;
        /// <summary>
        /// 投资者帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        /// <summary>
        /// 期货密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        /// <summary>
        /// 期货公司流水号
        /// </summary>
        public int FutureSerial;
        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;
        /// <summary>
        /// 用户标识
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        /// 验证客户证件号码标志
        /// </summary>
        public TThostFtdcYesNoIndicatorType VerifyCertNoFlag;
        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        /// <summary>
        /// 摘要
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;
        /// <summary>
        /// 银行帐号类型
        /// </summary>
        public TThostFtdcBankAccTypeType BankAccType;
        /// <summary>
        /// 渠道标志
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;
        /// <summary>
        /// 期货单位帐号类型
        /// </summary>
        public TThostFtdcBankAccTypeType BankSecuAccType;
        /// <summary>
        /// 期货公司银行编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;
        /// <summary>
        /// 期货单位帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankSecuAcc;
        /// <summary>
        /// 银行密码标志
        /// </summary>
        public TThostFtdcPwdFlagType BankPwdFlag;
        /// <summary>
        /// 期货资金密码核对标志
        /// </summary>
        public TThostFtdcPwdFlagType SecuPwdFlag;
        /// <summary>
        /// 交易柜员
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;
        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;
        /// <summary>
        /// 交易ID
        /// </summary>
        public int TID;
        /// <summary>
        /// 银行可用金额
        /// </summary>
        public double BankUseAmount;
        /// <summary>
        /// 银行可取金额
        /// </summary>
        public double BankFetchAmount;
        /// <summary>
        /// 错误代码
        /// </summary>
        public int ErrorID;
        /// <summary>
        /// 错误信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;
    }

    /// <summary>
    /// 银期转账交易流水表
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcTransferSerialField
    {
        /// <summary>
        /// 平台流水号
        /// </summary>
        public int PlateSerial;
        /// <summary>
        /// 交易发起方日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        /// <summary>
        /// 交易日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        /// 交易时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        /// <summary>
        /// 交易代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        /// <summary>
        /// 会话编号
        /// </summary>
        public int SessionID;
        /// <summary>
        /// 银行编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        /// <summary>
        /// 银行分支机构编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        /// <summary>
        /// 银行帐号类型
        /// </summary>
        public TThostFtdcBankAccTypeType BankAccType;
        /// <summary>
        /// 银行帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;
        /// <summary>
        /// 银行流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        /// <summary>
        /// 期货公司编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 期商分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        /// <summary>
        /// 期货公司帐号类型
        /// </summary>
        public TThostFtdcFutureAccTypeType FutureAccType;
        /// <summary>
        /// 投资者帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        /// 期货公司流水号
        /// </summary>
        public int FutureSerial;
        /// <summary>
        /// 证件类型
        /// </summary>
        public TThostFtdcIdCardTypeType IdCardType;
        /// <summary>
        /// 证件号码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;
        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        /// <summary>
        /// 交易金额
        /// </summary>
        public double TradeAmount;
        /// <summary>
        /// 应收客户费用
        /// </summary>
        public double CustFee;
        /// <summary>
        /// 应收期货公司费用
        /// </summary>
        public double BrokerFee;
        /// <summary>
        /// 有效标志
        /// </summary>
        public TThostFtdcAvailabilityFlagType AvailabilityFlag;
        /// <summary>
        /// 操作员
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperatorCode;
        /// <summary>
        /// 新银行帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankNewAccount;
        /// <summary>
        /// 错误代码
        /// </summary>
        public int ErrorID;
        /// <summary>
        /// 错误信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;
    }

    /// <summary>
    /// 请求查询转帐流水
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryTransferSerialField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        /// <summary>
        /// 银行编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
    }

    /// <summary>
    /// 期商签到通知
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcNotifyFutureSignInField
    {
        /// <summary>
        /// 业务功能码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        /// <summary>
        /// 银行代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        /// <summary>
        /// 银行分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        /// <summary>
        /// 期商代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 期商分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        /// <summary>
        /// 交易日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        /// <summary>
        /// 交易时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        /// <summary>
        /// 银行流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        /// <summary>
        /// 交易系统日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        /// 银期平台消息流水号
        /// </summary>
        public int PlateSerial;
        /// <summary>
        /// 最后分片标志
        /// </summary>
        public TThostFtdcLastFragmentType LastFragment;
        /// <summary>
        /// 会话号
        /// </summary>
        public int SessionID;
        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;
        /// <summary>
        /// 用户标识
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        /// 摘要
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;
        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        /// <summary>
        /// 渠道标志
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;
        /// <summary>
        /// 期货公司银行编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;
        /// <summary>
        /// 交易柜员
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;
        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;
        /// <summary>
        /// 交易ID
        /// </summary>
        public int TID;
        /// <summary>
        /// 错误代码
        /// </summary>
        public int ErrorID;
        /// <summary>
        /// 错误信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;
        /// <summary>
        /// PIN密钥
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string PinKey;
        /// <summary>
        /// MAC密钥
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string MacKey;
    }

    /// <summary>
    /// 期商签退通知
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcNotifyFutureSignOutField
    {
        /// <summary>
        /// 业务功能码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        /// <summary>
        /// 银行代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        /// <summary>
        /// 银行分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        /// <summary>
        /// 期商代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 期商分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        /// <summary>
        /// 交易日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        /// <summary>
        /// 交易时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        /// <summary>
        /// 银行流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        /// <summary>
        /// 交易系统日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        /// 银期平台消息流水号
        /// </summary>
        public int PlateSerial;
        /// <summary>
        /// 最后分片标志
        /// </summary>
        public TThostFtdcLastFragmentType LastFragment;
        /// <summary>
        /// 会话号
        /// </summary>
        public int SessionID;
        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;
        /// <summary>
        /// 用户标识
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        /// 摘要
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;
        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        /// <summary>
        /// 渠道标志
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;
        /// <summary>
        /// 期货公司银行编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;
        /// <summary>
        /// 交易柜员
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;
        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;
        /// <summary>
        /// 交易ID
        /// </summary>
        public int TID;
        /// <summary>
        /// 错误代码
        /// </summary>
        public int ErrorID;
        /// <summary>
        /// 错误信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;
    }

    /// <summary>
    /// 交易核心向银期报盘发出密钥同步处理结果的通知
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcNotifySyncKeyField
    {
        /// <summary>
        /// 业务功能码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        /// <summary>
        /// 银行代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        /// <summary>
        /// 银行分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        /// <summary>
        /// 期商代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 期商分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        /// <summary>
        /// 交易日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        /// <summary>
        /// 交易时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        /// <summary>
        /// 银行流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        /// <summary>
        /// 交易系统日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        /// 银期平台消息流水号
        /// </summary>
        public int PlateSerial;
        /// <summary>
        /// 最后分片标志
        /// </summary>
        public TThostFtdcLastFragmentType LastFragment;
        /// <summary>
        /// 会话号
        /// </summary>
        public int SessionID;
        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;
        /// <summary>
        /// 用户标识
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        /// 交易核心给银期报盘的消息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string Message;
        /// <summary>
        /// 渠道标志
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;
        /// <summary>
        /// 期货公司银行编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;
        /// <summary>
        /// 交易柜员
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;
        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;
        /// <summary>
        /// 交易ID
        /// </summary>
        public int TID;
        /// <summary>
        /// 错误代码
        /// </summary>
        public int ErrorID;
        /// <summary>
        /// 错误信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;
    }

    /// <summary>
    /// 请求查询银期签约关系
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryAccountregisterField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 投资者帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        /// <summary>
        /// 银行编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
    }

    /// <summary>
    /// 客户开销户信息表
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcAccountregisterField
    {
        /// <summary>
        /// 交易日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDay;
        /// <summary>
        /// 银行编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        /// <summary>
        /// 银行分支机构编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        /// <summary>
        /// 银行帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;
        /// <summary>
        /// 期货公司编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 期货公司分支机构编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        /// <summary>
        /// 投资者帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        /// <summary>
        /// 证件类型
        /// </summary>
        public TThostFtdcIdCardTypeType IdCardType;
        /// <summary>
        /// 证件号码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;
        /// <summary>
        /// 客户姓名
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string CustomerName;
        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        /// <summary>
        /// 开销户类别
        /// </summary>
        public TThostFtdcOpenOrDestroyType OpenOrDestroy;
        /// <summary>
        /// 签约日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string RegDate;
        /// <summary>
        /// 解约日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string OutDate;
        /// <summary>
        /// 交易ID
        /// </summary>
        public int TID;
        /// <summary>
        /// 客户类型
        /// </summary>
        public TThostFtdcCustTypeType CustType;
        /// <summary>
        /// 银行帐号类型
        /// </summary>
        public TThostFtdcBankAccTypeType BankAccType;
    }

    /// <summary>
    /// 银期开户信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcOpenAccountField
    {
        /// <summary>
        /// 业务功能码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        /// <summary>
        /// 银行代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        /// <summary>
        /// 银行分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        /// <summary>
        /// 期商代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 期商分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        /// <summary>
        /// 交易日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        /// <summary>
        /// 交易时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        /// <summary>
        /// 银行流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        /// <summary>
        /// 交易系统日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        /// 银期平台消息流水号
        /// </summary>
        public int PlateSerial;
        /// <summary>
        /// 最后分片标志
        /// </summary>
        public TThostFtdcLastFragmentType LastFragment;
        /// <summary>
        /// 会话号
        /// </summary>
        public int SessionID;
        /// <summary>
        /// 客户姓名
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string CustomerName;
        /// <summary>
        /// 证件类型
        /// </summary>
        public TThostFtdcIdCardTypeType IdCardType;
        /// <summary>
        /// 证件号码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;
        /// <summary>
        /// 性别
        /// </summary>
        public TThostFtdcGenderType Gender;
        /// <summary>
        /// 国家代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string CountryCode;
        /// <summary>
        /// 客户类型
        /// </summary>
        public TThostFtdcCustTypeType CustType;
        /// <summary>
        /// 地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
        public string Address;
        /// <summary>
        /// 邮编
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string ZipCode;
        /// <summary>
        /// 电话号码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Telephone;
        /// <summary>
        /// 手机
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MobilePhone;
        /// <summary>
        /// 传真
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Fax;
        /// <summary>
        /// 电子邮件
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string EMail;
        /// <summary>
        /// 资金账户状态
        /// </summary>
        public TThostFtdcMoneyAccountStatusType MoneyAccountStatus;
        /// <summary>
        /// 银行帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;
        /// <summary>
        /// 银行密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankPassWord;
        /// <summary>
        /// 投资者帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        /// <summary>
        /// 期货密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;
        /// <summary>
        /// 验证客户证件号码标志
        /// </summary>
        public TThostFtdcYesNoIndicatorType VerifyCertNoFlag;
        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        /// <summary>
        /// 汇钞标志
        /// </summary>
        public TThostFtdcCashExchangeCodeType CashExchangeCode;
        /// <summary>
        /// 摘要
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;
        /// <summary>
        /// 银行帐号类型
        /// </summary>
        public TThostFtdcBankAccTypeType BankAccType;
        /// <summary>
        /// 渠道标志
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;
        /// <summary>
        /// 期货单位帐号类型
        /// </summary>
        public TThostFtdcBankAccTypeType BankSecuAccType;
        /// <summary>
        /// 期货公司银行编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;
        /// <summary>
        /// 期货单位帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankSecuAcc;
        /// <summary>
        /// 银行密码标志
        /// </summary>
        public TThostFtdcPwdFlagType BankPwdFlag;
        /// <summary>
        /// 期货资金密码核对标志
        /// </summary>
        public TThostFtdcPwdFlagType SecuPwdFlag;
        /// <summary>
        /// 交易柜员
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;
        /// <summary>
        /// 交易ID
        /// </summary>
        public int TID;
        /// <summary>
        /// 错误代码
        /// </summary>
        public int ErrorID;
        /// <summary>
        /// 错误信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;
    }

    /// <summary>
    /// 银期销户信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcCancelAccountField
    {
        /// <summary>
        /// 业务功能码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        /// <summary>
        /// 银行代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        /// <summary>
        /// 银行分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        /// <summary>
        /// 期商代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 期商分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        /// <summary>
        /// 交易日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        /// <summary>
        /// 交易时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        /// <summary>
        /// 银行流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        /// <summary>
        /// 交易系统日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        /// 银期平台消息流水号
        /// </summary>
        public int PlateSerial;
        /// <summary>
        /// 最后分片标志
        /// </summary>
        public TThostFtdcLastFragmentType LastFragment;
        /// <summary>
        /// 会话号
        /// </summary>
        public int SessionID;
        /// <summary>
        /// 客户姓名
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string CustomerName;
        /// <summary>
        /// 证件类型
        /// </summary>
        public TThostFtdcIdCardTypeType IdCardType;
        /// <summary>
        /// 证件号码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;
        /// <summary>
        /// 性别
        /// </summary>
        public TThostFtdcGenderType Gender;
        /// <summary>
        /// 国家代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string CountryCode;
        /// <summary>
        /// 客户类型
        /// </summary>
        public TThostFtdcCustTypeType CustType;
        /// <summary>
        /// 地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
        public string Address;
        /// <summary>
        /// 邮编
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string ZipCode;
        /// <summary>
        /// 电话号码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Telephone;
        /// <summary>
        /// 手机
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MobilePhone;
        /// <summary>
        /// 传真
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Fax;
        /// <summary>
        /// 电子邮件
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string EMail;
        /// <summary>
        /// 资金账户状态
        /// </summary>
        public TThostFtdcMoneyAccountStatusType MoneyAccountStatus;
        /// <summary>
        /// 银行帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;
        /// <summary>
        /// 银行密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankPassWord;
        /// <summary>
        /// 投资者帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        /// <summary>
        /// 期货密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;
        /// <summary>
        /// 验证客户证件号码标志
        /// </summary>
        public TThostFtdcYesNoIndicatorType VerifyCertNoFlag;
        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        /// <summary>
        /// 汇钞标志
        /// </summary>
        public TThostFtdcCashExchangeCodeType CashExchangeCode;
        /// <summary>
        /// 摘要
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;
        /// <summary>
        /// 银行帐号类型
        /// </summary>
        public TThostFtdcBankAccTypeType BankAccType;
        /// <summary>
        /// 渠道标志
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;
        /// <summary>
        /// 期货单位帐号类型
        /// </summary>
        public TThostFtdcBankAccTypeType BankSecuAccType;
        /// <summary>
        /// 期货公司银行编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;
        /// <summary>
        /// 期货单位帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankSecuAcc;
        /// <summary>
        /// 银行密码标志
        /// </summary>
        public TThostFtdcPwdFlagType BankPwdFlag;
        /// <summary>
        /// 期货资金密码核对标志
        /// </summary>
        public TThostFtdcPwdFlagType SecuPwdFlag;
        /// <summary>
        /// 交易柜员
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;
        /// <summary>
        /// 交易ID
        /// </summary>
        public int TID;
        /// <summary>
        /// 错误代码
        /// </summary>
        public int ErrorID;
        /// <summary>
        /// 错误信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;
    }

    /// <summary>
    /// 银期变更银行账号信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcChangeAccountField
    {
        /// <summary>
        /// 业务功能码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        /// <summary>
        /// 银行代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        /// <summary>
        /// 银行分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        /// <summary>
        /// 期商代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 期商分支机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        /// <summary>
        /// 交易日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        /// <summary>
        /// 交易时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        /// <summary>
        /// 银行流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        /// <summary>
        /// 交易系统日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        /// 银期平台消息流水号
        /// </summary>
        public int PlateSerial;
        /// <summary>
        /// 最后分片标志
        /// </summary>
        public TThostFtdcLastFragmentType LastFragment;
        /// <summary>
        /// 会话号
        /// </summary>
        public int SessionID;
        /// <summary>
        /// 客户姓名
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string CustomerName;
        /// <summary>
        /// 证件类型
        /// </summary>
        public TThostFtdcIdCardTypeType IdCardType;
        /// <summary>
        /// 证件号码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;
        /// <summary>
        /// 性别
        /// </summary>
        public TThostFtdcGenderType Gender;
        /// <summary>
        /// 国家代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string CountryCode;
        /// <summary>
        /// 客户类型
        /// </summary>
        public TThostFtdcCustTypeType CustType;
        /// <summary>
        /// 地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
        public string Address;
        /// <summary>
        /// 邮编
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string ZipCode;
        /// <summary>
        /// 电话号码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Telephone;
        /// <summary>
        /// 手机
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MobilePhone;
        /// <summary>
        /// 传真
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Fax;
        /// <summary>
        /// 电子邮件
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string EMail;
        /// <summary>
        /// 资金账户状态
        /// </summary>
        public TThostFtdcMoneyAccountStatusType MoneyAccountStatus;
        /// <summary>
        /// 银行帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;
        /// <summary>
        /// 银行密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankPassWord;
        /// <summary>
        /// 新银行帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string NewBankAccount;
        /// <summary>
        /// 新银行密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string NewBankPassWord;
        /// <summary>
        /// 投资者帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        /// <summary>
        /// 期货密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        /// <summary>
        /// 银行帐号类型
        /// </summary>
        public TThostFtdcBankAccTypeType BankAccType;
        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;
        /// <summary>
        /// 验证客户证件号码标志
        /// </summary>
        public TThostFtdcYesNoIndicatorType VerifyCertNoFlag;
        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        /// <summary>
        /// 期货公司银行编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;
        /// <summary>
        /// 银行密码标志
        /// </summary>
        public TThostFtdcPwdFlagType BankPwdFlag;
        /// <summary>
        /// 期货资金密码核对标志
        /// </summary>
        public TThostFtdcPwdFlagType SecuPwdFlag;
        /// <summary>
        /// 交易ID
        /// </summary>
        public int TID;
        /// <summary>
        /// 摘要
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;
        /// <summary>
        /// 错误代码
        /// </summary>
        public int ErrorID;
        /// <summary>
        /// 错误信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;
    }

    /// <summary>
    /// 灾备中心交易权限
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcUserRightsAssignField
    {
        /// <summary>
        /// 应用单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        /// 交易中心代码
        /// </summary>
        public int DRIdentityID;
    }

    /// <summary>
    /// 经济公司是否有在本标示的交易权限
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcBrokerUserRightAssignField
    {
        /// <summary>
        /// 应用单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        /// 交易中心代码
        /// </summary>
        public int DRIdentityID;
        /// <summary>
        /// 能否交易
        /// </summary>
        public int Tradeable;
    }

    /// <summary>
    /// 灾备交易转换报文
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcDRTransferField
    {
        /// <summary>
        /// 原交易中心代码
        /// </summary>
        public int OrigDRIdentityID;
        /// <summary>
        /// 目标交易中心代码
        /// </summary>
        public int DestDRIdentityID;
        /// <summary>
        /// 原应用单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string OrigBrokerID;
        /// <summary>
        /// 目标易用单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string DestBrokerID;
    }
}
