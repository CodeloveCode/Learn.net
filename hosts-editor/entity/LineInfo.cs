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
    public class LineInfo
    {
        public int LineNumber { get; set; }
        public string OriginContent { get; set; }
        public string Ip { get; set; }
        // 这个自动属性相当于:
        //  public string host;
        // public string Host { get => host; set => host = value; }
        public string Host { get; set; }

        public LineInfo(int lineNumber, string originContent, string ip, string host)
        {
            LineNumber = lineNumber;
            OriginContent = originContent;
            Ip = ip;
            Host = host;
        }

        public LineInfo(int lineNumber, string originContent)
        {
            LineNumber = lineNumber;
            OriginContent = originContent;
        }
        /// <summary>
        /// 为DataGridView自动创建新行,提供一个空构造函数.
        /// </summary>
        public LineInfo()
        {
        }

        public override string ToString()
        {
            return $"lineNO:{LineNumber},ip:{Ip},host:{Host},originContent:{OriginContent}";
        }
    }
}
