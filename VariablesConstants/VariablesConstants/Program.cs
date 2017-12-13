using System;

namespace VariablesConstants
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte number = 2;
            //int counter = 10;
            //float totalPrice = 20.95f;
            //decimal totalPrice2 = 20.95M;
            //char character = 'A';
            //string firstName = "Mosh";
            //bool isWorking = false;

            // will detect automatically what the type is 
            // var number = 2;
            // var counter = 10;
            // var totalPrice = 20.95f;
            // var totalPrice2 = 20.95M;
            // var character = 'A';
            // var firstName = "Mosh";
            // var isWorking = false;

            //// Console.WriteLine(totalPrice);

            // Console.WriteLine("{0} {1}", int.MinValue, int.MaxValue);

            const float Pi = 3.14f; // cant change the value of Pi
            Pi = 1; 


            Console.Read();
        }
    }
}