using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab2DLL
{
    //Функція, що визначає та по максимальний та елемент масиву
    //Функція, яка переводить число з шістнадцяткової системи в
    //десяткову(від 0 до 15). Параметром функції має бути символ від
    //‘0’до ‘F’ .
    public static class Lab2DllFunctions
    {
        private static string chars = "0123456789ABCDEF";
        public static Tuple<T,T> MaxMin<T>(IEnumerable<T> container, Func<T, T, bool> predicate)
        {
            if (container == null) return null;
            T min = container.First(),max = container.First();
            foreach(T t in container)
            {
                if (predicate(t, min)) min = t;
                else if (predicate(max, t)) max = t;
            }
            return new Tuple<T,T>(min,max);
        }

        public static string asHex(double num,int precision = 0)
        {
            char[] decimal_part = new char[(int)Math.Ceiling(Math.Log(num) / Math.Log(16))];
            int i = decimal_part.Length;
            int int_part = (int)num;
            num = num - (double)int_part;
            while(int_part > 0)
            {
                decimal_part[--i] = Lab2DllFunctions.chars[int_part % 16];
                int_part = int_part / 16;
            }
            
            string result = string.Empty;
            foreach (char c in decimal_part) result += c;

            if (num != 0) result += '.';
            double divisor = 1;
            while(precision-- > 0 && num != 0)
            {
                divisor /= 16;
                int index = (int)(num / divisor);
                result += Lab2DllFunctions.chars[index];
                num -= divisor * index;
            }

            return result;
        }
    }
}
