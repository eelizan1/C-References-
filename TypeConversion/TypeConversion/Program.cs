using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte b = 1;
            //int i = b;

            //int i = 1;
            //byte b = (byte)i; 

            //var number = "1234";
            //int i = Convert.ToInt32(number); 

            try
            {
                //var number = "1234";
                //byte b = Convert.ToByte(number);
                //Console.WriteLine(b);

                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.Read();
        }
    }
}