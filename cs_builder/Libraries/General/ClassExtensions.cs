using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    static class Extensions
    {
        public static string encodeMD5(string data)
        {
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(data);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                return Convert.ToHexString(hashBytes);
            }
        }
        private static UInt16[] getColumnLengths(this DataTable table)
        {
            UInt16[] result = new UInt16[table.Columns.Count];

            for(int k = 0;k < result.Length; k++)
            {
                int res = table.Columns[k].ColumnName.Length;
                for (int j = 0; j < table.Rows.Count;j++) res = Math.Max(res,table.Rows[j][k].ToString().Length);
                result[k] = Convert.ToUInt16(res); 
            }

            return result;
        }
        public static void Show(this DataTable table)
        {
            UInt16[] cLenghts = table.getColumnLengths();
            int rows_count = table.Rows.Count;
            string horizontal_border = $"+{Repeat("-", rows_count.ToString().Length)}+";
            string header = $"|{Repeat("#",rows_count.ToString().Length)}|";

            for(int k = 0;k < cLenghts.Length; k++)
            {
                horizontal_border += $"{Repeat("-", cLenghts[k])}+";
                header += String.Format("{0,"+ cLenghts[k].ToString() +"}|", table.Columns[k].ColumnName);
            }

            Console.Write($"{horizontal_border}\n{header}\n{horizontal_border}\n");

            for (int k = 0; k < rows_count; k++)
            {
                Console.Write(String.Format("|{0,"+rows_count.ToString().Length+"}|",k));
                for(int j = 0;j < cLenghts.Length; j++)
                {
                    Console.Write(String.Format("{0,"+cLenghts[j]+"}|",table.Rows[k][j].ToString()));
                }
                Console.WriteLine("\n"+horizontal_border);
            }

        }

        public static string Repeat(this string left,int times)
        {
            string result = String.Empty;
            for(uint k = 0;k < times; k++)
            {
                result += left;
            }
            return result;
        }
        public static string Trim(this string text, string erase_symbols)
        {
            foreach (char c in erase_symbols) text = text.Replace(c.ToString(), "");
            return text;
        }

        public static void Show<T>(this List<T> list)
        {
            Console.Write($"{list.Count} : ");
            foreach (T item in list)
            {
                Console.Write($"{item}, ");
            }
            Console.Write($"\b\b;\n");
        }

        public static ICollection<ReturnType> MapOn<ReturnType, ContainerType>(this ICollection<ContainerType> list,Func<ContainerType, ReturnType> transform)
        {
            ICollection<ReturnType> result = (ICollection<ReturnType>)Activator.CreateInstance(list.GetType());

            foreach (ContainerType item in list)
            {
                result.Add(transform(item));
            }

            return result;
        }

        public static void MapIn<ContainerType>(this ICollection<ContainerType> list,Func<ContainerType, ContainerType> transform)
        {
            list = MapOn<ContainerType, ContainerType>(list, transform);   
        }

        public static void Show<T>(this T[] array)
        {
            Console.Write($"{array.Length} : ");
            foreach (T item in array)
            {
                Console.Write($"{item}, ");
            }
            Console.Write($"\b\b;\n");
        }

        public static int pair_comparer(KeyValuePair<char, int> left, KeyValuePair<char, int> right)
        {
            return left.Value.CompareTo(right.Value);
        }

        public static int find_key(KeyValuePair<char, int> left, KeyValuePair<char, int> right)
        {
            if (left.Key == right.Key) return 0;
            return 1;
        }

        static public ReturnType Fold<InputType, ReturnType>(this IEnumerable container, Func<ReturnType, InputType, ReturnType> func)
        {
            ReturnType accumulator = default(ReturnType);
            foreach (InputType item in container)
            {
                accumulator = func(accumulator, item);
            }
            return accumulator;
        }

    }
}
