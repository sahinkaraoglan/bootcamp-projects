using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace uyg4
{
    public class Cars:IEnumerable,IEnumerator
    {
        private Car[] carlist;
        int konum = -1;
        public Cars()
        {
            carlist = new Car[5]
            {
                new Car(2010,"BMW"),
                new Car(2018,"mercedes"),
                new Car(2020,"honda"),
                new Car(2021,"toyota"),
                new Car(2022,"hyundaı")
            };
        }
        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }
        public bool MoveNext()
        {
            konum++;
            return (konum < carlist.Length);
        }
        public object Current
        {
            get
            {
                return carlist[konum];
            }
        }
        public void Reset()
        {
            konum = -1;
        }

    }
}
