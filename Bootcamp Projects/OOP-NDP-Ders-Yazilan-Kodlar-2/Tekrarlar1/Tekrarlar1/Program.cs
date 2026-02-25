using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tekrarlar1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[] {21,14,49,67,28,33,71,64,98,128,346,587,471};
            foreach (int item in dizi)  //dizinin elemanlarını göstermek için foreach kullanılır.
                Console.WriteLine(item);
            Console.WriteLine("******************************");


            for(int i=0;i<dizi.Length;i++)
                Console.WriteLine(dizi[i]);





            Console.WriteLine("*******************************");





            for (int i = 0; i < 13; i++)    //burda da for döngüsü ile dizi elemanlarını göstermiş olduk.
                Console.WriteLine(dizi[i]);

            Console.WriteLine("********************************");





            //DİZİNİN ELEMANLARINI EKRANA YAZDIRMA
            double[] dizi1 = new double[] { 1.6, 8.4, 9.1, 2.7, 5.9, 3.3, };
            for(int i=0;i<6;i++)
                Console.WriteLine("a[{0}]={1:F2}",i,dizi1[i]);

            Console.WriteLine("*********************************");





            //DİZİNİN İÇİNDEKİ MAX ELEMANI BULMA.
            int max = 0;
            for (int i = 0; i < 13; i++)
                if (dizi[i] > max)
                    max = dizi[i];
            Console.WriteLine("max={0:F2}",max);

            Console.WriteLine("*********************************");




            ////KLAVYEDEN GİRİLEN DEĞERİ DİZİYE ATAMAK.
            //double[] a = new double[5];
            //Console.WriteLine("5 tane sayı giriniz: ");
            //for (int i = 0; i < 5; i++)    //DİZİNİN ELEMANLARINI OKU.
            //    double.TryParse(Console.ReadLine(), out a[i]);
            //for(int i=0;i<5;i++)   //DİZİNİN ELEMANLARINI GÖSTER.
            //    Console.WriteLine("a[{0}]={1:F2}",i,a[i]);

            //double maxx = 0.0;      //DİZİDEKİ MAX DEĞERİ BULMAK İÇİN YAZDIK.
            //for(int i=0;i<5;i++)
            //{
            //    if (a[i] > maxx)
            //        maxx = a[i];

            //}
            //Console.WriteLine("maxx={0:F2}",maxx);




            Console.WriteLine("********************************");




            //ARRAY SINIFI: DİZİ OLUŞTURMA,DEĞİŞTİRME,SIRALAMA,KOPYALAMA, ARAMA GİBİ DİZİ İŞLEMLERİNİ BARINDIRAN BİR SINIFTIR.
            int[] dizi3 = new int[] { 45, 85, 94, 76, 24, 23, 33, 41, 14, };
            Console.Write("dizinin önceki hali: ");
            for(int i=0;i<dizi3.Length;i++)
                Console.Write(dizi3[i]+" - ");

            Console.WriteLine("\n");

            //Array.Clear(dizi3,2,3);                          //dizide silme işlemi yapar.
            //Console.Write("dizinin yeni hali: ");
            //for (int i = 0; i < dizi3.Length; i++)
            //    Console.Write(dizi3[i] + " - ");  



            //Array.Reverse(dizi3);                            //dizide ters çevirme işlemi yapar.
            //Console.Write("dizinin şimdiki hali: ");
            //for (int i = 0; i < dizi3.Length; i++)
            //    Console.Write(dizi3[i] + " - ");


            Array.Sort(dizi3);                                //alfabetik yada kücükten büyüğe sıralama işlemi yapar.
            Console.Write("dizinin yeni hali: ");
            for (int i = 0; i < dizi3.Length; i++)
            Console.Write(dizi3[i] + " - "); 




            Console.ReadLine();
        }
    }
}
