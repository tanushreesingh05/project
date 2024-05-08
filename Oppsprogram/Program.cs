using System;

namespace Oppsprogram
{
    //Program of abstraction
    /*Data abstraction is the process of hiding certain details and showing only essential information to the user.
Abstraction can be achieved with either abstract classes or interfaces (which you will learn more about in the next chapter).

The abstract keyword is used for classes and methods:

Abstract class: is a restricted class that cannot be used to create objects (to access it, it must be inherited from another class).

Abstract method: can only be used in an abstract class, and it does not have a body. The body is provided by the derived class (inherited from).*/
    

    abstract class Animal
    {
        // Abstract method (does not have a body)
        public abstract void animalSound();

        //normal method 
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }

    }

    class Dog : Animal
    {
        // The body of animalSound() is provided here
        public override void animalSound()
        {
            Console.WriteLine("The dog says : bow wow");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.animalSound();
            dog.sleep();
        }
    }
}
