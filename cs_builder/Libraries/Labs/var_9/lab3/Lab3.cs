using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_builder.Libraries.Labs.var_9.lab3
{
    internal static class Lab3
    {
        static Thread WFThread;
        [STAThread]
        public static void lab3_main()
        {
            WFThread = new Thread(form_activator);
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
