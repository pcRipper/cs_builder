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
        }

        private void Draw_Click(object sender, EventArgs e)
        {
            var figure = new Polygon(Convert.ToInt32(textBox_posX.Text), Convert.ToInt32(textBox_posY.Text));
            figure.Draw(pictureBox1, (object)Convert.ToInt32(textBox_SidesAmount.Text));
        }
    }
}
