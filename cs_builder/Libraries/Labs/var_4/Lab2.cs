using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace cs_builder.Libraries.Labs.var_4
{
    internal class Lab2
    {
        public static void lab2_main()
        {
            const string DLL_PATH = "E:\\TEMP_BACKUP\\code\\cs\\cs_builder\\Lab2_DLL\\bin\\Debug\\Lab2_DLL.dll";
            
            ArrayList data = new ArrayList() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            try
            {
                //load dll into RAM
                Assembly assembly = Assembly.LoadFrom(DLL_PATH);
                //initializing type
                Type Functions = assembly.GetType("Lab2DLL.Functions");

                //Loading generic RemoveAt function
                MethodInfo RemoveAt = Functions.GetMethod("RemoveAt");
                //Loading method for Int type
                MethodInfo RemoveAtInt = RemoveAt.MakeGenericMethod(typeof(int));
                //Loading generic method Show
                MethodInfo Show = Functions.GetMethod("Show");
                //creating method for Int type
                MethodInfo ShowInt = Show.MakeGenericMethod(typeof(int));


                Console.WriteLine("Container before operatrion :");
                ShowInt.Invoke(null, new object[] { data, ", " });
                var result = RemoveAtInt.Invoke(null, new object[] { data, 5 });
                Console.WriteLine("Container after operation :");
                ShowInt.Invoke(null,new object[] { data, ", " });
                Console.WriteLine($"excluded element : {result.ToString()}");


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
