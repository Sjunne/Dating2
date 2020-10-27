using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using Network;
using Server.Network;
using WebApplication.Network;

namespace Server
{
    public class SocketHandler
    {
        private NetworkStream _stream;
        private Tier3SocketHandler tier3SocketHandler;

        public SocketHandler()
        {
            //TODO: SINGLETON V
            tier3SocketHandler = new Tier3SocketHandler();
        }
      

        public void HandlerClient(TcpClient tcpClient, List<SocketHandler> clientList)
        {
            _stream = tcpClient.GetStream();
            
            //read
            byte[] array = new byte[1024];
            int bytesRead = _stream.Read(array, 0, array.Length);
            string s = Encoding.ASCII.GetString(array, 0, bytesRead);
            Request r = JsonSerializer.Deserialize<Request>(s);
            
            switch (r.requestEnum)
            {
                case RequestOperationEnum.EDITINTRODUCTION:
                {
                    Console.WriteLine("VI ER HER (SOCKETHANDLER)");
                    tier3SocketHandler.EditIntroduction(r);
                    break;
                }
                default:
                {
                    break;
                }
            }
        }
    }
}

