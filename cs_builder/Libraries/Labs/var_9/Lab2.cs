using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace cs_builder.Libraries.Labs.var_9
{
    static class Lab2
    {
        public static void lab2_main()
        {
            const string DLL_PATH = "E:\\TEMP_BACKUP\\code\\cs\\cs_builder\\Lab2_DLL\\bin\\Debug\\Lab2_DLL.dll";
            var list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 99, -101 };
            var predicate = (int x, int y) => x < y;

            try
            {
                //load dll into RAM
                Assembly assembly = Assembly.LoadFrom(DLL_PATH);
                //initializing type
                Type Lab2Functions = assembly.GetType("Lab2DLL.Lab2DllFunctions");

                //Generic MinMax
                MethodInfo GenericMinMax = Lab2Functions.GetMethod("MaxMin");
                //Int minMax
                MethodInfo IntMinMax = GenericMinMax.MakeGenericMethod(typeof(int));

                var result = IntMinMax.Invoke(null, new object[2] { list, predicate });
                if (result != null)
                {
                    (int min, int max) = (Tuple<int, int>)result;
                    Console.WriteLine($"Min and Max from the List : {min} and {max}");
                }

                //toHex function
                MethodInfo asHex = Lab2Functions.GetMethod("asHex");

                result = asHex.Invoke(null, new object[2] { 212.32, 20 });
                if (result != null)
                {
                    Console.WriteLine($"212.32 in base 10 = {(string)result} in base 16");
                }



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
