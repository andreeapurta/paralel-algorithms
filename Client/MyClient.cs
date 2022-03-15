using System;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace Client
{
    internal class MyClient
    {
        private TcpClient client = null;
        private NetworkStream stream = null;
        private StreamReader streamReader = null;
        private StreamWriter streamWriter = null;
        private MyForm formClient;
        private ListBox ClientsListBox;
        private Thread GetMessage;
        public string ClientName;

        public MyClient(MyForm form, String nume, ListBox clientsListBox)
        {
            client = new TcpClient("localhost", 8000);
            stream = client.GetStream();
            streamReader = new StreamReader(stream);
            streamWriter = new StreamWriter(stream);
            ClientName = nume;
            SendString(nume);
            formClient = form;
            ClientsListBox = clientsListBox;
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
                string message = Convert.ToString(streamReader.ReadLine());

                if (message != null)
                {
                    if (message.Contains("#"))
                    {
                        ClientsListBox.Items.Add(message.Remove(0, 1));
                    }
                    else
                    formClient.textBoxMesaje.Text += message + "\r\n";
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