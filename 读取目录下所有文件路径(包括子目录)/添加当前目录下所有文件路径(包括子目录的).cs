using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace io_directory_manitulate
{
    /// <summary>
    /// 获取给定目录的文件路径,包括子目录
    /// </summary>
    public static class FileUtils
    {
        public static List<string> getFilesInDirectory(string dir)
        {

            //声明一个string类型泛型集合,用来存储文件路径
            List<String> path目录下所有文件 = new List<string>();
            //声明一个字符串数组来 存储目录下 所有子目录路径信息
            string[] path子目录 = Directory.GetDirectories(dir);
            //将当前目录下文件添加到集合里
            path目录下所有文件.AddRange(Directory.GetFiles(dir));
            //遍历子目录,将子目录下所有文件路径 也添加到 path目录下所有文件 集合里
            foreach (string path in path子目录)
            {
                path目录下所有文件.AddRange(Directory.GetFiles(path));
            }

            //end 当前目录及其子目录 文件路径 添加完成

            return path目录下所有文件;
        }
    }
}
