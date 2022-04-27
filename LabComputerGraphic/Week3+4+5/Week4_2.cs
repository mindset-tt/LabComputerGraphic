using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace LabComputerGraphic.Week3_4_5
{
    public partial class Week4_2 : Form
    {
        Graphics g;
        Bitmap bmp = new Bitmap("C:/Users/khamp/Source/Repos/LabComputerGraphic/LabComputerGraphic/Pic/Bae_Suzy.png");

        public Week4_2()
        {
            InitializeComponent();
        }

        private void Week4_2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Rectangle rect = new Rectangle(0, 0, 150, 150);

            //ແຕ້ມຮູບອອກມາກຳນົດຂະໜາດເປັນ 150x150
            g.DrawImage(bmp, rect);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            /*Matrix m = new Matrix();
            m.Rotate(45);
            g.Transform = m;*/
            g.RotateTransform(45);
            g.DrawImage(bmp, new Rectangle(212, 0, 150, 150), 0, 0, bmp.Width, bmp.Height, GraphicsUnit.Pixel);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            /*Matrix m = new Matrix();
m.Scale(float.Parse(txtShx.Text), float.Parse(txtShy.Text),MatrixOrder.Prepend);
            g.Transform = m;*/
            g.ScaleTransform(float.Parse(txtShx.Text), float.Parse(txtShy.Text), MatrixOrder.Prepend);
            g.DrawImage(bmp, new Rectangle(112, 300, 150, 150), 0, 0, bmp.Width, bmp.Height, GraphicsUnit.Pixel);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.Clear(Color.WhiteSmoke);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();

            Matrix m = new Matrix();
            m.Shear(float.Parse(txtShx.Text), float.Parse(txtShy.Text));
            g.Transform = m;

            g.DrawImage(bmp, new Rectangle(0, 50, 150, 150), 0, 0,
                        bmp.Width, bmp.Height, GraphicsUnit.Pixel);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            /*Matrix m = new Matrix();
            m.Translate(int.Parse(txtX.Text),int.Parse(txtY.Text),MatrixOrder.Prepend);
            g.Transform = m;*/
            g.TranslateTransform(int.Parse(txtX.Text), int.Parse(txtY.Text), MatrixOrder.Prepend);
            g.DrawImage(bmp, new Rectangle(212, 0, 150, 150), 0, 0, bmp.Width, bmp.Height, GraphicsUnit.Pixel);

        }
    }
}
