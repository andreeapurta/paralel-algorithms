using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab1._2
{
    public partial class Form1 : Form
    {
        private Ball ball = null;

        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            this.BackColor = Color.White;
            ball = new Ball(this, 0, 50, 20, Color.Purple);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(400, 300);
            this.Name = "Balls";
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush brush = new SolidBrush(Color.White);
            e.Graphics.FillRectangle(brush, 0, 0, Size.Width, Size.Height);
            brush = new SolidBrush(ball.getColor());
            e.Graphics.FillEllipse(brush, ball.getPX(), ball.getPY(), ball.getSize(), ball.getSize());
            brush.Dispose();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ball.terminateBallThread();
        }
    }
}