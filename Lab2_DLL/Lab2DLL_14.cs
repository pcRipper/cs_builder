using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab2DLL
{
    public static class Functions
    {
        public static object RemoveAt<T>(ref ArrayList container,int index)
        {
            if (index < 0 || container.Count <= index) return default(T);
            T result = (T)container[index];
            container.RemoveAt(index);
            return result;
        }

        public static void Show<T>(ref ICollection container,string sepparator)
        {
            if (container.Count == 0) {
                Console.WriteLine("{ empty }");
                return;
            }

            Console.Write($"{container.Count} : " + "{");

            var iterator = container.GetEnumerator();
            iterator.MoveNext();
            for(int i = 1; i < container.Count; i++) {
                Console.Write($"{iterator.Current.ToString()}{sepparator}");
                iterator.MoveNext();
            }

            Console.WriteLine($"{iterator.Current}" + "}");
        }
    }
}
