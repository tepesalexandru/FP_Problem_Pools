using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_1.Algorithms
{
    class BinarySearchAlgorithm : Algorithm
    {
        int guess;
        public override void Compute()
        {
            void BinarySearch(int low, int high)
            {
                int mid = (low + high) / 2;
                guess = mid;
                Console.WriteLine($"Was your guess {guess}?");
                Console.WriteLine($"Press 1 your number is lower, 2 if I have guessed, press 3 if it's higher.");
                int response = Helper.ReadInt("response");
                if (response == 1)
                {
                    BinarySearch(low, mid - 1);
                } else if (response == 3)
                {
                    BinarySearch(mid + 1, high);
                }
            }
            BinarySearch(1, 1024);
            
        }

        public override void DisplayAnswer()
        {
            Console.Write($"Answer: {guess}");
        }

        public override void ReadInput()
        {
            
        }
    }
}
