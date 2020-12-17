using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pool_1.Algorithms;

namespace Pool_1.Services
{
    class AlgorithmsService
    {
        List<Algorithm> algorithms;
        public AlgorithmsService()
        {
            this.algorithms = new List<Algorithm>();
            GenerateAlgorithms();
        }

        private void GenerateAlgorithms()
        {
            algorithms.Add(new LinearEquationAlgorithm());
            // Change this in the future
            algorithms.Add(new LinearEquationAlgorithm());
            algorithms.Add(new DivisorAlgorithm());
            algorithms.Add(new LeapYearAlgorithm());
            algorithms.Add(new AuxSwapAlgorithm());
            algorithms.Add(new SwapAlgorithm());
            algorithms.Add(new DivisorsAlgorithm());
            algorithms.Add(new IsPrimeAlgorithm());
            algorithms.Add(new InverseDigitsAlgorithm());
            algorithms.Add(new DivislbeRangeAlgorithm());
            algorithms.Add(new LeapYearRangeAlgorithm());
            algorithms.Add(new PalindromeAlgorithm());
        }

        public List<Algorithm> GetAlgorithms()
        {
            return algorithms;
        }
    }
}
