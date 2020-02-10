using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class RockBot : Player
    {
        public RockBot()
        {
            Name = "Dopey";
        }

        public override string GenerateRoshambo()
        {
            RPS = Roshambo.Rock.ToString();
            return RPS;
        }
    }
}
