using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pool_3.Algorithms;

namespace Pool_3.Services
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
            algorithms.Add(new SumAlgorithm());
            algorithms.Add(new FindKAlgorithm());
            algorithms.Add(new MinMaxAlgorithm());
            algorithms.Add(new CountMinMaxAlgorithm());
            algorithms.Add(new InsertValueAlgorithm());
        }

        public List<Algorithm> GetAlgorithms()
        {
            return algorithms;
        }
    }
}
