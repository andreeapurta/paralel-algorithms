using System;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Threading;

namespace Client
{
    internal class MyClient
    {
        private TcpClient client = null;
        private NetworkStream stream = null;
        private StreamReader streamReader = null;
        private StreamWriter streamWriter = null;
        private MyForm formClient;
        private Thread GetMessage;
        public String ClientName;

        public MyClient(MyForm form, String nume)
        {
            client = new TcpClient("localhost", 8000);
            stream = client.GetStream();
            streamReader = new StreamReader(stream);
            streamWriter = new StreamWriter(stream);
            ClientName = nume;
            SendString(nume);
            formClient = form;
            GetMessage = new Thread(new ThreadStart(ReceiveMessage));
            GetMessage.Start();

            // stream.Close();
            //client.Close();
        }

        public void CloseConnnection()
        {
            GetMessage.Abort();
            SendString("$");
        }

        public void ReceiveMessage()
        {
            while (true)
            {
                String message = Convert.ToString(streamReader.ReadLine());
                if (message != null)
                {
                    if (message.Contains('&'))
                    {
                        string[] split = message.Split(' ');
                        ClientName = split[1];
                    }
                    else
                    {
                        formClient.textBoxMesaje.Text += message + "\r\n";
                    }
                }
            }
        }

        public void SendString(String txt)
        {
            streamWriter.WriteLine(Convert.ToString(txt));
            streamWriter.Flush();
        }
    }
}