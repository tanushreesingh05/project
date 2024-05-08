using System;

namespace Oppsprogram
{
    //Program of encapsulation
    /*
     Encapsulation is the concept of wrapping data into a single unit. It collects data members and member functions into a single unit called class. The purpose of encapsulation is to prevent alteration of data from outside. This data can only be accessed by getter functions of the class.

A fully encapsulated class has getter and setter functions that are used to read and write data. This class does not allow data access directly.

Here, we are creating an example in which we have a class that encapsulates properties and provides getter and setter functions.*/

    class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            //setting value to the properties
            student.id = 101;
            student.name = "Tanushree singh";
            student.email = "singhtanushree111@gmail.com || tanushreesingh555@gmail.com";

            //getting values
            
            Console.WriteLine("ID : "+ student.id);
            Console.WriteLine("Name : "+ student.name);
            Console.WriteLine("Email : "+ student.email);
        }
    }
}
