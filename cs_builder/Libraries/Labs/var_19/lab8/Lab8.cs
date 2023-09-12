using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_builder.Libraries.Labs.var_19.lab8
{
    internal static class Lab8
    {
        [STAThread]
        public static void lab8_main()
        {
            Thread WFThread = new Thread(form_activator);
            WFThread.Start();
            WFThread.Join();
        }

        public static void form_activator()
        {
            Form_8 form = new Form_8();

            form.Show();

            Application.Run(form);
        }
    }
}
