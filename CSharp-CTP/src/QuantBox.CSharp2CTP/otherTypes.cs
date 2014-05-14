
namespace QuantBox.CSharp2CTP
{
    public enum THOST_TE_RESUME_TYPE
    {
        THOST_TERT_RESTART = 0,
        THOST_TERT_RESUME,
        THOST_TERT_QUICK
    };

    //枚举不能以数字开头，所以3DES被改成了DES3
    /// <summary>
    /// TFtdcFBTEncryModeType是一个加密方式类型
    /// </summary>
    public enum TThostFtdcFBTEncryModeType : byte
    {
        /// <summary>
        /// 不加密
        /// </summary>
        NoEncry = (byte)'0',

        /// <summary>
        /// DES
        /// </summary>
        DES = (byte)'1',

        /// <summary>
        /// 3DES
        /// </summary>
        DES3 = (byte)'2'
    }

    //原文件是直接将'102001'放到char类型中，转换后不行了，在实际使用时得注意此处
    /// <summary>
    /// TFtdcFBTTradeCodeEnumType是一个银期交易代码枚举类型
    /// </summary>
    public enum TThostFtdcFBTTradeCodeEnumType : byte
    {
        /// <summary>
        /// 银行发起银行转期货
        /// </summary>
        BankLaunchBankToBroker = (byte)'0',//'102001',

        /// <summary>
        /// 期货发起银行转期货
        /// </summary>
        BrokerLaunchBankToBroker = (byte)'1',//'202001',

        /// <summary>
        /// 银行发起期货转银行
        /// </summary>
        BankLaunchBrokerToBank = (byte)'2',//'102002',

        /// <summary>
        /// 期货发起期货转银行
        /// </summary>
        BrokerLaunchBrokerToBank = (byte)'3'//'202002'
    }

    /// <summary>
    /// TFtdcVirementTradeCodeType是一个交易代码类型
    /// </summary>
    public enum TThostFtdcVirementTradeCodeType : byte
    {
        /// <summary>
        /// 银行发起银行资金转期货
        /// </summary>
        BankBankToFuture = (byte)'0',//'102001',

        /// <summary>
        /// 银行发起期货资金转银行
        /// </summary>
        BankFutureToBank = (byte)'1',//'102002',

        /// <summary>
        /// 期货发起银行资金转期货
        /// </summary>
        FutureBankToFuture = (byte)'2',//'202001',

        /// <summary>
        /// 期货发起期货资金转银行
        /// </summary>
        FutureFutureToBank = (byte)'3'//'202002'
    }
}
