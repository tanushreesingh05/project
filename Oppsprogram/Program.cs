using System;
using System.Collections.Generic;


//Program of Dictionary
namespace Oppsprogram
{


    class Program
    {


        static void Main(string[] args)
        {
            Dictionary<int, string> mydict = new Dictionary<int, string>();

            mydict.Add(1, "Emp1");
            mydict.Add(2, "Emp2");
            mydict.Add(3, "Emp3");
            mydict.Add(4, "Emp4");
            mydict.Add(5, "Emp5");

            foreach(KeyValuePair<int,string> val in mydict) {

                Console.WriteLine("{0} and {1} ", val.Key, val.Value);

                               
            
            }
            Console.WriteLine();
            mydict.Remove(1);

            if (mydict.ContainsKey(1))
            {
                Console.WriteLine("Key is found ...");
            }
            else
            {
                Console.WriteLine("Key is not found ...");
            }
            if(mydict.ContainsValue("Emp2")) {
                Console.WriteLine("Value is found...");
            }
            else
            {
                Console.WriteLine("Value is not found...");
            }
        }




    }
}

