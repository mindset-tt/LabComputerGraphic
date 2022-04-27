﻿using System;
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
    public partial class Week5_4 : Form
    {
        public Week5_4()
        {
            InitializeComponent();
        }

        private void Week5_4_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Point[] LineA = { new Point(10, 10), new Point(150, 150), new Point(400, 10) };
            Point[] LineB = { new Point(10, 40), new Point(150, 180), new Point(400, 40) }; Point[] LineC = { new Point(10, 70), new Point(150, 210), new Point(400, 70) };
            Point[] LineD = { new Point(10, 100), new Point(150, 240), new Point(400, 100) };

            Pen pen = new Pen(Color.DarkOrange, 10);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            //Draw LineA
            pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
            g.DrawLines(pen, LineA);
            //Draw LineB
            pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Miter;
            g.DrawLines(pen, LineB);
            //Draw LineC
            pen.LineJoin = System.Drawing.Drawing2D.LineJoin.MiterClipped;
            g.DrawLines(pen, LineC);
            //Draw LineD
            pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Round;
            g.DrawLines(pen, LineD);

        }
    }
}
