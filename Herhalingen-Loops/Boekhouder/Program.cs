using System;

namespace Boekhouder
{
    class Program
    {
        static void Main(string[] args)
        {

            int inputValue;
            int lengthInputValue;
            int valueSum = 0;
            int lengthValueSum;
            int valueSumPos = 0;
            int lengthValueSumPos;
            int valueMaxHigh = 0;
            int valueSumNegs = 0;
            int lengthValueSumNegs;
            int valueIndex = 0;
            int lengthValueCount;
            double valueAverage;
            int lengthValueAverage;

            string inputValueString = "";
            int tabSize = 11;
            string dummy = "";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"|    Index    |   Balans   |  Som neg.  |  Som pos.  | Gemiddelde |");
            Console.WriteLine($"------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Gray;

            do
            {
                valueIndex++;

                Console.Write("Voer gehele waarden in (32767=stop): ");
                inputValueString = Console.ReadLine();
                lengthInputValue = inputValueString.Length;
                inputValue = Convert.ToInt32(inputValueString);

                valueSum += inputValue;                                     // Calculate sum of all numbers

                if (inputValue >= valueMaxHigh && inputValue != 32767)      // Check for highest number and update if so.
                {
                    valueMaxHigh = inputValue;
                }
                else
                {

                }
                if (inputValue < 0)                                         // Calculates total sum all negative numbers
                {
                    valueSumNegs += inputValue;
                }
                else
                {
                    valueSumPos += inputValue;                              // Calculates total sum all positive numbers
                }

                valueAverage = valueSum / valueIndex;                       // Calculates average of all numbers

                // String Length calculations for estetic console printout
                dummy = Convert.ToString(valueSum);
                lengthValueSum = dummy.Length;
                dummy = Convert.ToString(valueSumPos);
                lengthValueSumPos = dummy.Length;
                dummy = Convert.ToString(valueSumNegs);
                lengthValueSumNegs = dummy.Length;
                dummy = Convert.ToString(valueIndex);
                lengthValueCount = dummy.Length;
                dummy = Convert.ToString(valueAverage);
                lengthValueAverage = dummy.Length;

                Console.ForegroundColor = ConsoleColor.Green;

                Console.Write($"| #{valueIndex}");
                for (int i = 0; i < tabSize - lengthValueCount; i++)
                {
                    Console.Write(" ");               // genereert het juiste aantal spaties 
                }

                Console.Write($"| {valueSum}");
                for (int i = 0; i < tabSize - lengthValueSum; i++)
                {
                    Console.Write(" ");               // genereert het juiste aantal spaties 
                }

                Console.Write($"| {valueSumNegs}");
                for (int i = 0; i < tabSize - lengthValueSumNegs; i++)
                {
                    Console.Write(" ");               // genereert het juiste aantal spaties 
                }

                Console.Write($"| {valueSumPos}");
                for (int i = 0; i < tabSize - lengthValueSumPos; i++)
                {
                    Console.Write(" ");               // genereert het juiste aantal spaties 
                }

                Console.Write($"| {valueAverage}");
                for (int i = 0; i < tabSize - lengthValueAverage; i++)
                {
                    Console.Write(" ");               // genereert het juiste aantal spaties 
                }
                Console.WriteLine($"|");
                Console.ForegroundColor = ConsoleColor.Gray;

            } while (inputValue != 32767);
        }
    }
}