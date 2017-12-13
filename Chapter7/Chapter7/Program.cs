using System;

namespace Chapter7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
           
            var time = DateTime.Now;
            var message = string.Format("It is {0} {1}", time, "today");
            Console.Read();
        }
    }
}