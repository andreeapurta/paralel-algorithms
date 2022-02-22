using System.Drawing;
using System.Threading;

namespace Lab1._2
{
    public class Ball
    {
        private int px = 0;
        private int py = 0;
        private int size = 0;
        private Color color;
        private Form1 parent = null;
        private Thread bthread = null;

        public Ball(Form1 parent, int px, int py, int size, Color color)
        {
            this.parent = parent;
            this.px = px;
            this.py = py;
            this.size = size;
            this.color = color;
            bthread = new Thread(new ThreadStart(run));
            bthread.Start();
        }

        public int getPX()
        {
            return px;
        }

        public int getPY()
        {
            return py;
        }

        public int getSize()
        {
            return size;
        }

        public Color getColor()
        {
            return color;
        }

        public void terminateBallThread()
        {
            bthread.Abort();
        }

        //incrementeaza pozitia bilei pe orizontala pana cand iese din fereastra
        public void run()
        {
            while (px < parent.Size.Width)
            {
                Thread.Sleep(20);
                px++;
                parent.Refresh();
            }
        }
    }
}