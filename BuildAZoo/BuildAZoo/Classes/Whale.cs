using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    public abstract class Whale : Mammal
    {
        public override string BodyCovering { get; set; } = "blubber";

        public override string Sound { get; set; } = "bwee";

        public override int NumberOfEyes { get; set; } = 2;

        public override bool HasSweatGlands { get; set; } = false;
    }
}
