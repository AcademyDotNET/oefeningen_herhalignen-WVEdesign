using System;

namespace Tafels_vermenigvuldigen
{
    class Program
    {
        static void Main(string[] args)
        {
            int tellerA = 0;
            int tellerB ;

            while (tellerA < 10)
            {
                tellerA++;
                tellerB = 0;
                while (tellerB < 10)
                {
                    tellerB++;
                    int product = tellerA * tellerB;
                    Console.WriteLine($"{tellerA} * {tellerB} = {product}");
                }
            }
        }
    }
}
