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

namespace hosts_editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            InitForm();
        }

        private void InitForm()
        {
            // C:\Windows\System32\drivers\etc\hosts维护了ip地址与主机名的映射,这份文件被windows的tcp/ip服务使用
            FileStream fileStream = new FileStream(@"C:\Windows\System32\drivers\etc\hosts", FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamReader sr = new StreamReader(fileStream);
            List<LineInfo> lines = new List<LineInfo>();
            string line;
            int lineIndex = 0;
            while ((line = sr.ReadLine()) != null)
            {
                lines.Add(new LineInfo(lineIndex, line));
                lineIndex++;
            }

            List<LineInfo> editableLines = new List<LineInfo>();

            editableLines = lines.FindAll(x => !string.IsNullOrEmpty(x.Content) && !x.Content.StartsWith("#"));

            for (int i = 0; i < editableLines.Count; i++)
            {
                this.listBox.Items.Add(editableLines[i].Content);
            }
        }

    }
}
