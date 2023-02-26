using System;

namespace haunteroller
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalDiceNo = 0;
            int HauntThreshold = HauntRandomiser();
            bool hauntFlag = false;
            int die = 0;


            while (hauntFlag == false)
            {
                Console.Clear();

                Console.WriteLine("//////////////////////////////////////");
                Console.WriteLine("HOUSE ON THE HILL HAUNT - RANDOM HAUNT ROLLER");
                Console.WriteLine("//////////////////////////////////////");
                Console.WriteLine();

                Console.WriteLine("YOU DREW AN OMEN...");
                Console.WriteLine("Press any key to roll for haunt, number track at {0} ", totalDiceNo);
                Console.ReadLine();

                die = RollDie(totalDiceNo);
                totalDiceNo++;
                hauntFlag = CheckHaunt(die, HauntThreshold);

                Console.WriteLine("You rolled a {0}, from {1} dice", die, totalDiceNo);

                if (hauntFlag == false)
                {
                    Console.WriteLine("Nothing happens...");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("SOMETHING HAPPENS...A HAUNT BEGINS!!!");
                    Console.WriteLine("The haunt threshold this time was {0}", HauntThreshold);
                    Console.WriteLine("Press any key to close...");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
            }
            
        }

        public static int HauntRandomiser()
        {
            Random rnd = new Random();
            return rnd.Next(4,8);
        }

        public static int RollDie ()
        {
            Random rnd = new Random();
            return rnd.Next(0,3);
        }
        public static bool CheckHaunt (int total, int threshold)
        {
            if (total >= threshold)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static int RollDie(int totalDice)
        {
            Random rnd = new Random();
            int total = 0;

            for (int i = 0; i < totalDice; i++)
            {
                total += rnd.Next(0, 3);
            }

            return total;
        }
    }
}
