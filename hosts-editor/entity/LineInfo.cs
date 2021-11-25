using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hosts_editor.entity
{
    /// <summary>
    /// 存放从文本文件读取到的每行的行号和内容.
    /// </summary>
    internal class LineInfo
    {
        int lineNumber;
        string content;

        public int LineNumber { get => lineNumber; set => lineNumber = value; }
        public string Content { get => content; set => content = value; }

        public LineInfo(int lineNumber, string content)
        {
            this.lineNumber = lineNumber;
            this.content = content;
        }
    }
}
