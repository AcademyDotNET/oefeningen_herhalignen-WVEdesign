using System;

namespace PRO_ForDoordenker

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("\nEnter a number[1-100] to animate a triangle;\n");
            string inputValueString = Console.ReadLine();

            int inputValue = Convert.ToInt32(inputValueString);
            int x = 0;

            Console.Write("\n");

            for (int i = 0; i < inputValue; i++)
            {
                x += 1;
                for (int j = 0; j < x; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            for (int i = 0; i < inputValue; i++)
            {
                x -= 1;
                for (int j = 0; j < x; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            Console.ForegroundColor = ConsoleColor.Gray;

        }
    }
}