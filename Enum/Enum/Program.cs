using System;

namespace EnumClass
{
    // because Enum is a new type, define at name space level
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2, 
        Express = 3 
    }
    class Program
    {
        static void Main(string[] args)
        {
            // cast to int to get the numeric value 
            var method = (int)ShippingMethod.Express;
            Console.WriteLine(method);

            // cast back to get string value if you get value from somewhere else 
            var methodId = 3;
            var methodCast = (ShippingMethod)methodId;
            Console.WriteLine(methodCast);

            // convert string to enum 
            var methodName = "Express";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);

            Console.WriteLine(shippingMethod);
            Console.Read();
        }
    }
}