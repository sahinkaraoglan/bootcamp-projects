using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uyg_1
{
    class Program
    {
        static unsafe void Main(string[] args)
        {
            int var = 20;
            int* p = &var;
            Console.WriteLine("var içeriği: " + var);
            Console.WriteLine("var değişkeni adresi: " + (int)p);
            Console.WriteLine("var değişkenine pointer üzerinden ulaşalım" + p->ToString());
            ++*p;
            Console.WriteLine("var içeriği: " + var);
            ++p;
            Console.WriteLine("var değişkeni adresi: " + (int)p);
            Console.WriteLine("-----------------------------------");

            int[] list = { 10, 20, 30 };
            fixed (int* ptr = list)
                for (int i = 0; i < 3; i++)
                {
                   // ptr++;  //artırmaz çünkü fixed olduğu için.
                    Console.WriteLine("adres değeri: " + (int)ptr);
                    Console.WriteLine("dizi içeriği: " + (*(ptr+i)));
                }
            //fixed lendiği için üçününde adres değeri aynı olarak kalır.
        }
    }
}
