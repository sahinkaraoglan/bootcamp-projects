using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama1

{
    public class Matematil_islem_property
    {
        private double sayi1;
        private double sayi2;

        public Matematil_islem_property(int s1,int s2)
        {
            sayi1 = s1;
            sayi2 = s2;

        }
        public double Sayi_1     //propertyler bir field dır.
        {
            get
            {
                return Sayi_1;
            }
            set
            {
                if (value <= 0)
                    Sayi_1 = 0;
                else
                    Sayi_1 = value;
            }
        }

        public double Sayi_2
        {                                        
            get
            {
                 return Sayi_2;
            }
            set
            {
                if (value <= 0)
                   Sayi_2 = 0;
                else
                   Sayi_2 = value;
            }
        }
        public double toplam
        {
            get
            {
                return Sayi_1 + Sayi_2;
            }
        }
        public double cikar()
        {
            return Sayi_1 - Sayi_2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Matematil_islem_property nesne1= new Matematil_islem_property(8,5);
            Console.WriteLine("girilen sayılar = {0},{1},toplam = {2},farkı={3}", nesne1.Sayi_1, nesne1.Sayi_2, nesne1.toplam, nesne1.cikar());
            Matematil_islem_property nesne2 = new Matematil_islem_property(10, 5);
            nesne2.Sayi_1 = -30;
            nesne2.Sayi_2 = 10;
            Console.WriteLine("girilen sayılar = {0},{1},toplam = {2},farkı={3}", nesne2.Sayi_1, nesne2.Sayi_2, nesne2.toplam, nesne2.cikar());

        }
    }
}
