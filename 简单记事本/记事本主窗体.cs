using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace 简单记事本
{
    public partial class Form记事本 : Form
    {
        public Form记事本()
        {
            InitializeComponent();
        }

        private void Form记事本_Load(object sender, EventArgs e)
        {
            //主窗体载入时,将自身对象引用传给静态类字段
            class主窗体对象将被存在这个静态类.Form存主窗体 = this;
            //主窗体载入时,创建登录窗口,并显示
            Form登录界面 frm登录 = new Form登录界面();
            frm登录.Show();
            //然后将主窗体隐藏,直到用户登录成功
            this.Visible = false;
           

        }

        private void bt自动换行_Click(object sender, EventArgs e)
        {
            //首先判断tb主编辑框 自动换行属性 目前的状态

            if (tb主编辑框.WordWrap==false)//如果不自动换行
            {
                tb主编辑框.WordWrap = true;//则设置为自动换行
                bt自动换行.Text = "取消自动换行";//然后将自动换行按钮的text修改
            }
            else//如果是自动换行
            {
                tb主编辑框.WordWrap = false;//取消自动换行
                bt自动换行.Text = "设置自动换行";//然后将自动换行按钮的text修改
            }
        }

        private void bt保存文件_Click(object sender, EventArgs e)
        {
            //使用filestream来保存文件
            Byte[] buffer = new Byte[1024*1024*1];
            //tb主编辑框.Text的内容去除头尾空格后,转换成字节数组
            buffer = Encoding.Default.GetBytes(tb主编辑框.Text.Trim());
            using (FileStream fsWrite = new FileStream(@"C:\Users\mudking\Desktop\newTest.txt", FileMode.CreateNew, FileAccess.Write))
            {

                fsWrite.Write(buffer, 0, buffer.Length);
                MessageBox.Show("保存成功");
            } 
        }
    }
}
