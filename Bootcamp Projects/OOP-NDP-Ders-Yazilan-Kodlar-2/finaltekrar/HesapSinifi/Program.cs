using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapSinifi
{
    public class Hesapla
    {
        string veri1;
        string veri2;
        public Hesapla(string v1,string v2)
        {
            veri1 = v1;
            veri2 = v2;
        }
        public int Toplama()
        {
            if(veri1.GetType()!=typeof(string))
            {
                return -1;
            }
            else if(veri2.GetType()!=typeof(string))
            {
                return -2;
            }
            else if((veri1.GetType()!=typeof(string ))||(veri2.GetType()!=typeof(string)))
            {
                return -3;
            }
            else if(int.Parse(veri1)<0)
            {
                return -4;
            }
            else if(int.Parse(veri2)<0)
            {
                return -5;
            }
            else if(int.Parse (veri1)<0||int.Parse(veri2)<0)
            {
                return -6;
            }
            else
            {
                int toplam = int.Parse(veri1) + int.Parse(veri2);
                return toplam;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Hesapla h1 = new Hesapla("10", "15");
            Console.WriteLine(h1.Toplama()) ;
        }
    }
}
