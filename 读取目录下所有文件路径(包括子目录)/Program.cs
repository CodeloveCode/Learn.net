using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace io_directory_manitulate
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = @"C:\Users\mudking\Pictures";
            List<string> paths = FileUtils.getFilesInDirectory(s);
            foreach (var item in paths)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
