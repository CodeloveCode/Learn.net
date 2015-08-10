using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 控件坐标练习
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt爱_Click(object sender, EventArgs e)
        {
            MessageBox.Show("我也爱你哟,么么哒");
            this.Close();
        }

        private void bt不爱_Click(object sender, EventArgs e)
        {
            MessageBox.Show("老娘给你这么多机会,你还不要不要的,活该屌丝!");
            this.Close();
        }

        private void bt不爱_MouseEnter(object sender, EventArgs e)
        {
            //点不爱的时候要求按钮在窗体内随机移动
            //控件的活动区域为窗体工作区的宽度-控件宽度
            int x = this.ClientSize.Width - bt不爱.Width;
            //控件的活动区域为窗体工作区的高度-控件高度
            int y = this.ClientSize.Height - bt不爱.Height;
            //声明一个随机数种子
            Random r = new Random();
            //按钮的坐标由location属性控制,这是point点类
            //r.Next(0, x + 1)生成X轴范围内的一个随机数
            bt不爱.Location = new Point(r.Next(0, x + 1), r.Next(0, y + 1));
        }
    }
}
