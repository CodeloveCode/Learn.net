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
        private List<LineInfo> lines;
        private List<LineInfo> editableLines;
        const string HOST_PATH = @"C:\Windows\System32\drivers\etc\hosts";

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
        }
        //void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        //{

        //}

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
            editableLines = lines.FindAll(x => !string.IsNullOrEmpty(x.OriginContent) && !x.OriginContent.StartsWith("#"));

            Regex regex = new Regex(@"\s");
            foreach (LineInfo lineInfo in editableLines)
            {
                string[] strs = regex.Split(lineInfo.OriginContent);
                lineInfo.Ip = strs[0];
                lineInfo.Host = strs[1];
            }

            // 为dataGridView设置数据源
            BindingList<LineInfo> bindingList = new BindingList<LineInfo>(editableLines);// BindingList可自动解决许多数据绑定问题
            // Bind BindingList directly to the DataGrid, no need of BindingSource
            this.dataGridView.DataSource = bindingList;
        }
        // 由于使用BindingList进行了数据绑定,因此对editableLines的修改,和对DataGridView.DataSource的修改,都会双向影响.
        // 因此保存时,不需要获取dataGridView.DataSource进行处理了.只需要处理被绑定的list即可.
        private void btnSave_Click(object sender, EventArgs e)
        {
            //BindingList<LineInfo> dataSource = (BindingList<LineInfo>)dataGridView.DataSource;

            // 使用editableLines更新存放原始host文件内容的lines.
            // 将lines逐行写入hosts文件.
            foreach (var line in this.lines)
            {
                LineInfo lineInfo = this.editableLines.Find(item => item.LineNumber == line.LineNumber);
                if (lineInfo != null)
                {
                    line.OriginContent = lineInfo.Ip + "\u0020" + lineInfo.Host;
                }
            }
            //this.lines.ForEach(line => Console.WriteLine(line));

            //FileStream fileStream = new FileStream(@"C:\Windows\System32\drivers\etc\hosts", FileMode.Open, FileAccess.Write, FileShare.Write);
            // 指定写入时覆盖.
            StreamWriter streamWriter = new StreamWriter(HOST_PATH, false, Encoding.UTF8);
            this.lines.ForEach(line => streamWriter.WriteLine(line.OriginContent));
            streamWriter.Flush();
            streamWriter.Close();
        }
    }
}
