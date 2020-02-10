using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class RandomBot : Player
    {
        public RandomBot()
        {
            Name = "Random Bot";
        }

        public override string GenerateRoshambo()
        {
            Random number = new Random();
            int num = number.Next(1, 4);
            RPS = Enum.GetName(typeof(Roshambo), num);
            return RPS;
        }
    }

}
