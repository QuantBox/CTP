using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace QuantBox.CSharp2CTP
{
    public class Toolkit
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool SetDllDirectory(string lpPathName);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern int GetDllDirectory(int bufSize, StringBuilder buf);


        public static string GetEntryAssemblyPath()
        {
            //string _CodeBase = System.Reflection.Assembly.GetExecutingAssembly().CodeBase;
            string _CodeBase = System.Reflection.Assembly.GetEntryAssembly().CodeBase;

            _CodeBase = _CodeBase.Substring(8, _CodeBase.LastIndexOf("/") - 8 + 1); // 8是 "file://" 的长度

            return _CodeBase.Replace("/", @"\");
            //return System.AppDomain.CurrentDomain.BaseDirectory;
        }
    }
}
