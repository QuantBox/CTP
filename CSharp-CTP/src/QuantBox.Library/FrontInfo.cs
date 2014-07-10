using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace QuantBox.Library
{
    public class FrontInfo : KeyInfo
    {
        /// <summary>
        /// 经纪商ID
        /// </summary>
        [XmlAttribute]
        public string BrokerId { get; set; }
        /// <summary>
        /// 行情地址
        /// </summary>
        [XmlAttribute]
        public string MarketDataAddress { get; set; }
        /// <summary>
        /// 交易地址
        /// </summary>
        [XmlAttribute]
        public string TradeAddress { get; set; }

        /// <summary>
        /// 客户端产品标识
        /// </summary>
        [XmlAttribute]
        public string UserProductInfo { get; set; }
        /// <summary>
        /// 授权码
        /// </summary>
        [XmlAttribute]
        public string AuthCode { get; set; }
    }
}
