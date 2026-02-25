using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sadievrensekerders3
{
    class insan
    {
        private int yas;
        public string ad;

        public void setyas(int yas)
        {
            if (yas < 0)
                this.yas = 0;
            else
                this.yas = yas;
        }
        public int getYas()
        {
            return yas;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            insan ozan = new insan();
            ozan.ad = "OZAN AKDORA";
            Console.WriteLine("ozanın ismi: "+ozan.ad);
            ozan.setyas(23);
            Console.WriteLine("ozanın yasi: "+ozan.getYas());
            ozan.setyas(-21);
            Console.WriteLine("ozanın yasi: " + ozan.getYas());

            Console.ReadKey();
        }
    }
}
