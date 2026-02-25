using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler1
{
    class Program
    {
        static void Main(string[] args)
        {
            //DİZİ TANIMLAMA.
            int[] dizi = new int[5];
            double[] dizi1 = new double[] { 45, 62, 74, 38, 21, 16 };

            dizi[0] = 63;
            dizi[1] = 34;
            dizi[2] = 28;
            dizi[3] = 9;
            dizi[4] = 87;
            Console.WriteLine(dizi[2]);
            Console.WriteLine(dizi[0]);

            Console.WriteLine("*************************************");


            //FOREACH DÖNGÜSÜ İLE ELEMANLARI DOLAŞMA.
            foreach(double item in dizi1)
                Console.WriteLine(item);
            Console.WriteLine("***************************************");



            //DİZİNİN EN BÜYÜK ELEMANINI BULMA İŞLEMİ.
            double max = 0.0;
            for(int i=0;i<6;i++)
            {
                if (dizi1[i] > max)
                    max = dizi1[i];
            }
            Console.WriteLine("max = {0:F2}",max);
            Console.WriteLine("********************************");



            //DİZİNİN BOYUTUNU BULMA.
            string[] renkler = new string[] { "kırmızı", "yeşil", "mavi", "sarı", "turkuaz" };
            for (int i = 0; i < renkler.Length; i++)
                Console.WriteLine(renkler[i]);
            Console.WriteLine("*********************************");


            //ARRAYDE EN ÇOK KULLANILAN METOTLAR.
            int[] sayi = { 14, 28, 39, 46, 79, 84, 65, 43, 79, 99, 256, 784 };

            Console.Write("dizinin önceki hali\t:");
            for (int i = 0; i < sayi.Length; i++)      //CLEAR METODU
                Console.WriteLine(sayi[i] + " - ");

            Array.Clear(sayi,2, 5);
            Console.Write("dizinin sonraki hali \t: ");
            for (int i = 0; i < sayi.Length; i++)
                Console.WriteLine(sayi[i] + " - ");
            Console.WriteLine("***************************************************");




            int[] sayi1 = { 14, 28, 39, 46, 79, 84, 65, 43, 79, 99, 256, 784 };
            Console.Write("dizinin önceki hali\t: ");
            for(int i=0;i<sayi1.Length;i++)
                Console.WriteLine(sayi1[i]+" - ");   //REVERSE METODU
            Array.Reverse(sayi1);
            Console.Write("dizinin çevrilmiş hali\t: ");
            for (int i = 0; i < sayi1.Length; i++)
                Console.WriteLine(sayi1[i] + " - ");

            Console.WriteLine("*******************************************************");



            int[] sayi2 = { 14, 28, 39, 46, 79, 84, 65, 43, 79, 99, 256, 784 };

            Console.Write("dizinin önceki hali\t:");
            for (int i = 0; i < sayi2.Length; i++)      //SORT METODU
                Console.WriteLine(sayi2[i] + " - ");

            Array.Sort(sayi2);
            Console.Write("dizinin sonraki hali \t: ");
            for (int i = 0; i < sayi2.Length; i++)
                Console.WriteLine(sayi2[i] + " - ");
            Console.WriteLine("***************************************************");








            Console.ReadKey();
        }
    }
}
