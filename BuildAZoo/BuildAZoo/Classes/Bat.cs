using System;
using System.Collections.Generic;
using System.Text;
using BuildAZoo.Interfaces;

namespace BuildAZoo.Classes
{
    public abstract class Bat : Mammal,ICanFly
    {
        // Overrides BodyCovering property from Animal - sets to Bat defaults
        public override string BodyCovering { get; set; } = "fur";

        // Overrides NumberOfEyes property from Animal - sets to Bat defaults
        public override int NumberOfEyes { get; set; } = 2;

        // Sets ICanFly Interface properties - sets to Bat defaults
        public virtual string FlyingMethod { get; set; } = "wings";

        // Sets ICanFly Interface methods - sets to Bat defaults
        public virtual string HowIFly()
        {
            return $"I fly very high with {FlyingMethod}!";
        }
    }
}
