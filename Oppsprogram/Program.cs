using System;

namespace Oppsprogram
{
    //Program of aggregation
    
    public class Address
    {
        public string addressLine;
        public string city;
        public string state;

        public Address(string addressLine, string city, string state)
        {
              this.addressLine = addressLine;
            this.city = city;
            this.state = state;


        }
    }
    
    public class Employee
    {
        public int id;
        public string name;
        public Address address;

        public Employee(int id, string name, Address address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
        }

        public void display()
        {
            Console.WriteLine("Employee ID : " + id);
            Console.WriteLine("Employee Name : " + name); 
            Console.WriteLine("Employee Address : " + address.addressLine + " " + address.city + " " + address.state);
       
             
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Address a = new Address("P-32", "Thane", "Maharashtra");
            Employee e = new Employee(101, "Taushree singh", a);
            e.display();
        }
    }
}
