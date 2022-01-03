using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static key_spirit.utils.BackgroundKeyUtils;
using static PInvoke.User32;

namespace key_spirit.utils
{
    /// <summary>
    /// 实际暴露给外部使用的类.需要初始化才可以使用.
    /// </summary>
    public class KeyHelper
    {
        public bool flag { get; set; }
        public KeyHelper()
        {
            this.flag = false;
        }

        public void stopAllKeyPress()
        {
            this.flag = false;
        }

        /// <summary>
        /// 按指定间隔, 向指定窗口重复发送按键命令.
        /// </summary>
        /// <param name="hwnd"></param>
        /// <param name="virtualKeyCode">虚拟键码.PInvoke.User32.VirtualKey</param>
        /// <param name="interval">按键间隔的毫秒值</param>
        public void keyPressInterval(IntPtr hwnd, VirtualKey virtualKeyCode, int interval)
        {
            this.flag = true;
            while (this.flag)
            {
                keyPress(hwnd, virtualKeyCode);
                // 额外加上一个随机延迟,模拟人工操作.
                Thread.Sleep(interval + RandomUtils.IntBetweenRange(1, 50));
            }
        }
    }
}
