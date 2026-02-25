using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finaltekrar
{
    public class Raporla
    {
        public string ogrenciad;
        public int vize;
        public int final;
        public char harfnot;
        public int nothesapla;
        public Raporla(string _ogrenciadi,int _vize,int _final)
        {
            ogrenciad = _ogrenciadi;
            vize = _vize;
            final = _final;
            nothesapla = (vize * (40 / 100)) + (final * (60 / 100));
        }
        public int hesapla()
        {
            try
            {
                if(vize<=0||final>=100)
                {
                    throw (new AggregateException("sınav aralığının dışında not girilmiştir."));
                }
                else if(nothesapla>90||nothesapla<=100)
                {
                    harfnot = 'A';
                }
                if(nothesapla>80||nothesapla<=90)
                {
                    harfnot = 'B';
                }
                if (nothesapla > 70 || nothesapla <= 80)
                {
                    harfnot = 'C';
                }
                 if (nothesapla > 60 || nothesapla <= 70)
                {
                    harfnot = 'D';
                }
                 if(nothesapla<60)
                {
                    harfnot = 'F';
                }
                else
                {
                    return nothesapla;
                }
            }
            catch(AggregateException ae)
            {
                Console.WriteLine("kullanıcı hatalı aralıkta değer girdi", ae.ToString());
            }
            return 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Raporla r1 = new Raporla("sahin", 70, 80);
            Console.WriteLine("Not" + r1.hesapla());
        }
    }
}
