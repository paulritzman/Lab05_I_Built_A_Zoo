using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    public abstract class Rodent : Mammal
    {
        public override string BodyCovering { get; set; } = "fur";

        public override int NumberOfEyes { get; set; } = 2;
    }
}
