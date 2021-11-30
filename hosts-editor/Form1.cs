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
using hosts_editor.entity;
using System.Text.RegularExpressions;

namespace hosts_editor
{
    public partial class Form1 : Form
    {
        const string HOST_PATH = @"C:\Windows\System32\drivers\etc\hosts";
        // 必须永远根据行号升序排序,否则添加新行和换行时会出现问题.
        private List<LineInfo> lines;
        //private List<LineInfo> editableLines;
        private BindingList<LineInfo> bindingList;


        public Form1()
        {
            InitializeComponent();
            initDataGridView();
            loadHost();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            loadHost();
        }
        private void initDataGridView()
        {
            // 手动设置dataGridView的列.如果手动和自动设置同时使用,默认会显示所有列,所以如果用自动,需要手动隐藏不需要的.
            //dataGridView.AutoGenerateColumns = false;
            //DataGridViewColumn columnIp = new DataGridViewTextBoxColumn();
            //columnIp.DataPropertyName = "ip";
            //columnIp.Name = "ip";
            //dataGridView.Columns.Add(columnIp);

            //DataGridViewTextBoxColumn columnHost = new DataGridViewTextBoxColumn();
            //columnHost.DataPropertyName = "host";
            //columnHost.Name = "host";
            //dataGridView.Columns.Add(columnHost);

            // Attach the DataError event to the corresponding event handler.为数据错误事件添加一个异常处理器.
            this.dataGridView.DataError += new DataGridViewDataErrorEventHandler(dataGridView_DataError);
            // 某个单元格停止编辑时.
            //this.dataGridView.CellEndEdit += new DataGridViewCellEventHandler(dataGridView1_CellEndEdit);
            // 用户在新行中输入任意一个字符时,才真正创建新行.
            //this.dataGridView.RowsAdded += new DataGridViewRowsAddedEventHandler(dataGridView1_RowsAdded);
            // 用户在新行中输入任意一个字符时,才真正创建新行.
            //this.dataGridView.UserAddedRow += new DataGridViewRowEventHandler(dataGridView1_UserAddedRow);
            // 为 Windows 窗体 DataGridView 控件中的新行指定默认值
            this.dataGridView.DefaultValuesNeeded += new DataGridViewRowEventHandler(dataGridView_DefaultValuesNeeded);
        }

        // 为新行添加行号.
        private void dataGridView_DefaultValuesNeeded(object sender, System.Windows.Forms.DataGridViewRowEventArgs e)
        {
            this.lines.Add(new LineInfo(this.lines.Last().LineNumber + 1, ""));
            e.Row.Cells[0].Value = this.lines.Last().LineNumber;
        }

        private void dataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // If the data source raises an exception when a cell value is
            // commited, display an error message.
            if (e.Exception != null &&
                e.Context == DataGridViewDataErrorContexts.Commit)
            {
                MessageBox.Show($"column value has error:{e.Exception.Message}");
            }
        }

        private void loadHost()
        {
            // C:\Windows\System32\drivers\etc\hosts维护了ip地址与主机名的映射,这份文件被windows的tcp/ip服务使用
            // 读取文件.
            lines = new List<LineInfo>();
            //string line;
            int lineIndex = 0;

            //// Read the file and display it line by line.  
            foreach (string line in System.IO.File.ReadLines(HOST_PATH, Encoding.UTF8))
            {
                lines.Add(new LineInfo(lineIndex, line));
                lineIndex++;
            }

            // 将有效内容组装成dataGridView需要的数据源.
            List<LineInfo> editableLines = lines.FindAll(x => !string.IsNullOrEmpty(x.OriginContent) && !x.OriginContent.StartsWith("#"));

            Regex regex = new Regex(@"\s");
            foreach (LineInfo lineInfo in editableLines)
            {
                string[] strs = regex.Split(lineInfo.OriginContent);
                lineInfo.Ip = strs[0];
                lineInfo.Host = strs[1];
            }

            // 为dataGridView设置数据源
            bindingList = new BindingList<LineInfo>(editableLines);// BindingList可自动解决许多数据绑定问题
            Console.WriteLine(bindingList.AllowNew);
            Console.WriteLine(bindingList.AllowEdit);
            Console.WriteLine(bindingList.AllowRemove);
            bindingList.AllowNew = true;
            // Bind BindingList directly to the DataGrid, no need of BindingSource
            this.dataGridView.DataSource = bindingList;
        }
        // 由于使用BindingList进行了数据绑定,因此对editableLines的修改,和对DataGridView.DataSource的修改,都会双向影响.
        // 因此保存时,不需要获取dataGridView.DataSource进行处理了.只需要处理被绑定的list即可.
        private void btnSave_Click(object sender, EventArgs e)
        {
            //BindingList<LineInfo> dataSource = (BindingList<LineInfo>)dataGridView.DataSource;

            List<LineInfo> editedlineInfos = this.bindingList.ToList();

            // 使用editableLines更新存放原始host文件内容的lines.
            // 将lines逐行写入hosts文件.
            foreach (var sourceLine in this.lines)
            {
                LineInfo foundLine = editedlineInfos.Find(item => item.LineNumber == sourceLine.LineNumber);
                if (foundLine != null && !string.IsNullOrWhiteSpace(foundLine.Ip) && !string.IsNullOrWhiteSpace(foundLine.Host))
                {
                    sourceLine.Ip = foundLine.Ip;
                    sourceLine.Host = foundLine.Host;
                    sourceLine.OriginContent = foundLine.Ip + "\u0020" + foundLine.Host;
                }
            }
            // 清除无效数据.
            //List<LineInfo> finalLines = this.lines.Where(line =>
            //{
            //    var result = !string.IsNullOrWhiteSpace(line.Ip)
            //    && !string.IsNullOrWhiteSpace(line.Host)
            //     && !string.IsNullOrWhiteSpace(line.OriginContent);
            //    return result;
            //}).ToList();
            //finalLines.ForEach(line => Console.WriteLine(line));

            // 指定写入时覆盖.
            StreamWriter streamWriter = new StreamWriter(HOST_PATH, false, Encoding.UTF8);
            this.lines.ForEach(line => streamWriter.WriteLine(line.OriginContent));
            streamWriter.Flush();
            streamWriter.Close();
        }
    }
}
