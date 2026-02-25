using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uyg4
{
    class Program
    {
        static void Main(string[] args)
        {
            Cars araclar = new Cars();
            foreach(Car item in araclar)
            {
                Console.WriteLine("arac markası = {0}, arac yılı= {1}", item.Uretici, item.Yil);            }
        }
    }
}
