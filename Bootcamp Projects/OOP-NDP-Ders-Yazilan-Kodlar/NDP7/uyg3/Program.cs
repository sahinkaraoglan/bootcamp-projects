using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uyg3
{
    class Program
    {
        //Ienumerable iterasyon yapmaya yarar.iterasyon deyince aklımaza foreach gelmeli.

        static void Goster(IEnumerable<int>_list)
        {
            foreach(int item in _list)
                Console.WriteLine(item);
        }
        static void Main(string[] args)
        {
            List<int> _l = new List<int>() { 5, 8, 13, 17, 20 };
            Goster(_l);
            int[] _dizi = new int[] { 20, 30, 40, 50, 60 };
            Goster(_dizi);

            Goster(new int[] { 120, 130, 140, 150, 160 });

        }
    }
}
