using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uyg2
{
    public abstract class A
    {
        private int a;
        private int b;
        public A (int sayi1,int sayi2)
        {
            a = sayi1;
            b = sayi2;
        }
        public int Topla(int a,int b)
        {
            return a + b;
        }
        public abstract int ToplaA(int a, int b);   //Abstract metotların gövdesi olmaz
        public abstract int Sayi
        {
            //abstract bir sınıfın geti olmak zorunda.
            get; set;
        }
    }
    public class B : A
    {
        public B (int a,int b):base (a,b)
        {

        }
        public override int ToplaA(int a, int b)
        {
            return a + b;
        }
        public override int Sayi
        {
            get { return 500; }
            set { }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            B bnesne1 = new B(8, 9);
            Console.WriteLine(bnesne1.ToplaA(8, 9));
        }
    }
}
