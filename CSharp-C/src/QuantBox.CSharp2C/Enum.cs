
namespace QuantBox.CSharp2C
{
    /// <summary>
    /// TFtdcExchangePropertyType是一个交易所属性类型
    /// </summary>
    public enum TThostFtdcExchangePropertyType : byte
    {
        /// <summary>
        /// 正常
        /// </summary>
        Normal = (byte)'0',

        /// <summary>
        /// 根据成交生成报单
        /// </summary>
        GenOrderByTrade = (byte)'1'
    }

    /// <summary>
    /// TFtdcIdCardTypeType是一个证件类型类型
    /// </summary>
    public enum TThostFtdcIdCardTypeType : byte
    {
        /// <summary>
        /// 组织机构代码
        /// </summary>
        EID = (byte)'0',

        /// <summary>
        /// 身份证
        /// </summary>
        IDCard = (byte)'1',

        /// <summary>
        /// 军官证
        /// </summary>
        OfficerIDCard = (byte)'2',

        /// <summary>
        /// 警官证
        /// </summary>
        PoliceIDCard = (byte)'3',

        /// <summary>
        /// 士兵证
        /// </summary>
        SoldierIDCard = (byte)'4',

        /// <summary>
        /// 户口簿
        /// </summary>
        HouseholdRegister = (byte)'5',

        /// <summary>
        /// 护照
        /// </summary>
        Passport = (byte)'6',

        /// <summary>
        /// 台胞证
        /// </summary>
        TaiwanCompatriotIDCard = (byte)'7',

        /// <summary>
        /// 回乡证
        /// </summary>
        HomeComingCard = (byte)'8',

        /// <summary>
        /// 营业执照号
        /// </summary>
        LicenseNo = (byte)'9',

        /// <summary>
        /// 税务登记号
        /// </summary>
        TaxNo = (byte)'A',

        /// <summary>
        /// 其他证件
        /// </summary>
        OtherCard = (byte)'x'
    }

    /// <summary>
    /// TFtdcInvestorRangeType是一个投资者范围类型
    /// </summary>
    public enum TThostFtdcInvestorRangeType : byte
    {
        /// <summary>
        /// 所有
        /// </summary>
        All = (byte)'1',

        /// <summary>
        /// 投资者组
        /// </summary>
        Group = (byte)'2',

        /// <summary>
        /// 单一投资者
        /// </summary>
        Single = (byte)'3'
    }

    /// <summary>
    /// TFtdcDepartmentRangeType是一个投资者范围类型
    /// </summary>
    public enum TThostFtdcDepartmentRangeType : byte
    {
        /// <summary>
        /// 所有
        /// </summary>
        All = (byte)'1',

        /// <summary>
        /// 组织架构
        /// </summary>
        Group = (byte)'2',

        /// <summary>
        /// 单一投资者
        /// </summary>
        Single = (byte)'3'
    }

    /// <summary>
    /// TFtdcDataSyncStatusType是一个数据同步状态类型
    /// </summary>
    public enum TThostFtdcDataSyncStatusType : byte
    {
        /// <summary>
        /// 未同步
        /// </summary>
        Asynchronous = (byte)'1',

        /// <summary>
        /// 同步中
        /// </summary>
        Synchronizing = (byte)'2',

        /// <summary>
        /// 已同步
        /// </summary>
        Synchronized = (byte)'3'
    }

    /// <summary>
    /// TFtdcBrokerDataSyncStatusType是一个经纪公司数据同步状态类型
    /// </summary>
    public enum TThostFtdcBrokerDataSyncStatusType : byte
    {
        /// <summary>
        /// 已同步
        /// </summary>
        Synchronized = (byte)'1',

        /// <summary>
        /// 同步中
        /// </summary>
        Synchronizing = (byte)'2'
    }

    /// <summary>
    /// TFtdcExchangeConnectStatusType是一个交易所连接状态类型
    /// </summary>
    public enum TThostFtdcExchangeConnectStatusType : byte
    {
        /// <summary>
        /// 没有任何连接
        /// </summary>
        NoConnection = (byte)'1',

        /// <summary>
        /// 已经发出合约查询请求
        /// </summary>
        QryInstrumentSent = (byte)'2',

        /// <summary>
        /// 已经获取信息
        /// </summary>
        GotInformation = (byte)'9'
    }

    /// <summary>
    /// TFtdcTraderConnectStatusType是一个交易所交易员连接状态类型
    /// </summary>
    public enum TThostFtdcTraderConnectStatusType : byte
    {
        /// <summary>
        /// 没有任何连接
        /// </summary>
        NotConnected = (byte)'1',

        /// <summary>
        /// 已经连接
        /// </summary>
        Connected = (byte)'2',

        /// <summary>
        /// 已经发出合约查询请求
        /// </summary>
        QryInstrumentSent = (byte)'3',

        /// <summary>
        /// 订阅私有流
        /// </summary>
        SubPrivateFlow = (byte)'4'
    }

    /// <summary>
    /// TFtdcFunctionCodeType是一个功能代码类型
    /// </summary>
    public enum TThostFtdcFunctionCodeType : byte
    {
        /// <summary>
        /// 数据异步化
        /// </summary>
        DataAsync = (byte)'1',

        /// <summary>
        /// 强制用户登出
        /// </summary>
        ForceUserLogout = (byte)'2',

        /// <summary>
        /// 变更管理用户口令
        /// </summary>
        UserPasswordUpdate = (byte)'3',

        /// <summary>
        /// 变更经纪公司口令
        /// </summary>
        BrokerPasswordUpdate = (byte)'4',

        /// <summary>
        /// 变更投资者口令
        /// </summary>
        InvestorPasswordUpdate = (byte)'5',

        /// <summary>
        /// 报单插入
        /// </summary>
        OrderInsert = (byte)'6',

        /// <summary>
        /// 报单操作
        /// </summary>
        OrderAction = (byte)'7',

        /// <summary>
        /// 同步系统数据
        /// </summary>
        SyncSystemData = (byte)'8',

        /// <summary>
        /// 同步经纪公司数据
        /// </summary>
        SyncBrokerData = (byte)'9',

        /// <summary>
        /// 批量同步经纪公司数据
        /// </summary>
        BachSyncBrokerData = (byte)'A',

        /// <summary>
        /// 超级查询
        /// </summary>
        SuperQuery = (byte)'B',

        /// <summary>
        /// 报单插入
        /// </summary>
        ParkedOrderInsert = (byte)'C',

        /// <summary>
        /// 报单操作
        /// </summary>
        ParkedOrderAction = (byte)'D',

        /// <summary>
        /// 同步动态令牌
        /// </summary>
        SyncOTP = (byte)'E'
    }

    /// <summary>
    /// TFtdcBrokerFunctionCodeType是一个经纪公司功能代码类型
    /// </summary>
    public enum TThostFtdcBrokerFunctionCodeType : byte
    {
        /// <summary>
        /// 强制用户登出
        /// </summary>
        ForceUserLogout = (byte)'1',

        /// <summary>
        /// 变更用户口令
        /// </summary>
        UserPasswordUpdate = (byte)'2',

        /// <summary>
        /// 同步经纪公司数据
        /// </summary>
        SyncBrokerData = (byte)'3',

        /// <summary>
        /// 批量同步经纪公司数据
        /// </summary>
        BachSyncBrokerData = (byte)'4',

        /// <summary>
        /// 报单插入
        /// </summary>
        OrderInsert = (byte)'5',

        /// <summary>
        /// 报单操作
        /// </summary>
        OrderAction = (byte)'6',

        /// <summary>
        /// 全部查询
        /// </summary>
        AllQuery = (byte)'7',

        /// <summary>
        /// 系统功能：登入/登出/修改密码等
        /// </summary>
        log = (byte)'a',

        /// <summary>
        /// 基本查询：查询基础数据，如合约，交易所等常量
        /// </summary>
        BaseQry = (byte)'b',

        /// <summary>
        /// 交易查询：如查成交，委托
        /// </summary>
        TradeQry = (byte)'c',

        /// <summary>
        /// 交易功能：报单，撤单
        /// </summary>
        Trade = (byte)'d',

        /// <summary>
        /// 银期转账
        /// </summary>
        Virement = (byte)'e',

        /// <summary>
        /// 风险监控
        /// </summary>
        Risk = (byte)'f',

        /// <summary>
        /// 查询/管理：查询会话，踢人等
        /// </summary>
        Session = (byte)'g',

        /// <summary>
        /// 风控通知控制
        /// </summary>
        RiskNoticeCtl = (byte)'h',

        /// <summary>
        /// 风控通知发送
        /// </summary>
        RiskNotice = (byte)'i',

        /// <summary>
        /// 察看经纪公司资金权限
        /// </summary>
        BrokerDeposit = (byte)'j',

        /// <summary>
        /// 资金查询
        /// </summary>
        QueryFund = (byte)'k',

        /// <summary>
        /// 报单查询
        /// </summary>
        QueryOrder = (byte)'l',

        /// <summary>
        /// 成交查询
        /// </summary>
        QueryTrade = (byte)'m',

        /// <summary>
        /// 持仓查询
        /// </summary>
        QueryPosition = (byte)'n',

        /// <summary>
        /// 行情查询
        /// </summary>
        QueryMarketData = (byte)'o',

        /// <summary>
        /// 用户事件查询
        /// </summary>
        QueryUserEvent = (byte)'p',

        /// <summary>
        /// 风险通知查询
        /// </summary>
        QueryRiskNotify = (byte)'q',

        /// <summary>
        /// 出入金查询
        /// </summary>
        QueryFundChange = (byte)'r',

        /// <summary>
        /// 投资者信息查询
        /// </summary>
        QueryInvestor = (byte)'s',

        /// <summary>
        /// 交易编码查询
        /// </summary>
        QueryTradingCode = (byte)'t',

        /// <summary>
        /// 强平
        /// </summary>
        ForceClose = (byte)'u',

        /// <summary>
        /// 压力测试
        /// </summary>
        PressTest = (byte)'v',

        /// <summary>
        /// 权益反算
        /// </summary>
        RemainCalc = (byte)'w',

        /// <summary>
        /// 净持仓保证金指标
        /// </summary>
        NetPositionInd = (byte)'x',

        /// <summary>
        /// 风险预算
        /// </summary>
        RiskPredict = (byte)'y',

        /// <summary>
        /// 数据导出
        /// </summary>
        DataExport = (byte)'z',

        /// <summary>
        /// 风控指标设置
        /// </summary>
        RiskTargetSetup = (byte)'A',

        /// <summary>
        /// 行情预警
        /// </summary>
        MarketDataWarn = (byte)'B',

        /// <summary>
        /// 业务通知查询
        /// </summary>
        QryBizNotice = (byte)'C',

        /// <summary>
        /// 业务通知模板设置
        /// </summary>
        CfgBizNotice = (byte)'D',

        /// <summary>
        /// 同步动态令牌
        /// </summary>
        SyncOTP = (byte)'E',

        /// <summary>
        /// 发送业务通知
        /// </summary>
        SendBizNotice = (byte)'F',

        /// <summary>
        /// 风险级别标准设置
        /// </summary>
        CfgRiskLevelStd = (byte)'G'
    }

    /// <summary>
    /// TFtdcOrderActionStatusType是一个报单操作状态类型
    /// </summary>
    public enum TThostFtdcOrderActionStatusType : byte
    {
        /// <summary>
        /// 已经提交
        /// </summary>
        Submitted = (byte)'a',

        /// <summary>
        /// 已经接受
        /// </summary>
        Accepted = (byte)'b',

        /// <summary>
        /// 已经被拒绝
        /// </summary>
        Rejected = (byte)'c'
    }

    /// <summary>
    /// TFtdcOrderStatusType是一个报单状态类型
    /// </summary>
    public enum TThostFtdcOrderStatusType : byte
    {
        /// <summary>
        /// 全部成交
        /// </summary>
        AllTraded = (byte)'0',

        /// <summary>
        /// 部分成交还在队列中
        /// </summary>
        PartTradedQueueing = (byte)'1',

        /// <summary>
        /// 部分成交不在队列中
        /// </summary>
        PartTradedNotQueueing = (byte)'2',

        /// <summary>
        /// 未成交还在队列中
        /// </summary>
        NoTradeQueueing = (byte)'3',

        /// <summary>
        /// 未成交不在队列中
        /// </summary>
        NoTradeNotQueueing = (byte)'4',

        /// <summary>
        /// 撤单
        /// </summary>
        Canceled = (byte)'5',

        /// <summary>
        /// 未知
        /// </summary>
        Unknown = (byte)'a',

        /// <summary>
        /// 尚未触发
        /// </summary>
        NotTouched = (byte)'b',

        /// <summary>
        /// 已触发
        /// </summary>
        Touched = (byte)'c'
    }

    /// <summary>
    /// TFtdcOrderSubmitStatusType是一个报单提交状态类型
    /// </summary>
    public enum TThostFtdcOrderSubmitStatusType : byte
    {
        /// <summary>
        /// 已经提交
        /// </summary>
        InsertSubmitted = (byte)'0',

        /// <summary>
        /// 撤单已经提交
        /// </summary>
        CancelSubmitted = (byte)'1',

        /// <summary>
        /// 修改已经提交
        /// </summary>
        ModifySubmitted = (byte)'2',

        /// <summary>
        /// 已经接受
        /// </summary>
        Accepted = (byte)'3',

        /// <summary>
        /// 报单已经被拒绝
        /// </summary>
        InsertRejected = (byte)'4',

        /// <summary>
        /// 撤单已经被拒绝
        /// </summary>
        CancelRejected = (byte)'5',

        /// <summary>
        /// 改单已经被拒绝
        /// </summary>
        ModifyRejected = (byte)'6'
    }

    /// <summary>
    /// TFtdcPositionDateType是一个持仓日期类型
    /// </summary>
    public enum TThostFtdcPositionDateType : byte
    {
        /// <summary>
        /// 今日持仓
        /// </summary>
        Today = (byte)'1',

        /// <summary>
        /// 历史持仓
        /// </summary>
        History = (byte)'2'
    }

    /// <summary>
    /// TFtdcPositionDateTypeType是一个持仓日期类型类型
    /// </summary>
    public enum TThostFtdcPositionDateTypeType : byte
    {
        /// <summary>
        /// 使用历史持仓
        /// </summary>
        UseHistory = (byte)'1',

        /// <summary>
        /// 不使用历史持仓
        /// </summary>
        NoUseHistory = (byte)'2'
    }

    /// <summary>
    /// TFtdcTradingRoleType是一个交易角色类型
    /// </summary>
    public enum TThostFtdcTradingRoleType : byte
    {
        /// <summary>
        /// 代理
        /// </summary>
        Broker = (byte)'1',

        /// <summary>
        /// 自营
        /// </summary>
        Host = (byte)'2',

        /// <summary>
        /// 做市商
        /// </summary>
        Maker = (byte)'3'
    }

    /// <summary>
    /// TFtdcProductClassType是一个产品类型类型
    /// </summary>
    public enum TThostFtdcProductClassType : byte
    {
        /// <summary>
        /// 期货
        /// </summary>
        Futures = (byte)'1',

        /// <summary>
        /// 期权
        /// </summary>
        Options = (byte)'2',

        /// <summary>
        /// 组合
        /// </summary>
        Combination = (byte)'3',

        /// <summary>
        /// 即期
        /// </summary>
        Spot = (byte)'4',

        /// <summary>
        /// 期转现
        /// </summary>
        EFP = (byte)'5'
    }

