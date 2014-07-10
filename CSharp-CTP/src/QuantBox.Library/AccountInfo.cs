using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace QuantBox.Library
{
    public class AccountInfo : KeyInfo
    {
        [XmlAttribute]
        public string InvestorId { get; set; }
        [XmlAttribute]
        public string Password { get; set; }
    }
}
