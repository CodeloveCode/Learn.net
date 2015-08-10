using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform猜大小
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 自动生成0-99,用于猜大小
        
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            //每点击一次,重置一次游戏,同时将lbl中游戏记时置0
            //首先情况所有按钮,(开始按钮除外)
            
        }
        /// <summary>
        /// 大小判断
        /// </summary>
        void Guess(int input,int sorce)
        {
            if (input==sorce)
            {
                MessageBox.Show("你猜对了");
            }
            else if(input >sorce)
            {
                MessageBox.Show("大了");
            }
            else
            {
                MessageBox.Show("小了");
            }
        }
    }
}
