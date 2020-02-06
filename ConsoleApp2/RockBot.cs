using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class RockBot : Player
    {
        public RockBot()
        {

        }

        public string returnRoshamboAsString()
        {
            Roshambo choice = generateRoshambo();
            string roshString = choice.ToString();
            return roshString;
        }

        //methods
        public override Roshambo generateRoshambo()
        {
            Choice = Roshambo.rock;
            return Choice;
        }
    }
}
