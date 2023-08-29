using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_builder.Libraries.Labs.var_14.lab3
{
    internal static class Lab3
    {
        [STAThread]
        public static void lab3()
        {
            Thread thread = new Thread(form_activator);

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join();
        }

        public static void form_activator()
        {
            Form_Drawer form = new Form_Drawer();
            form.Show();
            Application.Run(form);
        }
    }
}
