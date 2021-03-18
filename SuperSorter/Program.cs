using System;

namespace SuperSorter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ArrayGenerator AG = new ArrayGenerator(100, 50, 1000000);

            int[] GamerArray = new int[100];
            int[] values = {10, 2, 50, 9};
            AG.GenerateArray(GamerArray, values);

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(GamerArray[i]);
            }

            AG.SortTheArray(GamerArray);

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(GamerArray[i]);
            }

        }
    }
}
