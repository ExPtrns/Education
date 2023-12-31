﻿using System.Net.Sockets;
using System.Text;

namespace Client
{
    public class OurClient
    {
        TcpClient client;
        StreamWriter sWriter;


        public OurClient()
        {
            client = new TcpClient("127.0.0.1", 5555);
            sWriter = new StreamWriter(client.GetStream(),Encoding.UTF8);
            HandleCommunication();
        }

        void HandleCommunication()
        {
            while (true)
            {
                Console.Write("> ");
                string? message = Console.ReadLine();
                sWriter.WriteLine(message);
                sWriter.Flush();
            }
        }
    }
}