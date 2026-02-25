using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ListelerOrnekler
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> liste1 = new List<int>(new int[] { 62, 74, 16, 25, 98, 117, 87, 58 });
            //indexof ile index numarasını öğrenmek.
            int index = liste1.IndexOf(98);
            int index1 = liste1.IndexOf(22);   //istenilen değer elemanlar arasında yoksa -1 değeri döndürülür.
            Console.WriteLine(index1);
            Console.WriteLine(index);
            Console.WriteLine("*********************************************************");


            liste1.Sort();  //küçükten büyüğe doğru sıralama yapar.
            foreach(int item in liste1)
                Console.WriteLine(item);

            Console.WriteLine("***********************************************");


            List<string> sehirler = new List<string>(new string[] { "kayseri", "antalya", "bursa", "ankara", "zonguldak", "çanakkale", "rize", "gaziantep", "şanlıurfa" });

            //listede bir elemanın olup olmadığına bakmak için 'contains'kullanılmalıdır.
            if (sehirler.Contains("kayseri") == true)
            {
                Console.WriteLine("kayseri zaten eklenmiş");
            }
            else
            {
                sehirler.Add("kayseri");
            }

            int index2 = sehirler.IndexOf("rize");  //baştan başlar saymaya
            Console.WriteLine(index2);

            int index3 = sehirler.LastIndexOf("antalya");  //sondan başalar sayma 
            Console.WriteLine(index3);

            sehirler.Insert(3, "mersin"); //belirlenen indekten sınra araya eleman sokmaya yarar.
            sehirler.Remove("ankara");

            sehirler.Sort();  //alfabetik sırama ilşemi yapar.
            foreach(string item in sehirler)
                Console.WriteLine(item);
            Console.WriteLine("*****************************************************");





            Console.ReadLine();
        }
    }
}
