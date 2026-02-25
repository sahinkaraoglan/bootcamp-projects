using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders1
{
    public class Matematikselislemler
    {

       public int sayi1;
       private int sayi2;      //yapılan işlemler birer soyutlama örneğidir.
       private int sayi3;

        public Matematikselislemler()
        {
            sayi1 = 0;
            sayi2 = 0;
            sayi3 = -5;
        }

        #region getsetmetotları

        public int getsayi1()
        {
            return sayi1;
        }
        public int getsayi2()
        {
            return sayi2;
        }
        public int getsayi3()
        {
            return sayi3;
        }
        public void setsayi1(int a)
        {
            if (a <= 0) sayi1 = Math.Abs(a);
            else sayi1 = a;

        }
        public void setsayi2(int a)
        {
            if (a <= 0) sayi2 = Math.Abs(a);
            else sayi2 = a;

        }
        public void setsayi3(int a)
        {
            if (a <= 0) sayi3 = Math.Abs(a);
            else sayi3 = a;

        }
        #endregion
        public int Toplam()
        {
            return sayi1 + sayi2 + sayi3;
        }
        public int Carpma()
        {
            return sayi1 + sayi2 + sayi3;
        }

        public int Goster()
        {
            return sayi1 + sayi2 + sayi3;
        }

        public Matematikselislemler(int a,int b,int c)
        {
            setsayi1(a);
            setsayi2(b);
            setsayi3(c);
        }
       ~Matematikselislemler()
        {
            Console.WriteLine("nesne ölüyor.");
        }
        public void swap(ref int sayi1,ref int sayi2)
        {
            int temp = sayi1;
            sayi1 = sayi2;
            sayi2 = temp;


        }
    }
    //nsneler referans tipindedir.

    class Program   //sınıfların varsayılan erişim belirteci "internaldir".          
    {
        static void Main(string[] args)
        {
            Matematikselislemler m1 = new Matematikselislemler();
            //DEFAULT CONSTRUCTOR

            m1.setsayi1(10);
            m1.setsayi2(-20);
            m1.setsayi3(30);
            m1.Goster();

            Console.WriteLine(m1.getsayi3());


            m1.Toplam();
            m1.Carpma();
            Console.WriteLine(m1.Toplam());
            Console.WriteLine(m1.Carpma());

            Matematikselislemler m2 = new Matematikselislemler();
            m2.Goster();

            Matematikselislemler m3 = new Matematikselislemler();
            m3.Goster();
            //GC.Collect();

            int a = 10;
            int b = 20;
            m3.swap(ref a, ref b);

            Console.WriteLine("sayi1={0},sayi2={1}", a, b);

            Console.Read();


        }
    }
}
