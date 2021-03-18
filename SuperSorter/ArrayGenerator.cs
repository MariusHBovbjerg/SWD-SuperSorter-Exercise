using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;

namespace SuperSorter
{
    class ArrayGenerator
    {

        public ArrayGenerator(int size, int max, int seed)
        {
            _size = size;
            _max = max;
            _seed = seed;
        }

        public void GenerateArray(int[] res, int[] values)
        {
            FewButRandomArray(res, values);
        }

        private void RandomizedArray(int[] arr)
        {
            var rand = new Random(_seed);

            for (int i = 0; i < _size; i++)
            {
                arr[i] = rand.Next(_max);

            }
        }

        private void ReversedArray(int[] arr)
        {
            var rand = new Random(_seed);

            for (int i = 0; i < _size; i++)
            {
                arr[i] = rand.Next(_max);

            }

            SuperSorter Sort = new SuperSorter();

            Sort.SortArray(arr);

            for (int i = 0; i < arr.Length / 2; i++)
            {
                int tmp = arr[i];
                arr[i] = arr[arr.Length - i - 1];
                arr[arr.Length - i - 1] = tmp;
            }
        }

        private void NearlySortedArray(int[] arr)
        {
            var rand = new Random(_seed);

            for (int i = 0; i < _size; i++)
            {
                arr[i] = rand.Next(_max);

            }

            SuperSorter Sort = new SuperSorter();

            Sort.SortArray(arr);

            for (int i = 0; i < arr.Length / 3; i++)
            {
                int tmp = arr[i];
                arr[i] = arr[i + i];
                arr[i + i] = tmp;
            }
        }

        private void FewButRandomArray(int[] arr, int[] values)
        {
            var rand = new Random(_seed);

            for (int i = 0; i < _size; i++)
            {
                arr[i] = values[rand.Next(0, values.Length)];

            }
        }

        public void SortTheArray(int[] arr)
        {
            SuperSorter SS = new SuperSorter();

            SS.SortArray(arr);
        }

        private readonly int _size;
        private readonly int _max;
        private readonly int _seed;

    }
}
