using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _UDE
{
    public class TempIsZeroException:ApplicationException
    {
        public TempIsZeroException(string message):base (message)
        {

        }
    }
    public class Teperature
    {
        public int temp = 0;
        public void ShowTemp()
        {
            if(temp==0)
            {
                throw (new TempIsZeroException("sıcaklık sıfıra düştü."));
            }
            else
            {
                Console.WriteLine("sıcaklık değeri= "+temp);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Teperature t1 = new Teperature();
            int x = 10;
            int y = 0;
            int z;
            t1.temp = 10;
            try
            {
                t1.temp -= 10;
                z = x / y;
                t1.ShowTemp();
            }
            catch(TempIsZeroException t)
            {
                Console.WriteLine("istisnai durum oluştu "+t.Message);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("merhaba");
            }
        }
    }
}
