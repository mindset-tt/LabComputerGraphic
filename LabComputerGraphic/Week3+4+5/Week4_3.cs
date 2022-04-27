using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabComputerGraphic.Week3_4_5
{
    public partial class Week4_3 : Form
    {
        Graphics g; Pen p;
        public Week4_3()
        {
            InitializeComponent();
        }
        private void drawEllipe()
        {
            p = new Pen(Color.Red, 3);
            g.DrawEllipse(p, 10, 10, 100, 100);
        }

        private void FillRectangle()
        {
            p = new Pen(Color.Orange, 3);
            g.FillRectangle(Brushes.Cyan, 10, 180, 100, 100);
            g.Dispose();
        }

        private void Week4_3_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            drawEllipe();
            FillRectangle();
            g.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.TranslateTransform(350, 30);
            g.RotateTransform(45);
            FillRectangle();
            g.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.TranslateTransform(350, 30);
            g.RotateTransform(45);
            FillRectangle();
            g.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.TranslateTransform(0, 200);
            g.ScaleTransform(2, 1);
            FillRectangle();
            g.Dispose();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            Matrix m = new Matrix();
            m.Translate(-110, 120);
            m.Shear(2, 1);
            g.Transform = m;
            //g.TranslateTransform(350, 30);
            FillRectangle();
            g.Dispose();
        }
    }
}
