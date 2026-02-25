using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, sum;
            Console.WriteLine("bir sayi giriniz: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("bir sayi daha giriniz: ");
            n2 = int.Parse(Console.ReadLine());
            sum = n1 + n2;
            Console.WriteLine($"toplam {sum}");    //bu kullanımın adı interpolasyon dur.
            Console.ReadKey();
        }
    }
}
