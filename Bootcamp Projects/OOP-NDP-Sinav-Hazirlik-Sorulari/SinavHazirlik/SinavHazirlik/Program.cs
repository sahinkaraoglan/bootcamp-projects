using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinavHazirlik
{
    class Program
    {
        //ref anahtar kelimesideğer tipinden önce kullanılmalı.
        static void Kareal(ref double d)    //d'nin adresi üzereinden işlem yapılıyor.
        {
            d = d * d;
        }
        static void Main(string[] args)
        {
            //ref anahtarlarına ilk değer verilmesi zorunludur.
            double i = 3.45;
            Console.WriteLine("double sayı :{0} ",i);
            Kareal(ref i);  //bu aşamada ref parametresi içeren metot çağrılıyor.
            Console.WriteLine("karesi: {0}",i);
            Console.ReadKey();

        }
    }
}
