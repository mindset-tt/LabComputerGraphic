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

namespace LabComputerGraphic.Week6
{
    public partial class Week6_1 : Form
    {
        private PointF[] Points = new PointF[4];
        private int NextPoint = 0;
        Graphics g; Pen p; int ps;
        Bitmap bmp; SolidBrush b;
        public Week6_1()
        {
            InitializeComponent();
            ps = 2;
            b = new SolidBrush(Color.Violet);
            p = new Pen(b.Color, ps);
            button2.BackColor = ((SolidBrush)b).Color;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (NextPoint > 3) NextPoint = 0;
            // Save this point.
            Points[NextPoint].X = e.X;
            Points[NextPoint].Y = e.Y;

            NextPoint++;
            pictureBox1.Refresh();

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(pictureBox1.BackColor);
            if (NextPoint >= 4)
            {
                p = new Pen(b, ps);
                g.DrawBezier(p,
                    Points[0], Points[1], Points[2], Points[3]);
            }

            // Draw the control points.
            for (int i = 0; i < NextPoint; i++)
            {
                g.FillRectangle(Brushes.White,
                    Points[i].X - 3, Points[i].Y - 3, 6, 6);
                g.DrawRectangle(Pens.Black,
                    Points[i].X - 3, Points[i].Y - 3, 6, 6);
            }
            e.Graphics.DrawImage(bmp, 0, 0);
            Invalidate();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog cld = new ColorDialog();
            if (cld.ShowDialog() == DialogResult.OK)
            {
                b = new SolidBrush(cld.Color);
                p = new Pen(b.Color, ps);
                button2.BackColor = ((SolidBrush)b).Color;
                pictureBox1.Refresh();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Title = "Save Bezier Curve";
            sf.DefaultExt = "*.jpeg";
            sf.Filter = "Jpeg Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|BMP Files(*.bmp)|*.bmp";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = bmp;
                pictureBox1.Image.Save(sf.FileName);
            }

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            ps = (int)numericUpDown1.Value;
            pictureBox1.Refresh();
        }
    }
}
