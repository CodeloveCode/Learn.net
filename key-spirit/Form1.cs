using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using com.example.appconfig.utils;
using key_spirit.utils;
// 引入WIN32互操作命名空间.减少重复代码.
using PInvoke;
// 静态引入User32类.减少重复代码.
using static PInvoke.User32;


namespace key_spirit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            init();
        }

        private void init()
        {
            // 1. 初始化所有下拉框.

            // 准备系统支持的所有虚拟键码列表.
            List<VirtualKeyStruct> virtualKeyStructs = new List<VirtualKeyStruct>();
            Array virtualKeyNames = Enum.GetValues(typeof(VirtualKey));

            foreach (VirtualKey virtualKey in virtualKeyNames)
            {
                virtualKeyStructs.Add(new VirtualKeyStruct(virtualKey.ToString(), virtualKey));
            }
            // 为下拉框设置列表数据源
            this.keySelector1.Items.AddRange(virtualKeyStructs.ToArray());
            this.keySelector1.DataSource = virtualKeyStructs;
            // 列表元素的"keyName"属性作为下拉框的显示值.
            this.keySelector1.DisplayMember = "keyName";
            // 列表元素的"keyCode"属性作为下拉框的实际值.
            this.keySelector1.ValueMember = "keyCode";
        }



        private void btnJump_Click(object sender, EventArgs e)
        {
            //PInvoke.User32.MessageBox(&this, "hello world!", "hello", User32.MessageBoxOptions.MB_APPLMODAL);

            // 检索鼠标光标在屏幕坐标中的位置。
            POINT point = GetCursorPos();
            // 检索鼠标所在窗口的句柄.
            IntPtr intPtr = WindowFromPoint(point);

            WINDOWINFO windowInfo = WINDOWINFO.Create();
            if (GetWindowInfo(intPtr, ref windowInfo))
            {
                MessageBox(intPtr, windowInfo.ToString(), "窗口信息", User32.MessageBoxOptions.MB_APPLMODAL);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void keySelector1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnSaveKeyConfig_Click(object sender, EventArgs e)
        {
            // 获取下拉框选择的virtual key对象.
            VirtualKey selectedKey1 = (VirtualKey)this.keySelector1.SelectedValue;

            // 写入到app的配置文件中.
            string appPath = Application.ExecutablePath;
            string KEY_1 = "KEY_1";
            AppConfigHelper.write(appPath, KEY_1, (int)selectedKey1 + "");
        }

        private KeyHelper keyHelper = new KeyHelper();

        /// <summary>
        /// 自动查找记事本,发送持续按键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            // 如果自动按键进行中,则停止自动按键.
            if (keyHelper.flag)
            {
                keyHelper.stopAllKeyPress();
                return;
            }
            // 参数校验
            if (this.keySelector1.SelectedValue == null)
            {
                throw new ArgumentException("请选择按键");
            }
            if (string.IsNullOrWhiteSpace(this.keyInterval1.Text))
            {
                throw new ArgumentException("请输入按键延迟");
            }

            // 根据用户配置,开启自动按键.
            IntPtr phwnd = FindWindow("Notepad", null);
            IntPtr hwnd = FindWindowEx(phwnd, IntPtr.Zero, "Edit", null);
            keyHelper.keyPressInterval(hwnd, (VirtualKey)this.keySelector1.SelectedValue, int.Parse(this.keyInterval1.Text));
        }

        // TODO:监听全局的开始按键热键,执行停止和开始自动按键的动作.
        // todo:按键需要多线程.
    }
}
