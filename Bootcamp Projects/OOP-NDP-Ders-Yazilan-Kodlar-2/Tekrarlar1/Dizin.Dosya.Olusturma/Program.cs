using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Temelislemler

{
    class Program
    {
        static void Main(string[] args)
        {
            //DİZİN(DİRECTORYINFO)
            DirectoryInfo newdir = new DirectoryInfo(@"C:\Test\TestDizini");
            if(newdir.Exists)
            {
                Console.WriteLine("dizin mevcut.");
                newdir.Delete();
                Console.WriteLine("dizin silindi.");
            }
            newdir.Create();                                                 //dizin oluşturulma.
            Console.WriteLine("klasör oluşturuldu");
            Console.WriteLine("oluşturulma tarihi:"+newdir.CreationTime);
            Console.WriteLine("dizinin adı: "+newdir.Name);
            Console.WriteLine("son erişim tarihi: "+newdir.LastAccessTime);
            Console.WriteLine("dizinin tam adı: " + newdir.FullName);
            Console.ReadLine();


            DirectoryInfo subdir = new DirectoryInfo("alt dizin");           //dizinin içerisinde bir alt dizin oluşturuldu.
            subdir.CreateSubdirectory("alt dizin2");                         //alt dizin içerinde alt dizin oluşturma.
            Console.WriteLine("{0} dizindeki klasör sayısı: {1}",newdir.FullName,newdir.GetDirectories().Length);
            Console.ReadLine();

        }
    }
}
