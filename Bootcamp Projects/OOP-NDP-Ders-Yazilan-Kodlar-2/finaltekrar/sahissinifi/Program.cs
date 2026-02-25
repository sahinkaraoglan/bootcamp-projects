using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sahissinifi
{
    public abstract class sahis
    {
        public string ad;
        public string soyad;
        public string cinsiyet;
        public abstract string BilgiGoster();

    }
    public class Ogretmen:sahis
    {
        public string ad;
        public string soyad;
        public string cinsiyet;
        public Ogretmen(string _ad, string _soyad, string _cins)
        {
            ad = _ad;
            soyad = _soyad;
            cinsiyet = _cins;
        }
        public override string BilgiGoster()
        {
            return "Adı: " + this.ad.ToString() + "\nSoyadı: " + this.soyad.ToString() + "\nCinsiyet: " + this.cinsiyet.ToString()+"\nBulunduğu sınıfın adı: "+this.ToString();
        }
    }
    public class Ogrenci: sahis
    {
        public string ad;
        public string soyad;
        public string cinsiyet;
        public Ogrenci(string _ad,string _soyad,string _cins)
        {
            ad = _ad;
            soyad = _soyad;
            cinsiyet = _cins;
        }
        public override string ToString()
        {
            return "Adı: " + this.ad.ToString() + "Soyadı: " + this.soyad.ToString() + "Cinsiyeti: " + this.cinsiyet.ToString() + "\nBulunduğu sınıfn adı: " + this.ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogr1 = new Ogrenci("şahin", "KARAOĞLAN", "erkek");
            Console.WriteLine(ogr1.BilgiGoster());
            Ogretmen ogrt1 = new Ogretmen("dilek", "çınar", "kadın");
            Console.WriteLine(ogrt1.BilgiGoster());
        }
    }
}
