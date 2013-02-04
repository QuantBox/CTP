package quantbox.java2ctp;

import java.lang.reflect.Method;
import java.util.HashMap;

import quantbox.CThostFtdcOrderField;
import quantbox.CThostFtdcRspUserLoginField;
import quantbox.QuantBoxLibrary;
import quantbox.QuantBoxLibrary.THOST_TE_RESUME_TYPE;
import quantbox.QuantBoxLibrary.fnOnConnect;
import quantbox.QuantBoxLibrary.fnOnDisconnect;
import quantbox.QuantBoxLibrary.fnOnErrRtnOrderAction;
import quantbox.QuantBoxLibrary.fnOnErrRtnOrderInsert;
import quantbox.QuantBoxLibrary.fnOnRspError;
import quantbox.QuantBoxLibrary.fnOnRspOrderAction;
import quantbox.QuantBoxLibrary.fnOnRspOrderInsert;
import quantbox.QuantBoxLibrary.fnOnRspQryDepthMarketData;
import quantbox.QuantBoxLibrary.fnOnRspQryInstrument;
import quantbox.QuantBoxLibrary.fnOnRspQryInstrumentCommissionRate;
import quantbox.QuantBoxLibrary.fnOnRspQryInstrumentMarginRate;
import quantbox.QuantBoxLibrary.fnOnRspQryInvestorPosition;
import quantbox.QuantBoxLibrary.fnOnRspQryInvestorPositionDetail;
import quantbox.QuantBoxLibrary.fnOnRspQryOrder;
import quantbox.QuantBoxLibrary.fnOnRspQryTrade;
import quantbox.QuantBoxLibrary.fnOnRspQryTradingAccount;
import quantbox.QuantBoxLibrary.fnOnRtnInstrumentStatus;
import quantbox.QuantBoxLibrary.fnOnRtnOrder;
import quantbox.QuantBoxLibrary.fnOnRtnTrade;

import com.sun.jna.Library;
import com.sun.jna.Native;
import com.sun.jna.NativeLibrary;
import com.sun.jna.Pointer;
import com.sun.jna.win32.StdCallFunctionMapper;

public class TraderApiWrapper {
	public fnOnConnect fnOnConnect_Holder;
	public fnOnDisconnect fnOnDisconnect_Holder;
	public fnOnErrRtnOrderAction fnOnErrRtnOrderAction_Holder;
	public fnOnErrRtnOrderInsert fnOnErrRtnOrderInsert_Holder;
	public fnOnRspError fnOnRspError_Holder;
	public fnOnRspOrderAction fnOnRspOrderAction_Holder;
	public fnOnRspOrderInsert fnOnRspOrderInsert_Holder;
	public fnOnRspQryDepthMarketData fnOnRspQryDepthMarketData_Holder;
	public fnOnRspQryInstrument fnOnRspQryInstrument_Holder;
	public fnOnRspQryInstrumentCommissionRate fnOnRspQryInstrumentCommissionRate_Holder;
	public fnOnRspQryInstrumentMarginRate fnOnRspQryInstrumentMarginRate_Holder;
	public fnOnRspQryInvestorPosition fnOnRspQryInvestorPosition_Holder;
	public fnOnRspQryInvestorPositionDetail fnOnRspQryInvestorPositionDetail_Holder;
	public fnOnRspQryOrder fnOnRspQryOrder_Holder;
	public fnOnRspQryTrade fnOnRspQryTrade_Holder;
	public fnOnRspQryTradingAccount fnOnRspQryTradingAccount_Holder;
	public fnOnRtnInstrumentStatus fnOnRtnInstrumentStatus_Holder;
	public fnOnRtnOrder fnOnRtnOrder_Holder;
	public fnOnRtnTrade fnOnRtnTrade_Holder;

	private Object _lockTd = new Object();
	private Object _lockMsgQueue = new Object();

	private Pointer m_pTdApi;
	private Pointer m_pMsgQueue;
	private volatile boolean _bTdConnected;

	// private bool disposed;

	private String szPath;
	private String szAddresses;
	private String szBrokerId;
	private String szInvestorId;
	private String szPassword;
	private String szUserProductInfo;
	private String szAuthCode;
	private int nResumeType;

	private QuantBoxLibrary TraderApi;
	private QuantBoxLibrary CommApi;