    /// <summary>
    /// TFtdcInstLifePhaseType是一个合约生命周期状态类型
    /// </summary>
    public enum TThostFtdcInstLifePhaseType : byte
    {
        /// <summary>
        /// 未上市
        /// </summary>
        NotStart = (byte)'0',

        /// <summary>
        /// 上市
        /// </summary>
        Started = (byte)'1',

        /// <summary>
        /// 停牌
        /// </summary>
        Pause = (byte)'2',

        /// <summary>
        /// 到期
        /// </summary>
        Expired = (byte)'3'
    }

    /// <summary>
    /// TFtdcDirectionType是一个买卖方向类型
    /// </summary>
    public enum TThostFtdcDirectionType : byte
    {
        /// <summary>
        /// 买
        /// </summary>
        Buy = (byte)'0',

        /// <summary>
        /// 卖
        /// </summary>
        Sell = (byte)'1'
    }

    /// <summary>
    /// TFtdcPositionTypeType是一个持仓类型类型
    /// </summary>
    public enum TThostFtdcPositionTypeType : byte
    {
        /// <summary>
        /// 净持仓
        /// </summary>
        Net = (byte)'1',

        /// <summary>
        /// 综合持仓
        /// </summary>
        Gross = (byte)'2'
    }

    /// <summary>
    /// TFtdcPosiDirectionType是一个持仓多空方向类型
    /// </summary>
    public enum TThostFtdcPosiDirectionType : byte
    {
        /// <summary>
        /// 净
        /// </summary>
        Net = (byte)'1',

        /// <summary>
        /// 多头
        /// </summary>
        Long = (byte)'2',

        /// <summary>
        /// 空头
        /// </summary>
        Short = (byte)'3'
    }

    /// <summary>
    /// TFtdcSysSettlementStatusType是一个系统结算状态类型
    /// </summary>
    public enum TThostFtdcSysSettlementStatusType : byte
    {
        /// <summary>
        /// 不活跃
        /// </summary>
        NonActive = (byte)'1',

        /// <summary>
        /// 启动
        /// </summary>
        Startup = (byte)'2',

        /// <summary>
        /// 操作
        /// </summary>
        Operating = (byte)'3',

        /// <summary>
        /// 结算
        /// </summary>
        Settlement = (byte)'4',

        /// <summary>
        /// 结算完成
        /// </summary>
        SettlementFinished = (byte)'5'
    }

    /// <summary>
    /// TFtdcRatioAttrType是一个费率属性类型
    /// </summary>
    public enum TThostFtdcRatioAttrType : byte
    {
        /// <summary>
        /// 交易费率
        /// </summary>
        Trade = (byte)'0',

        /// <summary>
        /// 结算费率
        /// </summary>
        Settlement = (byte)'1'
    }

    /// <summary>
    /// TFtdcHedgeFlagType是一个投机套保标志类型
    /// </summary>
    public enum TThostFtdcHedgeFlagType : byte
    {
        /// <summary>
        /// 投机
        /// </summary>
        Speculation = (byte)'1',

        /// <summary>
        /// 套利
        /// </summary>
        Arbitrage = (byte)'2',

        /// <summary>
        /// 套保
        /// </summary>
        Hedge = (byte)'3'
    }

    /// <summary>
    /// TFtdcBillHedgeFlagType是一个投机套保标志类型
    /// </summary>
    public enum TThostFtdcBillHedgeFlagType : byte
    {
        /// <summary>
        /// 投机
        /// </summary>
        Speculation = (byte)'1',

        /// <summary>
        /// 套利
        /// </summary>
        Arbitrage = (byte)'2',

        /// <summary>
        /// 套保
        /// </summary>
        Hedge = (byte)'3'
    }

    /// <summary>
    /// TFtdcClientIDTypeType是一个交易编码类型类型
    /// </summary>
    public enum TThostFtdcClientIDTypeType : byte
    {
        /// <summary>
        /// 投机
        /// </summary>
        Speculation = (byte)'1',

        /// <summary>
        /// 套利
        /// </summary>
        Arbitrage = (byte)'2',

        /// <summary>
        /// 套保
        /// </summary>
        Hedge = (byte)'3'
    }

    /// <summary>
    /// TFtdcOrderPriceTypeType是一个报单价格条件类型
    /// </summary>
    public enum TThostFtdcOrderPriceTypeType : byte
    {
        /// <summary>
        /// 任意价
        /// </summary>
        AnyPrice = (byte)'1',

        /// <summary>
        /// 限价
        /// </summary>
        LimitPrice = (byte)'2',

        /// <summary>
        /// 最优价
        /// </summary>
        BestPrice = (byte)'3',

        /// <summary>
        /// 最新价
        /// </summary>
        LastPrice = (byte)'4',

        /// <summary>
        /// 最新价浮动上浮1个ticks
        /// </summary>
        LastPricePlusOneTicks = (byte)'5',

        /// <summary>
        /// 最新价浮动上浮2个ticks
        /// </summary>
        LastPricePlusTwoTicks = (byte)'6',

        /// <summary>
        /// 最新价浮动上浮3个ticks
        /// </summary>
        LastPricePlusThreeTicks = (byte)'7',

        /// <summary>
        /// 卖一价
        /// </summary>
        AskPrice1 = (byte)'8',

        /// <summary>
        /// 卖一价浮动上浮1个ticks
        /// </summary>
        AskPrice1PlusOneTicks = (byte)'9',

        /// <summary>
        /// 卖一价浮动上浮2个ticks
        /// </summary>
        AskPrice1PlusTwoTicks = (byte)'A',

        /// <summary>
        /// 卖一价浮动上浮3个ticks
        /// </summary>
        AskPrice1PlusThreeTicks = (byte)'B',

        /// <summary>
        /// 买一价
        /// </summary>
        BidPrice1 = (byte)'C',

        /// <summary>
        /// 买一价浮动上浮1个ticks
        /// </summary>
        BidPrice1PlusOneTicks = (byte)'D',

        /// <summary>
        /// 买一价浮动上浮2个ticks
        /// </summary>
        BidPrice1PlusTwoTicks = (byte)'E',

        /// <summary>
        /// 买一价浮动上浮3个ticks
        /// </summary>
        BidPrice1PlusThreeTicks = (byte)'F'
    }

    /// <summary>
    /// TFtdcOffsetFlagType是一个开平标志类型
    /// </summary>
    public enum TThostFtdcOffsetFlagType : byte
    {
        /// <summary>
        /// 开仓
        /// </summary>
        Open = (byte)'0',

        /// <summary>
        /// 平仓
        /// </summary>
        Close = (byte)'1',

        /// <summary>
        /// 强平
        /// </summary>
        ForceClose = (byte)'2',

        /// <summary>
        /// 平今
        /// </summary>
        CloseToday = (byte)'3',

        /// <summary>
        /// 平昨
        /// </summary>
        CloseYesterday = (byte)'4',

        /// <summary>
        /// 强减
        /// </summary>
        ForceOff = (byte)'5',

        /// <summary>
        /// 本地强平
        /// </summary>
        LocalForceClose = (byte)'6'
    }

    /// <summary>
    /// TFtdcForceCloseReasonType是一个强平原因类型
    /// </summary>
    public enum TThostFtdcForceCloseReasonType : byte
    {
        /// <summary>
        /// 非强平
        /// </summary>
        NotForceClose = (byte)'0',

        /// <summary>
        /// 资金不足
        /// </summary>
        LackDeposit = (byte)'1',

        /// <summary>
        /// 客户超仓
        /// </summary>
        ClientOverPositionLimit = (byte)'2',

        /// <summary>
        /// 会员超仓
        /// </summary>
        MemberOverPositionLimit = (byte)'3',

        /// <summary>
        /// 持仓非整数倍
        /// </summary>
        NotMultiple = (byte)'4',

        /// <summary>
        /// 违规
        /// </summary>
        Violation = (byte)'5',

        /// <summary>
        /// 其它
        /// </summary>
        Other = (byte)'6',

        /// <summary>
        /// 自然人临近交割
        /// </summary>
        PersonDeliv = (byte)'7'
    }

    /// <summary>
    /// TFtdcOrderTypeType是一个报单类型类型
    /// </summary>
    public enum TThostFtdcOrderTypeType : byte
    {
        /// <summary>
        /// 正常
        /// </summary>
        Normal = (byte)'0',

        /// <summary>
        /// 报价衍生
        /// </summary>
        DeriveFromQuote = (byte)'1',

        /// <summary>
        /// 组合衍生
        /// </summary>
        DeriveFromCombination = (byte)'2',

        /// <summary>
        /// 组合报单
        /// </summary>
        Combination = (byte)'3',

        /// <summary>
        /// 条件单
        /// </summary>
        ConditionalOrder = (byte)'4',

        /// <summary>
        /// 互换单
        /// </summary>
        Swap = (byte)'5'
    }

    /// <summary>
    /// TFtdcTimeConditionType是一个有效期类型类型
    /// </summary>
    public enum TThostFtdcTimeConditionType : byte
    {
        /// <summary>
        /// 立即完成，否则撤销
        /// </summary>
        IOC = (byte)'1',

        /// <summary>
        /// 本节有效
        /// </summary>
        GFS = (byte)'2',

        /// <summary>
        /// 当日有效
        /// </summary>
        GFD = (byte)'3',

        /// <summary>
        /// 指定日期前有效
        /// </summary>
        GTD = (byte)'4',

        /// <summary>
        /// 撤销前有效
        /// </summary>
        GTC = (byte)'5',

        /// <summary>
        /// 集合竞价有效
        /// </summary>
        GFA = (byte)'6'
    }

    /// <summary>
    /// TFtdcVolumeConditionType是一个成交量类型类型
    /// </summary>
    public enum TThostFtdcVolumeConditionType : byte
    {
        /// <summary>
        /// 任何数量
        /// </summary>
        AV = (byte)'1',

        /// <summary>
        /// 最小数量
        /// </summary>
        MV = (byte)'2',

        /// <summary>
        /// 全部数量
        /// </summary>
        CV = (byte)'3'
    }

    /// <summary>
    /// TFtdcContingentConditionType是一个触发条件类型
    /// </summary>
    public enum TThostFtdcContingentConditionType : byte
    {
        /// <summary>
        /// 立即
        /// </summary>
        Immediately = (byte)'1',

        /// <summary>
        /// 止损
        /// </summary>
        Touch = (byte)'2',

        /// <summary>
        /// 止赢
        /// </summary>
        TouchProfit = (byte)'3',

        /// <summary>
        /// 预埋单
        /// </summary>
        ParkedOrder = (byte)'4',

        /// <summary>
        /// 最新价大于条件价
        /// </summary>
        LastPriceGreaterThanStopPrice = (byte)'5',

        /// <summary>
        /// 最新价大于等于条件价
        /// </summary>
        LastPriceGreaterEqualStopPrice = (byte)'6',

        /// <summary>
        /// 最新价小于条件价
        /// </summary>
        LastPriceLesserThanStopPrice = (byte)'7',

        /// <summary>
        /// 最新价小于等于条件价
        /// </summary>
        LastPriceLesserEqualStopPrice = (byte)'8',

        /// <summary>
        /// 卖一价大于条件价
        /// </summary>
        AskPriceGreaterThanStopPrice = (byte)'9',

        /// <summary>
        /// 卖一价大于等于条件价
        /// </summary>
        AskPriceGreaterEqualStopPrice = (byte)'A',

        /// <summary>
        /// 卖一价小于条件价
        /// </summary>
        AskPriceLesserThanStopPrice = (byte)'B',

        /// <summary>
        /// 卖一价小于等于条件价
        /// </summary>
        AskPriceLesserEqualStopPrice = (byte)'C',

        /// <summary>
        /// 买一价大于条件价
        /// </summary>
        BidPriceGreaterThanStopPrice = (byte)'D',

        /// <summary>
        /// 买一价大于等于条件价
        /// </summary>
        BidPriceGreaterEqualStopPrice = (byte)'E',

        /// <summary>
        /// 买一价小于条件价
        /// </summary>
        BidPriceLesserThanStopPrice = (byte)'F',

        /// <summary>
        /// 买一价小于等于条件价
        /// </summary>
        BidPriceLesserEqualStopPrice = (byte)'H'
    }

    /// <summary>
    /// TFtdcActionFlagType是一个操作标志类型
    /// </summary>
    public enum TThostFtdcActionFlagType : byte
    {
        /// <summary>
        /// 删除
        /// </summary>
        Delete = (byte)'0',

        /// <summary>
        /// 修改
        /// </summary>
        Modify = (byte)'3'
    }

    /// <summary>
    /// TFtdcTradingRightType是一个交易权限类型
    /// </summary>
    public enum TThostFtdcTradingRightType : byte
    {
        /// <summary>
        /// 可以交易
        /// </summary>
        Allow = (byte)'0',

        /// <summary>
        /// 只能平仓
        /// </summary>
        CloseOnly = (byte)'1',

        /// <summary>
        /// 不能交易
        /// </summary>
        Forbidden = (byte)'2'
    }

    /// <summary>
    /// TFtdcOrderSourceType是一个报单来源类型
    /// </summary>
    public enum TThostFtdcOrderSourceType : byte
    {
        /// <summary>
        /// 来自参与者
        /// </summary>
        Participant = (byte)'0',

        /// <summary>
        /// 来自管理员
        /// </summary>
        Administrator = (byte)'1'
    }

    /// <summary>
    /// TFtdcTradeTypeType是一个成交类型类型
    /// </summary>
    public enum TThostFtdcTradeTypeType : byte
    {
        /// <summary>
        /// 普通成交
        /// </summary>
        Common = (byte)'0',

        /// <summary>
        /// 期权执行
        /// </summary>
        OptionsExecution = (byte)'1',

        /// <summary>
        /// OTC成交
        /// </summary>
        OTC = (byte)'2',

        /// <summary>
        /// 期转现衍生成交
        /// </summary>
        EFPDerived = (byte)'3',

        /// <summary>
        /// 组合衍生成交
        /// </summary>
        CombinationDerived = (byte)'4'
    }

    /// <summary>
    /// TFtdcPriceSourceType是一个成交价来源类型
    /// </summary>
    public enum TThostFtdcPriceSourceType : byte
    {
        /// <summary>
        /// 前成交价
        /// </summary>
        LastPrice = (byte)'0',

        /// <summary>
        /// 买委托价
        /// </summary>
        Buy = (byte)'1',

        /// <summary>
        /// 卖委托价
        /// </summary>
        Sell = (byte)'2'
    }

    /// <summary>
    /// TFtdcInstrumentStatusType是一个合约交易状态类型
    /// </summary>
    public enum TThostFtdcInstrumentStatusType : byte
    {
        /// <summary>
        /// 开盘前
        /// </summary>
        BeforeTrading = (byte)'0',

        /// <summary>
        /// 非交易
        /// </summary>
        NoTrading = (byte)'1',

        /// <summary>
        /// 连续交易
        /// </summary>
        Continous = (byte)'2',

        /// <summary>
        /// 集合竞价报单
        /// </summary>
        AuctionOrdering = (byte)'3',

        /// <summary>
        /// 集合竞价价格平衡
        /// </summary>
        AuctionBalance = (byte)'4',

        /// <summary>
        /// 集合竞价撮合
        /// </summary>
        AuctionMatch = (byte)'5',

        /// <summary>
        /// 收盘
        /// </summary>
        Closed = (byte)'6'
    }

    /// <summary>
    /// TFtdcInstStatusEnterReasonType是一个品种进入交易状态原因类型
    /// </summary>
    public enum TThostFtdcInstStatusEnterReasonType : byte
    {
        /// <summary>
        /// 自动切换
        /// </summary>
        Automatic = (byte)'1',

