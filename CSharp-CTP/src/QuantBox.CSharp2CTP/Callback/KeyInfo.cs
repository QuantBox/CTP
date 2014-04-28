using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace QuantBox.CSharp2CTP.Callback
{
    public class KeyInfo
    {
        [XmlAttribute]
        [DefaultValue(null)]
        public string StringKey { get; set; }

        [XmlAttribute]
        [DefaultValue(0)]
        public int IntKey { get; set; }

        [XmlIgnore]
        public IntPtr IntPtrKey { get; set; }
    }
}
