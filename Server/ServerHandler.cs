using System;
using System.IO;
using System.Net.Sockets;
using System.Threading;

namespace Server
{
    internal class ServerHandler
    {
        private readonly NetworkStream stream = null;
        private readonly StreamReader streamReader = null;
        private readonly StreamWriter streamWriter = null;
        public string ClientName;
        private readonly Thread receiveMessageThread;

        public ServerHandler(TcpClient clientSocket)
        {
            stream = clientSocket.GetStream();
            streamReader = new StreamReader(stream);
            streamWriter = new StreamWriter(stream);
            ClientName = ReceiveName();

            receiveMessageThread = new Thread(GetMessage);
            receiveMessageThread.Start();
        }

        public void SendMessage(string txt)
        {
            streamWriter.WriteLine(txt);
            streamWriter.Flush();
        }

        public void GetMessage()
        {
            while (true)
            {
                string message = Convert.ToString(streamReader.ReadLine());
                DateTime currentDate = DateTime.Now;

                if (message != null)
                {
                    string messageFromClient = " [ " + currentDate + " ] " + ClientName + " : " + message;

                    foreach (var client in MyServer.GetClientList())
                    {
                        client.SendMessage(messageFromClient);
                    }
                }
            }
        }

        public String ReceiveName()
        {
            string name = Convert.ToString(streamReader.ReadLine());
            Console.WriteLine(name);
            return name;
        }
    }
}