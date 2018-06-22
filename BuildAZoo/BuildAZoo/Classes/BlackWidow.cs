using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    public class BlackWidow : Spider
    {
        // Overrides Diet property from Animal
        public override string Diet { get; set; } = "humans";

        // Overrides BodyCovering property from Animal
        public override string BodyCovering { get; set; } = "hourglasses";
    }
}
