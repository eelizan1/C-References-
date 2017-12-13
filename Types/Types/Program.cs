using System;

namespace Types
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = a;
            b++; 

            Console.WriteLine(a); // a stays 10 since its value type 

            // Reference type 
            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1; // copies the MEMEORY ADDRESS to the object on the heap

            array2[0] = 0; 

            for(var i = 0; i < array1.Length;i++)
            {
                Console.WriteLine(array1[i]); // changes made to array1
            }

            Console.Read();
        }
    }
}