using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Enrico Elizan  ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim()); // removes white space
            // note: use trim when compariing strings 

            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());

            // Seperate from first name to last name 
            var index = fullName.IndexOf(' '); // splits on space 
            var firstName = fullName.Substring(0, index); // from index 0 to the space 
            var lastName = fullName.Substring(index + 1).Trim();

            Console.WriteLine("First name: '{0}', Last name: '{1}'", firstName, lastName);

            // another way to split 
            var names = fullName.Split(' ');
            Console.WriteLine("FirstName: " + names[0]);
            Console.WriteLine("LastName: " + names[1].Trim());

            // replace 
            var nickName = fullName.Replace("Enrico", "Rico");

            Console.WriteLine(nickName);
            // *note that all these methods do not affect the original string, they return new strings 

            // check if string is null or empty
           
            if (String.IsNullOrWhiteSpace(" "))
                // null
                // ""
                // " "
                Console.WriteLine("Invalid");
            else
                Console.WriteLine("String is not null");

            var str = "25";
            Convert.ToByte(str); // convert to byte
            Console.WriteLine(str);

            // convert number to string 
            float price = 29.95f;
            var formatPrice = price.ToString("C0"); // "C0" used to convert to currency
            Console.WriteLine(formatPrice);

            Console.Read();
        }
    }
}