using System;
using Classes.Math; 

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            var person2 = new Person();
            person1.firstName = "Enrico";
            person1.lastName = "Elizan";

            person1.Introduce();

            // calling the math namespace and creating an object
            Calculator calc = new Calculator();
            Console.WriteLine(calc.Add(3, 4));

            Console.Read();
        }
    }
}