using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PInvoke.User32;

namespace key_spirit.utils
{
    /// <summary>
    /// 对PInvoke.User32.VirtualKey枚举成员的简单封装.
    /// </summary>
    public class VirtualKeyStruct
    {
        public string keyName { get; set; }
        public VirtualKey keyCode { get; set; }

        public VirtualKeyStruct()
        {
        }

        public VirtualKeyStruct(string keyName, VirtualKey keyCode)
        {
            this.keyName = keyName;
            this.keyCode = keyCode;
        }
    }
}
