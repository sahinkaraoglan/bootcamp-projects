using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Attrb
{
    public class Matematik
    {
        [Obsolete("metot eski bir metot lütfen yenisisni kullanın.",false)]
        public int Topla()
        {
            return 0;
        }
        public int Topla2(int a,int b)
        {
            return a + b;
        }
        public int Topla3(params int [] a)
        {
            int toplam = 0;
            foreach (int item in a)
                toplam += item;
            return toplam;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Matematik matematiknesne = new Matematik();
            Console.WriteLine(matematiknesne.Topla());
        }
    }
}
