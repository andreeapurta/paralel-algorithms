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

        public static List<ServerHandler> ListClients = new List<ServerHandler>();

        public MyServer()
        {
            Thread thread = new Thread(new ThreadStart(Run));
            thread.Start();
        }

        public static List<ServerHandler> GetClientList()
        {
            return ListClients;
        }

        private void Run()
        {
            server = new TcpListener(8000);
            server.Start();
            while (true)
            {
                TcpClient clientSocket = server.AcceptTcpClient();

                ServerHandler currClient = new ServerHandler(clientSocket);

                ListClients.Add(currClient);
            }
        }
    }
}