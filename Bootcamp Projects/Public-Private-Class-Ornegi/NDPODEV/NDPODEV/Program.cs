using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDPODEV
{
    public class Arac
    {
        private string marka, model;
        private int fiyat;

        public string Marka
        {
            get
            {
                return marka;
            }
            set
            {
                marka = value;
            }

        }
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }

        }
        public int Fiyat
        {
            get
            {
                return fiyat;
            }
            set
            {
                if (value < 0)
                    fiyat = 0;
                else
                    fiyat = value;
            }
        }
    }
    class Arac1
    {
        string marka1;
        string model1;
        int fiyat1;
        public Arac1(string ma, string mo, int fi)
        {
            marka1 = ma;
            model1 = mo;
            fiyat1 = fi;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Arac a1 = new Arac();
            a1.Fiyat = 50000;
            a1.Marka = "BMW";
            a1.Model = "C serisi";
            Console.WriteLine("marka: " + a1.Marka + "   " + "fiyat: " + a1.Fiyat + "  " + "model: " + a1.Model);

            Arac1 a11 = new Arac1();


            Console.ReadLine();
        }
    }
}
