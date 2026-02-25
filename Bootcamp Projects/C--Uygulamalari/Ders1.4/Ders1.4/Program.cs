using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ders1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //DirectoryInfo newdir = new DirectoryInfo(@"C:\test2\testdizini");
            //if (newdir.Exists)
            //{                                                                //dizin oluşturma.
            //    Console.WriteLine("dizin zaten var");
            //    newdir.Delete();
            //    Console.WriteLine(("dizin silindi"));
            //}
            //newdir.Create();




            FileInfo Newfile = new FileInfo(@"C:\test2\testdizini\NewFile.txt");  //dosya oluşturma.
            if(Newfile.Exists)
            {
                Console.WriteLine("dosya zaten var.");
                Newfile.Delete();
                Console.WriteLine("dosya silindi");
            }
            Newfile.Create();
            Console.WriteLine("---------------------");
            Console.WriteLine(Newfile.CreationTime);


            Console.ReadLine();
        }
    }
}
