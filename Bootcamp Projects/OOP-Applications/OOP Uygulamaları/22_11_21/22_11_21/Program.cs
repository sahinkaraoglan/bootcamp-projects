using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_11_21
{
    public class X
    {
        private int m;

        public X(int d)
        {
            m = d;
        }
        public X(int k ,int c)
        {
            m = k + c;
        }
        public X(int k,int z,int f)
        {
            m = k * z * f;
        }
        public int m_get()
        {
            return m;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            X _x01 = new X(5);
            Console.WriteLine(_x01.m_get());
            X _x02 = new X(6,9);
            Console.WriteLine(_x02.m_get());
            X _x03 = new X(9, 9,10);
            Console.WriteLine(_x03.m_get());
            Console.ReadLine();
        }
    }
}
