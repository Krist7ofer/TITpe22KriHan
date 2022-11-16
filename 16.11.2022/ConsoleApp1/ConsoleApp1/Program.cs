using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your favorite football t-shirt  number!");
            string number = Console.ReadLine();
            int numberParsed = Int16.Parse(number);

            // Teen siia if ja else loogikaga vastused. 

            if (numberParsed < 50 && numberParsed > 0)
            {
                Console.WriteLine("JA");
            }
            else if(numberParsed >= 50 && numberParsed <= 99)
            {
                Console.WriteLine("EI");
            }
            else
            {
                Console.WriteLine("ERROR");
            }

        }
    }
}
