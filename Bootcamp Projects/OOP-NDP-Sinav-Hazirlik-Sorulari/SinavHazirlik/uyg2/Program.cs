using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uyg2
{
    //VİRTUAL METOTLAR
    public class Personel
    {
        public string AdSoyad;
        protected decimal Maas;
        public Personel(string _adsoyad,decimal _maas)
        {
            this.AdSoyad = _adsoyad;
            this.Maas = _maas;
        }
        public virtual decimal UcretiHesapla()
        {
            return Maas;
        }
    }
    public class Satici:Personel
    {
        private decimal satisbonusu;
        public Satici(string _adsoyad,decimal _maas,decimal _satisbonusu):base(_adsoyad,_maas)
        {
            this.satisbonusu = _satisbonusu;
        }
        public override decimal UcretiHesapla()
        {
            return Maas + satisbonusu;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
