using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    public class Batman : Bat
    {
        public override string BodyCovering { get; set; } = "cape";

        public override string Diet { get; set; } = "Justice";

        public override string Sound { get; set; } = "I'm Batman";
    }
}
