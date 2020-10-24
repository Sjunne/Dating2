using System;
using System.Collections.Generic;
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
            SocketHandler socketHandler = new SocketHandler();

            while (true)
            {
                TcpClient client = tcpListener.AcceptTcpClient();
                Console.WriteLine("FANDT CLIENT");

                NetworkStream networkStream = client.GetStream();
                socketHandler.HandlerClient(client,new List<SocketHandler>());
            }
        }
    }
}