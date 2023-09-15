using cs_builder.Libraries.Labs.var_19.lab8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs_builder.Libraries.Labs.var_19.lab5
{
    internal static class Lab5
    {
        [STAThread]
        public static void lab5_main()
        {
            Thread WFThread = new Thread(form_activator);
            WFThread.Start();
            WFThread.Join();
        }

        public static void form_activator()
        {
            Form_5 form = new Form_5();
            
            form.Show();
            
            Application.Run(form);
        }
    }
}
