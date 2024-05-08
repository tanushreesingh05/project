using System;

namespace Oppsprogram
{
    //Program of interface 
    /*An interface is a completely "abstract class", 
     which can only contain abstract methods and properties (with empty bodies):
    // interface
      interface Animal 
      {
        void animalSound(); // interface method (does not have a body)
        void run(); // interface method (does not have a body)
      }

    Notes on Interfaces:
  1. Like abstract classes, interfaces cannot be used to create objects (in the example above, it is not possible to create an "IAnimal" object in the Program class)
  2. Interface methods do not have a body - the body is provided by the "implement" class
  3. On implementation of an interface, you must override all of its methods
  4. Interfaces can contain properties and methods, but not fields/variables
  5. Interface members are by default abstract and public
  6. An interface cannot contain a constructor (as it cannot be used to create objects)
   Why And When To Use Interfaces?
     1) To achieve security - hide certain details and only show the important details of an object (interface).

     2) C# does not support "multiple inheritance" (a class can only inherit from one base class). However, it can be achieved with interfaces, because the class can implement multiple interfaces.
     */

    interface IAnimal
    {
        void animalSound();
        void sleep();
    }
    
    class Pig : IAnimal
    {
        public void animalSound() {

            Console.WriteLine("The pig says :wee wee");
        }  
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }


class Program
    {
        static void Main(string[] args)
        {
            Pig p=new Pig();    
            p.animalSound();
             p.sleep();

        }
    }
}
