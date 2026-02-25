using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structsss
{
    public struct Book
    {
        public Book(string T, string A, string s, int i)
        {
            Title = T;
            Author = A;
            Subject = s;
            ID = i;

        }
        public string Title;
        public string Author;
        public string Subject;
        public int ID;
        public int getID { get { return ID; } }
        public void Goster()
        {
            Console.WriteLine("Title = {0}\nAuthor={1},Subject = {2}\nID={3}\n", Title, Author, Subject, ID);
        }
    }
    public class Ogrenci_c
    {
        public int a;
        public int b;
    }
    public struct Ogrenci_s
    {
        public int a;
        public int b;

    }
    class Program
    {
        static void Main(string[] args)
        {
            Book b1;
            b1.Author = "MEHMET BAKIR";
            b1.Title = "NESNEYE DAYALI PROGRAMLAMA";
            b1.Subject = "MÜHENDİSLİK EĞİTİMİ";
            b1.ID = 202;
            Console.WriteLine(b1.Title);
            b1.Goster();
            Book b2 = new Book("veri tabanı", "ayşe çalışkan", "mühendislik", 206);
            b2.Goster();
            Ogrenci_c ogrencinesne = new Ogrenci_c();
            Ogrenci_s ogrenciyapi = new Ogrenci_s();
            ogrencinesne.a = 5;
            ogrencinesne.b = 10;
            Console.WriteLine("------------------------");
            Console.WriteLine("ogrencinesne a=" + ogrencinesne.a);
            Ogrenci_c ogrencinesne2 = new Ogrenci_c();
            ogrencinesne2.a = 100;
            ogrencinesne2.b = 200;
            ogrencinesne = ogrencinesne2;
            Console.WriteLine("ogrencinesne a=" + ogrencinesne.a);
            ogrencinesne2.a = 1000;
            Console.WriteLine("ogrencinesne a=" + ogrencinesne.a);
            Ogrenci_s ogrenciyapi1 = new Ogrenci_s();
            Ogrenci_s ogrenciyapi2 = new Ogrenci_s();
            ogrenciyapi1.a = 500;
            ogrenciyapi2.a = 1500;
            Console.WriteLine("---------------------");
            Console.WriteLine(ogrenciyapi1.a);
            ogrenciyapi1.a = ogrenciyapi2.a;
            Console.WriteLine(ogrenciyapi1.a);
            ogrenciyapi2.a = 5800;
            Console.WriteLine(ogrenciyapi1.a);

        }
    }
}
