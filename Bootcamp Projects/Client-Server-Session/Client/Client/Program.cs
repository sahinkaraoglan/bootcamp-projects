using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            //bu oluşturulan soketi bağlamamız lazım belirtilen ıp adresine ve porta
            s.Connect(IPAddress.Parse("127.0.0.1"), 600);
            byte[] buffer = Encoding.ASCII.GetBytes(Console.ReadLine());
            //aldığımız buffre gönderelim şimdi
            s.Send(buffer);
            s.Close();     //soket kapatılır.
            Console.Read();
        }
    }
}
