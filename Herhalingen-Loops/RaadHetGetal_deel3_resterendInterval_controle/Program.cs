using System;

namespace RaadHetGetal_deel3_resterendInterval_controle
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
            int bovengrens = 100;
                        
            while (!gevonden)
            {
                aantalPogingen++;
                Console.WriteLine($"Geef een getal tussen {ondergrens} en {bovengrens}");
                pogingString = Console.ReadLine();
                poging = int.Parse(pogingString);

                if (poging < getal)
                {
                    if(poging > ondergrens)
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
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Gevonden! Het te zoeken getal was inderdaad {getal} je had er {aantalPogingen} pogingen voor nodig.");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}