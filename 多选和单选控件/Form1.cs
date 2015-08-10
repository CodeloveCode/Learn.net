using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 多选和单选控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt登陆_Click(object sender, EventArgs e)
        {
            string name = tb帐号.Text;
            string pw = tb密码.Text;
            //登录界面判断
            if (rb会员.Checked||rb游客.Checked)//如果游客,会员选择框被选中
            {
                if (rb游客.Checked)
                {
                    if (name=="游客"&&pw=="游客")
                    {
                        MessageBox.Show("登录成功");
                    }
                    else
                    {
                        MessageBox.Show("帐户信息错误,请重新输入");
                        tb帐号.Clear();
                        tb密码.Clear();
                        tb帐号.Focus();
                    }
                }
                else
                {
                    if (name == "admin" && pw == "admin")
                    {
                        MessageBox.Show("登录成功");
                    }
                    else
                    {
                        MessageBox.Show("帐户信息错误,请重新输入");
                        tb帐号.Clear();
                        tb密码.Clear();
                        tb帐号.Focus();
                    }

                }
            }
            else
            {
                MessageBox.Show("请选择身份登录");
            }
        }
    }
}
