using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_12_21
{
    struct Books
    {
        public string title;
        public string author;
        public string subject;
        public int ıd;
    };
    public class TestStructer
    {
        public static void main(string [] args)
        {
            Books book1 = new Books();
            Books book2 = new Books();

            book1.title = "camdaki kız";
            book1.author = "gülseren budayıcıoğlu";
            book1.subject = "gerçek bir hayat hikayesi";
            book1.ıd = 123456;

            book2.title = "çürük elmalar masum mahkumkar";
            book2.author = "sevil atasoy";
            book2.subject = "cinayet,polisiye";
            book2.ıd = 456789;


            Console.WriteLine("book1.litle {0}",book1.title);
            Console.WriteLine("book1.author {0}", book1.author);
            Console.WriteLine("book1.subject{0}", book1.subject);
            Console.WriteLine("book1.id{0}",book1.ıd);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
