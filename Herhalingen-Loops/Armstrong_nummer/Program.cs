using System;

namespace Armstrong_nummer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nGive me a number to check whether it is an Armstrong Number;\n");
            string inputValueString = Console.ReadLine();
            
            int inputValue = Convert.ToInt32(inputValueString);
            int subInputValue = inputValue;
            
            int lengthValue = inputValueString.Length;
            int subLengthValue = lengthValue;
            
            int ArmstrongValue = 0;
            
            Console.WriteLine($"\ninputvalue = {inputValue}, en is {lengthValue} long.");

            do
            {
                lengthValue--;
                int cypher = (int)(subInputValue / Math.Pow(10, lengthValue));
                int difference = cypher * (int)Math.Pow(10, lengthValue);
                subInputValue -= difference;

                ArmstrongValue += (int)Math.Pow(cypher, subLengthValue);

                Console.WriteLine($"Cypher {cypher}, another {lengthValue} digits..., ( subtractor = {difference} ), subvalue = {subInputValue}, armstrongValue = {ArmstrongValue} ");

            } while (lengthValue > 0);

            if (ArmstrongValue == inputValue)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\nThis is an Armstrong Number !     {ArmstrongValue} == {inputValue} ");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nThis is NOT an Armstrong Number !     {ArmstrongValue} != {inputValue} ");
                Console.ForegroundColor = ConsoleColor.Gray;
            }

        }
    }
}
