using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayListe
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arlist = new ArrayList();
            arlist.Add(5);
            arlist.Add(32);
            arlist.Add(62);
            arlist.Add(28);

            foreach (var item in arlist)
                Console.WriteLine(item);

            Console.WriteLine("**************************");

            int toplam = 0;
            for(int i=0;i<arlist.Count;i++)
            {
                toplam += (int)arlist[i];
            }
            Console.WriteLine(toplam);



            Console.ReadLine();

        }
    }
}