        /// <summary>
        /// 手动切换
        /// </summary>
        Manual = (byte)'2',

        /// <summary>
        /// 熔断
        /// </summary>
        Fuse = (byte)'3'
    }

    /// <summary>
    /// TFtdcBatchStatusType是一个处理状态类型
    /// </summary>
    public enum TThostFtdcBatchStatusType : byte
    {
        /// <summary>
        /// 未上传
        /// </summary>
        NoUpload = (byte)'1',

        /// <summary>
        /// 已上传
        /// </summary>
        Uploaded = (byte)'2',

        /// <summary>
        /// 审核失败
        /// </summary>
        Failed = (byte)'3'
    }

    /// <summary>
    /// TFtdcReturnStyleType是一个按品种返还方式类型
    /// </summary>
    public enum TThostFtdcReturnStyleType : byte
    {
        /// <summary>
        /// 按所有品种
        /// </summary>
        All = (byte)'1',

        /// <summary>
        /// 按品种
        /// </summary>
        ByProduct = (byte)'2'
    }

    /// <summary>
    /// TFtdcReturnPatternType是一个返还模式类型
    /// </summary>
    public enum TThostFtdcReturnPatternType : byte
    {
        /// <summary>
        /// 按成交手数
        /// </summary>
        ByVolume = (byte)'1',

        /// <summary>
        /// 按留存手续费
        /// </summary>
        ByFeeOnHand = (byte)'2'
    }

    /// <summary>
    /// TFtdcReturnLevelType是一个返还级别类型
    /// </summary>
    public enum TThostFtdcReturnLevelType : byte
    {
        /// <summary>
        /// 级别1
        /// </summary>
        Level1 = (byte)'1',

        /// <summary>
        /// 级别2
        /// </summary>
        Level2 = (byte)'2',

        /// <summary>
        /// 级别3
        /// </summary>
        Level3 = (byte)'3',

        /// <summary>
        /// 级别4
        /// </summary>
        Level4 = (byte)'4',

        /// <summary>
        /// 级别5
        /// </summary>
        Level5 = (byte)'5',

        /// <summary>
        /// 级别6
        /// </summary>
        Level6 = (byte)'6',

        /// <summary>
        /// 级别7
        /// </summary>
        Level7 = (byte)'7',

        /// <summary>
        /// 级别8
        /// </summary>
        Level8 = (byte)'8',

        /// <summary>
        /// 级别9
        /// </summary>
        Level9 = (byte)'9'
    }

    /// <summary>
    /// TFtdcReturnStandardType是一个返还标准类型
    /// </summary>
    public enum TThostFtdcReturnStandardType : byte
    {
        /// <summary>
        /// 分阶段返还
        /// </summary>
        ByPeriod = (byte)'1',

        /// <summary>
        /// 按某一标准
        /// </summary>
        ByStandard = (byte)'2'
    }

    /// <summary>
    /// TFtdcMortgageTypeType是一个质押类型类型
    /// </summary>
    public enum TThostFtdcMortgageTypeType : byte
    {
        /// <summary>
        /// 质出
        /// </summary>
        Out = (byte)'0',

        /// <summary>
        /// 质入
        /// </summary>
        In = (byte)'1'
    }

    /// <summary>
    /// TFtdcInvestorSettlementParamIDType是一个投资者结算参数代码类型
    /// </summary>
    public enum TThostFtdcInvestorSettlementParamIDType : byte
    {
        /// <summary>
        /// 基础保证金
        /// </summary>
        BaseMargin = (byte)'1',

        /// <summary>
        /// 最低权益标准
        /// </summary>
        LowestInterest = (byte)'2',

        /// <summary>
        /// 质押比例
        /// </summary>
        MortgageRatio = (byte)'4',

        /// <summary>
        /// 保证金算法
        /// </summary>
        MarginWay = (byte)'5',

        /// <summary>
        /// 结算单(盯市)权益等于结存
        /// </summary>
        BillDeposit = (byte)'9'
    }

    /// <summary>
    /// TFtdcExchangeSettlementParamIDType是一个交易所结算参数代码类型
    /// </summary>
    public enum TThostFtdcExchangeSettlementParamIDType : byte
    {
        /// <summary>
        /// 质押比例
        /// </summary>
        MortgageRatio = (byte)'1',

        /// <summary>
        /// 分项资金导入项
        /// </summary>
        OtherFundItem = (byte)'2',

        /// <summary>
        /// 分项资金入交易所出入金
        /// </summary>
        OtherFundImport = (byte)'3',

        /// <summary>
        /// 上期所交割手续费收取方式
        /// </summary>
        SHFEDelivFee = (byte)'4',

        /// <summary>
        /// 大商所交割手续费收取方式
        /// </summary>
        DCEDelivFee = (byte)'5',

        /// <summary>
        /// 中金所开户最低可用金额
        /// </summary>
        CFFEXMinPrepa = (byte)'6'
    }

    /// <summary>
    /// TFtdcSystemParamIDType是一个系统参数代码类型
    /// </summary>
    public enum TThostFtdcSystemParamIDType : byte
    {
        /// <summary>
        /// 投资者代码最小长度
        /// </summary>
        InvestorIDMinLength = (byte)'1',

        /// <summary>
        /// 投资者帐号代码最小长度
        /// </summary>
        AccountIDMinLength = (byte)'2',

        /// <summary>
        /// 投资者开户默认登录权限
        /// </summary>
        UserRightLogon = (byte)'3',

        /// <summary>
        /// 投资者交易结算单成交汇总方式
        /// </summary>
        SettlementBillTrade = (byte)'4',

        /// <summary>
        /// 统一开户更新交易编码方式
        /// </summary>
        TradingCode = (byte)'5',

        /// <summary>
        /// 结算是否判断存在未复核的出入金和分项资金
        /// </summary>
        CheckFund = (byte)'6',

        /// <summary>
        /// 是否启用手续费模板数据权限
        /// </summary>
        CommModelRight = (byte)'7',

        /// <summary>
        /// 是否规范用户才能激活
        /// </summary>
        IsStandardActive = (byte)'8',

        /// <summary>
        /// 上传的交易所结算文件路径
        /// </summary>
        UploadSettlementFile = (byte)'U',

        /// <summary>
        /// 上报保证金监控中心文件路径
        /// </summary>
        DownloadCSRCFile = (byte)'D',

        /// <summary>
        /// 生成的结算单文件路径
        /// </summary>
        SettlementBillFile = (byte)'S',

        /// <summary>
        /// 证监会文件标识
        /// </summary>
        CSRCOthersFile = (byte)'C',

        /// <summary>
        /// 投资者照片路径
        /// </summary>
        InvestorPhoto = (byte)'P',

        /// <summary>
        /// 全结经纪公司上传文件路径
        /// </summary>
        CSRCData = (byte)'R',

        /// <summary>
        /// 开户密码录入方式
        /// </summary>
        InvestorPwdModel = (byte)'I',

        /// <summary>
        /// 投资者中金所结算文件下载路径
        /// </summary>
        CFFEXInvestorSettleFile = (byte)'F',

        /// <summary>
        /// 投资者代码编码方式
        /// </summary>
        InvestorIDType = (byte)'a'
    }

    /// <summary>
    /// TFtdcTradeParamIDType是一个交易系统参数代码类型
    /// </summary>
    public enum TThostFtdcTradeParamIDType : byte
    {
        /// <summary>
        /// 系统加密算法
        /// </summary>
        EncryptionStandard = (byte)'E',

        /// <summary>
        /// 系统风险算法
        /// </summary>
        RiskMode = (byte)'R',

        /// <summary>
        /// 系统风险算法是否全局 0-否 1-是
        /// </summary>
        RiskModeGlobal = (byte)'G'
    }

    /// <summary>
    /// TFtdcFileIDType是一个文件标识类型
    /// </summary>
    public enum TThostFtdcFileIDType : byte
    {
        /// <summary>
        /// 资金数据
        /// </summary>
        SettlementFund = (byte)'F',

        /// <summary>
        /// 成交数据
        /// </summary>
        Trade = (byte)'T',

        /// <summary>
        /// 投资者持仓数据
        /// </summary>
        InvestorPosition = (byte)'P',

        /// <summary>
        /// 投资者分项资金数据
        /// </summary>
        SubEntryFund = (byte)'O',

        /// <summary>
        /// 郑商所组合持仓数据
        /// </summary>
        CZCECombinationPos = (byte)'C',

        /// <summary>
        /// 上报保证金监控中心数据
        /// </summary>
        CSRCData = (byte)'R'
    }

    /// <summary>
    /// TFtdcFileTypeType是一个文件上传类型类型
    /// </summary>
    public enum TThostFtdcFileTypeType : byte
    {
        /// <summary>
        /// 结算
        /// </summary>
        Settlement = (byte)'0',

        /// <summary>
        /// 核对
        /// </summary>
        Check = (byte)'1'
    }

    /// <summary>
    /// TFtdcFileFormatType是一个文件格式类型
    /// </summary>
    public enum TThostFtdcFileFormatType : byte
    {
        /// <summary>
        /// 文本文件(.txt)
        /// </summary>
        Txt = (byte)'0',

        /// <summary>
        /// 压缩文件(.zip)
        /// </summary>
        Zip = (byte)'1',

        /// <summary>
        /// DBF文件(.dbf)
        /// </summary>
        DBF = (byte)'2'
    }

    /// <summary>
    /// TFtdcFileUploadStatusType是一个文件状态类型
    /// </summary>
    public enum TThostFtdcFileUploadStatusType : byte
    {
        /// <summary>
        /// 上传成功
        /// </summary>
        SucceedUpload = (byte)'1',

        /// <summary>
        /// 上传失败
        /// </summary>
        FailedUpload = (byte)'2',

        /// <summary>
        /// 导入成功
        /// </summary>
        SucceedLoad = (byte)'3',

        /// <summary>
        /// 导入部分成功
        /// </summary>
        PartSucceedLoad = (byte)'4',

        /// <summary>
        /// 导入失败
        /// </summary>
        FailedLoad = (byte)'5'
    }

    /// <summary>
    /// TFtdcTransferDirectionType是一个移仓方向类型
    /// </summary>
    public enum TThostFtdcTransferDirectionType : byte
    {
        /// <summary>
        /// 移出
        /// </summary>
        Out = (byte)'0',

        /// <summary>
        /// 移入
        /// </summary>
        In = (byte)'1'
    }

    /// <summary>
    /// TFtdcBankFlagType是一个银行统一标识类型类型
    /// </summary>
    public enum TThostFtdcBankFlagType : byte
    {
        /// <summary>
        /// 工商银行
        /// </summary>
        ICBC = (byte)'1',

        /// <summary>
        /// 农业银行
        /// </summary>
        ABC = (byte)'2',

        /// <summary>
        /// 中国银行
        /// </summary>
        BC = (byte)'3',

        /// <summary>
        /// 建设银行
        /// </summary>
        CBC = (byte)'4',

        /// <summary>
        /// 交通银行
        /// </summary>
        BOC = (byte)'5',

        /// <summary>
        /// 其他银行
        /// </summary>
        Other = (byte)'Z'
    }

    /// <summary>
    /// TFtdcSpecialCreateRuleType是一个特殊的创建规则类型
    /// </summary>
    public enum TThostFtdcSpecialCreateRuleType : byte
    {
        /// <summary>
        /// 没有特殊创建规则
        /// </summary>
        NoSpecialRule = (byte)'0',

        /// <summary>
        /// 不包含春节
        /// </summary>
        NoSpringFestival = (byte)'1'
    }

    /// <summary>
    /// TFtdcBasisPriceTypeType是一个挂牌基准价类型类型
    /// </summary>
    public enum TThostFtdcBasisPriceTypeType : byte
    {
        /// <summary>
        /// 上一合约结算价
        /// </summary>
        LastSettlement = (byte)'1',

        /// <summary>
        /// 上一合约收盘价
        /// </summary>
        LaseClose = (byte)'2'
    }

    /// <summary>
    /// TFtdcProductLifePhaseType是一个产品生命周期状态类型
    /// </summary>
    public enum TThostFtdcProductLifePhaseType : byte
    {
        /// <summary>
        /// 活跃
        /// </summary>
        Active = (byte)'1',

        /// <summary>
        /// 不活跃
        /// </summary>
        NonActive = (byte)'2',

        /// <summary>
        /// 注销
        /// </summary>
        Canceled = (byte)'3'
    }

    /// <summary>
    /// TFtdcDeliveryModeType是一个交割方式类型
    /// </summary>
    public enum TThostFtdcDeliveryModeType : byte
    {
        /// <summary>
        /// 现金交割
        /// </summary>
        CashDeliv = (byte)'1',

        /// <summary>
        /// 实物交割
        /// </summary>
        CommodityDeliv = (byte)'2'
    }

    /// <summary>
    /// TFtdcFundIOTypeType是一个出入金类型类型
    /// </summary>
    public enum TThostFtdcFundIOTypeType : byte
    {
        /// <summary>
        /// 出入金
        /// </summary>
        FundIO = (byte)'1',

        /// <summary>
        /// 银期转帐
        /// </summary>
        Transfer = (byte)'2'
    }

    /// <summary>
    /// TFtdcFundTypeType是一个资金类型类型
    /// </summary>
    public enum TThostFtdcFundTypeType : byte
    {
        /// <summary>
        /// 银行存款
        /// </summary>
        Deposite = (byte)'1',

        /// <summary>
        /// 分项资金
        /// </summary>
        ItemFund = (byte)'2',

        /// <summary>
        /// 公司调整
        /// </summary>
        Company = (byte)'3'
    }

    /// <summary>
    /// TFtdcFundDirectionType是一个出入金方向类型
    /// </summary>
    public enum TThostFtdcFundDirectionType : byte
    {
        /// <summary>
        /// 入金
        /// </summary>
        In = (byte)'1',

        /// <summary>
        /// 出金
        /// </summary>
        Out = (byte)'2'
    }

    /// <summary>
    /// TFtdcFundStatusType是一个资金状态类型
    /// </summary>
    public enum TThostFtdcFundStatusType : byte
    {
        /// <summary>
        /// 已录入
        /// </summary>
        Record = (byte)'1',

        /// <summary>
        /// 已复核
        /// </summary>
        Check = (byte)'2',

        /// <summary>
        /// 已冲销
        /// </summary>
        Charge = (byte)'3'
    }

    /// <summary>
    /// TFtdcPublishStatusType是一个发布状态类型
    /// </summary>
    public enum TThostFtdcPublishStatusType : byte
    {
        /// <summary>
        /// 未发布
        /// </summary>
        None = (byte)'1',

        /// <summary>
        /// 正在发布
        /// </summary>
        Publishing = (byte)'2',

        /// <summary>
        /// 已发布
        /// </summary>
        Published = (byte)'3'
    }

    /// <summary>
    /// TFtdcSystemStatusType是一个系统状态类型
    /// </summary>
    public enum TThostFtdcSystemStatusType : byte
    {
        /// <summary>
        /// 不活跃
        /// </summary>
        NonActive = (byte)'1',

        /// <summary>
        /// 启动
        /// </summary>
        Startup = (byte)'2',

        /// <summary>
        /// 交易开始初始化
        /// </summary>
        Initialize = (byte)'3',

        /// <summary>
        /// 交易完成初始化
        /// </summary>
        Initialized = (byte)'4',

        /// <summary>
        /// 收市开始
        /// </summary>
        Close = (byte)'5',

