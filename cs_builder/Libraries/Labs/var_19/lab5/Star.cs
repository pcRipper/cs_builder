using System;
using System.Collections.Generic;
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
    internal class Star : Drawable
    {
        double a;
        double b;

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
            
        }
    }
}
