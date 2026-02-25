using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiselOperatorTanımlama
{
    public class karmasiksayi
    {
        private int x;
        private int y;
        public karmasiksayi()
        {
            x = 0;
            y = 0;
        }
        public karmasiksayi(int m,int n)
        {
            x = m;
            y = n;
        }
        public string yaz()
        {
            return x + "i" + "+" + y;
        }

        #region operatorlerimiz
        //tekli operatorler.
        public static karmasiksayi operator-(karmasiksayi c)
        {
            karmasiksayi temp = new karmasiksayi();
            temp.x = -Math.Abs(c.x);
            temp.y = -Math.Abs(c.y);
            return temp;
        }
        public static karmasiksayi operator +(karmasiksayi c)
        {
            karmasiksayi temp = new karmasiksayi();
            temp.x = Math.Abs(c.x);
            temp.y = Math.Abs(c.y);
            return temp;
        }
        //ikili operatorlerimiz.
        public static karmasiksayi operator-(karmasiksayi c1,karmasiksayi c2)
        {
            karmasiksayi temp = new karmasiksayi();
            temp.x = c1.x - c2.x;
            temp.y = c1.y - c2.y;
            return temp;
        }
        public static karmasiksayi operator +(karmasiksayi c1, karmasiksayi c2)
        {
            karmasiksayi temp = new karmasiksayi();
            temp.x = c1.x + c2.x;
            temp.y = c1.y + c2.y;
            return temp;
        }
        #endregion

    }
    class Program
    {
        static void Main(string[] args)
        {
            karmasiksayi _ks1 = new karmasiksayi(-4, 6);
            karmasiksayi _ks2 = new karmasiksayi(2, -1);

            Console.WriteLine(_ks1.yaz());
            Console.WriteLine(_ks2.yaz());


            karmasiksayi _ks3 = -_ks1;
            Console.WriteLine(_ks3.yaz());

            karmasiksayi _ks4 = +_ks2;
            Console.WriteLine(_ks4.yaz());

            karmasiksayi _ks5 = _ks1 + _ks2;
            karmasiksayi _ks6 = -_ks3 - _ks4;
            Console.WriteLine(_ks5.yaz());
            Console.WriteLine(_ks6.yaz());
        }
    }
}
