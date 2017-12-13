using System;

namespace Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
           // exceeding byte storage amount 
           checked
            {
                short number = 255;
                number++;

                Console.WriteLine(number);
                Console.Read();
            }
        }
    }
}