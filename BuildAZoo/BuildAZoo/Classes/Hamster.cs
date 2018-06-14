using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    public class Hamster : Rodent
    {
        public override string Diet { get; set; } = "crickets";

        public override string Sound { get; set; } = "squeak";

        public bool WasYourMother = true;
    }
}
