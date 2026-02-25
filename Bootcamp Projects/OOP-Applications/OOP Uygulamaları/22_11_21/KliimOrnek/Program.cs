using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KliimOrnek
{
    public class X
    {
        public int m;
        private int k;
        protected int z = 10;
        public int topla1()
        {
            return this.m + z;
        }
    }
    public class Y:X
    {
        public int n;
        protected int z1;
        public int topla2()
        {
            return base.m + this.n + z;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Y _y = new Y();
            _y.m = 10;
            _y.n = 5;
            Console.WriteLine(_y.topla2());
            Console.ReadLine();
        }
    }
}
