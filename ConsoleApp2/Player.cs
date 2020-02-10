using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public abstract class Player
    {
        public string Name { get; set; }
        public string RPS { get; set; }

        public Player() { }

        public abstract string GenerateRoshambo();
    }
}
