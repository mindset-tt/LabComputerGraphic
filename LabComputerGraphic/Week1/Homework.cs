using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Threading;

namespace LabComputerGraphic.Week1
{
    public partial class Homework : Form
    {
        double a = 0.0;
        double angle;
        Random ram = new Random();//this object is going to be used to the color
        bool auto = false;

        public Homework()
        {
            InitializeComponent();
        }

        private void Homework_Resize(object sender, EventArgs e)
        {
            Invalidate();
            this.Refresh();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Point[] apt = new Point[10];
            for (int i = 0; i < apt.Length; i++)
            {
                angle = ((i * 0.8 - 0.5) * Math.PI) + a;
                apt[i] = new Point(
                    (int)(ClientSize.Width * (0.5 + 0.48 * Math.Cos(angle))), 
                    (int)(ClientSize.Height * (0.5 + 0.48 * Math.Sin(angle))));
            }
            PathGradientBrush brocha = new PathGradientBrush(apt);
            brocha.CenterColor = Color.Chocolate;
            brocha.SurroundColors = new Color[10] { 
                Color.FromArgb(ram.Next(256), 
                ram.Next(256), ram.Next(256)), 
                Color.FromArgb(ram.Next(256), 
                ram.Next(256), ram.Next(256)), 
                Color.FromArgb(ram.Next(256), 
                ram.Next(256), ram.Next(256)), 
                Color.FromArgb(ram.Next(256), 
                ram.Next(256), ram.Next(256)), 
                Color.FromArgb(ram.Next(256), 
                ram.Next(256), ram.Next(256)),
                Color.FromArgb(ram.Next(256),
                ram.Next(256), ram.Next(256)),
                Color.FromArgb(ram.Next(256),
                ram.Next(256), ram.Next(256)),
                Color.FromArgb(ram.Next(256),
                ram.Next(256), ram.Next(256)),
                Color.FromArgb(ram.Next(256),
                ram.Next(256), ram.Next(256)),
                Color.FromArgb(ram.Next(256),
                ram.Next(256), ram.Next(256))};
            Graphics g = this.CreateGraphics();
            // RECTANGLE WITH FILLER DEGRADED
            Rectangle rect = new Rectangle(0, 0, ClientSize.Width, ClientSize.Height);
            LinearGradientBrush lBrush = new LinearGradientBrush(rect, Color.FromArgb(
                ram.Next(256), 
                ram.Next(256), 
                ram.Next(256)), 
                Color.FromArgb(
                    ram.Next(256), 
                    ram.Next(256), 
                    ram.Next(256)), 
                LinearGradientMode.Vertical);
            g.FillRectangle(lBrush, rect);
            g.FillRectangle(brocha, 0, 0, ClientSize.Width, ClientSize.Height);
            Thread.Sleep(200);
            a += 45;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (auto == false)
            {
                timer1.Enabled = true;
                auto = true;
            }
            else
            {
                auto = false;
                timer1.Enabled = false;
            }
        }
    }
}
