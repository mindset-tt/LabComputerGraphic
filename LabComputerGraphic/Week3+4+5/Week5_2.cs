using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabComputerGraphic.Week3_4_5
{
    public partial class Week5_2 : Form
    {
        public Week5_2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.WhiteSmoke);
            Bitmap bmp = new Bitmap(Image.FromFile("C:/Users/khamp/Source/Repos/LabComputerGraphic/LabComputerGraphic/Pic/edge.png"), int.Parse(txtW.Text), int.Parse(txtH.Text));
            g.DrawImage(bmp, 10, 12);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            //g.Clear(Color.WhiteSmoke);
            Bitmap bmp = new Bitmap(Image.FromFile("C:/Users/khamp/Source/Repos/LabComputerGraphic/LabComputerGraphic/Pic/edge.png"), int.Parse(txtW.Text), int.Parse(txtH.Text));
            bmp.RotateFlip(RotateFlipType.RotateNoneFlipX);
            g.DrawImage(bmp, 10, 270);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            //g.Clear(Color.WhiteSmoke);
            Bitmap bmp = new Bitmap(Image.FromFile("C:/Users/khamp/Source/Repos/LabComputerGraphic/LabComputerGraphic/Pic/edge.png"), int.Parse(txtW.Text), int.Parse(txtH.Text));
            bmp.RotateFlip(RotateFlipType.RotateNoneFlipY);
            g.DrawImage(bmp, 10, 270);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            //g.Clear(Color.WhiteSmoke);
            Bitmap bmp = new Bitmap(Image.FromFile("C:/Users/khamp/Source/Repos/LabComputerGraphic/LabComputerGraphic/Pic/edge.png"), int.Parse(txtW.Text), int.Parse(txtH.Text));
            bmp.RotateFlip(RotateFlipType.RotateNoneFlipXY);
            g.DrawImage(bmp, 10, 270);

        }
    }
}