        /// <summary>
        /// 收市完成
        /// </summary>
        Closed = (byte)'6',

        /// <summary>
        /// 结算
        /// </summary>
        Settlement = (byte)'7'
    }

    /// <summary>
    /// TFtdcSettlementStatusType是一个结算状态类型
    /// </summary>
    public enum TThostFtdcSettlementStatusType : byte
    {
        /// <summary>
        /// 初始
        /// </summary>
        Initialize = (byte)'0',

        /// <summary>
        /// 结算中
        /// </summary>
        Settlementing = (byte)'1',

        /// <summary>
        /// 已结算
        /// </summary>
        Settlemented = (byte)'2',

        /// <summary>
        /// 结算完成
        /// </summary>
        Finished = (byte)'3'
    }

    /// <summary>
    /// TFtdcInvestorTypeType是一个投资者类型类型
    /// </summary>
    public enum TThostFtdcInvestorTypeType : byte
    {
        /// <summary>
        /// 自然人
        /// </summary>
        Person = (byte)'0',

        /// <summary>
        /// 法人
        /// </summary>
        Company = (byte)'1',

        /// <summary>
        /// 投资基金
        /// </summary>
        Fund = (byte)'2'
    }

    /// <summary>
    /// TFtdcBrokerTypeType是一个经纪公司类型类型
    /// </summary>
    public enum TThostFtdcBrokerTypeType : byte
    {
        /// <summary>
        /// 交易会员
        /// </summary>
        Trade = (byte)'0',

        /// <summary>
        /// 交易结算会员
        /// </summary>
        TradeSettle = (byte)'1'
    }

    /// <summary>
    /// TFtdcRiskLevelType是一个风险等级类型
    /// </summary>
    public enum TThostFtdcRiskLevelType : byte
    {
        /// <summary>
        /// 低风险客户
        /// </summary>
        Low = (byte)'1',

        /// <summary>
        /// 普通客户
        /// </summary>
        Normal = (byte)'2',

        /// <summary>
        /// 关注客户
        /// </summary>
        Focus = (byte)'3',

        /// <summary>
        /// 风险客户
        /// </summary>
        Risk = (byte)'4'
    }

    /// <summary>
    /// TFtdcFeeAcceptStyleType是一个手续费收取方式类型
    /// </summary>
    public enum TThostFtdcFeeAcceptStyleType : byte
    {
        /// <summary>
        /// 按交易收取
        /// </summary>
        ByTrade = (byte)'1',

        /// <summary>
        /// 按交割收取
        /// </summary>
        ByDeliv = (byte)'2',

        /// <summary>
        /// 不收
        /// </summary>
        None = (byte)'3',

        /// <summary>
        /// 按指定手续费收取
        /// </summary>
        FixFee = (byte)'4'
    }

    /// <summary>
    /// TFtdcPasswordTypeType是一个密码类型类型
    /// </summary>
    public enum TThostFtdcPasswordTypeType : byte
    {
        /// <summary>
        /// 交易密码
        /// </summary>
        Trade = (byte)'1',

        /// <summary>
        /// 资金密码
        /// </summary>
        Account = (byte)'2'
    }

    /// <summary>
    /// TFtdcAlgorithmType是一个盈亏算法类型
    /// </summary>
    public enum TThostFtdcAlgorithmType : byte
    {
        /// <summary>
        /// 浮盈浮亏都计算
        /// </summary>
        All = (byte)'1',

        /// <summary>
        /// 浮盈不计，浮亏计
        /// </summary>
        OnlyLost = (byte)'2',

        /// <summary>
        /// 浮盈计，浮亏不计
        /// </summary>
        OnlyGain = (byte)'3',

        /// <summary>
        /// 浮盈浮亏都不计算
        /// </summary>
        None = (byte)'4'
    }

    /// <summary>
    /// TFtdcIncludeCloseProfitType是一个是否包含平仓盈利类型
    /// </summary>
    public enum TThostFtdcIncludeCloseProfitType : byte
    {
        /// <summary>
        /// 包含平仓盈利
        /// </summary>
        Include = (byte)'0',

        /// <summary>
        /// 不包含平仓盈利
        /// </summary>
        NotInclude = (byte)'2'
    }

    /// <summary>
    /// TFtdcAllWithoutTradeType是一个是否受可提比例限制类型
    /// </summary>
    public enum TThostFtdcAllWithoutTradeType : byte
    {
        /// <summary>
        /// 不受可提比例限制
        /// </summary>
        Enable = (byte)'0',

        /// <summary>
        /// 受可提比例限制
        /// </summary>
        Disable = (byte)'2'
    }

    /// <summary>
    /// TFtdcFuturePwdFlagType是一个资金密码核对标志类型
    /// </summary>
    public enum TThostFtdcFuturePwdFlagType : byte
    {
        /// <summary>
        /// 不核对
        /// </summary>
        UnCheck = (byte)'0',

        /// <summary>
        /// 核对
        /// </summary>
        Check = (byte)'1'
    }

    /// <summary>
    /// TFtdcTransferTypeType是一个银期转账类型类型
    /// </summary>
    public enum TThostFtdcTransferTypeType : byte
    {
        /// <summary>
        /// 银行转期货
        /// </summary>
        BankToFuture = (byte)'0',

        /// <summary>
        /// 期货转银行
        /// </summary>
        FutureToBank = (byte)'1'
    }

    /// <summary>
    /// TFtdcTransferValidFlagType是一个转账有效标志类型
    /// </summary>
    public enum TThostFtdcTransferValidFlagType : byte
    {
        /// <summary>
        /// 无效或失败
        /// </summary>
        Invalid = (byte)'0',

        /// <summary>
        /// 有效
        /// </summary>
        Valid = (byte)'1',

        /// <summary>
        /// 冲正
        /// </summary>
        Reverse = (byte)'2'
    }

    /// <summary>
    /// TFtdcReasonType是一个事由类型
    /// </summary>
    public enum TThostFtdcReasonType : byte
    {
        /// <summary>
        /// 错单
        /// </summary>
        CD = (byte)'0',

        /// <summary>
        /// 资金在途
        /// </summary>
        ZT = (byte)'1',

        /// <summary>
        /// 其它
        /// </summary>
        QT = (byte)'2'
    }

    /// <summary>
    /// TFtdcSexType是一个性别类型
    /// </summary>
    public enum TThostFtdcSexType : byte
    {
        /// <summary>
        /// 未知
        /// </summary>
        None = (byte)'0',

        /// <summary>
        /// 男
        /// </summary>
        Man = (byte)'1',

        /// <summary>
        /// 女
        /// </summary>
        Woman = (byte)'2'
    }

    /// <summary>
    /// TFtdcUserTypeType是一个用户类型类型
    /// </summary>
    public enum TThostFtdcUserTypeType : byte
    {
        /// <summary>
        /// 投资者
        /// </summary>
        Investor = (byte)'0',

        /// <summary>
        /// 操作员
        /// </summary>
        Operator = (byte)'1',

        /// <summary>
        /// 管理员
        /// </summary>
        SuperUser = (byte)'2'
    }

    /// <summary>
    /// TFtdcRateTypeType是一个费率类型类型
    /// </summary>
    public enum TThostFtdcRateTypeType : byte
    {
        /// <summary>
        /// 保证金率
        /// </summary>
        MarginRate = (byte)'2'
    }

    /// <summary>
    /// TFtdcNoteTypeType是一个通知类型类型
    /// </summary>
    public enum TThostFtdcNoteTypeType : byte
    {
        /// <summary>
        /// 交易结算单
        /// </summary>
        TradeSettleBill = (byte)'1',

        /// <summary>
        /// 交易结算月报
        /// </summary>
        TradeSettleMonth = (byte)'2',

        /// <summary>
        /// 追加保证金通知书
        /// </summary>
        CallMarginNotes = (byte)'3',

        /// <summary>
        /// 强行平仓通知书
        /// </summary>
        ForceCloseNotes = (byte)'4',

        /// <summary>
        /// 成交通知书
        /// </summary>
        TradeNotes = (byte)'5',

        /// <summary>
        /// 交割通知书
        /// </summary>
        DelivNotes = (byte)'6'
    }

    /// <summary>
    /// TFtdcSettlementStyleType是一个结算单方式类型
    /// </summary>
    public enum TThostFtdcSettlementStyleType : byte
    {
        /// <summary>
        /// 逐日盯市
        /// </summary>
        Day = (byte)'1',

        /// <summary>
        /// 逐笔对冲
        /// </summary>
        Volume = (byte)'2'
    }

    /// <summary>
    /// TFtdcSettlementBillTypeType是一个结算单类型类型
    /// </summary>
    public enum TThostFtdcSettlementBillTypeType : byte
    {
        /// <summary>
        /// 日报
        /// </summary>
        Day = (byte)'0',

        /// <summary>
        /// 月报
        /// </summary>
        Month = (byte)'1'
    }

    /// <summary>
    /// TFtdcUserRightTypeType是一个客户权限类型类型
    /// </summary>
    public enum TThostFtdcUserRightTypeType : byte
    {
        /// <summary>
        /// 登录
        /// </summary>
        Logon = (byte)'1',

        /// <summary>
        /// 银期转帐
        /// </summary>
        Transfer = (byte)'2',

        /// <summary>
        /// 邮寄结算单
        /// </summary>
        EMail = (byte)'3',

        /// <summary>
        /// 传真结算单
        /// </summary>
        Fax = (byte)'4',

        /// <summary>
        /// 条件单
        /// </summary>
        ConditionOrder = (byte)'5'
    }

    /// <summary>
    /// TFtdcMarginPriceTypeType是一个保证金价格类型类型
    /// </summary>
    public enum TThostFtdcMarginPriceTypeType : byte
    {
        /// <summary>
        /// 昨结算价
        /// </summary>
        PreSettlementPrice = (byte)'1',

        /// <summary>
        /// 最新价
        /// </summary>
        SettlementPrice = (byte)'2',

        /// <summary>
        /// 成交均价
        /// </summary>
        AveragePrice = (byte)'3',

        /// <summary>
        /// 开仓价
        /// </summary>
        OpenPrice = (byte)'4'
    }

    /// <summary>
    /// TFtdcBillGenStatusType是一个结算单生成状态类型
    /// </summary>
    public enum TThostFtdcBillGenStatusType : byte
    {
        /// <summary>
        /// 不生成
        /// </summary>
        None = (byte)'0',

        /// <summary>
        /// 未生成
        /// </summary>
        NoGenerated = (byte)'1',

        /// <summary>
        /// 已生成
        /// </summary>
        Generated = (byte)'2'
    }

    /// <summary>
    /// TFtdcAlgoTypeType是一个算法类型类型
    /// </summary>
    public enum TThostFtdcAlgoTypeType : byte
    {
        /// <summary>
        /// 持仓处理算法
        /// </summary>
        HandlePositionAlgo = (byte)'1',

        /// <summary>
        /// 寻找保证金率算法
        /// </summary>
        FindMarginRateAlgo = (byte)'2'
    }

    /// <summary>
    /// TFtdcHandlePositionAlgoIDType是一个持仓处理算法编号类型
    /// </summary>
    public enum TThostFtdcHandlePositionAlgoIDType : byte
    {
        /// <summary>
        /// 基本
        /// </summary>
        Base = (byte)'1',

        /// <summary>
        /// 大连商品交易所
        /// </summary>
        DCE = (byte)'2',

        /// <summary>
        /// 郑州商品交易所
        /// </summary>
        CZCE = (byte)'3'
    }

    /// <summary>
    /// TFtdcFindMarginRateAlgoIDType是一个寻找保证金率算法编号类型
    /// </summary>
    public enum TThostFtdcFindMarginRateAlgoIDType : byte
    {
        /// <summary>
        /// 基本
        /// </summary>
        Base = (byte)'1',

        /// <summary>
        /// 大连商品交易所
        /// </summary>
        DCE = (byte)'2',

        /// <summary>
        /// 郑州商品交易所
        /// </summary>
        CZCE = (byte)'3'
    }

    /// <summary>
    /// TFtdcHandleTradingAccountAlgoIDType是一个资金处理算法编号类型
    /// </summary>
    public enum TThostFtdcHandleTradingAccountAlgoIDType : byte
    {
        /// <summary>
        /// 基本
        /// </summary>
        Base = (byte)'1',

        /// <summary>
        /// 大连商品交易所
        /// </summary>
        DCE = (byte)'2',

        /// <summary>
        /// 郑州商品交易所
        /// </summary>
        CZCE = (byte)'3'
    }

    /// <summary>
    /// TFtdcPersonTypeType是一个联系人类型类型
    /// </summary>
    public enum TThostFtdcPersonTypeType : byte
    {
        /// <summary>
        /// 指定下单人
        /// </summary>
        Order = (byte)'1',

        /// <summary>
        /// 开户授权人
        /// </summary>
        Open = (byte)'2',

        /// <summary>
        /// 资金调拨人
        /// </summary>
        Fund = (byte)'3',

        /// <summary>
        /// 结算单确认人
        /// </summary>
        Settlement = (byte)'4',

        /// <summary>
        /// 法人
        /// </summary>
        Company = (byte)'5',

        /// <summary>
        /// 法人代表
        /// </summary>
        Corporation = (byte)'6',

        /// <summary>
        /// 投资者联系人
        /// </summary>
        LinkMan = (byte)'7'
    }

    /// <summary>
    /// TFtdcQueryInvestorRangeType是一个查询范围类型
    /// </summary>
    public enum TThostFtdcQueryInvestorRangeType : byte
    {
        /// <summary>
        /// 所有
        /// </summary>
        All = (byte)'1',

        /// <summary>
        /// 查询分类
        /// </summary>
        Group = (byte)'2',

        /// <summary>
        /// 单一投资者
        /// </summary>
        Single = (byte)'3'
    }

    /// <summary>
    /// TFtdcInvestorRiskStatusType是一个投资者风险状态类型
    /// </summary>
    public enum TThostFtdcInvestorRiskStatusType : byte
    {
        /// <summary>
        /// 正常
        /// </summary>
        Normal = (byte)'1',

        /// <summary>
        /// 警告
        /// </summary>
        Warn = (byte)'2',

        /// <summary>
        /// 追保
        /// </summary>
        Call = (byte)'3',

        /// <summary>
        /// 强平
        /// </summary>
        Force = (byte)'4',

        /// <summary>
        /// 异常
        /// </summary>
        Exception = (byte)'5'
    }

    /// <summary>
    /// TFtdcUserEventTypeType是一个用户事件类型类型
    /// </summary>
    public enum TThostFtdcUserEventTypeType : byte
    {
        /// <summary>
        /// 登录
        /// </summary>
        Login = (byte)'1',

        /// <summary>
        /// 登出
        /// </summary>
        Logout = (byte)'2',

        /// <summary>
        /// 交易成功
        /// </summary>
        Trading = (byte)'3',

        /// <summary>
        /// 交易失败
        /// </summary>
        TradingError = (byte)'4',

        /// <summary>
        /// 修改密码
        /// </summary>
        UpdatePassword = (byte)'5',

        /// <summary>
        /// 客户端认证
        /// </summary>
        Authenticate = (byte)'6',

        /// <summary>
        /// 其他
        /// </summary>
        Other = (byte)'9'
    }

    /// <summary>
    /// TFtdcCloseStyleType是一个平仓方式类型
    /// </summary>
    public enum TThostFtdcCloseStyleType : byte
    {
        /// <summary>
        /// 先开先平
        /// </summary>
        Close = (byte)'0',

