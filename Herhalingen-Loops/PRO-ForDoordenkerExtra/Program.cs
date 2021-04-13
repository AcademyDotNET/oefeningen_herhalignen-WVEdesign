using System;

namespace PRO_ForDoordenkerExtra

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("\nEnter a number[4-50] to animate a tree;\n");
            string inputValueString = Console.ReadLine();

            int inputValue = Convert.ToInt32(inputValueString);
            int offset = inputValue;
            int lenghtRight = 0;
            int lenghtLeft = 0;
            int lenghtHeight = inputValue / 4; //stamhoogte

            Console.Write("\n");
            Console.ForegroundColor = ConsoleColor.DarkGreen;  //boomkleur

            // tekent de piek, 1 *
            for (int j = 0; j < offset - lenghtLeft; j++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("*");
            // tekent de groene driehoek van de boom, telkens 1 lijn (offset+links+midden+rechts)
            for (int i = 0; i < inputValue - 1; i++)
            {
                //offset van lege spaties
                for (int j = 1; j < offset - lenghtLeft; j++)
                {
                    Console.Write(" ");
                }
                //linkerkant boom
                lenghtLeft += 1;
                for (int j = 0; j < lenghtLeft; j += 1)
                {
                    Console.Write("*");
                }
                //midden boom, == offset value
                Console.Write("*");
                //rechterkant boom
                lenghtRight += 1;
                for (int j = 0; j < lenghtRight; j += 1)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            // tekent de stam van de boom
            Console.ForegroundColor = ConsoleColor.DarkRed;
            for (int i = 0; i < lenghtHeight; i++)
            {
                for (int j = 0; j < offset ; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("|");
            }

            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}