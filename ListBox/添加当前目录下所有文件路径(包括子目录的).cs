using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace 读取目录下所有文件路径_包括子目录_
{
    public static class Pat添加当前目录下所有文件路径_包括子目录的_
    {
        public static List<string>   Path添加当前目录下所有文件路径(string path需要读取的目录)
        {

            //声明一个string类型泛型集合,用来存储文件路径
            List<String> path目录下所有文件 = new List<string>();
            //声明一个字符串数组来 存储目录下 所有子目录路径信息
            string[] path子目录 = Directory.GetDirectories(path需要读取的目录);
            //遍历子目录,将子目录下所有文件路径 添加到 path目录下所有文件 集合里
            foreach (string path in path子目录)
            {
                path目录下所有文件.AddRange(Directory.GetFiles(path));
            }
            //将当前目录下文件也添加到集合里
            path目录下所有文件.AddRange(Directory.GetFiles(path需要读取的目录));
            //end 当前目录及其子目录 文件路径 添加完成

            return path目录下所有文件;
        }
    }
}
