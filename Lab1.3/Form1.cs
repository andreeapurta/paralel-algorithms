using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Lab1._3
{
    public partial class Form1 : Form
    {
        private readonly Ad[] ads = new Ad[] { new Ad("C", 5), new Ad("B", 3), new Ad("A", 2), new Ad("D", 10) };
        private string[] order;

        public Form1()
        {
            InitializeComponent();
            SetOrder();
        }

        private int Sum()
        {
            int total = 0;
            for (int i = 0; i < ads.Length; i++)
            {
                total += ads[i].Priority; //4+3+2
            }
            return total;
        }

        private void GetFrequency(int total)
        {
            for (int i = 0; i < ads.Length; i++)
            {
                ads[i].Frequency = (int)Math.Round((double)total / ads[i].Priority);
            }
        }

        private void SetOrder()
        {
            int total = Sum();
            order = new string[total];
            GetFrequency(total);

            for (int i = 0; i < total; i++)
            {
                order[i] = "";
            }

            for (int i = 0; i < ads.Length; i++)
            {
                for (int j = 0; j < order.Length; j++)
                {
                    int index = j * ads[i].Frequency;
                    if (index > order.Length - 1)
                    {
                        break;
                    }
                    if (string.IsNullOrEmpty(order[index]))
                    {
                        order[index] = ads[i].Name;
                    }
                    else if (index < order.Length - 1)
                    {
                        while (!string.IsNullOrEmpty(order[index]) && j < order.Length - 1)
                        {
                            index++;
                            if (index > order.Length - 2) //daca e mai mare de penultimul
                            {
                                break;
                            }
                        }
                        order[index] = ads[i].Name;
                    }
                }
            }

            Console.WriteLine(order);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            int i = 0;
            while (true)
            {
                string picture = string.Format(@".\photos\{0}.bmp", order[i]);

                Bitmap bmp = new Bitmap(picture);
                e.Graphics.DrawImage(bmp, 0, 0, new Rectangle(0, 0, Size.Width, Size.Height), GraphicsUnit.Pixel);
                i = (i + 1) % order.Length;
                Thread.Sleep(3000);
            }
        }
    }
}