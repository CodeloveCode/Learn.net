using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 下拉框comboBox_日期选择器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗口载入时,给年份下拉框赋初值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            int year = DateTime.Now.Year;//获取当前系统年份
            for (int i = year; i >= 1949; i--)
            {
                cmb年.Items.Add(i + "年");
            }
        }

        /// <summary>
        /// 当选中某年份时,给月份comboBox赋初值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmb年_SelectedIndexChanged(object sender, EventArgs e)
        {
            //每次改变选择时,先清空 cmb月 里的元素
            cmb月.Items.Clear();
            for(int i = 1; i <= 12; i++)
            {
                cmb月.Items.Add(i + "月");
            }
        }

        /// <summary>
        /// 选中某月时,改变combox日 组合框里的项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmb月_SelectedIndexChanged(object sender, EventArgs e)
        {
            //每次改变选择时,先清空 组合框 里的项
            cmb日.Items.Clear();

            //int month月份 = cmb月.SelectedIndex+1;
            //MessageBox.Show(month月份.ToString());

            //获取月份
            //获取cmb月 的当前选择项,里氏转换成string
            string strMonth = (string)cmb月.SelectedItem;
            //切掉strMonth里的'月'和空格后,返回一个只有一个元素的字符串数组,取元素[0]
            string monthStr = strMonth.Split(new char[] { '月' }, StringSplitOptions.RemoveEmptyEntries)[0];
            //获取年份
            string yearStr = cmb年.SelectedItem.ToString().Split(new char[] { '年' }, StringSplitOptions.RemoveEmptyEntries)[0];

            int year = Convert.ToInt32(yearStr);
            int month = Convert.ToInt32(monthStr);
            int days = 0;

           switch (month)//判断每月天数
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:days = 31;
                    break;
                case 2://判断闰年的标准是：1、能整除4且不能整除100  2、能整除400
                    if (year%4==0&&year%100!=0||year%400==0)
                    {
                        days = 29;
                    }
                    else
                    {
                        days = 28;
                    }
                    break;
                default:days = 30;
                    break;
            }

            //给cmb日 赋值
            for (int i = 1; i <=days ; i++)
            {
                cmb日.Items.Add(i + "天");
            }


            

        }
    }
}
