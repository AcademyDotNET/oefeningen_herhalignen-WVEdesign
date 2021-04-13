using System;

namespace Grootste_getal
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            int valueTop = 0;
            do
            {
                y = y + x;
                Console.WriteLine("Voer gehele waarden in (32767=stop)");
                string instring = Console.ReadLine();
                x = Convert.ToInt32(instring);
                if(x >= valueTop && x != 32767)
                {
                    valueTop = x;
                }
                else
                {

                }

            } while (x != 32767);
            Console.WriteLine($"Som is {y}, en de grootste waarde is {valueTop}");
        }
    }
}
