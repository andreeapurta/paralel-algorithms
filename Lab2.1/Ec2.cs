﻿using System;
using System.Threading;

namespace Lab2._1
{
    public class Ec2
    {
        private int a = 1;
        private int b = -4;
        private int c = 1;
        private double x1, x2, d;
        private static ManualResetEvent deltaReady = new ManualResetEvent(false);

        public Ec2()
        {
            Thread tx1 = new Thread(new ThreadStart(ComputeX1));
            Thread tx2 = new Thread(new ThreadStart(ComputeX2));
            Thread tdelta = new Thread(new ThreadStart(ComputeDelta));
            tdelta.Start();
            tx1.Start();
            tx2.Start();
            Console.ReadLine();
        }

        public void ComputeDelta()
        {
            d = b * b - 4 * a * c;
            Console.WriteLine("delta = " + d);
            Console.WriteLine("tdelta: sleeping");
            Thread.Sleep(5000);
            Console.WriteLine("tdelta: ready");
            deltaReady.Set();
        }

        public void ComputeX1()
        {
            Console.WriteLine("tx1: waiting...");
            deltaReady.WaitOne();
            x1 = (-b + Math.Sqrt(d)) / (2 * a);
            Console.WriteLine("x1 = " + x1);
        }

        public void ComputeX2()
        {
            Console.WriteLine("tx2: waiting...");
            deltaReady.WaitOne();
            x2 = (-b - Math.Sqrt(d)) / (2 * a);
            Console.WriteLine("x2 = " + x2);
        }
    }
}