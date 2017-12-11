using System;

namespace Chapter6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inline if
            // condition ? value if condition is true : value if condition is false; 
            int myNum = 3 > 2 ? 10 : 5;
            Console.WriteLine(myNum);

            // ForEach
            char[] message = { 'H', 'E', 'L', 'L', 'O' };

            foreach (char i in message)
                Console.Write(i);

            // while loop
            int counter = 5;
            while (counter > 0)
            {
                Console.WriteLine("Counter = {0}", counter);
                counter--;
            }

            // Jump Statements
            int i = 0;
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("i = {0}", i);
                if (i == 2)
                    break; // exits loop when i = 2
            }

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("i = {0}", i);
                if (i == 2)
                    continue; // rest of the loop after this keyword will be skipped until the next iteration 
                Console.WriteLine("I will not be printed if i = 2");
            }

            // Specific Errors
            int choice = 0;
            int[] number = { 10, 11, 12, 13, 14, 15 };
            Console.Write("Please enter the index of the array:"); 

            try
            {
                choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("numbers[{0}] = {1}", choice, number[choice]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index out of range");
            }
            catch(FormatException)
            {
                Console.WriteLine("Choice should be an integer");
            }
            catch (Exception e)
            {
                Console.Write(e);
            }


            Console.Read();
        }
    }
}