        /// <summary>
        /// 先平今再平昨
        /// </summary>
        CloseToday = (byte)'1'
    }

    /// <summary>
    /// TFtdcStatModeType是一个统计方式类型
    /// </summary>
    public enum TThostFtdcStatModeType : byte
    {
        /// <summary>
        /// ----
        /// </summary>
        Non = (byte)'0',

        /// <summary>
        /// 按合约统计
        /// </summary>
        Instrument = (byte)'1',

        /// <summary>
        /// 按产品统计
        /// </summary>
        Product = (byte)'2',

        /// <summary>
        /// 按投资者统计
        /// </summary>
        Investor = (byte)'3'
    }

    /// <summary>
    /// TFtdcParkedOrderStatusType是一个预埋单状态类型
    /// </summary>
    public enum TThostFtdcParkedOrderStatusType : byte
    {
        /// <summary>
        /// 未发送
        /// </summary>
        NotSend = (byte)'1',

        /// <summary>
        /// 已发送
        /// </summary>
        Send = (byte)'2',

        /// <summary>
        /// 已删除
        /// </summary>
        Deleted = (byte)'3'
    }

    /// <summary>
    /// TFtdcVirDealStatusType是一个处理状态类型
    /// </summary>
    public enum TThostFtdcVirDealStatusType : byte
    {
        /// <summary>
        /// 正在处理
        /// </summary>
        Dealing = (byte)'1',

        /// <summary>
        /// 处理成功
        /// </summary>
        DeaclSucceed = (byte)'2'
    }

    /// <summary>
    /// TFtdcOrgSystemIDType是一个原有系统代码类型
    /// </summary>
    public enum TThostFtdcOrgSystemIDType : byte
    {
        /// <summary>
        /// 综合交易平台
        /// </summary>
        Standard = (byte)'0',

        /// <summary>
        /// 易盛系统
        /// </summary>
        ESunny = (byte)'1',

        /// <summary>
        /// 金仕达V6系统
        /// </summary>
        KingStarV6 = (byte)'2'
    }

    /// <summary>
    /// TFtdcVirTradeStatusType是一个交易状态类型
    /// </summary>
    public enum TThostFtdcVirTradeStatusType : byte
    {
        /// <summary>
        /// 正常处理中
        /// </summary>
        NaturalDeal = (byte)'0',

        /// <summary>
        /// 成功结束
        /// </summary>
        SucceedEnd = (byte)'1',

        /// <summary>
        /// 失败结束
        /// </summary>
        FailedEND = (byte)'2',

        /// <summary>
        /// 异常中
        /// </summary>
        Exception = (byte)'3',

        /// <summary>
        /// 已人工异常处理
        /// </summary>
        ManualDeal = (byte)'4',

        /// <summary>
        /// 通讯异常 ，请人工处理
        /// </summary>
        MesException = (byte)'5',

        /// <summary>
        /// 系统出错，请人工处理
        /// </summary>
        SysException = (byte)'6'
    }

    /// <summary>
    /// TFtdcVirBankAccTypeType是一个银行帐户类型类型
    /// </summary>
    public enum TThostFtdcVirBankAccTypeType : byte
    {
        /// <summary>
        /// 存折
        /// </summary>
        BankBook = (byte)'1',

        /// <summary>
        /// 储蓄卡
        /// </summary>
        BankCard = (byte)'2',

        /// <summary>
        /// 信用卡
        /// </summary>
        CreditCard = (byte)'3'
    }

    /// <summary>
    /// TFtdcVirementStatusType是一个银行帐户类型类型
    /// </summary>
    public enum TThostFtdcVirementStatusType : byte
    {
        /// <summary>
        /// 正常
        /// </summary>
        Natural = (byte)'0',

        /// <summary>
        /// 销户
        /// </summary>
        Canceled = (byte)'9'
    }

    /// <summary>
    /// TFtdcVirementAvailAbilityType是一个有效标志类型
    /// </summary>
    public enum TThostFtdcVirementAvailAbilityType : byte
    {
        /// <summary>
        /// 未确认
        /// </summary>
        NoAvailAbility = (byte)'0',

        /// <summary>
        /// 有效
        /// </summary>
        AvailAbility = (byte)'1',

        /// <summary>
        /// 冲正
        /// </summary>
        Repeal = (byte)'2'
    }

    /// <summary>
    /// TFtdcAMLGenStatusType是一个Aml生成方式类型
    /// </summary>
    public enum TThostFtdcAMLGenStatusType : byte
    {
        /// <summary>
        /// 程序生成
        /// </summary>
        Program = (byte)'0',

        /// <summary>
        /// 人工生成
        /// </summary>
        HandWork = (byte)'1'
    }

    /// <summary>
    /// TFtdcCFMMCKeyKindType是一个动态密钥类别(保证金监管)类型
    /// </summary>
    public enum TThostFtdcCFMMCKeyKindType : byte
    {
        /// <summary>
        /// 主动请求更新
        /// </summary>
        REQUEST = (byte)'R',

        /// <summary>
        /// CFMMC自动更新
        /// </summary>
        AUTO = (byte)'A',

        /// <summary>
        /// CFMMC手动更新
        /// </summary>
        MANUAL = (byte)'M'
    }

    /// <summary>
    /// TFtdcCertificationTypeType是一个证件类型类型
    /// </summary>
    public enum TThostFtdcCertificationTypeType : byte
    {
        /// <summary>
        /// 身份证
        /// </summary>
        IDCard = (byte)'0',

        /// <summary>
        /// 护照
        /// </summary>
        Passport = (byte)'1',

        /// <summary>
        /// 军官证
        /// </summary>
        OfficerIDCard = (byte)'2',

        /// <summary>
        /// 士兵证
        /// </summary>
        SoldierIDCard = (byte)'3',

        /// <summary>
        /// 回乡证
        /// </summary>
        HomeComingCard = (byte)'4',

        /// <summary>
        /// 户口簿
        /// </summary>
        HouseholdRegister = (byte)'5',

        /// <summary>
        /// 营业执照号
        /// </summary>
        LicenseNo = (byte)'6',

        /// <summary>
        /// 组织机构代码证
        /// </summary>
        InstitutionCodeCard = (byte)'7',

        /// <summary>
        /// 临时营业执照号
        /// </summary>
        TempLicenseNo = (byte)'8',

        /// <summary>
        /// 民办非企业登记证书
        /// </summary>
        NoEnterpriseLicenseNo = (byte)'9',

        /// <summary>
        /// 其他证件
        /// </summary>
        OtherCard = (byte)'x',

        /// <summary>
        /// 主管部门批文
        /// </summary>
        SuperDepAgree = (byte)'a'
    }

    /// <summary>
    /// TFtdcFileBusinessCodeType是一个文件业务功能类型
    /// </summary>
    public enum TThostFtdcFileBusinessCodeType : byte
    {
        /// <summary>
        /// 其他
        /// </summary>
        Others = (byte)'0',

        /// <summary>
        /// 转账交易明细对账
        /// </summary>
        TransferDetails = (byte)'1',

        /// <summary>
        /// 客户账户状态对账
        /// </summary>
        CustAccStatus = (byte)'2',

        /// <summary>
        /// 账户类交易明细对账
        /// </summary>
        AccountTradeDetails = (byte)'3',

        /// <summary>
        /// 期货账户信息变更明细对账
        /// </summary>
        FutureAccountChangeInfoDetails = (byte)'4',

        /// <summary>
        /// 客户资金台账余额明细对账
        /// </summary>
        CustMoneyDetail = (byte)'5',

        /// <summary>
        /// 客户销户结息明细对账
        /// </summary>
        CustCancelAccountInfo = (byte)'6',

        /// <summary>
        /// 客户资金余额对账结果
        /// </summary>
        CustMoneyResult = (byte)'7',

        /// <summary>
        /// 其它对账异常结果文件
        /// </summary>
        OthersExceptionResult = (byte)'8',

        /// <summary>
        /// 客户结息净额明细
        /// </summary>
        CustInterestNetMoneyDetails = (byte)'9',

        /// <summary>
        /// 客户资金交收明细
        /// </summary>
        CustMoneySendAndReceiveDetails = (byte)'a',

        /// <summary>
        /// 法人存管银行资金交收汇总
        /// </summary>
        CorporationMoneyTotal = (byte)'b',

        /// <summary>
        /// 主体间资金交收汇总
        /// </summary>
        MainbodyMoneyTotal = (byte)'c',

        /// <summary>
        /// 总分平衡监管数据
        /// </summary>
        MainPartMonitorData = (byte)'d',

        /// <summary>
        /// 存管银行备付金余额
        /// </summary>
        PreparationMoney = (byte)'e',

        /// <summary>
        /// 协办存管银行资金监管数据
        /// </summary>
        BankMoneyMonitorData = (byte)'f'
    }

    /// <summary>
    /// TFtdcCashExchangeCodeType是一个汇钞标志类型
    /// </summary>
    public enum TThostFtdcCashExchangeCodeType : byte
    {
        /// <summary>
        /// 汇
        /// </summary>
        Exchange = (byte)'1',

        /// <summary>
        /// 钞
        /// </summary>
        Cash = (byte)'2'
    }

    /// <summary>
    /// TFtdcYesNoIndicatorType是一个是或否标识类型
    /// </summary>
    public enum TThostFtdcYesNoIndicatorType : byte
    {
        /// <summary>
        /// 是
        /// </summary>
        Yes = (byte)'0',

        /// <summary>
        /// 否
        /// </summary>
        No = (byte)'1'
    }

    /// <summary>
    /// TFtdcBanlanceTypeType是一个余额类型类型
    /// </summary>
    public enum TThostFtdcBanlanceTypeType : byte
    {
        /// <summary>
        /// 当前余额
        /// </summary>
        CurrentMoney = (byte)'0',

        /// <summary>
        /// 可用余额
        /// </summary>
        UsableMoney = (byte)'1',

        /// <summary>
        /// 可取余额
        /// </summary>
        FetchableMoney = (byte)'2',

        /// <summary>
        /// 冻结余额
        /// </summary>
        FreezeMoney = (byte)'3'
    }

    /// <summary>
    /// TFtdcGenderType是一个性别类型
    /// </summary>
    public enum TThostFtdcGenderType : byte
    {
        /// <summary>
        /// 未知状态
        /// </summary>
        Unknown = (byte)'0',

        /// <summary>
        /// 男
        /// </summary>
        Male = (byte)'1',

        /// <summary>
        /// 女
        /// </summary>
        Female = (byte)'2'
    }

    /// <summary>
    /// TFtdcFeePayFlagType是一个费用支付标志类型
    /// </summary>
    public enum TThostFtdcFeePayFlagType : byte
    {
        /// <summary>
        /// 由受益方支付费用
        /// </summary>
        BEN = (byte)'0',

        /// <summary>
        /// 由发送方支付费用
        /// </summary>
        OUR = (byte)'1',

        /// <summary>
        /// 由发送方支付发起的费用，受益方支付接受的费用
        /// </summary>
        SHA = (byte)'2'
    }

    /// <summary>
    /// TFtdcPassWordKeyTypeType是一个密钥类型类型
    /// </summary>
    public enum TThostFtdcPassWordKeyTypeType : byte
    {
        /// <summary>
        /// 交换密钥
        /// </summary>
        ExchangeKey = (byte)'0',

        /// <summary>
        /// 密码密钥
        /// </summary>
        PassWordKey = (byte)'1',

        /// <summary>
        /// MAC密钥
        /// </summary>
        MACKey = (byte)'2',

        /// <summary>
        /// 报文密钥
        /// </summary>
        MessageKey = (byte)'3'
    }

    /// <summary>
    /// TFtdcFBTPassWordTypeType是一个密码类型类型
    /// </summary>
    public enum TThostFtdcFBTPassWordTypeType : byte
    {
        /// <summary>
        /// 查询
        /// </summary>
        Query = (byte)'0',

        /// <summary>
        /// 取款
        /// </summary>
        Fetch = (byte)'1',

        /// <summary>
        /// 转帐
        /// </summary>
        Transfer = (byte)'2',

        /// <summary>
        /// 交易
        /// </summary>
        Trade = (byte)'3'
    }

    /// <summary>
    /// TFtdcBankRepealFlagType是一个银行冲正标志类型
    /// </summary>
    public enum TThostFtdcBankRepealFlagType : byte
    {
        /// <summary>
        /// 银行无需自动冲正
        /// </summary>
        BankNotNeedRepeal = (byte)'0',

        /// <summary>
        /// 银行待自动冲正
        /// </summary>
        BankWaitingRepeal = (byte)'1',

        /// <summary>
        /// 银行已自动冲正
        /// </summary>
        BankBeenRepealed = (byte)'2'
    }

    /// <summary>
    /// TFtdcBrokerRepealFlagType是一个期商冲正标志类型
    /// </summary>
    public enum TThostFtdcBrokerRepealFlagType : byte
    {
        /// <summary>
        /// 期商无需自动冲正
        /// </summary>
        BrokerNotNeedRepeal = (byte)'0',

        /// <summary>
        /// 期商待自动冲正
        /// </summary>
        BrokerWaitingRepeal = (byte)'1',

        /// <summary>
        /// 期商已自动冲正
        /// </summary>
        BrokerBeenRepealed = (byte)'2'
    }

    /// <summary>
    /// TFtdcInstitutionTypeType是一个机构类别类型
    /// </summary>
    public enum TThostFtdcInstitutionTypeType : byte
    {
        /// <summary>
        /// 银行
        /// </summary>
        Bank = (byte)'0',

        /// <summary>
        /// 期商
        /// </summary>
        Future = (byte)'1',

        /// <summary>
        /// 券商
        /// </summary>
        Store = (byte)'2'
    }

    /// <summary>
    /// TFtdcLastFragmentType是一个最后分片标志类型
    /// </summary>
    public enum TThostFtdcLastFragmentType : byte
    {
        /// <summary>
        /// 是最后分片
        /// </summary>
        Yes = (byte)'0',

        /// <summary>
        /// 不是最后分片
        /// </summary>
        No = (byte)'1'
    }

    /// <summary>
    /// TFtdcBankAccStatusType是一个银行账户状态类型
    /// </summary>
    public enum TThostFtdcBankAccStatusType : byte
    {
        /// <summary>
        /// 正常
        /// </summary>
        Normal = (byte)'0',

        /// <summary>
        /// 冻结
        /// </summary>
        Freeze = (byte)'1',

        /// <summary>
        /// 挂失
        /// </summary>
        ReportLoss = (byte)'2'
    }

    /// <summary>
    /// TFtdcMoneyAccountStatusType是一个资金账户状态类型
    /// </summary>
    public enum TThostFtdcMoneyAccountStatusType : byte
    {
        /// <summary>
        /// 正常
        /// </summary>
        Normal = (byte)'0',

        /// <summary>
        /// 销户
        /// </summary>
        Cancel = (byte)'1'
    }

    /// <summary>
    /// TFtdcManageStatusType是一个存管状态类型
    /// </summary>
    public enum TThostFtdcManageStatusType : byte
    {
        /// <summary>
        /// 指定存管
        /// </summary>
        Point = (byte)'0',

        /// <summary>
        /// 预指定
        /// </summary>
        PrePoint = (byte)'1',

        /// <summary>
        /// 撤销指定
        /// </summary>
        CancelPoint = (byte)'2'
    }

    /// <summary>
    /// TFtdcSystemTypeType是一个应用系统类型类型
    /// </summary>
    public enum TThostFtdcSystemTypeType : byte
    {
        /// <summary>
        /// 银期转帐
        /// </summary>
        FutureBankTransfer = (byte)'0',

