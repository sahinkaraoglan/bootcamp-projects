using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uyg4
{
    public class Car
    {
        private int yil;
        private string uretici;
        public Car (int Yil,string Uretici)
        {
            yil = Yil;
            uretici = Uretici;
        }
        public int Yil
        {
            get
            {
                return yil;
            }
            set
            {
                yil = value;
            }
        }
        public string Uretici
        {
            get { return uretici; }
            set { uretici = value; }
        }
    }
}
