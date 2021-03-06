﻿using System;
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
            algorithms.Add(new DeleteKAlgorithm());
            algorithms.Add(new ReverseArrayAlgorithm());
            algorithms.Add(new RotateAlgorithm());
            algorithms.Add(new RotateKTimesAlgorithm());
            algorithms.Add(new BinarySearchAlgorithm());
            algorithms.Add(new ErathostenesAlgorithm());
            algorithms.Add(new SelectionSortAlgorithm());
            algorithms.Add(new InsertionSortAlgorithm());
            algorithms.Add(new MoveZerosAlgorithm());
            algorithms.Add(new DeleteDuplicatesAlgorithm());
            algorithms.Add(new ArrayGCDAlgorithm());
            algorithms.Add(new MergeAlgorithm());
            algorithms.Add(new IndexAlgorithm());
            algorithms.Add(new QuickSortAlgorithm());
            algorithms.Add(new MergeSortAlgorithm());
            algorithms.Add(new DoubleSortAlgorithm());
            algorithms.Add(new MajorityElementAlgorithm());
        }

        public List<Algorithm> GetAlgorithms()
        {
            return algorithms;
        }
    }
}
