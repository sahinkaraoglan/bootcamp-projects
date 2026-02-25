using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listeler
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> liste = new List<int>(new int[] { 6, 15, 29, 36, 42, 57, 66, 72, 89, 94, 110, 254 });
            for(int i=0;i<liste.Count;i++)                      //liste ile eleman oluşturup count ile anlık elemanları gördük.
            Console.WriteLine(liste[i]);

            Console.WriteLine("****************************");

            liste.Add(55);                                      //add ile birer birer eleman ekledik.
            liste.Add(652);
            liste.Add(26);
            foreach(int item in liste)
                Console.WriteLine(item);

            Console.WriteLine("******************************");

            liste.AddRange(new int[] { 12, 41, 38, 50 });       //addrange ile birden fazla elemanı diziye aktardık.
            for(int i=0;i<liste.Count;i++)
                Console.WriteLine(liste[i]); 

            Console.WriteLine("*******************************");

            int[] dizi = new int[] { 36, 96, 81, 75 };           //dizi yaratıp diziyi listenin içine koyduk.
            liste.AddRange(dizi);
            foreach(int item in liste)
                Console.WriteLine(item);

            Console.WriteLine("*******************************");

            List<bool> a = new List<bool>();
            a.Add(true);                                         //liste oluşturup bool türünde elemanlar ekledik.
            a.Add(false);
            a.Add(false);
            Console.WriteLine(a.Count);
            foreach(bool item in a)
                Console.WriteLine(item);
            a.Clear();                                           //a listesindeki elemanları temizledik.
            Console.WriteLine(a.Count);

            Console.WriteLine("**************************************************************");

            List<string> sehirler = new List<string>();
            sehirler.AddRange(new string[] { "kayseri", "çankırı", "nevşehir", "zonguldak", "antalya", "bursa", "rize", "ankara" });

            sehirler.Sort();                                  //string olduğu için alfabetik bir sıralama yapar.
            foreach(string item in sehirler)
                Console.WriteLine(item);
            Console.WriteLine("*******************************************");
            sehirler.Reverse();                                //listeyi ters çevirir.
            for (int i = 0; i < sehirler.Count; i++)
                Console.WriteLine(sehirler[i]);
            Console.WriteLine("*************************************");

            sehirler.Remove("zonguldak");                      //remove dizide silme işlemi yapar.
            foreach (string item in sehirler)
                Console.WriteLine(item);


            Console.WriteLine("******************************************");

            int index =sehirler.IndexOf("antalya");           //dizideki varsa istenilen elemanın index numarasını verir.
            Console.WriteLine(index);

            Console.WriteLine("********************************************");


            if (sehirler.Contains("kayseri") == true)         //dizide bir elemanın olup olmadığına bakmak için kullanılır.
                Console.WriteLine("kayseri zaten eklenmiş.");
            else
                sehirler.Add("kayseri");


            if(sehirler.Contains("izmir")==true)
                Console.WriteLine("izmir zaten eklenmiş");
            else
                Console.WriteLine("izmir lisstede yok.");

            Console.WriteLine("*****************************");

            sehirler.Add("izmir");
            foreach (string item in sehirler)
                Console.WriteLine(item);




            Console.ReadLine();
        }
    }
}
