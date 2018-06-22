using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    public abstract class Snake : Reptile
    {
        // Overrides NumberOfEyes property from Animal - set to Snake defaults
        public override int NumberOfEyes { get; set; } = 2;

        // Overrides Diet property from Animal - set to Snake defaults
        public override string Diet { get; set; } = "rodents";

        // Overrides Sound property from Animal - set to Snake defaults
        public override string Sound { get; set; } = "hiss";
    }
}
