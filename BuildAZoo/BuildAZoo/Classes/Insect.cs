using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    public abstract class Insect : Bug
    {
        // Overrides NumberOfEyes property from Animal - sets to Insect defaults
        public override int NumberOfEyes { get; set; } = 2;

        // Overrides BodyCovering property from Animal - sets to Insect defaults
        public override string BodyCovering { get; set; } = "Shell";

        // Overrides Eat() method from Animal - sets to Insect defaults
        public override string Eat(string diet)
        {
            return $"I munch on {diet} with my bug mouth.";
        }
    }
}
