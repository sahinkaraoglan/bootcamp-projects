using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public class MatematikIslemler
    {
        private double sayi1;
        private double sayi2;

        public MatematikIslemler(double s1,double s2)
        {
            Sayi1 = s1;
            Sayi2 = s2;
        }
        public double Sayi1
        {
            get
            {
                return sayi1;
            }
            set
            {
                if (value <= 0)
                    sayi1 = 0;
                else
                    sayi1 = value;
            }
        }
        public double Sayi2
        {
            get
            {
                return sayi2;
            }
            set
            {
                if (value <= 0)
                    sayi2 = 0;
                else
                    sayi2 = value;
            }
        }
        public double Topla
        {
            //sadece get olan propertye read only property denir.
            get
            {
                return sayi1 + sayi2;
            }
        }
        public double ToplaFonksiyon()
        {
            return sayi1 + sayi2;
        }
        public double FarkFonksiyon()
        {
            return sayi1 - sayi2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MatematikIslemler nesne1 = new MatematikIslemler(-30, 20);
            Console.WriteLine(nesne1.Topla);
            MatematikIslemler nesne2 = new MatematikIslemler(13, 9);
            nesne2.Sayi1 = 55;
            nesne2.Sayi2 = 33;
            Console.WriteLine("sayi1={0} sayi2={1} toplam={2} fark={3} ",nesne2.Sayi1,nesne2.Sayi2,nesne2.ToplaFonksiyon(),nesne2.FarkFonksiyon());
        }
    }
}