        /// <summary>
        /// 银证转帐
        /// </summary>
        StockBankTransfer = (byte)'1',

        /// <summary>
        /// 第三方存管
        /// </summary>
        TheThirdPartStore = (byte)'2'
    }

    /// <summary>
    /// TFtdcTxnEndFlagType是一个银期转帐划转结果标志类型
    /// </summary>
    public enum TThostFtdcTxnEndFlagType : byte
    {
        /// <summary>
        /// 正常处理中
        /// </summary>
        NormalProcessing = (byte)'0',

        /// <summary>
        /// 成功结束
        /// </summary>
        Success = (byte)'1',

        /// <summary>
        /// 失败结束
        /// </summary>
        Failed = (byte)'2',

        /// <summary>
        /// 异常中
        /// </summary>
        Abnormal = (byte)'3',

        /// <summary>
        /// 已人工异常处理
        /// </summary>
        ManualProcessedForException = (byte)'4',

        /// <summary>
        /// 通讯异常 ，请人工处理
        /// </summary>
        CommuFailedNeedManualProcess = (byte)'5',

        /// <summary>
        /// 系统出错，请人工处理
        /// </summary>
        SysErrorNeedManualProcess = (byte)'6'
    }

    /// <summary>
    /// TFtdcProcessStatusType是一个银期转帐服务处理状态类型
    /// </summary>
    public enum TThostFtdcProcessStatusType : byte
    {
        /// <summary>
        /// 未处理
        /// </summary>
        NotProcess = (byte)'0',

        /// <summary>
        /// 开始处理
        /// </summary>
        StartProcess = (byte)'1',

        /// <summary>
        /// 处理完成
        /// </summary>
        Finished = (byte)'2'
    }

    /// <summary>
    /// TFtdcCustTypeType是一个客户类型类型
    /// </summary>
    public enum TThostFtdcCustTypeType : byte
    {
        /// <summary>
        /// 自然人
        /// </summary>
        Person = (byte)'0',

        /// <summary>
        /// 机构户
        /// </summary>
        Institution = (byte)'1'
    }

    /// <summary>
    /// TFtdcFBTTransferDirectionType是一个银期转帐方向类型
    /// </summary>
    public enum TThostFtdcFBTTransferDirectionType : byte
    {
        /// <summary>
        /// 入金，银行转期货
        /// </summary>
        FromBankToFuture = (byte)'1',

        /// <summary>
        /// 出金，期货转银行
        /// </summary>
        FromFutureToBank = (byte)'2'
    }

    /// <summary>
    /// TFtdcOpenOrDestroyType是一个开销户类别类型
    /// </summary>
    public enum TThostFtdcOpenOrDestroyType : byte
    {
        /// <summary>
        /// 开户
        /// </summary>
        Open = (byte)'1',

        /// <summary>
        /// 销户
        /// </summary>
        Destroy = (byte)'0'
    }

    /// <summary>
    /// TFtdcAvailabilityFlagType是一个有效标志类型
    /// </summary>
    public enum TThostFtdcAvailabilityFlagType : byte
    {
        /// <summary>
        /// 未确认
        /// </summary>
        Invalid = (byte)'0',

        /// <summary>
        /// 有效
        /// </summary>
        Valid = (byte)'1',

        /// <summary>
        /// 冲正
        /// </summary>
        Repeal = (byte)'2'
    }

    /// <summary>
    /// TFtdcOrganTypeType是一个机构类型类型
    /// </summary>
    public enum TThostFtdcOrganTypeType : byte
    {
        /// <summary>
        /// 银行代理
        /// </summary>
        Bank = (byte)'1',

        /// <summary>
        /// 交易前置
        /// </summary>
        Future = (byte)'2',

        /// <summary>
        /// 银期转帐平台管理
        /// </summary>
        PlateForm = (byte)'9'
    }

    /// <summary>
    /// TFtdcOrganLevelType是一个机构级别类型
    /// </summary>
    public enum TThostFtdcOrganLevelType : byte
    {
        /// <summary>
        /// 银行总行或期商总部
        /// </summary>
        HeadQuarters = (byte)'1',

        /// <summary>
        /// 银行分中心或期货公司营业部
        /// </summary>
        Branch = (byte)'2'
    }

    /// <summary>
    /// TFtdcProtocalIDType是一个协议类型类型
    /// </summary>
    public enum TThostFtdcProtocalIDType : byte
    {
        /// <summary>
        /// 期商协议
        /// </summary>
        FutureProtocal = (byte)'0',

        /// <summary>
        /// 工行协议
        /// </summary>
        ICBCProtocal = (byte)'1',

        /// <summary>
        /// 农行协议
        /// </summary>
        ABCProtocal = (byte)'2',

        /// <summary>
        /// 中国银行协议
        /// </summary>
        CBCProtocal = (byte)'3',

        /// <summary>
        /// 建行协议
        /// </summary>
        CCBProtocal = (byte)'4',

        /// <summary>
        /// 交行协议
        /// </summary>
        BOCOMProtocal = (byte)'5',

        /// <summary>
        /// 银期转帐平台协议
        /// </summary>
        FBTPlateFormProtocal = (byte)'X'
    }

    /// <summary>
    /// TFtdcConnectModeType是一个套接字连接方式类型
    /// </summary>
    public enum TThostFtdcConnectModeType : byte
    {
        /// <summary>
        /// 短连接
        /// </summary>
        ShortConnect = (byte)'0',

        /// <summary>
        /// 长连接
        /// </summary>
        LongConnect = (byte)'1'
    }

    /// <summary>
    /// TFtdcSyncModeType是一个套接字通信方式类型
    /// </summary>
    public enum TThostFtdcSyncModeType : byte
    {
        /// <summary>
        /// 异步
        /// </summary>
        ASync = (byte)'0',

        /// <summary>
        /// 同步
        /// </summary>
        Sync = (byte)'1'
    }

    /// <summary>
    /// TFtdcBankAccTypeType是一个银行帐号类型类型
    /// </summary>
    public enum TThostFtdcBankAccTypeType : byte
    {
        /// <summary>
        /// 银行存折
        /// </summary>
        BankBook = (byte)'1',

        /// <summary>
        /// 储蓄卡
        /// </summary>
        SavingCard = (byte)'2',

        /// <summary>
        /// 信用卡
        /// </summary>
        CreditCard = (byte)'3'
    }

    /// <summary>
    /// TFtdcFutureAccTypeType是一个期货公司帐号类型类型
    /// </summary>
    public enum TThostFtdcFutureAccTypeType : byte
    {
        /// <summary>
        /// 银行存折
        /// </summary>
        BankBook = (byte)'1',

        /// <summary>
        /// 储蓄卡
        /// </summary>
        SavingCard = (byte)'2',

        /// <summary>
        /// 信用卡
        /// </summary>
        CreditCard = (byte)'3'
    }

    /// <summary>
    /// TFtdcOrganStatusType是一个接入机构状态类型
    /// </summary>
    public enum TThostFtdcOrganStatusType : byte
    {
        /// <summary>
        /// 启用
        /// </summary>
        Ready = (byte)'0',

        /// <summary>
        /// 签到
        /// </summary>
        CheckIn = (byte)'1',

        /// <summary>
        /// 签退
        /// </summary>
        CheckOut = (byte)'2',

        /// <summary>
        /// 对帐文件到达
        /// </summary>
        CheckFileArrived = (byte)'3',

        /// <summary>
        /// 对帐
        /// </summary>
        CheckDetail = (byte)'4',

        /// <summary>
        /// 日终清理
        /// </summary>
        DayEndClean = (byte)'5',

        /// <summary>
        /// 注销
        /// </summary>
        Invalid = (byte)'9'
    }

    /// <summary>
    /// TFtdcCCBFeeModeType是一个建行收费模式类型
    /// </summary>
    public enum TThostFtdcCCBFeeModeType : byte
    {
        /// <summary>
        /// 按金额扣收
        /// </summary>
        ByAmount = (byte)'1',

        /// <summary>
        /// 按月扣收
        /// </summary>
        ByMonth = (byte)'2'
    }

    /// <summary>
    /// TFtdcCommApiTypeType是一个通讯API类型类型
    /// </summary>
    public enum TThostFtdcCommApiTypeType : byte
    {
        /// <summary>
        /// 客户端
        /// </summary>
        Client = (byte)'1',

        /// <summary>
        /// 服务端
        /// </summary>
        Server = (byte)'2',

        /// <summary>
        /// 交易系统的UserApi
        /// </summary>
        UserApi = (byte)'3'
    }

    /// <summary>
    /// TFtdcLinkStatusType是一个连接状态类型
    /// </summary>
    public enum TThostFtdcLinkStatusType : byte
    {
        /// <summary>
        /// 已经连接
        /// </summary>
        Connected = (byte)'1',

        /// <summary>
        /// 没有连接
        /// </summary>
        Disconnected = (byte)'2'
    }

    /// <summary>
    /// TFtdcPwdFlagType是一个密码核对标志类型
    /// </summary>
    public enum TThostFtdcPwdFlagType : byte
    {
        /// <summary>
        /// 不核对
        /// </summary>
        NoCheck = (byte)'0',

        /// <summary>
        /// 明文核对
        /// </summary>
        BlankCheck = (byte)'1',

        /// <summary>
        /// 密文核对
        /// </summary>
        EncryptCheck = (byte)'2'
    }

    /// <summary>
    /// TFtdcSecuAccTypeType是一个期货帐号类型类型
    /// </summary>
    public enum TThostFtdcSecuAccTypeType : byte
    {
        /// <summary>
        /// 资金帐号
        /// </summary>
        AccountID = (byte)'1',

        /// <summary>
        /// 资金卡号
        /// </summary>
        CardID = (byte)'2',

        /// <summary>
        /// 上海股东帐号
        /// </summary>
        SHStockholderID = (byte)'3',

        /// <summary>
        /// 深圳股东帐号
        /// </summary>
        SZStockholderID = (byte)'4'
    }

    /// <summary>
    /// TFtdcTransferStatusType是一个转账交易状态类型
    /// </summary>
    public enum TThostFtdcTransferStatusType : byte
    {
        /// <summary>
        /// 正常
        /// </summary>
        Normal = (byte)'0',

        /// <summary>
        /// 被冲正
        /// </summary>
        Repealed = (byte)'1'
    }

    /// <summary>
    /// TFtdcSponsorTypeType是一个发起方类型
    /// </summary>
    public enum TThostFtdcSponsorTypeType : byte
    {
        /// <summary>
        /// 期商
        /// </summary>
        Broker = (byte)'0',

        /// <summary>
        /// 银行
        /// </summary>
        Bank = (byte)'1'
    }

    /// <summary>
    /// TFtdcReqRspTypeType是一个请求响应类别类型
    /// </summary>
    public enum TThostFtdcReqRspTypeType : byte
    {
        /// <summary>
        /// 请求
        /// </summary>
        Request = (byte)'0',

        /// <summary>
        /// 响应
        /// </summary>
        Response = (byte)'1'
    }

    /// <summary>
    /// TFtdcFBTUserEventTypeType是一个银期转帐用户事件类型类型
    /// </summary>
    public enum TThostFtdcFBTUserEventTypeType : byte
    {
        /// <summary>
        /// 签到
        /// </summary>
        SignIn = (byte)'0',

        /// <summary>
        /// 银行转期货
        /// </summary>
        FromBankToFuture = (byte)'1',

        /// <summary>
        /// 期货转银行
        /// </summary>
        FromFutureToBank = (byte)'2',

        /// <summary>
        /// 开户
        /// </summary>
        OpenAccount = (byte)'3',

        /// <summary>
        /// 销户
        /// </summary>
        CancelAccount = (byte)'4',

        /// <summary>
        /// 变更银行账户
        /// </summary>
        ChangeAccount = (byte)'5',

        /// <summary>
        /// 冲正银行转期货
        /// </summary>
        RepealFromBankToFuture = (byte)'6',

        /// <summary>
        /// 冲正期货转银行
        /// </summary>
        RepealFromFutureToBank = (byte)'7',

        /// <summary>
        /// 查询银行账户
        /// </summary>
        QueryBankAccount = (byte)'8',

        /// <summary>
        /// 查询期货账户
        /// </summary>
        QueryFutureAccount = (byte)'9',

        /// <summary>
        /// 签退
        /// </summary>
        SignOut = (byte)'A',

        /// <summary>
        /// 密钥同步
        /// </summary>
        SyncKey = (byte)'B',

        /// <summary>
        /// 其他
        /// </summary>
        Other = (byte)'Z'
    }

    /// <summary>
    /// TFtdcNotifyClassType是一个风险通知类型类型
    /// </summary>
    public enum TThostFtdcNotifyClassType : byte
    {
        /// <summary>
        /// 正常
        /// </summary>
        NOERROR = (byte)'0',

        /// <summary>
        /// 警示
        /// </summary>
        Warn = (byte)'1',

        /// <summary>
        /// 追保
        /// </summary>
        Call = (byte)'2',

        /// <summary>
        /// 强平
        /// </summary>
        Force = (byte)'3',

        /// <summary>
        /// 穿仓
        /// </summary>
        CHUANCANG = (byte)'4',

        /// <summary>
        /// 异常
        /// </summary>
        Exception = (byte)'5'
    }

    /// <summary>
    /// TFtdcForceCloseTypeType是一个强平单类型类型
    /// </summary>
    public enum TThostFtdcForceCloseTypeType : byte
    {
        /// <summary>
        /// 手工强平
        /// </summary>
        Manual = (byte)'0',

        /// <summary>
        /// 单一投资者辅助强平
        /// </summary>
        Single = (byte)'1',

        /// <summary>
        /// 批量投资者辅助强平
        /// </summary>
        Group = (byte)'2'
    }

    /// <summary>
    /// TFtdcRiskNotifyMethodType是一个风险通知途径类型
    /// </summary>
    public enum TThostFtdcRiskNotifyMethodType : byte
    {
        /// <summary>
        /// 系统通知
        /// </summary>
        System = (byte)'0',

        /// <summary>
        /// 短信通知
        /// </summary>
        SMS = (byte)'1',

        /// <summary>
        /// 邮件通知
        /// </summary>
        EMail = (byte)'2',

        /// <summary>
        /// 人工通知
        /// </summary>
        Manual = (byte)'3'
    }

    /// <summary>
    /// TFtdcRiskNotifyStatusType是一个风险通知状态类型
    /// </summary>
    public enum TThostFtdcRiskNotifyStatusType : byte
    {
        /// <summary>
        /// 未生成
        /// </summary>
        NotGen = (byte)'0',

        /// <summary>
        /// 已生成未发送
        /// </summary>
        Generated = (byte)'1',

        /// <summary>
        /// 发送失败
        /// </summary>
        SendError = (byte)'2',

        /// <summary>
        /// 已发送未接收
        /// </summary>
        SendOk = (byte)'3',

        /// <summary>
        /// 已接收未确认
        /// </summary>
        Received = (byte)'4',

        /// <summary>
        /// 已确认
        /// </summary>
        Confirmed = (byte)'5'
    }

    /// <summary>
    /// TFtdcRiskUserEventType是一个风控用户操作事件类型
    /// </summary>
    public enum TThostFtdcRiskUserEventType : byte
    {
        /// <summary>
        /// 导出数据
        /// </summary>
        ExportData = (byte)'0'
    }

