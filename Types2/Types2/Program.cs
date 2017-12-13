using System;

namespace Types2
{
    public class Person
    {
        public int Age; 
    }
    class Program
    {
        static void Main(string[] args)
        {
            var number = 1;
            Increment(number);
            Console.WriteLine(number); // still 1

            var person = new Person()
            {
                Age = 20
            };
            Console.Read();
        }

        public static void Increment(int number)
        {
            number += 10;
            Console.WriteLine(number); // value of 11
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10; 
        }
    }
}