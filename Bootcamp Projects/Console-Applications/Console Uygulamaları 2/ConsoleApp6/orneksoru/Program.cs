using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orneksoru
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;
            Console.WriteLine("bir sayi giriniz: ");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("bir sayi daha giriniz: ");
            number2 = int.Parse(Console.ReadLine());
            if (number1 == number2)
            {
                Console.WriteLine("eşittir...");

            }
            if(number1>=number2)
            {
                Console.WriteLine("birinci sayi büyük eşit...");

            }
            if(number1>number2)
            {
                Console.WriteLine("birinci sayi daha büyük");

            }
            if(number1<number2)
            {
                Console.WriteLine("sayi iki daha büyük");
            }
            Console.ReadKey();
        }

    }
}
