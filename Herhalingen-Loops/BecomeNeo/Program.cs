using System;

namespace BecomeNeo
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rangen = new Random();
            Random kleur = new Random();

            Console.ForegroundColor = ConsoleColor.Green;
            while (true)
            {
                //Genereer nieuw random teken:
                char teken = Convert.ToChar(rangen.Next(62, 400));
                
                //Zet teken op scherm
                Console.Write(teken);

                //Ietwat vertragen
                System.Threading.Thread.Sleep(10); //dit getal is in milliseconden. Speel er gerust mee.

                //Af en toe donker kleurtje
                if (rangen.Next(0, 3) == 0)
                {
                    Console.ForegroundColor = (ConsoleColor)kleur.Next(0, 16);
                }
                else
                {
                    Console.ForegroundColor = (ConsoleColor)kleur.Next(0, 16);
                }
            }
        }
    }
}
