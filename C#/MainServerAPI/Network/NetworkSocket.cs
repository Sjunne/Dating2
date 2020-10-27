using System.Net.Sockets;
using System.Text;
using System.Text.Json;

namespace MainServerAPI.Network
{
    public class NetworkSocket : INetwork
    {
        
        private TcpClient tcpClient;
        private NetworkStream stream;
        
        public NetworkSocket()
        {
            tcpClient = new TcpClient("127.0.0.1", 6000);
            stream = tcpClient.GetStream();
        }
        
        public void updateProfile(string profile)
        {
            string s = JsonSerializer.Serialize(new Request
            {
            o=profile,
            requestOperation = RequestOperationEnum.EDITINTRODUCTION,
            
            });
            byte[] dataToServer = Encoding.ASCII.GetBytes(s);
            stream.Write(dataToServer, 0, dataToServer.Length);
        }
    }
}