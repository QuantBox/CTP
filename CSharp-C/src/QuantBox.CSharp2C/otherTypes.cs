
namespace QuantBox.CSharp2C
{
    //自己定义的
    public enum ConnectionStatus
    {
        E_uninit,		//未初始化
        E_inited,		//已经初始化
        E_unconnected,	//连接已经断开
        E_connecting,	//连接中
        E_connected,	//连接成功
        E_authing,		//授权中
        E_authed,		//授权成功
        E_logining,		//登录中
        E_logined,		//登录成功
        E_confirming,	//确认中
        E_confirmed,	//已经确认
        E_conn_max		//最大值
    };

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
}
