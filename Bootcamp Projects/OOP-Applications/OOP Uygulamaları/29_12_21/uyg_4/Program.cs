using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uyg_4
{
    class Program
    {
        public delegate void eventhandler();
        public static event eventhandler _show;

        static void cat()
        {
            Console.WriteLine("CAT");
        }
        static void dog()
        {
            Console.WriteLine("DOG");
        }
        static void mouse()
        {
            Console.WriteLine("MOUSE");
        }

        static void Main(string[] args)
        {
            _show = new eventhandler(dog);    //en başta ya böyle tanımlama yapmak zorundasın yada += şeklindede yapılabilir,yada null olarak tanımlamalısın.
            _show += new eventhandler(cat);
            _show += new eventhandler(mouse);
            _show += new eventhandler(mouse);
            _show.Invoke();
        }
    }
}
