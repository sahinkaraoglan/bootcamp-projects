using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uyg_2
{
    delegate void NumberChanger(int n);

    class TestDelegate
    {
        static int num = 10;
        public static void SayiEkle(int n)     //1. aşama çünkü delegenin imzasını taşıyor.
        {
            num += n;
            Console.WriteLine("isimli sayiekle metodu num degeri: "+num);

        }
        public static void SayiCarp(int n)          //1. aşama çünkü delegenin imzasını taşıyor.
        {
            num *= n;
            Console.WriteLine("isimli carp metodu çalıştı num: "+num);
        }
        public static int getSayi()
        {
            return num;
        }

        static void Main(string[] args)
        {
            //2. aşama örnekleme.

            NumberChanger nc = delegate (int x)
            {
                Console.WriteLine("anomim metot x değeri: "+ x);
            };
            nc(10);
            nc = new NumberChanger(SayiEkle);
            nc(5);
            nc = new NumberChanger(SayiCarp);
            nc(3); 
        }
    }
}
