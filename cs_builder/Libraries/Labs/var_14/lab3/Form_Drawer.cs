using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs_builder.Libraries.Labs.var_14.lab3
{
    public partial class Form_Drawer : Form
    {
        public Form_Drawer()
        {
            InitializeComponent();
            pictureBox1.Image = new Bitmap(pictureBox1.Height, pictureBox1.Width);
            Clear_Click(null, null);
        }

        private void Draw_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(textBox4.Text);
                int b = Convert.ToInt32(textBox3.Text);

                if (a*2 <= b) throw new Exception("A cannot be less or equal B!");

                Rhombus rhombus = new Rhombus(a,b);

                rhombus.Draw(
                    ref pictureBox1,
                    Convert.ToInt32(textBox1.Text),
                    Convert.ToInt32(textBox2.Text)
                );

                ++Rhombus.ObjectsCount;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Rhombus.ObjectsCount = 0;
            Bitmap bitmap = (Bitmap)pictureBox1.Image;
            Graphics g = Graphics.FromImage(bitmap);
            g.Clear(Color.White);
            pictureBox1.Image = bitmap;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Draw.Text = $"Draw {Rhombus.ObjectsCount + 1}th";
        }
    }
}
