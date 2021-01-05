using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_2
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
    }
}
