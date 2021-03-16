using System;

namespace SuperSorter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ArrayGenerator AG = new ArrayGenerator(10, 50, 1000000);
            SuperSorter SS = new SuperSorter();

            int[] GamerArray = new int[10];
            AG.GenerateArray(GamerArray);
            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(GamerArray[i]);
            }

            SS.SortArray(GamerArray);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(GamerArray[i]);
            }

        }
    }
}
