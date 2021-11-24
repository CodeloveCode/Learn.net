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
            String pictureFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            List<string> paths = FileUtils.getFilesInDirectory(pictureFolderPath);
            foreach (var item in paths)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
