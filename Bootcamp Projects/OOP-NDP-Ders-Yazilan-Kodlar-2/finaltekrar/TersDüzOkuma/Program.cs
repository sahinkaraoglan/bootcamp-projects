using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TersDüzOkuma
{
    class Program
    {
        public static void Main( string args)
        {
            void tersoku(string str[])
            {
                int l = 0;
                int h = (str) - 1;
                while(h>1)
                {
                    if([l++]!=str[h--])
                    {
                        Console.WriteLine("%s is not palindrome", str);
                    }
                }
                Console.WriteLine("%s is palindrome",str);
            }
            tersoku("abba");
            tersoku("abbccbba");
            tersoku("geeks");
        }
    }
    class program
    {
        static void Main(string []args)
        {
            string s;
            Console.WriteLine("kelime girin: ");
            s = Console.ReadLine();
            bool durum = true;
            for(int i=0;i<s.Length/2;i++)
            {
                if (s[i] != s[s.Length - i - 1])
                    durum = false;
            }
            if(durum=true)
                Console.WriteLine("polindrome kelime girdiniz.");
                else
                Console.WriteLine("polindrome olmayan kelime giridiniz.");
            Console.ReadLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bir kelime giriniz: ");
            string kelime = Console.ReadLine();
            string kelime_ters = " ";
            for(int i=kelime.Length-1;i>=0;i--)
            {
                kelime_ters += kelime[i];
            }
            Console.WriteLine("\nkelimenin tersten yazılışı=" + kelime_ters);
            if(kelime_ters==kelime)
            {
                Console.WriteLine("\ngirilen kelime polindromik bir kelimedir.");
            }
            else
            {
                Console.WriteLine("\ngirilen kelime polindromik bir kelime değildir");
            }
            Console.ReadLine();
;
        }
    }
}
