using System;

namespace BecomeNeo_cooler
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rangen = new Random();
            Random kleur = new Random();
            Random speed = new Random();
            int sleepTime;

            Console.ForegroundColor = ConsoleColor.Green;
            while (true)
            {
                              
                //Genereer nieuw random teken:
                char teken = Convert.ToChar(rangen.Next(62, 400));

                //Zet teken op scherm
                Console.Write(teken);

                //Ietwat vertragen
                sleepTime = speed.Next(1, 60);
                System.Threading.Thread.Sleep(sleepTime); //dit getal is in milliseconden. RANDOMIZED

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
