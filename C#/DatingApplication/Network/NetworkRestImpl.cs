﻿using System;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WebApplication.Data;

namespace WebApplication.Network
{
    public class NetworkRestImpl : INetworkComp
    {
        private HttpClient client;

        public NetworkRestImpl()
        {
            client = new HttpClient();
        }

        public async Task EditIntroduction(ProfileData profileData)
        {
            Console.WriteLine("Test");
            string message = JsonSerializer.Serialize(profileData);
            HttpContent content = new StringContent(message,Encoding.UTF8,"application/json");
            HttpResponseMessage info = await client.PostAsync("https://localhost:5003/Profile", content);
            Console.WriteLine(info);
        }
    }
}