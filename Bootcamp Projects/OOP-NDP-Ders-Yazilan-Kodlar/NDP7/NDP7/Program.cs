using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP7
{
    public class A
    {
        //tostring bir metotdur türüde virtualdir.
        //metodu kendimize göre tanımlarsak override etmiş oluruz.

        public virtual int Topla(int a,int b)
        {
            return a + b;
        }
        public virtual int Topla(int a,int b,int c)
        {
            return a + b + c;
        }
        public override string ToString()
        {
            return "yozgat bozok üniversitesi";
        }
    }
    public class B : A
    {
        //neyi override ediyorsak ona göre yapmalıyız .
        public override int Topla(int a, int b)
        {
            return 1500;
        }
        public override int Topla(int a, int b, int c)
        {
            return 25000;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A anesne = new A();
            Console.WriteLine(anesne.ToString());
            B nesne2 = new B();
            Console.WriteLine(nesne2.Topla(5, 8, 16));   //yukarda 2500 olarak tanımladık ne  yazarsak yaz 2500 değerini verecektir.

        }
    }
}
