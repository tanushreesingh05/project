using System;
using System.Collections.Generic;

namespace Oppsprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> myhash1 = new HashSet<string>();

            myhash1.Add("C");
            myhash1.Add("C++");
            myhash1.Add("C#");
            myhash1.Add("Java");
            myhash1.Add("Ruby");

            foreach (var val in myhash1)
            {
                Console.WriteLine(val);
            }

            Console.WriteLine("-------------------------------");

            HashSet<string> myhash2 = new HashSet<string>();

            myhash2.Add("PHP");
            myhash2.Add("C++");
            myhash2.Add("Perl");
            myhash2.Add("Java");

            foreach (var val in myhash2)
            {
                Console.WriteLine(val);
            }

            Console.WriteLine("-------UnionWith-----");//The unique element present in both table 
            myhash1.UnionWith(myhash2);
            foreach (var val in myhash1)
            {
                Console.WriteLine(val);
            }

            Console.WriteLine("-------IntersectWith-----");//The element only present in both table
            myhash1.IntersectWith(myhash2);
            foreach (var val in myhash1)
            {
                Console.WriteLine(val);
            }

            Console.WriteLine("-------ExceptWith-----");//The element only present in table 2
            myhash1.ExceptWith(myhash2);
            foreach (var ele in myhash2)
            {
                Console.WriteLine(ele);
            }

            Console.ReadLine();
        }
    }
}
