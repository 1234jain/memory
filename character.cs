// C# program for character comparison 
using System;
using System.IO;
using System.Text;

namespace IncludeHelp
{
    class Test
    {
        // Main Method 
        static void Main(string[] args)
        {
            char ch1;
            char ch2;

            //input characters
            Console.Write("Enter a character: ");
            ch1 = Console.ReadLine()[0];
            Console.Write("Enter another character: ");
            ch2 = Console.ReadLine()[0];
            
            //comparing characters
            if (ch1 == ch2)
                Console.WriteLine("Input characters are the same");
            else
                Console.WriteLine("Input characters are not the same");

            //hit ENTER to exit the program
            Console.ReadLine();
        }
    }
}
