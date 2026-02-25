using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uyg4
{
    class Program
    {
        public delegate void MyDelegate(int deger1, int deger2);
        public void toplam(int s1,int s2)
        {
            Console.WriteLine("toplam metodu sonucu: {0}",s1+s2);
        }
        public void carpma(int s1, int s2)
        {
            Console.WriteLine("carpma metodu sonucu: {0}", s1 *s2);
        }
        public void bolme(int s1, int s2)
        {
            Console.WriteLine("bolme metodu sonucu: {0}", s1 / s2);
        }

        static void Main(string[] args)
        {
            new Program();
        }
        public Program()
        {
            MyDelegate delege = null;
            delege += new MyDelegate(toplam);
            delege += new MyDelegate(carpma);
            delege += new MyDelegate(bolme);
            delege.Invoke(18, 3);
            delege(24, 8);
            Console.WriteLine("----------------------------");
            delege -= new MyDelegate(bolme); //bolme metodu silinmiş oldu.
            delege(24, 8);
        }
    }
}
