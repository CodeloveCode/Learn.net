using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform基本练习1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void bt窗体3_Click(object sender, EventArgs e)
        {
            FormContain.装主窗体.Close();//FormContain.装主窗体 装的是窗体1的引用,关闭主窗体整个程序也就结束了
        }
    }
}
