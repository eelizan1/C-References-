using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // using place holders 
            string name = "Enrico";
            string msg = string.Format("Hello, {0}", name);
            Console.WriteLine(msg);

            Console.WriteLine("The number is {0:F3}", 123.45678);

            decimal balance = 1234.5M;
            Console.WriteLine("The balance is: {0:C}", balance);
            Console.Read(); 
        } 
    }
}
