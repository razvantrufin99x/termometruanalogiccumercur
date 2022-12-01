using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace termometruanalogiccumercur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int ismd = 0;
        public Graphics g;
        public int x = 150;
        public int j = 0;
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            ismd = 0;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (ismd == 1)
            {
                Left += e.X;
                Top += e.Y;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ismd = 1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            g = pictureBox1.CreateGraphics();
            g.FillEllipse(new SolidBrush(Color.Red), 8, 218, Width/2+10, Width/2+10);
            for (int i = 0; i < Height && j < x; i+=50)
            {
                g.DrawLine(new Pen(Color.Red, 5), Width / 2 - 20, Height - 30, Width / 2 - 20, Height - 30 -  i);
                Thread.Sleep(20);
                j = i;
            }
            
        }
    }
}