    /// <summary>
    /// TFtdcConditionalOrderSortTypeType是一个条件单索引条件类型
    /// </summary>
    public enum TThostFtdcConditionalOrderSortTypeType : byte
    {
        /// <summary>
        /// 使用最新价升序
        /// </summary>
        LastPriceAsc = (byte)'0',

        /// <summary>
        /// 使用最新价降序
        /// </summary>
        LastPriceDesc = (byte)'1',

        /// <summary>
        /// 使用卖价升序
        /// </summary>
        AskPriceAsc = (byte)'2',

        /// <summary>
        /// 使用卖价降序
        /// </summary>
        AskPriceDesc = (byte)'3',

        /// <summary>
        /// 使用买价升序
        /// </summary>
        BidPriceAsc = (byte)'4',

        /// <summary>
        /// 使用买价降序
        /// </summary>
        BidPriceDesc = (byte)'5'
    }

    /// <summary>
    /// TFtdcSendTypeType是一个报送状态类型
    /// </summary>
    public enum TThostFtdcSendTypeType : byte
    {
        /// <summary>
        /// 未发送
        /// </summary>
        NoSend = (byte)'0',

        /// <summary>
        /// 已发送
        /// </summary>
        Sended = (byte)'1',

        /// <summary>
        /// 已生成
        /// </summary>
        Generated = (byte)'2',

        /// <summary>
        /// 报送失败
        /// </summary>
        SendFail = (byte)'3',

        /// <summary>
        /// 接收成功
        /// </summary>
        Success = (byte)'4',

        /// <summary>
        /// 接收失败
        /// </summary>
        Fail = (byte)'5',

        /// <summary>
        /// 取消报送
        /// </summary>
        Cancel = (byte)'6'
    }

    /// <summary>
    /// TFtdcClientIDStatusType是一个交易编码状态类型
    /// </summary>
    public enum TThostFtdcClientIDStatusType : byte
    {
        /// <summary>
        /// 未申请
        /// </summary>
        NoApply = (byte)'1',

        /// <summary>
        /// 已提交申请
        /// </summary>
        Submited = (byte)'2',

        /// <summary>
        /// 已发送申请
        /// </summary>
        Sended = (byte)'3',

        /// <summary>
        /// 完成
        /// </summary>
        Success = (byte)'4',

        /// <summary>
        /// 拒绝
        /// </summary>
        Refuse = (byte)'5',

        /// <summary>
        /// 已撤销编码
        /// </summary>
        Cancel = (byte)'6'
    }

    /// <summary>
    /// TFtdcQuestionTypeType是一个特有信息类型类型
    /// </summary>
    public enum TThostFtdcQuestionTypeType : byte
    {
        /// <summary>
        /// 单选
        /// </summary>
        Radio = (byte)'1',

        /// <summary>
        /// 多选
        /// </summary>
        Option = (byte)'2',

        /// <summary>
        /// 填空
        /// </summary>
        Blank = (byte)'3'
    }

    /// <summary>
    /// TFtdcProcessTypeType是一个流程功能类型类型
    /// </summary>
    public enum TThostFtdcProcessTypeType : byte
    {
        /// <summary>
        /// 申请交易编码
        /// </summary>
        ApplyTradingCode = (byte)'1',

        /// <summary>
        /// 撤销交易编码
        /// </summary>
        CancelTradingCode = (byte)'2',

        /// <summary>
        /// 修改身份信息
        /// </summary>
        ModifyIDCard = (byte)'3',

        /// <summary>
        /// 修改一般信息
        /// </summary>
        ModifyNoIDCard = (byte)'4',

        /// <summary>
        /// 交易所开户报备
        /// </summary>
        ExchOpenBak = (byte)'5',

        /// <summary>
        /// 交易所销户报备
        /// </summary>
        ExchCancelBak = (byte)'6',

        /// <summary>
        /// 补报规范资料
        /// </summary>
        StandardAccount = (byte)'7',

        /// <summary>
        /// 账户休眠
        /// </summary>
        FreezeAccount = (byte)'8',

        /// <summary>
        /// 激活休眠账户
        /// </summary>
        ActiveFreezeAccount = (byte)'9'
    }

    /// <summary>
    /// TFtdcBusinessTypeType是一个业务类型类型
    /// </summary>
    public enum TThostFtdcBusinessTypeType : byte
    {
        /// <summary>
        /// 请求
        /// </summary>
        Request = (byte)'1',

        /// <summary>
        /// 应答
        /// </summary>
        Response = (byte)'2',

        /// <summary>
        /// 通知
        /// </summary>
        Notice = (byte)'3'
    }

    /// <summary>
    /// TFtdcCfmmcReturnCodeType是一个监控中心返回码类型
    /// </summary>
    public enum TThostFtdcCfmmcReturnCodeType : byte
    {
        /// <summary>
        /// 成功
        /// </summary>
        Success = (byte)'0',

        /// <summary>
        /// 该客户已经有流程在处理中
        /// </summary>
        Working = (byte)'1',

        /// <summary>
        /// 监控中客户资料检查失败
        /// </summary>
        InfoFail = (byte)'2',

        /// <summary>
        /// 监控中实名制检查失败
        /// </summary>
        IDCardFail = (byte)'3',

        /// <summary>
        /// 其他错误
        /// </summary>
        OtherFail = (byte)'4'
    }

    /// <summary>
    /// TFtdcClientTypeType是一个客户类型类型
    /// </summary>
    public enum TThostFtdcClientTypeType : byte
    {
        /// <summary>
        /// 所有
        /// </summary>
        All = (byte)'0',

        /// <summary>
        /// 个人
        /// </summary>
        Person = (byte)'1',

        /// <summary>
        /// 单位
        /// </summary>
        Company = (byte)'2'
    }

    /// <summary>
    /// TFtdcExchangeIDTypeType是一个交易所编号类型
    /// </summary>
    public enum TThostFtdcExchangeIDTypeType : byte
    {
        /// <summary>
        /// 上海期货交易所
        /// </summary>
        SHFE = (byte)'S',

        /// <summary>
        /// 郑州商品交易所
        /// </summary>
        CZCE = (byte)'Z',

        /// <summary>
        /// 大连商品交易所
        /// </summary>
        DCE = (byte)'D',

        /// <summary>
        /// 中国金融期货交易所
        /// </summary>
        CFFEX = (byte)'J'
    }

    /// <summary>
    /// TFtdcExClientIDTypeType是一个交易编码类型类型
    /// </summary>
    public enum TThostFtdcExClientIDTypeType : byte
    {
        /// <summary>
        /// 套保
        /// </summary>
        Hedge = (byte)'1',

        /// <summary>
        /// 套利
        /// </summary>
        Arbitrage = (byte)'2',

        /// <summary>
        /// 投机
        /// </summary>
        Speculation = (byte)'3'
    }

    /// <summary>
    /// TFtdcUpdateFlagType是一个更新状态类型
    /// </summary>
    public enum TThostFtdcUpdateFlagType : byte
    {
        /// <summary>
        /// 未更新
        /// </summary>
        NoUpdate = (byte)'0',

        /// <summary>
        /// 更新全部信息成功
        /// </summary>
        Success = (byte)'1',

        /// <summary>
        /// 更新全部信息失败
        /// </summary>
        Fail = (byte)'2',

        /// <summary>
        /// 更新交易编码成功
        /// </summary>
        TCSuccess = (byte)'3',

        /// <summary>
        /// 更新交易编码失败
        /// </summary>
        TCFail = (byte)'4',

        /// <summary>
        /// 已丢弃
        /// </summary>
        Cancel = (byte)'5'
    }

    /// <summary>
    /// TFtdcApplyOperateIDType是一个申请动作类型
    /// </summary>
    public enum TThostFtdcApplyOperateIDType : byte
    {
        /// <summary>
        /// 开户
        /// </summary>
        OpenInvestor = (byte)'1',

        /// <summary>
        /// 修改身份信息
        /// </summary>
        ModifyIDCard = (byte)'2',

        /// <summary>
        /// 修改一般信息
        /// </summary>
        ModifyNoIDCard = (byte)'3',

        /// <summary>
        /// 申请交易编码
        /// </summary>
        ApplyTradingCode = (byte)'4',

        /// <summary>
        /// 撤销交易编码
        /// </summary>
        CancelTradingCode = (byte)'5',

        /// <summary>
        /// 销户
        /// </summary>
        CancelInvestor = (byte)'6',

        /// <summary>
        /// 账户休眠
        /// </summary>
        FreezeAccount = (byte)'8',

        /// <summary>
        /// 激活休眠账户
        /// </summary>
        ActiveFreezeAccount = (byte)'9'
    }

    /// <summary>
    /// TFtdcApplyStatusIDType是一个申请状态类型
    /// </summary>
    public enum TThostFtdcApplyStatusIDType : byte
    {
        /// <summary>
        /// 未补全
        /// </summary>
        NoComplete = (byte)'1',

        /// <summary>
        /// 已提交
        /// </summary>
        Submited = (byte)'2',

        /// <summary>
        /// 已审核
        /// </summary>
        Checked = (byte)'3',

        /// <summary>
        /// 已拒绝
        /// </summary>
        Refused = (byte)'4',

        /// <summary>
        /// 已删除
        /// </summary>
        Deleted = (byte)'5'
    }

    /// <summary>
    /// TFtdcSendMethodType是一个发送方式类型
    /// </summary>
    public enum TThostFtdcSendMethodType : byte
    {
        /// <summary>
        /// 文件发送
        /// </summary>
        ByAPI = (byte)'1',

        /// <summary>
        /// 电子发送
        /// </summary>
        ByFile = (byte)'2'
    }

    /// <summary>
    /// TFtdcEventModeType是一个操作方法类型
    /// </summary>
    public enum TThostFtdcEventModeType : byte
    {
        /// <summary>
        /// 增加
        /// </summary>
        ADD = (byte)'1',

        /// <summary>
        /// 修改
        /// </summary>
        UPDATE = (byte)'2',

        /// <summary>
        /// 删除
        /// </summary>
        DELETE = (byte)'3',

        /// <summary>
        /// 复核
        /// </summary>
        CHECK = (byte)'4',

        /// <summary>
        /// 复制
        /// </summary>
        COPY = (byte)'5',

        /// <summary>
        /// 注销
        /// </summary>
        CANCEL = (byte)'6',

        /// <summary>
        /// 冲销
        /// </summary>
        Reverse = (byte)'7'
    }

    /// <summary>
    /// TFtdcUOAAutoSendType是一个统一开户申请自动发送类型
    /// </summary>
    public enum TThostFtdcUOAAutoSendType : byte
    {
        /// <summary>
        /// 自动发送并接收
        /// </summary>
        ASR = (byte)'1',

        /// <summary>
        /// 自动发送，不自动接收
        /// </summary>
        ASNR = (byte)'2',

        /// <summary>
        /// 不自动发送，自动接收
        /// </summary>
        NSAR = (byte)'3',

        /// <summary>
        /// 不自动发送，也不自动接收
        /// </summary>
        NSR = (byte)'4'
    }

    /// <summary>
    /// TFtdcFlowIDType是一个流程ID类型
    /// </summary>
    public enum TThostFtdcFlowIDType : byte
    {
        /// <summary>
        /// 投资者对应投资者组设置
        /// </summary>
        InvestorGroupFlow = (byte)'1',

        /// <summary>
        /// 投资者手续费率设置
        /// </summary>
        InvestorRate = (byte)'2',

        /// <summary>
        /// 投资者手续费率模板关系设置
        /// </summary>
        InvestorCommRateModel = (byte)'3'
    }

    /// <summary>
    /// TFtdcCheckLevelType是一个复核级别类型
    /// </summary>
    public enum TThostFtdcCheckLevelType : byte
    {
        /// <summary>
        /// 零级复核
        /// </summary>
        Zero = (byte)'0',

        /// <summary>
        /// 一级复核
        /// </summary>
        One = (byte)'1',

        /// <summary>
        /// 二级复核
        /// </summary>
        Two = (byte)'2'
    }

    /// <summary>
    /// TFtdcCheckStatusType是一个复核级别类型
    /// </summary>
    public enum TThostFtdcCheckStatusType : byte
    {
        /// <summary>
        /// 未复核
        /// </summary>
        Init = (byte)'0',

        /// <summary>
        /// 复核中
        /// </summary>
        Checking = (byte)'1',

        /// <summary>
        /// 已复核
        /// </summary>
        Checked = (byte)'2',

        /// <summary>
        /// 拒绝
        /// </summary>
        Refuse = (byte)'3',

        /// <summary>
        /// 作废
        /// </summary>
        Cancel = (byte)'4'
    }

    /// <summary>
    /// TFtdcUsedStatusType是一个生效状态类型
    /// </summary>
    public enum TThostFtdcUsedStatusType : byte
    {
        /// <summary>
        /// 未生效
        /// </summary>
        Unused = (byte)'0',

        /// <summary>
        /// 已生效
        /// </summary>
        Used = (byte)'1',

        /// <summary>
        /// 生效失败
        /// </summary>
        Fail = (byte)'2'
    }

    /// <summary>
    /// TFtdcBankAcountOriginType是一个账户来源类型
    /// </summary>
    public enum TThostFtdcBankAcountOriginType : byte
    {
        /// <summary>
        /// 手工录入
        /// </summary>
        ByAccProperty = (byte)'0',

        /// <summary>
        /// 银期转账
        /// </summary>
        ByFBTransfer = (byte)'1'
    }

    /// <summary>
    /// TFtdcMonthBillTradeSumType是一个结算单月报成交汇总方式类型
    /// </summary>
    public enum TThostFtdcMonthBillTradeSumType : byte
    {
        /// <summary>
        /// 同日同合约
        /// </summary>
        ByInstrument = (byte)'0',

        /// <summary>
        /// 同日同合约同价格
        /// </summary>
        ByDayInsPrc = (byte)'1',

        /// <summary>
        /// 同合约
        /// </summary>
        ByDayIns = (byte)'2'
    }

    /// <summary>
    /// TFtdcOTPTypeType是一个动态令牌类型类型
    /// </summary>
    public enum TThostFtdcOTPTypeType : byte
    {
        /// <summary>
        /// 无动态令牌
        /// </summary>
        NONE = (byte)'0',

        /// <summary>
        /// 时间令牌
        /// </summary>
        TOTP = (byte)'1'
    }

    /// <summary>
    /// TFtdcOTPStatusType是一个动态令牌状态类型
    /// </summary>
    public enum TThostFtdcOTPStatusType : byte
    {
        /// <summary>
        /// 未使用
        /// </summary>
        Unused = (byte)'0',

        /// <summary>
        /// 已使用
        /// </summary>
        Used = (byte)'1',

        /// <summary>
        /// 注销
        /// </summary>
        Disuse = (byte)'2'
    }

    /// <summary>
    /// TFtdcBrokerUserTypeType是一个经济公司用户类型类型
    /// </summary>
    public enum TThostFtdcBrokerUserTypeType : byte
    {
        /// <summary>
        /// 投资者
        /// </summary>
        Investor = (byte)'1',

        /// <summary>
        /// 操作员
        /// </summary>
        BrokerUser = (byte)'2'
    }

    /// <summary>
    /// TFtdcFutureTypeType是一个期货类型类型
    /// </summary>
    public enum TThostFtdcFutureTypeType : byte
    {
        /// <summary>
        /// 商品期货
        /// </summary>
        Commodity = (byte)'1',

        /// <summary>
        /// 金融期货
        /// </summary>
        Financial = (byte)'2'
    }

