using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_3.Algorithms
{
    class MajorityElementAlgorithm : Algorithm
    {
        int n, elementMajoritar;
        int[] arr;
        bool exista;
        public override void Compute()
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            int i;
            exista = false;
            for (i = 0; i < n; i++)
            {
                if (map.ContainsKey(arr[i]))
                {
                    int count;
                    map.TryGetValue(arr[i], out count);
                    map[arr[i]] = count + 1;
                    if (count + 1 > n / 2)
                    {
                        exista = true;
                        elementMajoritar = arr[i];
                    }
                } else
                {
                    map[arr[i]] = 1;
                }
            }
        }

        public override void DisplayAnswer()
        {
            if (exista)
            {
                Console.WriteLine($"Answer: The majority element is {elementMajoritar}");
            } else
            {
                Console.WriteLine($"Answer: The array does not contain a majority element.");
            }
        }

        public override void ReadInput()
        {
            n = Helper.ReadInt("n");
            arr = Helper.ReadIntArray(n);
        }
    }
}
