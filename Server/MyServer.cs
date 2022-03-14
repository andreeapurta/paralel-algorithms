using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Threading;

namespace Server
{
    internal class MyServer
    {
        private TcpListener server = null;
        private NetworkStream stream = null;
        private StreamReader streamReader = null;
        private StreamWriter streamWriter = null;

        public static List<ServerHandler> Clients = new List<ServerHandler>();

        public MyServer()
        {
            Thread thread = new Thread(new ThreadStart(Run));
            thread.Start();
        }

        public static List<ServerHandler> GetClientList()
        {
            return Clients;
        }

        private void Run()
        {
            server = new TcpListener(8000);
            server.Start();
            while (true)
            {
                TcpClient clientSocket = server.AcceptTcpClient();

                ServerHandler currentClient = new ServerHandler(clientSocket);
                foreach (var client in Clients)
                {
                    client.SendMessage("#" + currentClient.ClientName);
                    currentClient.SendMessage(client.ClientName);
                }

                Clients.Add(currentClient);
            }
        }
    }
}