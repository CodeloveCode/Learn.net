using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI窗体设计
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 增加窗口ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();//创建窗体2对象
            frm2.MdiParent = this;//将frm2 mdi父窗体设置为当前对象form1
            frm2.Show();
           
            Form3 frm3 = new Form3();
            frm3.MdiParent =this;
            frm3.Show();

            Form4 frm4 = new Form4();
            frm4.MdiParent = this;
            frm4.Show();
            
        }

        private void 横向排列ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void 纵向排列ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
