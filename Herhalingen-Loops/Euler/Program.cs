using System;

namespace Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nGive me a number to calculate the SuperFantastic Euler Number;\n");
            string inputValueString = Console.ReadLine();

            int inputValue = Convert.ToInt32(inputValueString) + 1;

            int EulerValue = 0;

            do
            {
                inputValue--;

                if (inputValue % 3 == 0 || inputValue % 5 == 0)
                {
                    EulerValue += inputValue;

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Euler:{EulerValue}, inputValue:{inputValue}");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else
                {

                }

            } while (inputValue > 0);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nThe SuperFantastic Euler number is = {EulerValue}");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}