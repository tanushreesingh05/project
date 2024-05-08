using System;

namespace Oppsprogram
{
    //Program of array data structure
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 1, 2, 3, 4, 5 };

            //accessing the element 
            Console.WriteLine("Accessing arr value using for loop: ");
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
            Console.WriteLine("Accessing arr value using foreach loop");
            foreach(int i in arr)
            {
                Console.WriteLine(i+ " ");
            }
            Console.WriteLine("Acessing arr value using while loop");
            int j = 0;
            while (j < arr.Length)
            {
                Console.WriteLine(arr[j] + " ");
                j++;
            } 
            Console.WriteLine("Acessing arr value using do - while loop");
            int k = 0;
            do
            {
                Console.WriteLine(arr[k] + " ");
                k++;
            } while (k < arr.Length);
        }
    }
}
