using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PInvoke;
using static PInvoke.User32;
using System.Threading;

namespace key_spirit.utils
{
    public unsafe class BackgroundKeyUtils
    {
        /**
         * 向指定窗口发送(系统)按键消息.
         * 按照官方文档介绍,按下F10时,或者按住alt键时再按其他键,此时都会发送一个系统按键消息.
         * https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-syskeydown
         */

        /**
         * 向指定窗口发送(非系统)按键消息.
         * System.Windows.Forms. Keys Enum
         * https://docs.microsoft.com/zh-cn/dotnet/api/system.windows.forms.keys?view=windowsdesktop-6.0
         * 按键消息.
         * https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-keydown
         * windows 虚拟键码
         * https://docs.microsoft.com/en-us/windows/win32/inputdev/virtual-key-codes
         * 将扫描码,字符翻译为虚拟键码.
         * https://docs.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-mapvirtualkeyexw
         *
         * @param hWnd           窗口句柄.
         * @param virtualKeyCode 虚拟键码. 可以使用java.awt.event.KeyEvent类中的常量.
         */
        public static void keyDown(IntPtr hWnd, VirtualKey virtualKeyCode)
        {
            // TODO:判断hWnd不能为空
            // TODO:判断virtualKeyCode须是非系统按键.
            //        int virtualKeyCode = keyEvent;

            User32.WindowMessage msg = User32.WindowMessage.WM_KEYDOWN;
            int* wParam = (int*)&virtualKeyCode; // 对于WM_KEYDOWN消息. wParam就是 virtual-key code of the nonsystem key.
            int* lParam = makeLparamForKeydown(virtualKeyCode);
            User32.PostMessage(hWnd, msg, wParam, lParam);
        }

        /**
         * 向指定窗口发送(非系统)按键消息.
         * 按键消息.
         * https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-keydown
         * windows 虚拟键码
         * https://docs.microsoft.com/en-us/windows/win32/inputdev/virtual-key-codes
         * 将扫描码,字符翻译为虚拟键码.
         * https://docs.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-mapvirtualkeyexw
         *
         * @param hWnd           窗口句柄.
         * @param virtualKeyCode 虚拟键码. 可以使用java.awt.event.KeyEvent类中的常量.
         */
        public static void keyUp(IntPtr hWnd, VirtualKey virtualKeyCode)
        {
            // TODO:判断hWnd不能为空
            // TODO:判断virtualKeyCode须是非系统按键.
            //        int virtualKeyCode = keyEvent;
            User32.WindowMessage msg = User32.WindowMessage.WM_KEYUP;
            //int msg = KeyboardInputNotifications.WM_KEYUP;

            // 对于WM_KEYDOWN消息. wParam就是 virtual-key code of the nonsystem key.
            int* wParam = (int*)&virtualKeyCode;

            int* lParam = makeLparamForKeyup(virtualKeyCode);

            User32.PostMessage(hWnd, msg, wParam, lParam);
        }

        /**
         * uMapType
         * https://docs.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-mapvirtualkeyexw
         */
        private enum MapType
        {
            MAPVK_VK_TO_VSC,
            MAPVK_VSC_TO_VK,
            MAPVK_VK_TO_CHAR,
            MAPVK_VSC_TO_VK_EX,
            MAPVK_VK_TO_VSC_EX,
        }

        // 击键消息. https://docs.microsoft.com/en-us/windows/win32/inputdev/about-keyboard-input#keystroke-message-flags
        public static unsafe int* makeLparamForKeydown(VirtualKey virtualKeyCode)
        {
            // The repeat count, scan code, extended-key flag, context code, previous key-state flag, and transition-state flag, as shown following.
            int* lParam = null;
            // 0-15
            short repeatCount = 0b1;
            // 16-
            int scanCode = User32.MapVirtualKey((int)virtualKeyCode, User32.MapVirtualKeyTranslation.MAPVK_VK_TO_VSC);
            //int scanCode = User32.MapVirtualKeyEx(virtualKeyCode, MapType.MAPVK_VK_TO_VSC.ordinal(), null);
            // 24. Indicates whether the key is an extended key, such as the right-hand ALT and CTRL keys that appear on an enhanced 101- or 102-key keyboard. The value is 1 if it is an extended key; otherwise, it is 0.
            int isExtendKey = 0b0;
            // 25-28.Reserved; do not use.
            // 29
            int contextCode = 0b0; // The value is always 0 for a WM_KEYDOWN message.
            // 30.The previous key state. The value is 1 if the key is down before the message is sent, or it is zero if the key is up.
            int previousKeyState = 0b0; // 如果需要用组合键,则这里需要为1.
            // 31
            int transitionState = 0b0; // The value is always 0 for a WM_KEYDOWN message.
            // 把这些值连起来.
            // 16-23
            int total16_23 = scanCode << 16;
            // 24-31. 观察可知,当按下键时,24-31补零就行.
            int total24_31 = 0b0 << 24;

            int total = total24_31 + total16_23 + repeatCount; // TODO:把上面的值按照位拼接为一个32位long整数.可能需要用位移计算.
            Console.WriteLine("lparam:{0}", total);
            lParam = &total;
            return lParam;
        }


        public static int* makeLparamForKeyup(VirtualKey virtualKeyCode)
        {
            int* lParam = null; // The repeat count, scan code, extended-key flag, context code, previous key-state flag, and transition-state flag, as shown following.
                                // 0-15
            short repeatCount = 0b1;
            // 16-23
            int scanCode = User32.MapVirtualKey((int)virtualKeyCode, User32.MapVirtualKeyTranslation.MAPVK_VK_TO_VSC);
            // 24. Indicates whether the key is an extended key, such as the right-hand ALT and CTRL keys that appear on an enhanced 101- or 102-key keyboard. The value is 1 if it is an extended key; otherwise, it is 0.
            int isExtendKey = 0b0;
            // 25-28.Reserved; do not use.
            // 用0填充.
            // 29.The context code. The value is always 0 for a WM_KEYUP message.
            int contextCode = 0b0;
            // 30.The previous key state. The value is always 1 for a WM_KEYUP message.
            int previousKeyState = 0b1;
            // 31
            int transitionState = 0b1; // The transition state. The value is always 1 for a WM_KEYUP message.

            // 把这些值连起来.参考文档把各值移动到二进制对应的位置上.
            // 16-23
            int total16_23 = scanCode << 16;
            // 24-31.
            int total24_31 = transitionState << 31 + previousKeyState << 30;

            int total = total24_31 + total16_23 + repeatCount; // TODO:把上面的值按照位拼接为一个32位long整数.可能需要用位移计算.
            //System.out.printf("lparam: %d", total);
            Console.WriteLine($"lparam:{total}");
            lParam = &total;
            return lParam;
        }

        /// <summary>
        /// 向指定窗口发送按键命令.
        /// </summary>
        /// <param name="hwnd"></param>
        /// <param name="virtualKeyCode">虚拟键码.PInvoke.User32.VirtualKey</param>
        public static void keyPress(IntPtr hwnd, VirtualKey virtualKeyCode)
        {
            keyDown(hwnd, virtualKeyCode);
            // 随机给一个延迟,模拟人工操作.
            Thread.Sleep(RandomUtils.IntBetweenRange(4, 14));
            keyUp(hwnd, virtualKeyCode);
        }



    }
}
