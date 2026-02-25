using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class İnsan
    {
        private string Adi;
        private int  kilo; 

        public İnsan()    //yapıcı contructor.
        {
            Console.WriteLine("yeni bir nesne yaratıldı...");    //kaç tane nesne ürettiyseniz o kadar bu cümleyi yazar.

        }

        public int Kilo    //küçük harfle başayalan kiloyu değiştirmek için büyük harfle başlayan kilo kodunu yazdık cünkü küçük kilo private.
        {
            get
            {
                return kilo;
            }
            set
            {
                if (value < 0)
                    this.kilo = 0;
                else
                    this.kilo = value;

            }
        }

        // get set metotları ile kilo adı özelliklerine doğrudan erişimi kaldırıyoruz.private ile bunun sebebi kontrolun bizde olması.
        public void setAdi(string adi)
        {
            this.Adi = adi;
        }
        public string getAdi()
        {
            return Adi;
        }

        public void setKilo(int kilo)    //se teetik böylelikle encapsulation yapımış olduk.
        {
            if (kilo < 0)
                this.kilo = 0;
            else
                this.kilo = kilo;
        }
        public int getKilo()
        {
            return kilo;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            İnsan ali = new İnsan();
            //ali.kilo = 80;    kiloya artık böyle erişilme çümkü kilo özelliği set edildi. çünkü kilo private önceden publicti.
            ali.setKilo(80);
            //ali.Adi = "ali demir";
            ali.setAdi("ali demir");
            Console.WriteLine("alinin ismi: "+ ali.getAdi());
            Console.WriteLine("alinin kilosu: " + ali.getKilo());

            Console.WriteLine("*********************************************");
            İnsan veli = new İnsan();
            //veli.kilo = 70;   aynı şeyler velinin kikosu içinde geçerli.
            veli.setKilo(70);
            //veli.Adi = "veli yılmaz";
            veli.setAdi("veli yılmaz");
            Console.WriteLine("velin ismi: " + veli.getAdi());
            Console.WriteLine("velinin kilosu: " + veli.getKilo());

            Console.WriteLine("*********************************************");

            ali.setKilo(-60);
            Console.WriteLine("alinin kilosu: " + ali.getKilo());
            ali.setKilo(75);
            Console.WriteLine("alinin kilosu: " + ali.getKilo());

            ali.Kilo = 90;
            Console.WriteLine("alinin yeni kilosu: "+ali.Kilo);




            Console.ReadKey();

        }
    }
}
