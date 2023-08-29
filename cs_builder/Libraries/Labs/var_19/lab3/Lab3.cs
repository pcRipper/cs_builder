using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_builder.Libraries.Labs.var_19.lab3
{
    internal static class Lab3
    {
        [STAThread]
        public static void lab3_main()
        {
            Thread WFThread = new Thread(form_activator);

            WFThread.SetApartmentState(ApartmentState.STA);
            WFThread.Start();
            WFThread.Join();
        }

        public static void form_activator()
        {
            Form1 form = new Form1();
            
            form.Show();
            
            Application.Run(form);
        }
    }
}
