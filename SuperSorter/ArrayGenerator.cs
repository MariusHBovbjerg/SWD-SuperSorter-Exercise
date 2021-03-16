using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
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

        public void GenerateArray(int[] res)
        {
            RandomizedArray(res);
        }

        private void RandomizedArray(int[] arr)
        {
            var rand = new Random(_seed);

            for (int i = 0; i < _size; i++)
            {
                arr[i] = rand.Next(_max);

            }
        }



        private readonly int _size;
        private readonly int _max;
        private readonly int _seed;

    }
}
