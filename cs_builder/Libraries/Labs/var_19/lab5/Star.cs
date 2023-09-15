using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_builder.Libraries.Labs.var_19.lab5
{
    interface Drawable
    {
        public void Draw(ref PictureBox pictureBox, params object[] values);
    }


    [Serializable]
    public class Star : Drawable
    {
        public double a;
        public double b;

        public Star()
        {
            this.a = 0; 
            this.b = 0;
        }
        public Star(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public void Draw(ref PictureBox pictureBox, params object[] values)
        {
            const double square_size = 20;
            const double spike_length = 80;

            Random c = new Random();
            Bitmap bitmap = new Bitmap(pictureBox.Image);
            Graphics g = Graphics.FromImage(bitmap);
            Pen pen = new Pen(Color.FromArgb(255, c.Next(0, 255), c.Next(0, 255), c.Next(0, 255)), 2);
            double scale = values.Length > 0 ? (double)values[0] : 1d;

            int square = (int)(square_size * scale);
            int spike = (int)(spike_length * scale);
            int startY = (bitmap.Height - square) / 2;
            int startX = (bitmap.Width - square) / 2;

            g.Clear(Color.White);

            g.DrawPolygon(pen, new Point[] {
                new Point(startX,startY),
                new Point(startX + square/2, startY - spike),
                new Point(startX + square,startY),
                new Point(startX + square + spike,startY + square/2),
                new Point(startX + square,startY + square),
                new Point(startX + square/2,startY + square + spike),
                new Point(startX,startY+square),
                new Point(startX - spike,startY + square /2)
            });

            pictureBox.Image = bitmap;
        }
    }
}
