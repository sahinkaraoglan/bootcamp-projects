using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] ucboyutludizi = new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } }, { { 7, 8, 9 }, { 10, 11, 12 } } };
            for(int i=0;i<2;i++)
            {
                for(int j=0;j<2;j++)
                {
                    for( int a=0;a<3;a++)
                    {
                        Console.Write(ucboyutludizi[i, j, a]+" ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
