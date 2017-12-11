using System;

namespace Chapter5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Converting a string to a number with user input 

            string userName = "";
            int userAge = 0;
            int currentYear = 0;

            Console.Write("Please enter you name: ");
            userName = Console.ReadLine();
            Console.Write("Please enter your age: ");
            userAge = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the year: ");
            currentYear = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Name: " + userName);
            Console.WriteLine("Name: " + userAge);
            Console.WriteLine("Name: " + currentYear);

            Console.Read(); 
        }
    }
}