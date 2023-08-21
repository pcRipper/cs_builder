using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs_builder.Libraries.Labs.var_9.lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Clear_Click(null, null);
        }

        private void Draw_Click(object sender, EventArgs e)
        {
            var figure = new Polygon(Convert.ToInt32(textBox_posX.Text), Convert.ToInt32(textBox_posY.Text));
            figure.Draw(ref pictureBox1, (object)Convert.ToInt32(textBox_SidesAmount.Text));
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Polygon.Count = 0;
            Bitmap bitmap = (Bitmap)pictureBox1.Image;
            Graphics g = Graphics.FromImage(bitmap);
            g.Clear(Color.White);
            pictureBox1.Image = bitmap;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            label5.Text = $"{Polygon.Count} polygons";
        }
    }
}
