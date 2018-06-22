using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    public class Hamster : Rodent
    {
        // Overrides Diet property from Animal
        public override string Diet { get; set; } = "crickets";

        // Overrides Sound property from Animal
        public override string Sound { get; set; } = "squeak";

        // Concrete properties
        public bool WasYourMother = true;
    }
}
