using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace QuantBox.Library
{
    public class ConnectionInfo : KeyInfo
    {
        [XmlAttribute]
        public string TempPath { get; set; }
    }
}
