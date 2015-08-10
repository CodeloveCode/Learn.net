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
using 读取目录下所有文件路径_包括子目录_;
namespace ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 窗体载入时,载入初始文件列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
 
            
            //给listbox加载集合元素
            foreach (string paths in path目录所有文件)
            {
                listBox列表.Items.Add(Path.GetFileName(paths));
            }
        }
        //存放给定目录的所有文件路径
        List<string> path目录所有文件 = Pat添加当前目录下所有文件路径_包括子目录的_.Path添加当前目录下所有文件路径(@"C:\Users\mudking\Pictures");

        private void listBox列表_SelectedIndexChanged(object sender, EventArgs e)
        {
            //listBox列表.Items里存放的只是图片的名称和扩展名
            //需要获取对应的文件路径才行
            int index = listBox列表.SelectedIndex;
            picB图片显示框.ImageLocation = path目录所有文件[index];
        }
    }
}
