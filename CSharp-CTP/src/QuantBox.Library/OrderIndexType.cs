using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuantBox.Library
{
    /// <summary>
    /// 默认使用FIX 5.0中的协议字段来填充
    /// </summary>
    public class OrderIndexType
    {
        public const int Account = 1;
        public const int PositionEffect = 77;
        public const int HedgeFlag = 255; // 投机与保值，这个不知道对应的是哪一个，先这样用着
    }
}
