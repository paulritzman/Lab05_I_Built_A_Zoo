using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    public abstract class Insect : Bug
    {
        public override int NumberOfEyes { get; set; } = 2;

        public override string BodyCovering { get; set; } = "Shell";

        public override string Eat(string diet)
        {
            return $"I munch on {diet} with my bug mouth.";
        }
    }
}
