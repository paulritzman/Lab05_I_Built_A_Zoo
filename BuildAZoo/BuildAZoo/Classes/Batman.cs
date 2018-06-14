using System;
using System.Collections.Generic;
using System.Text;
using BuildAZoo.Interfaces;

namespace BuildAZoo.Classes
{
    public class Batman : Bat
    {
        public override string BodyCovering { get; set; } = "a cape";

        public override string Diet { get; set; } = "Justice";

        public override string Sound { get; set; } = "I'm Batman";

        public override string FlyingMethod { get; set; } = "cape";

        public override string HowIFly()
        {
            return "I only glide!";
        }
    }
}
