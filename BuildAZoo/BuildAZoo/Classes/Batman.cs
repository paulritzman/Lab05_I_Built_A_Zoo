using System;
using System.Collections.Generic;
using System.Text;
using BuildAZoo.Interfaces;

namespace BuildAZoo.Classes
{
    public class Batman : Bat
    {
        // Overrides BodyCovering property from Animal and Bat
        public override string BodyCovering { get; set; } = "a cape";

        // Overrides BodyCovering property from Animal
        public override string Diet { get; set; } = "Justice";

        // Overrides BodyCovering property from Animal
        public override string Sound { get; set; } = "I'm Batman";

        // Overrides ICanFly Interface properties from Bat
        public override string FlyingMethod { get; set; } = "cape";

        // Overrides ICanFly Interface methods from Bat
        public override string HowIFly()
        {
            return $"I glide with my {FlyingMethod}!";
        }
    }
}
