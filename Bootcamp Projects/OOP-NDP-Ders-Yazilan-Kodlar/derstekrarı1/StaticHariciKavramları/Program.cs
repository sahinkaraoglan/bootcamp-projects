using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticHariciKavramları
{
    public static class MatematikStatic     //STATİC BİR SINIF.
    {
        public static int topla(int x,int y)  //STATİC BİR SINIFIN TÜM ELEMENTLERİ STATİC OLMAK ZORUNDA.
        {
            return x + y;
        }
    }





    public class MatematikHarici                       //HARİCİ BİR SINIF.  KULLANMAK İÇİN NESNE YARATILMALI.
    {
        public int topla(int x,int y)                  //HARİCİ SINIF İÇERİSİNDEKİ HARİCİ BİR DEĞİŞKEN.
        {
            return x + y;
        }
        public static int topla2(int x,int y)          //HARİCİ SINIFIN İÇERİSİNDEKİ STATİC BİR ELEMENT.
        {
            return x + y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MatematikStatic.topla(52,38));
            MatematikHarici mh = new MatematikHarici();
            mh.topla(41, 63);
            Console.WriteLine(mh.topla(41, 63));   //HARİCİ BİR SINIFTAN HARİCİ BİR METODU ÇAĞIRMA.
            Console.WriteLine(MatematikHarici.topla2(10,20));   //HARİCİ BİR SINIFTAN STATİC BİR ELEMENT ÇAĞIRMA.

            Console.ReadLine();
        }
    }
}
