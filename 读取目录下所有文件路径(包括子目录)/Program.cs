using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace 读取目录下所有文件路径_包括子目录_
{
    class Program
    {
        static void Main(string[] args)
        {
            string s =@"C:\Users\mudking\Pictures";
            List<string> paths = Pat添加当前目录下所有文件路径_包括子目录的_.Path添加当前目录下所有文件路径(s);  
           foreach (var item in paths)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
