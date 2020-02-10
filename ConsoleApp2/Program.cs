using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Player dopey = new RockBot();
            Player random = new RandomBot();
            Player chosen = null;
            int userNum = Validation.CheckRange(Validation.GetUserInput("Play against\n1. Jerry \n2. Random Man"), 1, 2);
            if (userNum == 1)
            {
                chosen = dopey;
            }
            if (userNum == 2)
            {
                chosen = random;
            }
            Console.WriteLine(RoshamboApp.Play(chosen, "Blake"));
            Console.WriteLine($"{chosen.Name} throws {chosen.RPS}");

        }
    }
}