	static public HashMap map;
	static {
		map = new HashMap();
		map.put(Library.OPTION_FUNCTION_MAPPER, new StdCallFunctionMapper() {
			public String getFunctionName(NativeLibrary library, Method method) {
				if (method.getName().equalsIgnoreCase("TD_SendOrder"))
					return "_TD_SendOrder@52";
				return super.getFunctionName(library, method);
			}
		});
	}

	public TraderApiWrapper() {
		super();

		CommApi = TraderApi = (QuantBoxLibrary) Native.loadLibrary(
				QuantBoxLibrary.JNA_LIBRARY_NAME, QuantBoxLibrary.class, map);
	}

	public void Connect(String szPath, String szAddresses, String szBrokerId,
			String szInvestorId, String szPassword, int nResumeType,
			String szUserProductInfo, String szAuthCode) {
		this.szPath = szPath;
		this.szAddresses = szAddresses;
		this.szBrokerId = szBrokerId;
		this.szInvestorId = szInvestorId;
		this.szPassword = szPassword;
		this.nResumeType = nResumeType;
		this.szUserProductInfo = szUserProductInfo;
		this.szAuthCode = szAuthCode;

		Disconnect_TD();
		Connect_MsgQueue();
		Connect_TD();
	}

	public void Disconnect() {
		Disconnect_TD();
		Disconnect_MsgQueue();
	}

	// 建立行情
	private void Connect_TD() {
		synchronized (_lockTd) {
			if (null == m_pTdApi) {
				m_pTdApi = TraderApi.TD_CreateTdApi();
				TraderApi.CTP_RegOnErrRtnOrderAction(m_pMsgQueue,
						fnOnErrRtnOrderAction_Holder);
				TraderApi.CTP_RegOnErrRtnOrderInsert(m_pMsgQueue,
						fnOnErrRtnOrderInsert_Holder);
				TraderApi.CTP_RegOnRspOrderAction(m_pMsgQueue,
						fnOnRspOrderAction_Holder);
				TraderApi.CTP_RegOnRspOrderInsert(m_pMsgQueue,
						fnOnRspOrderInsert_Holder);
				TraderApi.CTP_RegOnRspQryDepthMarketData(m_pMsgQueue,
						fnOnRspQryDepthMarketData_Holder);
				TraderApi.CTP_RegOnRspQryInstrument(m_pMsgQueue,
						fnOnRspQryInstrument_Holder);
				TraderApi.CTP_RegOnRspQryInstrumentCommissionRate(m_pMsgQueue,
						fnOnRspQryInstrumentCommissionRate_Holder);
				TraderApi.CTP_RegOnRspQryInstrumentMarginRate(m_pMsgQueue,
						fnOnRspQryInstrumentMarginRate_Holder);
				TraderApi.CTP_RegOnRspQryInvestorPosition(m_pMsgQueue,
						fnOnRspQryInvestorPosition_Holder);
				TraderApi.CTP_RegOnRspQryOrder(m_pMsgQueue,
						fnOnRspQryOrder_Holder);
				TraderApi.CTP_RegOnRspQryTrade(m_pMsgQueue,
						fnOnRspQryTrade_Holder);
				TraderApi.CTP_RegOnRspQryTradingAccount(m_pMsgQueue,
						fnOnRspQryTradingAccount_Holder);
				TraderApi.CTP_RegOnRtnInstrumentStatus(m_pMsgQueue,
						fnOnRtnInstrumentStatus_Holder);
				TraderApi.CTP_RegOnRtnOrder(m_pMsgQueue, fnOnRtnOrder_Holder);
				TraderApi.CTP_RegOnRtnTrade(m_pMsgQueue, fnOnRtnTrade_Holder);
				TraderApi.TD_RegMsgQueue2TdApi(m_pTdApi, m_pMsgQueue);
				TraderApi.TD_Connect(m_pTdApi, szPath, szAddresses, szBrokerId,
						szInvestorId, szPassword, nResumeType,
						szUserProductInfo, szAuthCode);
			}
		}
	}

	private void Disconnect_TD() {
		synchronized (_lockTd) {
			if (null != m_pTdApi) {
				TraderApi.TD_RegMsgQueue2TdApi(m_pTdApi, null);
				TraderApi.TD_ReleaseTdApi(m_pTdApi);
				m_pTdApi = null;
			}
			_bTdConnected = false;
		}
	}

