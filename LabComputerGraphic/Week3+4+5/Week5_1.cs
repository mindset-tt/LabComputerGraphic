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
    public partial class Week5_1 : Form
    {
        public Week5_1()
        {
            InitializeComponent();
        }
        Graphics g;
        private void Week5_1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Bitmap bmp = new Bitmap("C:/Users/khamp/Source/Repos/LabComputerGraphic/LabComputerGraphic/Pic/edge.png");
            Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            g.DrawImage(bmp, rect, rect, GraphicsUnit.Pixel);
            g.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            Bitmap bmp = new Bitmap("C:/Users/khamp/Source/Repos/LabComputerGraphic/LabComputerGraphic/Pic/edge.png");
            int width = bmp.Width;
            int height = bmp.Height;
            g.InterpolationMode = InterpolationMode.Bicubic;
            g.DrawImage(bmp, new Rectangle(0, 0, width * 4, height * 4), new Rectangle(0, 0, width, height), GraphicsUnit.Pixel);
            g.Dispose();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            Bitmap bmp = new Bitmap("C:/Users/khamp/Source/Repos/LabComputerGraphic/LabComputerGraphic/Pic/edge.png");
            int width = bmp.Width;
            int height = bmp.Height;
            g.InterpolationMode = InterpolationMode.Bicubic;
            //Format g.DrawingImage(Image image,Rectangle destRect, Rectangle srcRect,GraphicsUnit srcUnit)
            g.DrawImage(bmp, new Rectangle(0, 0, width * 4, height * 4), new Rectangle(0, 0, width, height), GraphicsUnit.Pixel);
            g.Dispose();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            Bitmap bmp = new Bitmap("C:/Users/khamp/Source/Repos/LabComputerGraphic/LabComputerGraphic/Pic/edge.png");
            int width = bmp.Width;
            int height = bmp.Height;
            g.InterpolationMode = InterpolationMode.Bilinear;
            g.DrawImage(bmp, new Rectangle(0, 0, width * 4, height * 4), new Rectangle(0, 0, width, height), GraphicsUnit.Pixel);
            g.Dispose();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.Clear(Color.WhiteSmoke);
            g.Dispose();

        }
    }
}
