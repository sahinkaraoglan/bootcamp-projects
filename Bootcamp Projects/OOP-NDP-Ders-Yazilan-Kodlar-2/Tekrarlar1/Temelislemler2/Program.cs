using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Temelislemler2
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo newfile = new FileInfo(@"C:\Test\HedefDizini\newfile.txt");
            if(newfile.Exists)
            {
                newfile.Delete();
            }

            newfile.CreateText();
            Console.WriteLine("olusturulma tarihi: "+newfile.CreationTime);
            Console.WriteLine("son erisim tarihi.  "+newfile.LastAccessTime);
            Console.WriteLine("dosyanın adı: "+newfile.Name);
            Console.WriteLine("dosyanın tam adı: "+newfile.FullName);
            Console.WriteLine("dosyanın uzantısı: "+newfile.Extension);
            newfile.CopyTo(@"C: \test");
            Console.ReadLine();

        }
    }
}
