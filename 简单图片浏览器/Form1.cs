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
namespace 简单图片浏览器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            i = r.Next(0, imagePath.Length + 1);//窗体加载时,随机加载第i张图片
            picb图片框.ImageLocation = imagePath[i];
        }
        
        //获取目录下图片路径,但子目录无法获得
        string []imagePath = Directory.GetFiles(@"C:\Users\mudking\Pictures");
        int i = 0;//i用来存放imagepath的下标,用来表示当前是目录中第几张图片
        Random r = new Random();

        /// <summary>
        /// 点击显示下一张图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt下一张_Click(object sender, EventArgs e)
        {
            i++;//点击按钮时,图片路径数组下标+1
            if (i==imagePath.Length)//当图片超过最后一张时(,imagePath.Length-1是最后一张)
            {
                i = 0;//切换到第一张继续显示
            }
            picb图片框.ImageLocation = imagePath[i];//实现显示下一张图片
        }

        /// <summary>
        /// 点击显示上一张图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt上一张_Click(object sender, EventArgs e)
        {
            i--;//点击按钮时,图片路径数组下标-1
            if (i<0)//如果图片超过第一张
            {
                i = imagePath.Length - 1;//切换到最后一张
            }
            picb图片框.ImageLocation = imagePath[i];//实现显示前一张图片
        }
    }
}
