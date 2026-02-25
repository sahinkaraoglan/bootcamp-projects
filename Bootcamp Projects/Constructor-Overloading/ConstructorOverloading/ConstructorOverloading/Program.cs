using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorOverloading
{
    public class x
    {
        private int m;

        public x()
        {
            m = 0;
        }
        public x(int k)
        {
            m = k;
        }
        public x(int k,int z)
        {
            m = k + z;
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
            x _x01 = new x();
            Console.WriteLine(_x01.m_get());
            x _x02 = new x(6);
            Console.WriteLine(_x02.m_get());
            x _x03 = new x(6, 6);
            Console.WriteLine(_x03.m_get());

        }
    }
}
