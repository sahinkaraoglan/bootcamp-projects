using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders24_11_21
{
    public class BinekArac: Arac
    {
        private int koltuksayisi;

        public BinekArac(string mr,string md,int uy,int sonhiz,int hiz,int ks):base(mr,md,uy,sonhiz,hiz)
        {
            koltuksayisi = ks;
        }

    }
    public class Arac
    {
        string marka;
        string model;
        int yil;
        int sonhiz;
        int hiz;

        public Arac(string mrk,string mdl, int yl,int sh, int h)
        {
            marka = mrk;
            model = mdl;
            yil = yl;
            Sonhiz = sh;
            Hiz = h;

        }
        public int Sonhiz
        {
            get
            {
                return sonhiz;
            }
            set
            {
                if (value <= 0) sonhiz = 0;

                else
                sonhiz = value;
            }


        }
        public int Hiz
        {
            get
            {
                return hiz;
            }
            set
            {

            }
        }
        public void Hizlan(int a)
        {
            hiz += a;
        }
        public void Yavasla(int a)
        {
            hiz -= a;
        }

        public string Goster()
        {
            return string.Format("marka={0}\n model={1}\n yil={2}\n sonhiz={3}\n hiz= {4}", marka, model, yil, sonhiz, hiz);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Arac a1 = new Arac("BMW", "760", 2021, 288, -30);
            Console.WriteLine(a1.Goster());
            Console.WriteLine("-------------------------------");

            a1.Hizlan(50);

            BinekArac binek1 = new BinekArac("BMW", "760", 2021, 288, 30, 5);
            binek1.Goster();
            Console.ReadKey();
        }
    }
}
