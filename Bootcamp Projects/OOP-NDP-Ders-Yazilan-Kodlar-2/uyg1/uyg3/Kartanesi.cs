using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uyg3
{
    public class Kartanesi
    {
        private int x, y;
        public Kartanesi(int _x,int _y)
        {
            x = _x;
            y = _y;
        }
        public void Kar_Dus()
        {
            y += 15;
        }
        public int X
        {
            get
            {
                return x;
            }
            //set etmeye gerek yok karlar random gelecek
        }
        public int Y
        {
            get
            {
                return y;
            }
        }
    }
}
