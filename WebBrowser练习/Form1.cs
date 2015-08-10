using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser练习
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btGo_Click(object sender, EventArgs e)
        {
            Uri urlInput = new Uri(@"http://" + tb地址栏.Text);
            web浏览器.Url = urlInput;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tb地址栏.Focus();
          
        }
    }
}
