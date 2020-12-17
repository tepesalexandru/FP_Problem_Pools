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
            algorithms.Add(new LinearEquation());
            algorithms.Add(new LinearEquation());
        }

        public List<Algorithm> GetAlgorithms()
        {
            return algorithms;
        }
    }
}
