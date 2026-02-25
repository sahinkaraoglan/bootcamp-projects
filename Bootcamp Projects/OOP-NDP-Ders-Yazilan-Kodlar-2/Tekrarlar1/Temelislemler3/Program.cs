using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Temelislemler3
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\test\testdizini";
            string target = @"C:\test\hedefdizini";

            if (!Directory.Exists(path))      //exists static metodu ile dizinin var olup olmadığını konrolü yapılıyor.
            {
                Directory.CreateDirectory(path);
                Console.WriteLine("oluşturulma tarihi: " + Directory.GetCreationTime(path));
                Console.WriteLine("son erişim tarihi: " + Directory.GetLastAccessTime(path));
                Console.WriteLine("son değiştirilme tarihi: " + Directory.GetLastWriteTime(path));
                Console.WriteLine("bulunduğu dizinin adı: " + Directory.GetParent(path));
                Console.ReadLine();

            }
            if (Directory.Exists(target))
            {
                Directory.Delete(target, true);
            }
            Directory.Move(path, target);                     //move taşıma işlemi yapar.
            string[] directories = Directory.GetDirectories(@"C:\test\");      //getdirectories dizindeki klasör seçimini 
            foreach (string dir in directories)
            {
                Console.WriteLine(dir);
            }
            File.CreateText(target + @"\newfile.txt");
            Console.WriteLine("{0} dizindeki dosya sayısı: {1}", target, Directory.GetFiles(target).Length);    //getfiles dizindeki dosyların seçimi.
            Console.ReadLine();
        }
    }
}
