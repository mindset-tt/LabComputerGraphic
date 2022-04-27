using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabComputerGraphic.Week3_4_5
{
    public partial class Week3_Lab : Form
    {
        Graphics g;
        SolidBrush b;
        Pen p;
        Bitmap im, bmp;

        public Week3_Lab()
        {
            InitializeComponent();
            b = new SolidBrush(Color.Orange);
            btnColor.BackColor = ((SolidBrush)b).Color;
            p = new Pen(b.Color, 3);
            im = new Bitmap("C:/Users/khamp/Source/Repos/LabComputerGraphic/LabComputerGraphic/Pic/Sanook_HAN-SO-HEE-2.jpg");

        }

        private void cmdLine_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmdLine.SelectedItem == "Dash")
            {
                p.DashStyle = DashStyle.Dash;
                pictureBox1.Refresh();
            }
            if (cmdLine.SelectedItem == "DashDot")
            {
                p.DashStyle = DashStyle.DashDot;
                pictureBox1.Refresh();
            }
            if (cmdLine.SelectedItem == "DashDotDot")
            {
                p.DashStyle = DashStyle.DashDotDot;
                pictureBox1.Refresh();
            }
            if (cmdLine.SelectedItem == "Solid")
            {
                p.DashStyle = DashStyle.Solid;
                pictureBox1.Refresh();
            }

        }

        private void Week3_Lab_Load(object sender, EventArgs e)
        {
            cmdLine.Items.Add("Dash");
            cmdLine.Items.Add("DashDot");
            cmdLine.Items.Add("DashDotDot");
            cmdLine.Items.Add("Solid");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Title = "Save Drawed Image";
            sf.DefaultExt = "*.jpg";
            sf.Filter = "Jpeg Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|BNP Files(*.bmp)|*.bmp";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                bmp.Save(sf.FileName);
            }

        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog clr = new ColorDialog();
            if (clr.ShowDialog() == DialogResult.OK)
            {
                btnColor.BackColor = clr.Color;
                b = new SolidBrush(clr.Color);
                p = new Pen(clr.Color, 3);
                pictureBox1.Invalidate();
            }

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.DrawImage(im, 10, 10, 200, 200);
            g.DrawRectangle(p, 10, 10, 200, 200);
            e.Graphics.DrawImage(bmp, 0, 0);
            //pictureBox1.Image = bmp;
            g.Dispose();
            Invalidate();

        }
    }
}
