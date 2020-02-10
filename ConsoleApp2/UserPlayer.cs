using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class UserPlayer : Player
    {
        public UserPlayer() { }
        public UserPlayer(string name)
        {
            Name = name;
        }

        public override string GenerateRoshambo()
        {
            int choice = Validation.CheckRange(Validation.GetUserInput("1. Rock\n2. Paper\n3. Scissors"), 1, 3);
            RPS = Enum.GetName(typeof(Roshambo), choice);
            return RPS;
        }
    }

}
