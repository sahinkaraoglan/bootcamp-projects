
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace derstekrarı1
{
    public class İslemProperty
    {
        private int y; //PAKETLEME İŞLEMEDİR.

        public int YinDegeri    //PROPERTY
        {
            set
            {
                if (value < 0)
                    y = 0;
                else
                    y = value;
            }
            get
            {
                return y;
            }
        }
      
    }
    class Program
    {
        static void Main(string[] args)
        {
            İslemProperty ip = new İslemProperty();
            ip.YinDegeri = 90;
            Console.WriteLine(ip.YinDegeri);
            Console.ReadKey();

        }
    }
}
