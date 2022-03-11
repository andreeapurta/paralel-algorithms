using System;
using System.IO;
using System.Net.Sockets;
using System.Threading;

namespace Lab3_Server
{
    internal class MyServer
    {
        private TcpListener server = null;
        public NetworkStream stream = null;
        private StreamReader streamReader = null;
        private StreamWriter streamWriter = null;

        public MyServer(TcpClient clientSocket)
        {
            stream = clientSocket.GetStream();
            streamReader = new StreamReader(stream);
            streamWriter = new StreamWriter(stream);
            //ReceiveInt();
            GetMessage();
            SendMessage("Salut sunt eu un haiduc :) !");
            //stream.Close();
            //Thread thread2 = new Thread(new ThreadStart(GetMessage));
            //thread2.Start();
        }

        public MyServer()
        {
            Thread thread = new Thread(new ThreadStart(Run));
            thread.Start();
        }

        public void GetMessage()
        {
            string message = streamReader.ReadLine();
            Console.WriteLine(message);
        }

        public void SendMessage(string message)
        {
            streamWriter.WriteLine(message);
            streamWriter.Flush();
        }

        public void SendInt(int val)
        {
            streamWriter.WriteLine(Convert.ToString(val));
            streamWriter.Flush();
        }

        public void ReceiveInt()
        {
            int val = Convert.ToInt32(streamReader.ReadLine());
            Console.WriteLine(val);
        }

        private void Run()
        {
            server = new TcpListener(8000);
            server.Start();
            while (true)
            {
                TcpClient clientSocket = server.AcceptTcpClient();
                new MyServer(clientSocket);
            }
        }
    }
}