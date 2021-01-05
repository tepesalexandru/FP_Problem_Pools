using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pool_2.Algorithms;

namespace Pool_2.Services
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
            algorithms.Add(new EvenCountAlgorithm());
            algorithms.Add(new NegativePositiveAlgorithm());
            algorithms.Add(new SumAndProductAlgorithm());
            algorithms.Add(new FindNumberAlgorithm());
            algorithms.Add(new EqualToPosAlgorithm());
            algorithms.Add(new AscendingSequenceAlgorithm());
            algorithms.Add(new MinMaxAlgorithm());
            algorithms.Add(new FibonacciAlgorithm());
            algorithms.Add(new MonotoneSequenceAlgorithm());
            algorithms.Add(new MaxEqualSequenceAlgorithm());
        }

        public List<Algorithm> GetAlgorithms()
        {
            return algorithms;
        }
    }
}
