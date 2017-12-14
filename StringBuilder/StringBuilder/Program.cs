using System;
using System.Text;

namespace StringBuilderDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder();
            var builder2 = new StringBuilder("Hello World");
            builder.Append('-', 10); // append '-' 10 times
            builder.AppendLine();
            builder.Append("Header");
            builder.AppendLine();
            builder.Append('-', 10);

            builder.Replace('-', '+');

            builder.Remove(0, 10);

            builder.Insert(0, new string('-', 10));
            Console.WriteLine(builder);
            Console.WriteLine(builder2);

            // access individual characters in the string 
            var firstChar = builder2[0];
            Console.WriteLine(firstChar);

            Console.Read();

        }
    }
}