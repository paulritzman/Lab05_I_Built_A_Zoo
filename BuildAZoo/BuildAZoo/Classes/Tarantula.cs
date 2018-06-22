using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    public class Tarantula : Spider
    {
        // Overrides Diet property from Animal
        public override string Diet { get; set; } = "rodents";

        // Overrides BodyCovering property from Animal
        public override string BodyCovering { get; set; } = "fur";
    }
}
