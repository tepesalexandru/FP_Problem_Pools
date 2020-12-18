using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_1.Algorithms
{
    class FractionAlgorithm : Algorithm
    {
        decimal m, n;
        public override void Compute()
        {
            decimal FractionalPart(decimal n)
            {
                return n - (int)n;
            }

            int IntegerPart(decimal n)
            {
                return (int)n;
            }
            void PrintDecimalConversion(decimal n, int b)
            {
                Dictionary<decimal, int> repeatingDecimals = new Dictionary<decimal, int>();
                List<char> decimals = new List<char>();
                bool infinite = false;
                int idx = 0;
                repeatingDecimals[n] = 1;
                if (FractionalPart(n) > 0) Console.Write(".");
                string HEX = "0123456789ABCDEF";
                while (FractionalPart(n) != 0.0M)
                {
                    n = n * b;
                    decimals.Add(HEX[IntegerPart(n)]);
                    n = n - IntegerPart(n);

                    try
                    {
                        if (repeatingDecimals[n] != null)
                        {
                            infinite = true;

                            decimals.Insert(repeatingDecimals[n] - 1, '(');
                            decimals.Add(')');
                            break;
                        }
                    }
                    catch (Exception)
                    {
                        repeatingDecimals[n] = idx;
                        idx++;
                    }

                }

                int i = 0;
                for (i = 0; i < decimals.Count; i++)
                {
                    Console.Write(decimals[i]);
                }
            }
            PrintDecimalConversion(FractionalPart(m / n), 10);
        }

        public override void DisplayAnswer()
        {
           
        }

        public override void ReadInput()
        {
            m = Helper.ReadInt("m");
            n = Helper.ReadInt("n");
        }
    }
}
