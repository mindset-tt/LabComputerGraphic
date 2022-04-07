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

namespace LabComputerGraphic.Week2
{
    public partial class Week2_Lab : Form
    {
        Graphics g;
        Pen p; //pen
        Color c;
        int ps; //pen size
        float ts; //tension
        Brush b;

        public Week2_Lab()
        {

            InitializeComponent();
            ps = (int)(numericUpDown1.Value);
            c = Color.Black;
            ts = 2.0f;
        }
        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            p = new Pen(c, ps);
            Point p1 = new Point(100, 100); Point p2 = new Point(50, 50);
            Point p3 = new Point(25, 75); Point p4 = new Point(100, 200);
            Point p5 = new Point(175, 75); Point p6 = new Point(150, 50);
            Point[] ptAr = { p1, p2, p3, p4, p5, p6 };
            //g.DrawLines(p, ptAr); //Lines
            //g.FillPolygon(Brushes.Orange, ptAr);
            //g.DrawPolygon(p, ptAr); //Polygon
            //g.DrawCurve(p, ptAr); //Curve
            //g.DrawCurve(p, ptAr, ts);
            g.FillClosedCurve(Brushes.Orange, ptAr, FillMode.Alternate, ts);
            g.DrawClosedCurve(p, ptAr, ts, FillMode.Alternate);
            g.Dispose();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            p = new Pen(c, ps);
            Point p1 = new Point(100, 100); Point p2 = new Point(50, 50);
            Point p3 = new Point(25, 75); Point p4 = new Point(100, 200);
            Point p5 = new Point(175, 75); Point p6 = new Point(150, 50);
            Point[] ptAr = { p1, p2, p3, p4, p5, p6 };
            //g.DrawLines(p, ptAr); //Lines
            //g.FillPolygon(Brushes.Orange, ptAr);
            //g.DrawPolygon(p, ptAr); //Polygon
            //g.DrawCurve(p, ptAr); //Curve
            //g.DrawCurve(p, ptAr, ts);
            g.FillClosedCurve(Brushes.Orange, ptAr, FillMode.Alternate, ts);
            g.DrawClosedCurve(p, ptAr, ts, FillMode.Alternate);
            g.Dispose();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.Clear(Color.WhiteSmoke);
            g.Dispose();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            ps = (int)(numericUpDown1.Value);
            Invalidate();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog clr = new ColorDialog();
            if (clr.ShowDialog() == DialogResult.OK)
            {
                c = clr.Color;
                btnColor.BackColor = clr.Color;
                Invalidate();
            }
        }
    }

}
