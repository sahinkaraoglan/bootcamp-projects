using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Ders_Tekrarı
{
    class Program
    {
        static void Main(string[] args)
        {
            //LİSTELER
            List<int> liste = new List<int>(10);
            liste.Add(20);
            liste.Add(17);
            liste.Add(38);
            Console.WriteLine(liste);
            liste.AddRange(new int[]{ 41,39,78,540,267});  //addrange aynı anda birden fazla eleman eklemede kullanılır.

            for(int i=0;i<liste.Count;i++)    //count dizinin anlık elemnanlarını verir.
                Console.WriteLine(liste[i]);
            Console.WriteLine("*****************************************************");





            //ARRAYLER
            ArrayList list = new ArrayList(); //yeni bir nesne oluşturduk.çünkü arraylist bir sınıftır.
            list.Add(41);
            list.Add(24);
            list.Add(37);
            list.Add("şahin");
            foreach(var item in list)
                Console.WriteLine(item);
            Console.WriteLine("**********************************");




            ArrayList arlist = new ArrayList();
            arlist.AddRange(new[] { 42, 85, 34, 11, 6, 96, 784, 214, 98, 115 });
            for(int i=0;i<arlist.Count;i++)
                Console.WriteLine(arlist[i]);
            Console.WriteLine("*******************************************");

            //listedeki elemanları toplama
            int toplam = 0;
            foreach (int item in arlist)
                toplam += item;
            Console.WriteLine(toplam);

            Console.ReadLine();

        }
    }
}
