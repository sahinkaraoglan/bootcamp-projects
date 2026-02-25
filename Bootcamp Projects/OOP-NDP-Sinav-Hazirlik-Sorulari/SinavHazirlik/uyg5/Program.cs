using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uyg5
{
    //ANOMİM METORLAR
    delegate void NumberChanger(int n);   //1. aşama declaration-tanımlama.
    class TestDelegate
    {
        static int num = 10;
        public static void SayiEkle(int n)
        {
            num += n;
            Console.WriteLine("isimli sayiekle metodu num degeri: "+num);
        }
        public static void SayiCarp(int n)
        {
            num *= n;
            Console.WriteLine("isimli sayicarp metodu num degeri: "+ num);
        }
        public static int getsayi()
        {
            return num;
        }
        static void Main(string[] args)
        {
            NumberChanger nc = delegate (int x)
             {
                 Console.WriteLine("anomim metodum x degeri: " + x);
             };
            nc(10);
            nc = new NumberChanger(SayiEkle);
            nc(5);
            nc = new NumberChanger(SayiCarp);
            nc(10);
        }
    }
}
