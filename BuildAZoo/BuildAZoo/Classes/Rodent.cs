using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    public abstract class Rodent : Mammal
    {
        // Overrides BodyCovering property from Animal - sets to Rodent defaults
        public override string BodyCovering { get; set; } = "fur";

        // Overrides NumberOfEyes property from Animal - sets to Rodent defaults
        public override int NumberOfEyes { get; set; } = 2;
    }
}
