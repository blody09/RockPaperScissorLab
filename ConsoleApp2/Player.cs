using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    abstract class Player
    {
        
        public string Name { get; set; }

        public Roshambo Choice { get; set; }


        public abstract Roshambo generateRoshambo();
           
    }
}
