using System.Net.Sockets;
using System.Text;

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
        
        public void EditIntroduction(string text)
        {
            byte[] dataToServer = Encoding.ASCII.GetBytes(text);
            stream.Write(dataToServer, 0, dataToServer.Length);
        }
    }
}