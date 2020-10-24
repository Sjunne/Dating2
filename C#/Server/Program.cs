using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            TcpListener tcpListener = new TcpListener(ip,6000);
            tcpListener.Start();

            while (true)
            {
                TcpClient client = tcpListener.AcceptTcpClient();
                Console.WriteLine("FANDT CLIENT");

                NetworkStream networkStream = client.GetStream();
                byte[] array = new byte[1024];
                int bytesRead = networkStream.Read(array, 0, array.Length);
                string s = Encoding.ASCII.GetString(array, 0, bytesRead);
                Console.WriteLine(s);
            }
        }
    }
}