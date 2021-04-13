using System;

namespace RaadHetGetal_deel4_resterendInterval_controle_maxretry
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal;
            int poging = 0;
            int aantalPogingen = 0;
            string pogingString;
            bool gevonden = false;
            Random rand = new Random();
            getal = rand.Next(0, 100);

            int ondergrens = 0;
            int bovengrens = 200;

            int maxRetries = 0;

            int i = bovengrens;
            do
            {
                maxRetries++;
                bovengrens = bovengrens / 2;
            } while (bovengrens > 0);
            Console.WriteLine($"Met een totaal interval van {bovengrens - ondergrens} zijn er idealiter max. {maxRetries} pogingen");
            bovengrens = i;

            while (!gevonden && aantalPogingen < maxRetries)
            {
                aantalPogingen++;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Poging {aantalPogingen}. Geef een getal tussen {ondergrens} en {bovengrens}");
                Console.ForegroundColor = ConsoleColor.Gray;
                pogingString = Console.ReadLine();
                poging = int.Parse(pogingString);

                if (poging < getal)
                {
                    if (poging > ondergrens)
                    {
                        ondergrens = poging;
                        Console.WriteLine($"Het gezochte getal is groter dan {poging}, en ligt tussen {ondergrens} en {bovengrens}.");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Het gezochte getal ligt tussen {ondergrens} en {bovengrens}. Uw poging van {poging} is zinloos.");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }

                }
                else if (poging > getal)
                {
                    if (poging < bovengrens)
                    {
                        bovengrens = poging;
                        Console.WriteLine($"Het gezochte getal is kleiner dan {poging}, en ligt tussen {ondergrens} en {bovengrens}.");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Het gezochte getal ligt tussen {ondergrens} en {bovengrens}. Uw poging van {poging} is zinloos.");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }

                }
                else
                    gevonden = true;
            }

            if(aantalPogingen < maxRetries)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Gevonden! Het te zoeken getal was inderdaad {getal} je had er {aantalPogingen} pogingen voor nodig.");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"NIET GEVONDEN! Het te zoeken getal was {getal} en je hebt geen pogingen meer over.");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
    }
}