using System;

namespace Lab3_Server
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            MyServer myServer = new MyServer();
            AppDomain.CurrentDomain.ProcessExit += new EventHandler((s, e) => CurrentDomain_ProcessExit(s, e, myServer));
        }

        private static void CurrentDomain_ProcessExit(object sender, EventArgs e, MyServer myServer)
        {
            myServer.stream.Close();
        }
    }
}