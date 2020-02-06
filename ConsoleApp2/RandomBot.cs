using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class RandomBot : Player
    {

        public override Roshambo generateRoshambo()
        {
            Random roll = new Random();
            int randomChoice = roll.Next(0, 3);
            Roshambo[] choices = { Roshambo.rock, Roshambo.paper, Roshambo.scissors };
            Roshambo randomSelection = choices[randomChoice];
            return randomSelection;
        }

        public void printRoshambo()
        {
            Roshambo botChoice = generateRoshambo();
            Console.WriteLine(botChoice);
        }
    }
}
