using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace QuantBox.CSharp2CTP.Callback
{
    public class ConnectionInfo : KeyInfo
    {
        [XmlAttribute]
        public string TempPath { get; set; }
    }
}
