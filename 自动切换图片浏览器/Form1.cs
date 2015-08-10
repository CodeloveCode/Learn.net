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

namespace 自动切换图片浏览器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //窗体加载时,给图片框加初始图片
            picb1.ImageLocation = path[r.Next(0, path.Count)];
            picb2.ImageLocation = path[r.Next(0, path.Count)];
            picb3.ImageLocation = path[r.Next(0, path.Count)];
            picb4.ImageLocation = path[r.Next(0, path.Count)];
            picb5.ImageLocation = path[r.Next(0, path.Count)];
            picb6.ImageLocation = path[r.Next(0, path.Count)];
            //播放一首音乐
        }

        //下面这三行其实都是字段
        List<string> path = path文件路径.path获取目录下文件路径();
        int i = 0;
        Random r = new Random();//随机数种子

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*
            //用Image.FromFile来加载图片的话,内存很快就爆了....不知道为什么,貌似跟Image.FromFile调用的类的方法有关?

            picb1.Image = Image.FromFile(path[r.Next(0, path.Count)]);
            picb2.Image = Image.FromFile(path[r.Next(0, path.Count)]);
            picb3.Image = Image.FromFile(path[r.Next(0, path.Count)]);
            picb4.Image = Image.FromFile(path[r.Next(0, path.Count)]);
            picb5.Image = Image.FromFile(path[r.Next(0, path.Count)]);
            picb6.Image = Image.FromFile(path[r.Next(0, path.Count)]);
            */
            //使用path路径中随机的一个元素作为图片路径
            picb1.ImageLocation = path[r.Next(0, path.Count)];
            picb2.ImageLocation = path[r.Next(0, path.Count)];
            picb3.ImageLocation = path[r.Next(0, path.Count)];
            picb4.ImageLocation = path[r.Next(0, path.Count)];
            picb5.ImageLocation = path[r.Next(0, path.Count)];
            picb6.ImageLocation = path[r.Next(0, path.Count)];
           
        }
    }
}
