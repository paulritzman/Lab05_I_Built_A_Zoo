using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    public abstract class Whale : Mammal
    {
        // Overrides BodyCovering property from Animal - sets to Whale defaults
        public override string BodyCovering { get; set; } = "blubber";

        // Overrides Sound property from Animal - sets to Whale defaults
        public override string Sound { get; set; } = "bwee";

        // Overrides NumberOfEyes property from Animal - sets to Whale defaults
        public override int NumberOfEyes { get; set; } = 2;

        // Overrides HasSweatGlands property from Mammal - sets to Whale defaults
        public override bool HasSweatGlands { get; set; } = false;
    }
}
