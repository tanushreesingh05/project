using System;

namespace Oppsprogram
{
    //single inheritance example
    public class Vehicle
    {

        public string brand = "Ford";
        public void hork()
        {
            Console.WriteLine("Tuut, tuut!");
        }

    }
    class Car : Vehicle { 
        public string modelName = "Mustang";  
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.hork();

            Console.WriteLine(c.brand + " " + c.modelName);
        }
    }
}
