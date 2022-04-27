using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabComputerGraphic.Week6
{
    public partial class Week6_2 : Form
    {
        Rectangle SelectRect = new Rectangle();
        Point ps = new Point();
        Point pe = new Point();
        Graphics g;
        public Week6_2()
        {
            InitializeComponent();
            radioButton1.Checked = true;
            radioButton2.Checked = false;

        }

        private void Week6_2_MouseDown(object sender, MouseEventArgs e)
        {
            SelectRect.Width = 0;
            SelectRect.Height = 0;
            SelectRect.X = e.X;
            SelectRect.Y = e.Y;

            ps.X = e.X;
            ps.Y = e.Y;
            pe = ps;

        }

        private void Week6_2_MouseUp(object sender, MouseEventArgs e)
        {
            Form thisform = (Form)sender;
            Pen p = new Pen(Color.Blue, 2);
            if (radioButton1.Checked)
            {
                ControlPaint.DrawReversibleLine(thisform.PointToScreen(ps), thisform.PointToScreen(pe), Color.Black);
                g.DrawLine(p, ps, pe);
            }
            else
            {
                ControlPaint.DrawReversibleFrame(thisform.RectangleToScreen(SelectRect), Color.Black, FrameStyle.Dashed);
                g.DrawRectangle(p, SelectRect);
            }
            g.Dispose();

        }

        private void Week6_2_MouseMove(object sender, MouseEventArgs e)
        {
            Form thisform = (Form)sender;
            g = this.CreateGraphics();
            if (e.Button == MouseButtons.Left)
            {
                if (radioButton1.Checked)
                {
                    ControlPaint.DrawReversibleLine(thisform.PointToScreen(ps), thisform.PointToScreen(pe), Color.Black);
                    pe = new Point(e.X, e.Y);
                    ControlPaint.DrawReversibleLine(thisform.PointToScreen(ps), thisform.PointToScreen(pe), Color.Black);
                }
                else
                {
                    ControlPaint.DrawReversibleFrame(thisform.RectangleToScreen(SelectRect), Color.Black, FrameStyle.Dashed);
                    SelectRect.Width = e.X - SelectRect.X;
                    SelectRect.Height = e.Y - SelectRect.Y;
                    ControlPaint.DrawReversibleFrame(thisform.RectangleToScreen(SelectRect), Color.Black, FrameStyle.Dashed);
                }
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                radioButton2.Checked = false;
            else
                radioButton2.Checked = true;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
                radioButton1.Checked = false;
            else
                radioButton1.Checked = true;
        }
    }
}
