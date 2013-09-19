﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuantBox.CSharp2CTP
{
    public enum ErrorType
    {
        /// <summary>
        /// 综合交易平台：正确
        /// </summary>
        NONE = 0,

        /// <summary>
        /// 综合交易平台：不在已同步状态
        /// </summary>
        INVALID_DATA_SYNC_STATUS = 1,
        
        /// <summary>
        /// 综合交易平台：会话信息不一致
        /// </summary>
        INCONSISTENT_INFORMATION = 2,
        
        /// <summary>
        /// 综合交易平台：不合法的登录
        /// </summary>
        INVALID_LOGIN = 3,

        /// <summary>
        /// 综合交易平台：用户不活跃
        /// </summary>
        USER_NOT_ACTIVE = 4,

        /// <summary>
        /// 综合交易平台：重复的登录
        /// </summary>
        DUPLICATE_LOGIN = 5,

        /// <summary>
        /// 综合交易平台：还没有登录
        /// </summary>
        NOT_LOGIN_YET = 6,

        /// <summary>
        /// 综合交易平台：还没有初始化
        /// </summary>
        NOT_INITED = 7,

        /// <summary>
        /// 综合交易平台：前置不活跃
        /// </summary>
        FRONT_NOT_ACTIVE = 8,

        /// <summary>
        /// 综合交易平台：无此权限
        /// </summary>
        NO_PRIVILEGE = 9,

        /// <summary>
        /// 综合交易平台：修改别人的口令
        /// </summary>
        CHANGE_OTHER_PASSWORD = 10,

        /// <summary>
        /// 综合交易平台：找不到该用户
        /// </summary>
        USER_NOT_FOUND = 11,

        /// <summary>
        /// 综合交易平台：找不到该经纪公司
        /// </summary>
        BROKER_NOT_FOUND = 12,

        /// <summary>
        /// 综合交易平台：找不到投资者
        /// </summary>
        INVESTOR_NOT_FOUND = 13,

        /// <summary>
        /// 综合交易平台：原口令不匹配
        /// </summary>
        OLD_PASSWORD_MISMATCH = 14,

        /// <summary>
        /// 综合交易平台：报单字段有误
        /// </summary>
        BAD_FIELD = 15,

        /// <summary>
        /// 综合交易平台：找不到合约
        /// </summary>
        INSTRUMENT_NOT_FOUND = 16,

        /// <summary>
        /// 综合交易平台：合约不能交易
        /// </summary>
        INSTRUMENT_NOT_TRADING = 17,

        /// <summary>
        /// 综合交易平台：经纪公司不是交易所的会员
        /// </summary>
        NOT_EXCHANGE_PARTICIPANT = 18,

        /// <summary>
        /// 综合交易平台：投资者不活跃
        /// </summary>
        INVESTOR_NOT_ACTIVE = 19,
        
        /// <summary>
        /// 综合交易平台：投资者未在交易所开户
        /// </summary>
        NOT_EXCHANGE_CLIENT = 20,
        
        /// <summary>
        /// 综合交易平台：该交易席位未连接到交易所
        /// </summary>
        NO_VALID_TRADER_AVAILABLE = 21,
        
        /// <summary>
        /// 综合交易平台：报单错误：不允许重复报单
        /// </summary>
        DUPLICATE_ORDER_REF = 22,
        
        /// <summary>
        /// 综合交易平台：错误的报单操作字段
        /// </summary>
        BAD_ORDER_ACTION_FIELD = 23,
        
        /// <summary>
        /// 综合交易平台：撤单已报送，不允许重复撤单
        /// </summary>
        DUPLICATE_ORDER_ACTION_REF = 24,
        
        /// <summary>
        /// 综合交易平台：撤单找不到相应报单
        /// </summary>
        ORDER_NOT_FOUND = 25,
        
        /// <summary>
        /// 综合交易平台：报单已全成交或已撤销，不能再撤
        /// </summary>
        INSUITABLE_ORDER_STATUS = 26,
        
        /// <summary>
        /// 综合交易平台：不支持的功能
        /// </summary>
        UNSUPPORTED_FUNCTION = 27,
        
        /// <summary>
        /// 综合交易平台：没有报单交易权限
        /// </summary>
        NO_TRADING_RIGHT = 28,
        
        /// <summary>
        /// 综合交易平台：只能平仓
        /// </summary>
        CLOSE_ONLY = 29,
        
        /// <summary>
        /// 综合交易平台：平仓量超过持仓量
        /// </summary>
        OVER_CLOSE_POSITION = 30,
        
        /// <summary>
        /// 综合交易平台：资金不足
        /// </summary>
        INSUFFICIENT_MONEY = 31,
        
        /// <summary>
        /// 综合交易平台：主键重复
        /// </summary>
        DUPLICATE_PK = 32,

        /// <summary>
        /// 综合交易平台：找不到主键
        /// </summary>
        CANNOT_FIND_PK = 33,
        
        /// <summary>
        /// 综合交易平台：设置经纪公司不活跃状态失败
        /// </summary>
        CAN_NOT_INACTIVE_BROKER = 34,
        
        /// <summary>
        /// 综合交易平台：经纪公司正在同步
        /// </summary>
        BROKER_SYNCHRONIZING = 35,
        
        /// <summary>
        /// 综合交易平台：经纪公司已同步
        /// </summary>
        BROKER_SYNCHRONIZED = 36,
        
        /// <summary>
        /// 综合交易平台：现货交易不能卖空
        /// </summary>
        SHORT_SELL = 37,
        
        /// <summary>
        /// 综合交易平台：不合法的结算引用
        /// </summary>
        INVALID_SETTLEMENT_REF = 38,
        
        /// <summary>
        /// 综合交易平台：交易所网络连接失败
        /// </summary>
        CFFEX_NETWORK_ERROR = 39,
        
        /// <summary>
        /// 综合交易平台：交易所未处理请求超过许可数
        /// </summary>
        CFFEX_OVER_REQUEST = 40,
        
        /// <summary>
        /// 综合交易平台：交易所每秒发送请求数超过许可数
        /// </summary>
        CFFEX_OVER_REQUEST_PER_SECOND = 41,
        
        /// <summary>
        /// 综合交易平台：结算结果未确认
        /// </summary>
        SETTLEMENT_INFO_NOT_CONFIRMED = 42,
        
        /// <summary>
        /// 综合交易平台：没有对应的入金记录
        /// </summary>
        DEPOSIT_NOT_FOUND = 43,
        
        /// <summary>
        /// 综合交易平台：交易所已经进入连续交易状态
        /// </summary>
        EXCHANG_TRADING = 44,
        
        /// <summary>
        /// 综合交易平台：找不到预埋（撤单）单
        /// </summary>
        PARKEDORDER_NOT_FOUND = 45,
        
        /// <summary>
        /// 综合交易平台：预埋（撤单）单已经发送
        /// </summary>
        PARKEDORDER_HASSENDED = 46,
        
        /// <summary>
        /// 综合交易平台：预埋（撤单）单已经删除
        /// </summary>
        PARKEDORDER_HASDELETE = 47,
        
        /// <summary>
        /// 综合交易平台：无效的投资者或者密码
        /// </summary>
        INVALID_INVESTORIDORPASSWORD = 48,
        
        /// <summary>
        /// 综合交易平台：不合法的登录IP地址
        /// </summary>
        INVALID_LOGIN_IPADDRESS = 49,
        
        /// <summary>
        /// 综合交易平台：平今仓位不足
        /// </summary>
        OVER_CLOSETODAY_POSITION = 50,
        
        /// <summary>
        /// 综合交易平台：平昨仓位不足
        /// </summary>
        OVER_CLOSEYESTERDAY_POSITION = 51,
        
        /// <summary>
        /// 综合交易平台：经纪公司没有足够可用的条件单数量
        /// </summary>
        BROKER_NOT_ENOUGH_CONDORDER = 52,
        
        /// <summary>
        /// 综合交易平台：投资者没有足够可用的条件单数量
        /// </summary>
        INVESTOR_NOT_ENOUGH_CONDORDER = 53,
        
        /// <summary>
        /// 综合交易平台：经纪公司不支持条件单
        /// </summary>
        BROKER_NOT_SUPPORT_CONDORDER = 54,
        
        /// <summary>
        /// 综合交易平台：重发未知单经济公司/投资者不匹配
        /// </summary>
        RESEND_ORDER_BROKERINVESTOR_NOTMATCH = 55,
        
        /// <summary>
        /// 综合交易平台：同步动态令牌失败
        /// </summary>
        SYC_OTP_FAILED = 56,
        
        /// <summary>
        /// 综合交易平台：动态令牌校验错误
        /// </summary>
        OTP_MISMATCH = 57,
        
        /// <summary>
        /// 综合交易平台：找不到动态令牌配置信息
        /// </summary>
        OTPPARAM_NOT_FOUND = 58,
        
        /// <summary>
        /// 综合交易平台：不支持的动态令牌类型
        /// </summary>
        UNSUPPORTED_OTPTYPE = 59,
        
        /// <summary>
        /// 综合交易平台：用户在线会话超出上限
        /// </summary>
        SINGLEUSERSESSION_EXCEED_LIMIT = 60,
        
        /// <summary>
        /// 综合交易平台：该交易所不支持套利类型报单
        /// </summary>
        EXCHANGE_UNSUPPORTED_ARBITRAGE = 61,
        
        /// <summary>
        /// 综合交易平台：没有条件单交易权限
        /// </summary>
        NO_CONDITIONAL_ORDER_RIGHT = 62,
        
        /// <summary>
        /// 综合交易平台：客户端认证失败
        /// </summary>
        AUTH_FAILED = 63,
        
        /// <summary>
        /// 综合交易平台：客户端未认证
        /// </summary>
        NOT_AUTHENT = 64,
        
        /// <summary>
        /// 综合交易平台：该合约不支持互换类型报单
        /// </summary>
        SWAPORDER_UNSUPPORTED = 65,

        /// <summary>
        /// 综合交易平台：连续登录失败次数超限，登录被禁止
        /// </summary>
        LOGIN_FORBIDDEN = 66,

        // <!--灾备系统错误代码 -->
        
        /// <summary>
        /// 综合交易平台：用户在本系统没有报单权限
        /// </summary>
        NO_TRADING_RIGHT_IN_SEPC_DR = 101,
        
        /// <summary>
        /// 综合交易平台：系统缺少灾备标示号
        /// </summary>
        NO_DR_NO = 102,

	    // <!--转帐系统错误代码 -->

        /// <summary>
        /// 银期转账：发送机构代码错误
        /// </summary>
	    SEND_INSTITUTION_CODE_ERROR = 1000,
        
        /// <summary>
        /// 银期转账：取平台流水号错误
        /// </summary>
        NO_GET_PLATFORM_SN = 1001,
        
        /// <summary>
        /// 银期转账：不合法的转账银行
        /// </summary>
        ILLEGAL_TRANSFER_BANK = 1002,
        
        /// <summary>
        /// 银期转账：已经开户
        /// </summary>
        ALREADY_OPEN_ACCOUNT = 1003,
        
        /// <summary>
        /// 银期转账：未开户
        /// </summary>
        NOT_OPEN_ACCOUNT = 1004,
        
        /// <summary>
        /// 银期转账：处理中
        /// </summary>
        PROCESSING = 1005,
        
        /// <summary>
        /// 银期转账：交易超时
        /// </summary>
        OVERTIME = 1006,
        
        /// <summary>
        /// 银期转账：找不到记录
        /// </summary>
        RECORD_NOT_FOUND = 1007,
        
        /// <summary>
        /// 银期转账：找不到被冲正的原始交易
        /// </summary>
        NO_FOUND_REVERSAL_ORIGINAL_TRANSACTION = 1008,
        
        /// <summary>
        /// 银期转账：连接主机失败
        /// </summary>
        CONNECT_HOST_FAILED = 1009,
        
        /// <summary>
        /// 银期转账：发送失败
        /// </summary>
        SEND_FAILED = 1010,
        
        /// <summary>
        /// 银期转账：迟到应答
        /// </summary>
        LATE_RESPONSE = 1011,
        
        /// <summary>
        /// 银期转账：冲正交易银行代码错误
        /// </summary>
        REVERSAL_BANKID_NOT_MATCH = 1012,
        
        /// <summary>
        /// 银期转账：冲正交易银行账户错误
        /// </summary>
        REVERSAL_BANKACCOUNT_NOT_MATCH = 1013,
        
        /// <summary>
        /// 银期转账：冲正交易经纪公司代码错误
        /// </summary>
        REVERSAL_BROKERID_NOT_MATCH = 1014,
        
        /// <summary>
        /// 银期转账：冲正交易资金账户错误
        /// </summary>
        REVERSAL_ACCOUNTID_NOT_MATCH = 1015,
        
        /// <summary>
        /// 银期转账：冲正交易交易金额错误
        /// </summary>
        REVERSAL_AMOUNT_NOT_MATCH = 1016,
        
        /// <summary>
        /// 银期转账：数据库操作错误
        /// </summary>
        DB_OPERATION_FAILED = 1017,
        
        /// <summary>
        /// 银期转账：发送到交易系统失败
        /// </summary>
        SEND_ASP_FAILURE = 1018,
        
        /// <summary>
        /// 银期转账：没有签到
        /// </summary>
        NOT_SIGNIN = 1019,
        
        /// <summary>
        /// 银期转账：已经签到
        /// </summary>
        ALREADY_SIGNIN = 1020,
        
        /// <summary>
        /// 银期转账：金额或次数超限
        /// </summary>
        AMOUNT_OR_TIMES_OVER = 1021,
        
        /// <summary>
        /// 银期转账：这一时间段不能转账
        /// </summary>
        NOT_IN_TRANSFER_TIME = 1022,
        
        /// <summary>
        /// 银行主机错
        /// </summary>
        BANK_SERVER_ERROR = 1023,
        
        /// <summary>
        /// 银期转账：银行已经冲正
        /// </summary>
        BANK_SERIAL_IS_REPEALED = 1024,
        
        /// <summary>
        /// 银期转账：银行流水不存在
        /// </summary>
        BANK_SERIAL_NOT_EXIST = 1025,
        
        /// <summary>
        /// 银期转账：机构没有签约
        /// </summary>
        NOT_ORGAN_MAP = 1026,
        
        /// <summary>
        /// 银期转账：存在转账，不能销户
        /// </summary>
        EXIST_TRANSFER = 1027,
        
        /// <summary>
        /// 银期转账：银行不支持冲正
        /// </summary>
        BANK_FORBID_REVERSAL = 1028,
        
        /// <summary>
        /// 银期转账：重复的银行流水
        /// </summary>
        DUP_BANK_SERIAL = 1029,
        
        /// <summary>
        /// 银期转账：转账系统忙，稍后再试
        /// </summary>
        FBT_SYSTEM_BUSY = 1030,
        
        /// <summary>
        /// 银期转账：MAC密钥正在同步
        /// </summary>
        MACKEY_SYNCING = 1031,
        
        /// <summary>
        /// 银期转账：资金账户已经登记
        /// </summary>
        ACCOUNTID_ALREADY_REGISTER = 1032,
        
        /// <summary>
        /// 银期转账：银行账户已经登记
        /// </summary>
        BANKACCOUNT_ALREADY_REGISTER = 1033,
        
        /// <summary>
        /// 银期转账：重复的银行流水,重发成功
        /// </summary>
        DUP_BANK_SERIAL_REDO_OK = 1034,

        /// <summary>
        /// 银期转账：该币种代码不支持
        /// </summary>
        CURRENCYID_NOT_SUPPORTED = 1035,

        /// <summary>
        /// 银期转账：MAC值验证失败
        /// </summary>
        INVALID_MAC = 1036,
  
        // <!-- add for transfer begin -->

        /// <summary>
        /// 综合交易平台：该报盘未连接到银行
        /// </summary>
        NO_VALID_BANKOFFER_AVAILABLE = 2000,
        
        /// <summary>
        /// 综合交易平台：资金密码错误
        /// </summary>
        PASSWORD_MISMATCH = 2001,
        
        /// <summary>
        /// 综合交易平台：银行流水号重复
        /// </summary>
        DUPLATION_BANK_SERIAL = 2004,
        
        /// <summary>
        /// 综合交易平台：报盘流水号重复
        /// </summary>
        DUPLATION_OFFER_SERIAL = 2005,
        
        /// <summary>
        /// 综合交易平台：被冲正流水不存在(冲正交易)
        /// </summary>
        SERIAL_NOT_EXSIT = 2006,
        
        /// <summary>
        /// 综合交易平台：原流水已冲正(冲正交易)
        /// </summary>
        SERIAL_IS_REPEALED = 2007,
        
        /// <summary>
        /// 综合交易平台：与原流水信息不符(冲正交易)
        /// </summary>
        SERIAL_MISMATCH = 2008,
        
        /// <summary>
        /// 综合交易平台：证件号码或类型错误
        /// </summary>
        IdentifiedCardNo_MISMATCH = 2009,
        
        /// <summary>
        /// 综合交易平台：资金账户不存在
        /// </summary>
        ACCOUNT_NOT_FUND = 2011,
        
        /// <summary>
        /// 综合交易平台：资金账户已经销户
        /// </summary>
        ACCOUNT_NOT_ACTIVE = 2012,
        
        /// <summary>
        /// 综合交易平台：该交易不能执行手工冲正
        /// </summary>
        NOT_ALLOW_REPEAL_BYMANUAL = 2013,
        
        /// <summary>
        /// 综合交易平台：转帐金额错误
        /// </summary>
        AMOUNT_OUTOFTHEWAY = 2014,
        
        /// <summary>
        /// 综合交易平台：等待银期报盘处理结果
        /// </summary>
        WAITING_OFFER_RSP = 999999,
	    
        // <!-- add for transfer end -->*/
    }
}
