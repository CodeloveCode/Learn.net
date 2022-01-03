using com.example.appconfig.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winForm读写配置文件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 保存key,value
        private void btnSave_Click(object sender, EventArgs e)
        {
            // 获取应用程序的可执行文件路径
            string appPath = Application.ExecutablePath;
            AppConfigHelper.write(appPath, txtKey.Text, txtValue.Text);
        }
        // 根据key读取value
        private void btnRead_Click(object sender, EventArgs e)
        {
            // 获取应用程序的可执行文件路径
            string appPath = Application.ExecutablePath;
            txtValue.Text = AppConfigHelper.read(appPath, txtKey.Text);
        }
        // 读取配置文件中AppSettings段的所有配置.
        private void btnReadAll_Click(object sender, EventArgs e)
        {
            string appPath = Application.ExecutablePath;
            Dictionary<string, string> map = AppConfigHelper.readAll(appPath);
            String str = "";
            foreach (string key in map.Keys)
            {
                // System.Environment.NewLine 跨平台换行符.
                str += key + "= " + map[key] + System.Environment.NewLine;
            }
            txtAll.Text = str;
        }
    }
}
