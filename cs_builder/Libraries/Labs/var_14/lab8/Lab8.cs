using cs_builder.Libraries.Labs.var_14.lab3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_builder.Libraries.Labs.var_14.lab8
{
    internal class Lab8
    {
        [STAThread]
        public static void lab8()
        {
            Thread thread = new Thread(form_activator);

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join();
        }

        public static void form_activator()
        {
            Form_ADO form = new Form_ADO();
            form.Show();
            Application.Run(form);
        }
    }
}
