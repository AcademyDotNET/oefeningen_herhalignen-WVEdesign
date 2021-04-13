using System;

namespace RaadHetGetal_deel2_resterendInterval
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
                Console.WriteLine("Geef een getal tussen 0 en 100");
                pogingString = Console.ReadLine();
                poging = int.Parse(pogingString);
                                
                if (getal > poging)
                {
                    ondergrens = poging;
                    Console.WriteLine($"Het gezochte getal is groter dan {poging}, en ligt tussen {ondergrens} en {bovengrens}.");
                }
                else if (getal < poging)
                {
                    bovengrens = poging;
                    Console.WriteLine($"Het gezochte getal is kleiner dan {poging}, en ligt tussen {ondergrens} en {bovengrens}.");
                }
                else
                    gevonden = true;
            }
            Console.WriteLine($"Gevonden! Het te zoeken getal was inderdaad {getal} je had er {aantalPogingen} pogingen voor nodig.");
        }
    }
}
