using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DersTekrarı
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] dizi = new int[4];
            //dizi[0] = 12;
            //dizi[1] = 75;
            //dizi[2] = 38;
            //dizi[3] = 24;

            //Console.WriteLine(dizi[2]);

            //Console.WriteLine("********************************************");


            //double[] a = new double[5];
            //Console.WriteLine("5 tane sayı giriniz: ");
            //for(int i=0;i<5;i++)
            //{
            //    double.TryParse(Console.ReadLine(), out a[i]);
            //}



            ////DİZİNİN EN BÜYÜK ELEMANINI BULMA
            //double[] a = new double[5] { 4.6, 7.3, 5.8, 6.4, 9.1 };

            //double max = 0.0;
            //for (int  i = 0; i < 5; i++)
            //{
            //    if (a[i] > max)
            //        max = a[i];

            //}
            //Console.WriteLine("max={0:F2}", max);
            //Console.ReadLine();




            ////FOREACH DÖNGÜSÜ
            //string[] kalem = new string[6] { "beyaz", "kırmızı", "yeşil", "turuncu", "mavi", "sarı" };
            //foreach (string item in kalem)
            //{
            //    Console.WriteLine(item);
            //}



            //int[] dizi1 = new int[4] { 56, 74, 24, 15 };
            //for(int i=0;i<dizi1.Length;i++)
            //{
            //    Console.WriteLine(dizi1[i]);
            //}





            //KLAVYEDEN GİRİLEN BİR DEĞERİ DİZİYE ATAMA


            double[] a = new double[5];
            Console.WriteLine("5 tane dizi elemanı giriniz.");
            for (int i = 0; i < 5; i++)    //dizi elemanları okuma işlemi yapılıyor.
                double.TryParse(Console.ReadLine(), out a[i]);

            for (int i = 0; i < 5; i++) //dizinin elemanlarını göster.
                Console.WriteLine("a[{0}]={1:F2}", i, a[i]);


            double max = 0.0;  //dizinin en büyük elemanını bulma işlemi.
            for (int i = 0; i < 5; i++)
            {
                if (a[i] > max)
                    max = a[i];
            }
            Console.WriteLine("max={0:F2}",max);









            Console.ReadKey();
        }
    }
}
