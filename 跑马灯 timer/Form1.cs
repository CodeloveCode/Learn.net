using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 跑马灯_timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 跑马灯原理:将一个字符串 切去开头 追加到尾部,按一定的时间间隔重复动作即可
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void tmr跑马灯_Tick(object sender, EventArgs e)
        {
            //   //这方法太傻....
            //    //将需要做跑马灯的字符 放入一个char类型泛型集合
            //List<char> Pmd跑马灯内容 = new List<char>(lbl显示器.Text);

            ////每次钟摆开始后,首先将集合中第一个元素取出,放到中转变量buffer里
            //char buffer = Pmd跑马灯内容[0];

            //    //然后将集合中第一个元素移除
            //    Pmd跑马灯内容.Remove(Pmd跑马灯内容[0]);
            //    //将中转变量buffer追加到集合里,也就是原来的第一个元素追加到尾部
            //    Pmd跑马灯内容.Add(buffer);
            //    //将更新后的跑马灯内容赋值给lbl显示器
            //    lbl显示器.Text = "";//首先清空text
            //    foreach (char item in Pmd跑马灯内容)
            //    {
            //        lbl显示器.Text += (item.ToString());
            //    }

            //直接用SubString方法,将去掉的第一个字符,加到去掉第一个字符后 剩下的字符串上
            //就实现了头移到尾的效果
            lbl显示器.Text =lbl显示器.Text.Substring(1) + lbl显示器.Text.Substring(0, 1);
            
        }


    }
}
