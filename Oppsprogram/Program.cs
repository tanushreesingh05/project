using System;
using System.Linq.Expressions;

namespace Oppsprogram
{
    //Program of array data structure
    class Program
    {
        static void Main(string[] args)
        {
            /*----------2D Array---------------*/
            // Declare the array of two elements:
            int[][] arr = new int[2][];
            arr[0] = new int[5] { 1,2,3,4,5};
            arr[1] = new int[4] { 10, 20, 30, 40 };

            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Element ["+ i +"] Array");
                for(int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] +" ");

                }
                Console.WriteLine();

            }


        }
    }
}
