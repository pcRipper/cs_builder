using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace cs_builder.Libraries.Labs.var_9.lab3
{
    interface Drawable
    {
        public void Draw(ref PictureBox pictureBox, params object[] values);
    }
    internal class Polygon : Drawable
    {
        public static int Count { get; set; }
        private int x;
        private int y;

        public Polygon(int x = 0,int y = 0)
        {
            this.y = y;
            this.x = x;
        }

        public void Draw(ref PictureBox pictureBox, params object[] values)
        {
            
            int N = values.Length > 0 ? Math.Max(3,(int)values[0]) : 3;
            Random c = new Random();
            Bitmap bitmap = new Bitmap(pictureBox.Image);
            Graphics g = Graphics.FromImage(bitmap);
            Pen pen = new Pen(Color.FromArgb(255, c.Next(0, 255), c.Next(0, 255), c.Next(0, 255)), 2);
            int
                radius = 100,
                sX = 10, sY = 15,
                currentY = sY + radius,
                currentX = sX;
            double
                RadianCoof = 57.29577951326093,
                rotateAngle = 360.0 / N,
                currentAngle = 90 - (180 - rotateAngle) / 2,
                sideLength = Math.Sqrt(2 * Math.Pow(radius, 2) - 2 * Math.Pow(radius, 2) * Math.Cos(rotateAngle / RadianCoof));


            for (int k = 0, x, y; k < N; k++, currentAngle += rotateAngle)
            {
                x = currentX;
                currentX += Convert.ToInt32(Math.Sin(currentAngle / RadianCoof) * sideLength);
                y = currentY;
                currentY += Convert.ToInt32(Math.Cos(currentAngle / RadianCoof) * sideLength);

                g.DrawLine(pen, new Point(x + this.x, y + this.y), new Point(sY + radius + this.x, sY + radius + this.y));
                g.DrawLine(pen, new Point(x + this.x, y + this.y), new Point(currentX + this.x, currentY + this.y));
            }

            ++Polygon.Count;
            pictureBox.Image = bitmap;
        }
    }
}
