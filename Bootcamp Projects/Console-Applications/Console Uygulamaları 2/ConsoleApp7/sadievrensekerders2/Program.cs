using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sadievrensekerders2
{
    class insan
    {
        private int yas;    //private ile amac encapsulation etmek, neden: kontrolun bizim elimizde olması.
        public int Yas
        {
            get
            {
                return yas;
            }
            set
            {
                if (value < 0)   //sedanın yaşının - bir değer girilmesini önleniyor 
                    this.yas = 0;
                else
                    this.yas = value;
            }
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            insan seda = new insan();
            seda.Yas = 24;
            Console.WriteLine("sedanin yasi: "+ seda.Yas);

            Console.WriteLine("*******************************");

            seda.Yas = -12;
            Console.WriteLine("sedanin yasi: " + seda.Yas);

            Console.ReadKey();
        }
    }
}
