using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_builder.Libraries.Labs.var_14
{
    public delegate void Event();
    internal static class Lab4
    {
        public static void lab4()
        {
            var f1 = (double x) => 1 / Math.Pow(x*x+4,0.33333333);
            var f2 = (double x) => 1 / Math.Sqrt(x);
            var f3 = (double x) => Math.Cos(x);

            Console.WriteLine($"Rienmann for function 1/(x^2 + 4)^0.3 in range [-2,2] = {rienmann_sum(-2,2,100,f1)}");
            Console.WriteLine($"Rienmann for function 1/x^0.5 in range [1,33] = {rienmann_sum(1,33,5000,f2)}");
            Console.WriteLine($"Rienmann for function cos(x) in range [0,PI] = {rienmann_sum(0, Math.PI, 1000, f3)}");

            Event @event = () => { Console.WriteLine("\nBohdana"); };
            event_example(ConsoleKey.B, @event);
        }

        public static double rienmann_sum(double from,double to,int steps,Func<double,double> function)
        {
            steps = Math.Max(steps, 1);
            double sum = 0;
            double rectangle_width = (to - from) / steps;

            while(from < to)
            {
                sum += Math.Abs(function(from)) * rectangle_width;
                from += rectangle_width;
            }

            return sum;
        }

        public static void event_example(ConsoleKey trigger,Event @event)
        {
            const ConsoleKey exit_default = ConsoleKey.Z;
            ConsoleKeyInfo key = default(ConsoleKeyInfo);

            Console.Write("Input your text : ");
            do
            {
                key = Console.ReadKey();
            } while (key.Key != trigger && key.Key != exit_default);

            if (key.Key == trigger) @event.Invoke();
        }

    }
}
