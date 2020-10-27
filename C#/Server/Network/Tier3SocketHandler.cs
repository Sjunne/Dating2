using System;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using Network;

namespace Server.Network
{
    public class Tier3SocketHandler
    {
        private HttpClient httpClient;

        public Tier3SocketHandler()
        {
           httpClient = new HttpClient();
        }

        public async void EditIntroduction(Request s)
        {
            Console.WriteLine("VI ER HER HVOR VI SKAL VÆRE");
            string username = JsonSerializer.Serialize(s.Username);
            StringContent content = new StringContent(
                username,
                Encoding.UTF8,
                "application/json"
                );
            Console.WriteLine(username);
            await httpClient.GetStringAsync("http://localhost:8080/" + s.Username);
        }
    }    
}