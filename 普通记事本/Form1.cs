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
namespace 普通记事本
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 打开文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog打开文件 = new OpenFileDialog();
            dialog打开文件.Filter = @"文本文件((*.txt))|*.txt|所有文件(*.*)|*.*";
            dialog打开文件.InitialDirectory = @"C:\Users\mudking\Desktop";
            dialog打开文件.Multiselect = false;
            dialog打开文件.Title = "请选择一个文件";
            dialog打开文件.ShowDialog();
            if (dialog打开文件.FileName == "")
            {
                return;
            }
            //读新文件前清空编辑框
            if (tb编辑框.Text!="")
            {
                tb编辑框.Text.Remove(0);
            }
          
            using (FileStream fsRead = new FileStream(dialog打开文件.FileName, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {

                //while (r!=0)
                //{
                //    r = fsRead.Read(buffer, 0, buffer.Length);
                //    if (r==0)
                //    {
                //        break;
                //    }
                //   tb编辑框.Text =tb编辑框.Text.Insert(tb编辑框.Text.Length, Encoding.Default.GetString(buffer));//将字节块buffer的数据转换为字符串,插入到编辑框的末尾
                //}
                r = fsRead.Read(buffer, 0, buffer.Length);
                tb编辑框.Text = Encoding.Default.GetString(buffer,0,r);
            }
            //文件成功打开后,将文件名追加到文件列表listbox
            lb文件列表.Items.Add(Path.GetFileName(dialog打开文件.FileName));
            //同时将文件路径存到集合里
            path打开过的文件路径.Add(dialog打开文件.FileName);
        }
        #region 定义一些全局变量
        byte[] buffer = new byte[1024 * 1024 * 5];//缓冲区
        List<string> path打开过的文件路径 = new List<string>();//为文件列表打开文件提供方便
        int r = 0;//r用来保存文件流读取的返回值
        #endregion
        /// <summary>
        /// 保存文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog保存文件 = new SaveFileDialog();
            dialog保存文件.InitialDirectory = @"C:\Users\mudking\Desktop";
            dialog保存文件.Title = "请选择文件保存的位置";
            dialog保存文件.CreatePrompt = true;
            dialog保存文件.DefaultExt = @"文本文件(*.txt)|*.txt ";
            dialog保存文件.Filter = @"文本文件(*.txt)|*.txt ";
            dialog保存文件.ShowDialog();
            if (dialog保存文件.FileName == "")
            {
                return;
            }
            using (FileStream fsWrite = new FileStream(dialog保存文件.FileName, FileMode.OpenOrCreate, FileAccess.Write))
            {
                //这里写法有问题,如果文件太大,这样写buffer可能超过大小而报错
                buffer = Encoding.Default.GetBytes(tb编辑框.Text);

                fsWrite.Write(buffer, 0, buffer.Length);


            }
        }
        /// <summary>
        /// 自动换行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 自动换行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Menustrip自动换行.Text == "√自动换行")//如果已经是自动换行
            {
                tb编辑框.WordWrap = false;
                Menustrip自动换行.Text = "自动换行";
            }
            else
            {
                tb编辑框.WordWrap = true;
                Menustrip自动换行.Text = "√自动换行";
            }

        }
        /// <summary>
        /// 字体菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 字体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dialog字体 = new FontDialog();
            dialog字体.ShowEffects = true;
            dialog字体.ShowDialog();
            tb编辑框.Font = dialog字体.Font;
        }
        /// <summary>
        /// 颜色菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dialog颜色 = new ColorDialog();
            dialog颜色.ShowDialog();
            tb编辑框.ForeColor = dialog颜色.Color;
        }

        private void 显示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel文件列表开关.Visible = true;
        }

        #region 控制文件列表开关


        private void 隐藏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel文件列表开关.Visible = false;
        }

        private void bt隐藏文件列表_Click(object sender, EventArgs e)
        {
            panel文件列表开关.Visible = false;
        }
        #endregion

        private void lb文件列表_DoubleClick(object sender, EventArgs e)
        {
            //读新文件前清空编辑框
            if (tb编辑框.Text != "")
            {
                tb编辑框.Text.Remove(0);
            }
            string lb文件列表选择项路径 = path打开过的文件路径[lb文件列表.SelectedIndex];
            using (FileStream fsWrite = new FileStream(lb文件列表选择项路径, FileMode.Open, FileAccess.Read))
            {
                //这里写法有问题,如果文件太大,这样写buffer可能超过大小而报错
                fsWrite.Read(buffer, 0, buffer.Length);
                tb编辑框.Text = Encoding.Default.GetString(buffer);

                

            }
        }
    }
}