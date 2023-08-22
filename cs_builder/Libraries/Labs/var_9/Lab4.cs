using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace cs_builder.Libraries.Labs.var_9
{
    internal static class Lab4
    {
        public static void lab4_main()
        {
            var func1 = (double x) => 1/(x*x);
            var func2 = (double x) => 1 / (x * x + 1);
            var func3 = (double x) => x;

            //Console.WriteLine($"Area under function[1/x^2] curve [2,10] = {integral(2,10,func1)}");
            //Console.WriteLine($"Area under function[1/(x^2 + 1)] curve [1,35] = {integral(1,35,func2)}");
            //Console.WriteLine($"Area under function[x] curve [-5,5] = {integral(0,1,func3)}");

            EventHandler handler = (sender, args) => { Console.WriteLine("\nMaksym"); };
            eventFunction(handler);
        }

        static double integral(double start, double finish, Func<double,double> func_var, UInt32 precision = 250)
        {
            precision = Math.Max(precision, 1);

            double res = 0;
            double step = (finish - start) / precision;
            
            while(start < finish)
            {
                res += Math.Abs(func_var(start)) * step;
                start += step;
            }

            return res;
        }

        static void eventFunction(EventHandler handler)
        {
            Console.Write("Your input : ");
            ConsoleKeyInfo key = default(ConsoleKeyInfo);
            do
            {
                key = Console.ReadKey();
            } while (key.Key != ConsoleKey.Q && key.Key != ConsoleKey.M);
            
            if(key.Key == ConsoleKey.M)handler?.Invoke(null,null);
        }

    }
}
