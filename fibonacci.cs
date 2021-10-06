using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            int c = 0;
            int i = 0;

            Console.Write(a + ", " + b );

            for (i = 1; i < 10; i++)
            {
                c = a + b;
                Console.Write(", "+c);

                a = b;
                b = c;
            }

            Console.WriteLine();

        }
    }
}
