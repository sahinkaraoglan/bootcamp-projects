using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] dizi = { { 2, 4, 2 }, { 7, 10, 4 }, { 7, 12, 6 }, { 2, 1, 12 } };
            int a = dizi.GetLength(1);
            Console.WriteLine(a);
        }
    }
}
