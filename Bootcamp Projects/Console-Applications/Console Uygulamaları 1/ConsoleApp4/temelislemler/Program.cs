using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace temelislemler
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader01 = new StreamReader("file.txt");
            string line = reader01.ReadLine();
            reader01.Close();
            reader01.Dispose();
            Console.WriteLine(line);
            Console.ReadLine();
        }
    }
}
