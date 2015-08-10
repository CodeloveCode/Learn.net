using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 简单记事本
{
    public partial class Form登录界面 : Form
    {
        public Form登录界面()
        {
            InitializeComponent();
        }

        private void Form登录界面_Load(object sender, EventArgs e)
        {
            //将焦点放到frm登录的文本框上
            lbl登录用户名.Focus();
        }

        private void bt登录按钮_Click(object sender, EventArgs e)
        {
            //假设:用户名是admin,密码是password
            
            //对输入数据做判断
            if (tb用户名输入.Text=="admin"&&tb密码输入.Text=="password")
            {
                MessageBox.Show("正确,进入程序");
                this.Close();//关闭登录窗口
                //将主窗体设置为可见
                class主窗体对象将被存在这个静态类.Form存主窗体.Visible = true;
            }
            else
            {
                MessageBox.Show("输入错误,请重新输入");
                //清空文本框,
                tb用户名输入.Clear();
                tb密码输入.Clear();
                //焦点移动到用户名输入框
                tb用户名输入.Focus();
            }
        }
    }
}
