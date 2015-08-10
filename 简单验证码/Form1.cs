using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 简单验证码
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 单击图片框,更换验证码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //先生成一组数字,用做验证码
            string str验证码 = null;//声明一个空的字符串
            Random r = new Random();

            for (int i = 0; i < 5; i++)//生成5位数字的字符串
            {
                str验证码 += r.Next(0, 10).ToString();//随机生成0-9的一个数字,放入验证码
            }
            #region 画出生成的字符串
            //创建GDI对象
            Bitmap bmp = new Bitmap(120, 40);//创建指定大小的位图
            Graphics g = Graphics.FromImage(bmp);

            //使用随机字体,随机颜色, 画出字符,每次只画一个
            //字体
            string[] fonts = { "微软雅黑", "幼圆", "方正喵呜", "仿宋", "楷体" };
            //颜色
            Color[] colors = { Color.Salmon, Color.Black, Color.Red, Color.Green, Color.Yellow };

            //循环5次,画出5个字符
            for (int i = 0; i < 5; i++)
            {
                //画字符的坐标
                Point p = new Point(i * 20, 0);
                //字符字体
                Font font1 = new Font(fonts[r.Next(0, fonts.Length)], 20, FontStyle.Bold);
                //单色画笔颜色
                SolidBrush brush1 = new SolidBrush(colors[r.Next(0, colors.Length)]);
                //使用随机字体,随机颜色, 在指定坐标,画出字符
                g.DrawString(str验证码[i].ToString(), font1, brush1, p);

            }
            #endregion

            #region 给验证码添加干扰线


            //画数条干扰线
            for (int i = 0; i < 30; i++)
            {
                //干扰线的两端坐标应该在bmp范围内
                Point p1 = new Point(r.Next(0, bmp.Width), r.Next(0, bmp.Height));
                Point p2 = new Point(r.Next(0, bmp.Width), r.Next(0, bmp.Height));
                g.DrawLine(new Pen(Brushes.Green), p1, p2);

            }


            #endregion

            #region 加一些干扰点

            for (int i = 0; i < 500; i++)
            {
                Point p3 = new Point(r.Next(0, bmp.Width), r.Next(0, bmp.Height));
                bmp.SetPixel(p3.X, p3.Y, Color.Black);
            }

            #endregion 

            //将画好的bmp位图,给picturebox
            pictureBox1.Image = bmp;

        }

    }
}