	private void Connect_MsgQueue() {
		synchronized (_lockMsgQueue) {
			if (null == m_pMsgQueue) {
				m_pMsgQueue = CommApi.CTP_CreateMsgQueue();

				CommApi.CTP_RegOnConnect(m_pMsgQueue, fnOnConnect_Holder);
				CommApi.CTP_RegOnDisconnect(m_pMsgQueue, fnOnDisconnect_Holder);
				CommApi.CTP_RegOnRspError(m_pMsgQueue, fnOnRspError_Holder);

				// 由底层启动线程
				CommApi.CTP_StartMsgQueue(m_pMsgQueue);
			}
		}
	}

	private void Disconnect_MsgQueue() {
		synchronized (_lockMsgQueue) {
			if (null != m_pMsgQueue) {
				// 停止底层线程
				CommApi.CTP_StopMsgQueue(m_pMsgQueue);

				CommApi.CTP_ReleaseMsgQueue(m_pMsgQueue);
				m_pMsgQueue = null;
			}
		}
	}

	public int SendOrder(String szInstrument, byte Direction,
			String szCombOffsetFlag, String szCombHedgeFlag,
			int VolumeTotalOriginal, double LimitPrice, byte OrderPriceType,
			byte TimeCondition, byte ContingentCondition, double StopPrice) {
		if (null == m_pTdApi) {
			return 0;
		}

		return TraderApi.TD_SendOrder(m_pTdApi, szInstrument, Direction,
				szCombOffsetFlag, szCombHedgeFlag, VolumeTotalOriginal,
				LimitPrice, OrderPriceType, TimeCondition, ContingentCondition,
				StopPrice);
	}

	public void CancelOrder(CThostFtdcOrderField pOrder) {
		if (null == m_pTdApi) {
			return;
		}

		TraderApi.TD_CancelOrder(m_pTdApi, pOrder);
	}

	public static void main(String[] args) throws InterruptedException {
		final TraderApiWrapper TdApi = new TraderApiWrapper();
		
		fnOnConnect fnOnConnect_Holder = new QuantBoxLibrary.fnOnConnect() {
			public void apply(Pointer pApi,
					CThostFtdcRspUserLoginField pRspUserLogin, int result) {
				// TODO Auto-generated method stub
				System.out.println(result);
				
				if(result == QuantBoxLibrary.ConnectionStatus.E_confirmed)
				{
					byte Direction = QuantBoxLibrary.THOST_FTDC_D_Buy;
					String szCombOffsetFlag = QuantBoxLibrary.THOST_FTDC_OF_Open + "";
					String szCombHedgeFlag = QuantBoxLibrary.THOST_FTDC_HF_Speculation + "";
					int VolumeTotalOriginal = 1;
					double LimitPrice = 2500;
					byte OrderPriceType = QuantBoxLibrary.THOST_FTDC_OPT_LimitPrice;
					byte TimeCondition = QuantBoxLibrary.THOST_FTDC_TC_GFD;
					byte ContingentCondition = QuantBoxLibrary.THOST_FTDC_CC_Immediately;
					double StopPrice = 0;

					TdApi.SendOrder("IF1303", Direction, szCombOffsetFlag, szCombHedgeFlag,
							VolumeTotalOriginal, LimitPrice, OrderPriceType, TimeCondition,
							ContingentCondition, StopPrice);
				}
			}
		};
		
		
		fnOnRtnOrder fnOnRtnOrder_Holder = new QuantBoxLibrary.fnOnRtnOrder() {
			
			public void apply(Pointer pTraderApi, CThostFtdcOrderField pOrder) {
				// TODO Auto-generated method stub
				System.out.println(new String(pOrder.StatusMsg).trim());
			}
		};
		
		TdApi.fnOnConnect_Holder = fnOnConnect_Holder;
		TdApi.fnOnRtnOrder_Holder = fnOnRtnOrder_Holder;

		TdApi.Connect("D:\\", "tcp://61.129.87.75:41205", "1009", "00000075",
				"123456", THOST_TE_RESUME_TYPE.THOST_TERT_QUICK, "", "");

		

		System.out.println("开始等待!");
		Thread.sleep(3600 * 1000);
		System.out.println("不等啦！");
		
		TdApi.Disconnect();
	}
}
