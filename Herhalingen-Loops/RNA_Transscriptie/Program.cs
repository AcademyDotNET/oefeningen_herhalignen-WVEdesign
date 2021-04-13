using System;

namespace RNA_Transscriptie
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengthDNA = 12;
            char DNA;
            char RNA;
            string DNA_input = "";
            string RNA_output = "";
            
            do
            {
                lengthDNA--;
                Console.WriteLine($"geef telkens een karakter in gevolgd door een ENTER (12x), nog {lengthDNA + 1}x ");
                DNA = Convert.ToChar(Console.ReadLine());
                RNA = DNA2RNA(DNA);
                RNA_output += RNA;
                DNA_input += DNA;
            } while (lengthDNA > 0);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Input: {DNA_input} -> Output: {RNA_output}");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        public static char DNA2RNA(char RNA)
        {
            switch (RNA)
            {
                case 'G':
                    return 'C';
                case 'C':
                    return 'G';
                case 'T':
                    return 'A';
                case 'A':
                    return 'U';
                default:
                    return 'X';
                    break;
            }
        }
    }
}
