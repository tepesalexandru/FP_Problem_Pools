using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_3
{
    public static class Helper
    {
        public static int ReadInt(string numberLabel)
        {
            Console.Write($"Enter the integer {numberLabel}: ");
            string input = Console.ReadLine();
            return Int32.Parse(input);
        }

        public static float ReadFloat(string numberLabel)
        {
            Console.Write($"Enter the float {numberLabel}: ");
            string input = Console.ReadLine();
            return float.Parse(input);
        }

        public static int[] ReadIntArray(int n)
        {
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = ReadInt($"arr[{i}]");
            }
            return arr;
        }
    }
}
