using System;

namespace Oppsprogram
{
    //Program of Anonymous function : 1. Lambda expression

    //
    delegate int Addition(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            Addition add = ((x, y) => x + y);
            int result = add(4, 8);

            Console.WriteLine("Addition: " + result); // Output: Addition: 12
        }
    }
}
