using System;
using System.Threading;

namespace Lab2._2
{
    internal class ProducerConsumer
    {
        private ManualResetEvent Full = new ManualResetEvent(false); //producer
        private ManualResetEvent Empty = new ManualResetEvent(false); //consumer
        private readonly Thread consumer;
        private readonly Thread producer;

        public ProducerConsumer()
        {
            producer = new Thread(Produce);
            consumer = new Thread(Consume);
            Full.Set();
            producer.Start();
            consumer.Start();
            Console.ReadLine();
        }

        private void Produce()
        {
            while (true)
            {
                Full.WaitOne();
                Full.Reset();
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(500);
                }
                Console.WriteLine("Producator a produs");
                Thread.Sleep(500);
                Empty.Set();
            }
        }

        private void Consume()
        {
            while (true)
            {
                Empty.WaitOne();
                Empty.Reset();
                for (int i = 10; i >= 0; i--)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(550);
                }
                Console.WriteLine("Consumator a consumat");
                Thread.Sleep(500);
                Console.Clear();
                Full.Set();
            }
        }
    }
}