using System;
using System.Collections.Generic;
using System.Text;

namespace Fundementals.Array
{
    class Array
    {
        static void Main(String[] args)
        {
            int[] numbers = new int[3];
            numbers[0] = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i]);
            }

            var flags = new bool[3];
            flags[0] = true; 

            for(int i = 0; i < flags.Length; i++)
            {
                Console.Write(flags[i]);
            }
        }
    }
}
