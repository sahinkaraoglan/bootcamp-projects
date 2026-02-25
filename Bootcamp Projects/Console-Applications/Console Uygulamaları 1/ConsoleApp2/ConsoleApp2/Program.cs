using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 78;
            //byte b = (byte)a;
            //Console.WriteLine(b);

            //byte x = (byte) 12.5f;
            //Console.WriteLine(x); 








            //object a = 'k';
            //Char b = (Char)a;
            //Console.WriteLine(b); ;








            //int x = 56;
            //string y = x.ToString();
            //Console.WriteLine(y);









            //string s1, s2;
            //int sayi1, sayi2;
            //int toplam;

            //Console.Write("birinci sayıyı girin: ");
            //s1 = Console.ReadLine();
            //Console.Write("ikinci sayıyı girin: ");
            //s2 = Console.ReadLine();

            //sayi1 = Convert.ToInt32(s1);
            //sayi2 = Convert.ToInt32(s2);
            //toplam = sayi1 + sayi2;

            //Console.Write("toplam: " + toplam);







            //int a = 5;
            //int i = a++;
            //int b = i--;
            //int c = 10;
            //int d = --c;
            //Console.Write("{0}\n{1}\n{2}\n{3}\n", a, i, b, d);









            //AS OPERATÖRÜ

            //object i = "50";     //object türündeki değişkeni string türüne dönüştürdü.
            //string s = i as string;
            //Console.WriteLine(s);



            //int o= 15;      //herhangi bir türdeki veriyi object türüne dönüşrürdü bu işlemler as operatötü sayesinde yapıldı.
            //object b = i as object;
            //Console.WriteLine(o);










            //for(int a=0;a<51;a++)
            //{
            //    if (a % 2 == 1)
            //        continue;
            //    Console.WriteLine(a);
            //}












            //int bs = 0, ks = 0, toplam = 0;
            //for(int a=0,b;a<10;a++)
            //{
            //    Console.Write(a + 1 + " . notu girdiniz");
            //    b = Convert.ToInt32(Console.ReadLine());
            //    if(b>100 || b<0)
            //    {
            //        Console.Write("yanlış not girdiniz lütfen tekrar giriniz.");
            //        a--;
            //        continue;
            //    }
            //    if(a==0)
            //    {
            //        bs = b;
            //        ks = b;
            //    }
            //    else
            //    {
            //        if (b > bs)
            //            bs = b;
            //        if(b<ks)
            //        {
            //            ks = b;
            //        }
            //    }
            //    toplam += b;
            //    Console.Write("en büyük: {0}\nenkücük: {1}\nortalama: " + toplam / 10, bs, ks);
            //}












            //int[] dizi = new int[10];
            //dizi[5] = 30;
            //dizi[6] = 96;
            //dizi[7] = 78;
            //dizi[3] = 30;
            //dizi[9] = 46;
            //dizi[0] = 52;
            //Console.WriteLine(dizi[7]);
            //Console.WriteLine(dizi[0]);











            //int[] kalem = { 78, 52, 14, 23, 32 };
            //foreach(int eleman in kalem)
            //    Console.WriteLine(eleman);





            int[] dizi = { 12, 74, 86, 23, 4, 34, 28, 56, 49 };

            Console.WriteLine(dizi[3]);
            Console.WriteLine(dizi[8]);
            Console.WriteLine(dizi[4]);


            Console.WriteLine("------------------------------------------------");

            ArrayList arlist = new ArrayList();

            arlist.Add(52);
            arlist.Add('k');
            arlist.Add(12.3);
            arlist.Add("şahin");


            foreach  (var item in arlist)
                Console.WriteLine(item);
            Console.WriteLine("********************************************");


            //LİSTELER

            List<int> liste = new List<int>(5);

            liste.Add(45);
            liste.Add(23);
            liste.Add(95);
            liste.Add(65);
            liste.Add(14);

            Console.WriteLine(liste[2]);
            Console.WriteLine(liste[4]);

            Console.WriteLine("**********************************************************");

            foreach(int item in liste)
                Console.WriteLine(item);

            liste.AddRange(new int[] { 18, 34, 43, 27 });
            Console.WriteLine(liste[6]);
            foreach (var item in liste)
                Console.WriteLine(item);








            Console.ReadLine();
        }
    }
}
