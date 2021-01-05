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
           
        }

        public List<Algorithm> GetAlgorithms()
        {
            return algorithms;
        }
    }
}
