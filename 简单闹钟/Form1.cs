using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 简单闹钟
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void timer1显示时间_Tick(object sender, EventArgs e)
        {
            //为了让lbl显示时间在窗体建立的时候就显示时间,应该在form.load里操作
            lbl显示时间.Text = DateTime.Now.ToString();
            //21:02时,闹钟响
            if (DateTime.Now.Hour==21&&DateTime.Now.Minute==2&&DateTime.Now.Second==0)
            {
                MessageBox.Show("到点了起床吧");
            }
        }

        private void tb输入_TextChanged(object sender, EventArgs e)
        {
            //当输入内容时, lbl同步文本框的内容随之改变
            lbl同步文本框.Text = tb输入.Text;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl显示时间.Text = DateTime.Now.ToString();
        }
    }
}
