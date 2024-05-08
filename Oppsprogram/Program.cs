using System;

namespace Oppsprogram
{
    //Program of array data structure
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[2, 2]
            {
                {1,2},
                {3,4}
            };


            Console.WriteLine("Print 2D array");

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            

        }
    }
}
