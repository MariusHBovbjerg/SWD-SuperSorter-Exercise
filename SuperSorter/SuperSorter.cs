using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace SuperSorter
{
    class SuperSorter
    {

        public SuperSorter()
        {

        }

        public void SortArray(int[] arr)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            IntArrayQuickSort(arr);
            stopWatch.Stop();

            Console.WriteLine("Elapsed={0}", stopWatch.Elapsed);
        }
        private static void IntArrayQuickSort(int[] data, int l, int r)
        {

            
            int i, j;
            int x;

            i = l;
            j = r;

            x = data[(l + r) / 2]; /* find pivot item */
            while (true)
            {
                while (data[i] < x)
                    i++;
                while (x < data[j])
                    j--;
                if (i <= j)
                {
                    exchange(data, i, j);
                    i++;
                    j--;
                }
                if (i > j)
                    break;
            }
            if (l < j)
                IntArrayQuickSort(data, l, j);
            if (i < r)
                IntArrayQuickSort(data, i, r);
        }

        private static void IntArrayQuickSort(int[] data)
        {
            IntArrayQuickSort(data, 0, data.Length - 1);
        }
        private static void exchange(int[] data, int m, int n)
        {
            int temporary;

            temporary = data[m];
            data[m] = data[n];
            data[n] = temporary;
        }
    }
}
