using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    public class Iguana : Lizard
    {
        // Overrides Diet property from Animal
        public override string Diet { get; set; } = "vegetables";

        // OVerrides Sound property from Animal
        public override string Sound { get; set; } = "braaah";
    }
}
