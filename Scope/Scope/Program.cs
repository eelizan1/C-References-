using System;

namespace Scope
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 1; // accessible anywhere inside this block or any of its child blocks (a, b, c)
            {
                byte b = 2; // (b, c)
                {
                    byte c = 3; // c
                }
            }
        }
    }
}