using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace cs_builder.Libraries.Labs.var_14.lab3
{
    internal class Rhombus 
    {
        public static int ObjectsCount { get; set; }
        private int a;
        private int b;

        public Rhombus(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public void Draw(ref PictureBox pictureBox, int x,int y)
        {
            Random random = new Random();
            Bitmap bitmap = new Bitmap(pictureBox.Image);
            Graphics g = Graphics.FromImage(bitmap);
            Pen pen = new Pen(Color.FromArgb(255, random.Next(0, 255), random.Next(0, 255), random.Next(0, 255)), 2);

            int c = (int)Math.Sqrt(Math.Pow(this.a,2) - (Math.Pow(this.b,2)/4));

            g.DrawPolygon(pen,new Point[4] {
                new Point(x + b/2,y),
                new Point(x + b,y + c),
                new Point(x + b/2,y + 2*c),
                new Point(x,y+c)
            });

            pictureBox.Image = bitmap;
        }
    }
}
