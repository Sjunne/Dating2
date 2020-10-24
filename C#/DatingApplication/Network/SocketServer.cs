using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using WebApplication.Data;

namespace WebApplication.Network
{
    public class SocketServer : INetworkComp
    {
        private TcpClient tcpClient;
        private NetworkStream stream;
        
        public SocketServer()
        {
            tcpClient = new TcpClient("127.0.0.1", 6000);
            stream = tcpClient.GetStream();
        }
        
        public void EditIntroduction(Request r)
        {
            string s = JsonSerializer.Serialize(r);
            byte[] dataToServer = Encoding.ASCII.GetBytes(s);
            stream.Write(dataToServer, 0, dataToServer.Length);
        }
    }
}