using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White; 

            DirectoryInfo di = new DirectoryInfo(@"C:\MinGW\libexec\gcc\mingw32\5.3.0");

            DirectoryInfo[] dirs = di.GetDirectories();

            foreach (DirectoryInfo d in dirs)
            {
                Console.WriteLine(d.Name);
            }

            Console.ForegroundColor = ConsoleColor.Yellow;

            FileInfo[] files = di.GetFiles();

            foreach (FileInfo f in files)
            {
                Console.WriteLine(f.Name);
            }

        }
    }
}
