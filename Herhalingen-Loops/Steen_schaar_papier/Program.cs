using System;

namespace Steen_schaar_papier
{
    class Program
    {
        static void Main(string[] args)
        {
            //Oefening Steen-Schaar-papier

            int maxScore = 10;
            int scoreUser = 0;
            int stap = 1;
            int scorePC = 0;
            bool scoreProcessed = false;
          
            Random rand = new Random();

            int sspNumUser;       // index Steen[1]-Schaar[2]-Papier[3] string user
            string sspStringUser; // Steen-Schaar-Papier string user

            int sspNumPC;         // index Steen[1]-Schaar[2]-Papier[3] string PC
            string sspStringPC;   // Steen-Schaar-Papier string PC

            do
            {
                sspNumPC = rand.Next(1, 3);
                sspStringPC = Translate(sspNumPC);

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Steen[1] - Schaar[2] - Papier[3]?");
                Console.ForegroundColor = ConsoleColor.Gray;
                sspNumUser = Convert.ToInt32(Console.ReadLine());
                sspStringUser = Translate(sspNumUser);

                Console.Write($"\nUserInput; {sspNumUser}=({sspStringUser}) - ");

                Console.WriteLine($"PCInput; {sspNumPC}=({sspStringPC}).\n");

                if (sspNumUser != sspNumPC)   //check wie gewonnen heeft
                {
                    while (scoreProcessed != true) // Steen[1]-Schaar[2]-Papier[3]   sspNumPC sspStringPC   sspNumUser sspStringUser
                    {
                        switch (stap)
                        {
                            case 1:
                                if (sspStringUser == "steen" && sspStringPC == "schaar")
                                {
                                    stap = 8; //user wint
                                }
                                else
                                {
                                    stap = 2;
                                }
                                break;
                            case 2:
                                if (sspStringUser == "steen" && sspStringPC == "papier")
                                {
                                    stap = 9; //PC wint
                                }
                                else
                                {
                                    stap = 3;
                                }
                                break;
                            case 3:
                                if (sspStringUser == "schaar" && sspStringPC == "steen")
                                {
                                    stap = 9; //PC wint
                                }
                                else
                                {
                                    stap = 4;
                                }
                                break;
                            case 4:
                                if (sspStringUser == "schaar" && sspStringPC == "papier")
                                {
                                    stap = 8; //user wint
                                }
                                else
                                {
                                    stap = 5;
                                }
                                break;
                            case 5:
                                if (sspStringUser == "papier" && sspStringPC == "steen")
                                {
                                    stap = 8; //user wint
                                }
                                else
                                {
                                    stap = 6;
                                }
                                break;
                            case 6:
                                if (sspStringUser == "papier" && sspStringPC == "schaar")
                                {
                                    stap = 9; //PC wint
                                }
                                else
                                {
                                    stap = 7;
                                }
                                break;
                            case 7:
                                if (sspStringUser == "error")
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine($"Userinput not valid. Choose from Steen[1] - Schaar[2] - Papier[3].\n");
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    stap = 1;
                                    scoreProcessed = true;
                                }
                                else
                                {

                                }
                                break;
                            case 8:
                                scoreUser++;
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"ScoreUser: {scoreUser} VS ScorePC: {scorePC} (User wint een punt)\n");
                                Console.ForegroundColor = ConsoleColor.Gray;
                                stap = 1;
                                scoreProcessed = true;
                                break;
                            case 9:
                                scorePC++;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"ScoreUser: {scoreUser} VS ScorePC: {scorePC} (PC wint een punt)\n");
                                Console.ForegroundColor = ConsoleColor.Gray;
                                stap = 1;
                                scoreProcessed = true;
                                break;
                            default:
                                stap = 1;
                                break;
                        }
                    }
                }
                else                          //als user en PC hetzelfde hebben, niets doen, en terug opnieuw.
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"ScoreUser: {scoreUser} VS ScorePC: {scorePC} (gelijkspel)\n");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }

                scoreProcessed = false;

            } while (scoreUser < maxScore && scorePC < maxScore);

            if (scoreUser > scorePC)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"User heeft gewonnen !!!\n");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"User heeft verloren !!!\n");
                Console.ForegroundColor = ConsoleColor.Gray;
            }

        }
        public static string Translate(int ssp)
        {
            switch (ssp)
            {
                case 1:
                    return "steen";
                case 2:
                    return "schaar";
                case 3:
                    return "papier";
                default:
                    return "error";
                    break;
            }
        }
    }
}
