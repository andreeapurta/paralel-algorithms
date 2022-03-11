using System;
using System.IO;
using System.Net.Sockets;

namespace Lab3_Client
{
    public class MyClient
    {
        private readonly TcpClient client = null;
        private readonly NetworkStream stream = null;
        private readonly StreamReader streamReader = null;
        private readonly StreamWriter streamWriter = null;

        public MyClient()
        {
            client = new TcpClient("localhost", 8000);
            stream = client.GetStream();
            streamReader = new StreamReader(stream);
            streamWriter = new StreamWriter(stream);
            //sendInt(100);
            SendMessage("S-a conetat clientul");
            //stream.Close();
            //client.Close();
        }

        public void SendMessage(string str)
        {
            streamWriter.WriteLine(str);
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

        public void GetMessage()
        {
            string str = streamReader.ReadLine();
            Console.WriteLine(str);
        }
    }
}