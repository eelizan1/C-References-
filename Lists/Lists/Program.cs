using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() {1, 2, 3, 4};
            numbers.Add(1); // add 1
            numbers.AddRange(new int[3] { 5, 6, 7 }); // adds an array to the list

            // iterate 
            foreach (var n in numbers)
                Console.Write(n);

            Console.WriteLine();

            // returns the index of that object
            Console.WriteLine("Index of 1: " + numbers.IndexOf(1)); // starts search from beginning 
            Console.WriteLine("Last Index of 1: " + numbers.LastIndexOf(1)); // starts search at the end of the list

            // returns the number of objects in the list 
            Console.WriteLine("Count: " + numbers.Count);

            // removes the first 1 from array 
            numbers.Remove(1);

            //// iterate 
            //foreach (var n in numbers)
            //    Console.Write(n);

            // to remove ALL 1's, putin for loop
            for(var i = 0; i < numbers.Count; i++)
            {
                if(numbers[i] == 1)
                {
                    numbers.Remove(numbers[i]);
                }
            }

            // iterate 
            foreach (var n in numbers)
                Console.Write(n);

            Console.Read();
        }
    }
}