    /// <summary>
    /// TFtdcFundEventTypeType是一个资金管理操作类型类型
    /// </summary>
    public enum TThostFtdcFundEventTypeType : byte
    {
        /// <summary>
        /// 转账限额
        /// </summary>
        Restriction = (byte)'0',

        /// <summary>
        /// 当日转账限额
        /// </summary>
        TodayRestriction = (byte)'1',

        /// <summary>
        /// 期商流水
        /// </summary>
        Transfer = (byte)'2',

        /// <summary>
        /// 资金冻结
        /// </summary>
        Credit = (byte)'3',

        /// <summary>
        /// 投资者可提资金比例
        /// </summary>
        InvestorWithdrawAlm = (byte)'4',

        /// <summary>
        /// 单个银行帐户转账限额
        /// </summary>
        BankRestriction = (byte)'5',

        /// <summary>
        /// 银期签约账户
        /// </summary>
        Accountregister = (byte)'6',

        /// <summary>
        /// 交易所出入金
        /// </summary>
        ExchangeFundIO = (byte)'7',

        /// <summary>
        /// 投资者出入金
        /// </summary>
        InvestorFundIO = (byte)'8'
    }

    /// <summary>
    /// TFtdcAccountSourceTypeType是一个资金账户来源类型
    /// </summary>
    public enum TThostFtdcAccountSourceTypeType : byte
    {
        /// <summary>
        /// 银期同步
        /// </summary>
        FBTransfer = (byte)'0',

        /// <summary>
        /// 手工录入
        /// </summary>
        ManualEntry = (byte)'1'
    }

    /// <summary>
    /// TFtdcCodeSourceTypeType是一个交易编码来源类型
    /// </summary>
    public enum TThostFtdcCodeSourceTypeType : byte
    {
        /// <summary>
        /// 统一开户(已规范)
        /// </summary>
        UnifyAccount = (byte)'0',

        /// <summary>
        /// 手工录入(未规范)
        /// </summary>
        ManualEntry = (byte)'1'
    }

    /// <summary>
    /// TFtdcUserRangeType是一个操作员范围类型
    /// </summary>
    public enum TThostFtdcUserRangeType : byte
    {
        /// <summary>
        /// 所有
        /// </summary>
        All = (byte)'0',

        /// <summary>
        /// 单一操作员
        /// </summary>
        Single = (byte)'1'
    }

    /// <summary>
    /// TFtdcByGroupType是一个交易统计表按客户统计方式类型
    /// </summary>
    public enum TThostFtdcByGroupType : byte
    {
        /// <summary>
        /// 按投资者统计
        /// </summary>
        Investor = (byte)'2',

        /// <summary>
        /// 按类统计
        /// </summary>
        Group = (byte)'1'
    }

    /// <summary>
    /// TFtdcTradeSumStatModeType是一个交易统计表按范围统计方式类型
    /// </summary>
    public enum TThostFtdcTradeSumStatModeType : byte
    {
        /// <summary>
        /// 按合约统计
        /// </summary>
        Instrument = (byte)'1',

        /// <summary>
        /// 按产品统计
        /// </summary>
        Product = (byte)'2',

        /// <summary>
        /// 按交易所统计
        /// </summary>
        Exchange = (byte)'3'
    }

    /// <summary>
    /// TFtdcRateInvestorRangeType是一个投资者范围类型
    /// </summary>
    public enum TThostFtdcRateInvestorRangeType : byte
    {
        /// <summary>
        /// 所有
        /// </summary>
        All = (byte)'1',

        /// <summary>
        /// 费率模板
        /// </summary>
        Model = (byte)'2',

        /// <summary>
        /// 单一投资者
        /// </summary>
        Single = (byte)'3'
    }

    /// <summary>
    /// TFtdcSyncDataStatusType是一个主次用系统数据同步状态类型
    /// </summary>
    public enum TThostFtdcSyncDataStatusType : byte
    {
        /// <summary>
        /// 未同步
        /// </summary>
        Initialize = (byte)'0',

        /// <summary>
        /// 同步中
        /// </summary>
        Settlementing = (byte)'1',

        /// <summary>
        /// 已同步
        /// </summary>
        Settlemented = (byte)'2'
    }

    /// <summary>
    /// TFtdcTradeSourceType是一个成交来源类型
    /// </summary>
    public enum TThostFtdcTradeSourceType : byte
    {
        /// <summary>
        /// 来自交易所普通回报
        /// </summary>
        NORMAL = (byte)'0',

        /// <summary>
        /// 来自查询
        /// </summary>
        QUERY = (byte)'1'
    }

    /// <summary>
    /// TFtdcFlexStatModeType是一个产品合约统计方式类型
    /// </summary>
    public enum TThostFtdcFlexStatModeType : byte
    {
        /// <summary>
        /// 产品统计
        /// </summary>
        Product = (byte)'1',

        /// <summary>
        /// 交易所统计
        /// </summary>
        Exchange = (byte)'2',

        /// <summary>
        /// 统计所有
        /// </summary>
        All = (byte)'3'
    }

    /// <summary>
    /// TFtdcByInvestorRangeType是一个投资者范围统计方式类型
    /// </summary>
    public enum TThostFtdcByInvestorRangeType : byte
    {
        /// <summary>
        /// 属性统计
        /// </summary>
        Property = (byte)'1',

        /// <summary>
        /// 统计所有
        /// </summary>
        All = (byte)'2'
    }

    /// <summary>
    /// TFtdcPropertyInvestorRangeType是一个投资者范围类型
    /// </summary>
    public enum TThostFtdcPropertyInvestorRangeType : byte
    {
        /// <summary>
        /// 所有
        /// </summary>
        All = (byte)'1',

        /// <summary>
        /// 投资者属性
        /// </summary>
        Property = (byte)'2',

        /// <summary>
        /// 单一投资者
        /// </summary>
        Single = (byte)'3'
    }

    /// <summary>
    /// TFtdcFileStatusType是一个文件状态类型
    /// </summary>
    public enum TThostFtdcFileStatusType : byte
    {
        /// <summary>
        /// 未生成
        /// </summary>
        NoCreate = (byte)'0',

        /// <summary>
        /// 已生成
        /// </summary>
        Created = (byte)'1',

        /// <summary>
        /// 生成失败
        /// </summary>
        Failed = (byte)'2'
    }

    /// <summary>
    /// TFtdcFileGenStyleType是一个文件生成方式类型
    /// </summary>
    public enum TThostFtdcFileGenStyleType : byte
    {
        /// <summary>
        /// 下发
        /// </summary>
        FileTransmit = (byte)'0',

        /// <summary>
        /// 生成
        /// </summary>
        FileGen = (byte)'1'
    }

    /// <summary>
    /// TFtdcSysOperModeType是一个系统日志操作方法类型
    /// </summary>
    public enum TThostFtdcSysOperModeType : byte
    {
        /// <summary>
        /// 增加
        /// </summary>
        Add = (byte)'1',

        /// <summary>
        /// 修改
        /// </summary>
        Update = (byte)'2',

        /// <summary>
        /// 删除
        /// </summary>
        Delete = (byte)'3',

        /// <summary>
        /// 复制
        /// </summary>
        Copy = (byte)'4',

        /// <summary>
        /// 激活
        /// </summary>
        AcTive = (byte)'5',

        /// <summary>
        /// 注销
        /// </summary>
        CanCel = (byte)'6',

        /// <summary>
        /// 重置
        /// </summary>
        ReSet = (byte)'7'
    }

    /// <summary>
    /// TFtdcSysOperTypeType是一个系统日志操作类型类型
    /// </summary>
    public enum TThostFtdcSysOperTypeType : byte
    {
        /// <summary>
        /// 修改操作员密码
        /// </summary>
        UpdatePassword = (byte)'0',

        /// <summary>
        /// 操作员组织架构关系
        /// </summary>
        UserDepartment = (byte)'1',

        /// <summary>
        /// 角色管理
        /// </summary>
        RoleManager = (byte)'2',

        /// <summary>
        /// 角色功能设置
        /// </summary>
        RoleFunction = (byte)'3',

        /// <summary>
        /// 基础参数设置
        /// </summary>
        BaseParam = (byte)'4',

        /// <summary>
        /// 设置操作员
        /// </summary>
        SetUserID = (byte)'5',

        /// <summary>
        /// 用户角色设置
        /// </summary>
        SetUserRole = (byte)'6',

        /// <summary>
        /// 用户IP限制
        /// </summary>
        UserIpRestriction = (byte)'7',

        /// <summary>
        /// 组织架构管理
        /// </summary>
        DepartmentManager = (byte)'8',

        /// <summary>
        /// 组织架构向查询分类复制
        /// </summary>
        DepartmentCopy = (byte)'9',

        /// <summary>
        /// 交易编码管理
        /// </summary>
        Tradingcode = (byte)'A',

        /// <summary>
        /// 投资者状态维护
        /// </summary>
        InvestorStatus = (byte)'B',

        /// <summary>
        /// 投资者权限管理
        /// </summary>
        InvestorAuthority = (byte)'C',

        /// <summary>
        /// 属性设置
        /// </summary>
        PropertySet = (byte)'D',

        /// <summary>
        /// 重置投资者密码
        /// </summary>
        ReSetInvestorPasswd = (byte)'E',

        /// <summary>
        /// 投资者个性信息维护
        /// </summary>
        InvestorPersonalityInfo = (byte)'F'
    }

    /// <summary>
    /// TFtdcCSRCDataQueyTypeType是一个上报数据查询类型类型
    /// </summary>
    public enum TThostFtdcCSRCDataQueyTypeType : byte
    {
        /// <summary>
        /// 查询当前交易日报送的数据
        /// </summary>
        Current = (byte)'0',

        /// <summary>
        /// 查询历史报送的代理经纪公司的数据
        /// </summary>
        History = (byte)'1'
    }

    /// <summary>
    /// TFtdcFreezeStatusType是一个休眠状态类型
    /// </summary>
    public enum TThostFtdcFreezeStatusType : byte
    {
        /// <summary>
        /// 活跃
        /// </summary>
        Normal = (byte)'1',

        /// <summary>
        /// 休眠
        /// </summary>
        Freeze = (byte)'0'
    }

    /// <summary>
    /// TFtdcStandardStatusType是一个规范状态类型
    /// </summary>
    public enum TThostFtdcStandardStatusType : byte
    {
        /// <summary>
        /// 已规范
        /// </summary>
        Standard = (byte)'0',

        /// <summary>
        /// 未规范
        /// </summary>
        NonStandard = (byte)'1'
    }

    /// <summary>
    /// TFtdcRightParamTypeType是一个配置类型类型
    /// </summary>
    public enum TThostFtdcRightParamTypeType : byte
    {
        /// <summary>
        /// 休眠户
        /// </summary>
        Freeze = (byte)'1',

        /// <summary>
        /// 激活休眠户
        /// </summary>
        FreezeActive = (byte)'2'
    }

    /// <summary>
    /// TFtdcDataStatusType是一个反洗钱审核表数据状态类型
    /// </summary>
    public enum TThostFtdcDataStatusType : byte
    {
        /// <summary>
        /// 正常
        /// </summary>
        Normal = (byte)'0',

        /// <summary>
        /// 已删除
        /// </summary>
        Deleted = (byte)'1'
    }

    /// <summary>
    /// TFtdcAMLCheckStatusType是一个审核状态类型
    /// </summary>
    public enum TThostFtdcAMLCheckStatusType : byte
    {
        /// <summary>
        /// 未复核
        /// </summary>
        Init = (byte)'0',

        /// <summary>
        /// 复核中
        /// </summary>
        Checking = (byte)'1',

        /// <summary>
        /// 已复核
        /// </summary>
        Checked = (byte)'2',

        /// <summary>
        /// 拒绝上报
        /// </summary>
        RefuseReport = (byte)'3'
    }

    /// <summary>
    /// TFtdcAmlDateTypeType是一个日期类型类型
    /// </summary>
    public enum TThostFtdcAmlDateTypeType : byte
    {
        /// <summary>
        /// 检查日期
        /// </summary>
        DrawDay = (byte)'0',

        /// <summary>
        /// 发生日期
        /// </summary>
        TouchDay = (byte)'1'
    }

    /// <summary>
    /// TFtdcAmlCheckLevelType是一个审核级别类型
    /// </summary>
    public enum TThostFtdcAmlCheckLevelType : byte
    {
        /// <summary>
        /// 零级审核
        /// </summary>
        CheckLevel0 = (byte)'0',

        /// <summary>
        /// 一级审核
        /// </summary>
        CheckLevel1 = (byte)'1',

        /// <summary>
        /// 二级审核
        /// </summary>
        CheckLevel2 = (byte)'2',

        /// <summary>
        /// 三级审核
        /// </summary>
        CheckLevel3 = (byte)'3'
    }

    /// <summary>
    /// TFtdcExportFileTypeType是一个导出文件类型类型
    /// </summary>
    public enum TThostFtdcExportFileTypeType : byte
    {
        /// <summary>
        /// CSV
        /// </summary>
        CSV = (byte)'0',

        /// <summary>
        /// Excel
        /// </summary>
        EXCEL = (byte)'1',

        /// <summary>
        /// DBF
        /// </summary>
        DBF = (byte)'2'
    }

    /// <summary>
    /// TFtdcSettleManagerTypeType是一个结算配置类型类型
    /// </summary>
    public enum TThostFtdcSettleManagerTypeType : byte
    {
        /// <summary>
        /// 结算前准备
        /// </summary>
        Before = (byte)'1',

        /// <summary>
        /// 结算
        /// </summary>
        Settlement = (byte)'2',

        /// <summary>
        /// 结算后核对
        /// </summary>
        After = (byte)'3',

        /// <summary>
        /// 结算完成
        /// </summary>
        Settlemented = (byte)'4'
    }

    /// <summary>
    /// TFtdcSettleManagerLevelType是一个结算配置等级类型
    /// </summary>
    public enum TThostFtdcSettleManagerLevelType : byte
    {
        /// <summary>
        /// 必要
        /// </summary>
        Must = (byte)'1',

        /// <summary>
        /// 警告
        /// </summary>
        Alarm = (byte)'2',

        /// <summary>
        /// 提示
        /// </summary>
        Prompt = (byte)'3',

        /// <summary>
        /// 不检查
        /// </summary>
        Ignore = (byte)'4'
    }

    /// <summary>
    /// TFtdcSettleManagerGroupType是一个模块分组类型
    /// </summary>
    public enum TThostFtdcSettleManagerGroupType : byte
    {
        /// <summary>
        /// 交易所核对
        /// </summary>
        Exhcange = (byte)'1',

        /// <summary>
        /// 内部核对
        /// </summary>
        ASP = (byte)'2',

        /// <summary>
        /// 上报数据核对
        /// </summary>
        CSRC = (byte)'3'
    }

    /// <summary>
    /// TFtdcLimitUseTypeType是一个保值额度使用类型类型
    /// </summary>
    public enum TThostFtdcLimitUseTypeType : byte
    {
        /// <summary>
        /// 可重复使用
        /// </summary>
        Repeatable = (byte)'1',

        /// <summary>
        /// 不可重复使用
        /// </summary>
        Unrepeatable = (byte)'2'
    }

    /// <summary>
    /// TFtdcDataResourceType是一个数据来源类型
    /// </summary>
    public enum TThostFtdcDataResourceType : byte
    {
        /// <summary>
        /// 本系统
        /// </summary>
        Settle = (byte)'1',

        /// <summary>
        /// 交易所
        /// </summary>
        Exchange = (byte)'2',

        /// <summary>
        /// 报送数据
        /// </summary>
        CSRC = (byte)'3'
    }
}
