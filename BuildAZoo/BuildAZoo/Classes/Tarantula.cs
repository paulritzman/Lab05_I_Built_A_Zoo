using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    public class Tarantula : Spider
    {
        public override string Diet { get; set; } = "rodents";

        public override string BodyCovering { get; set; } = "fur";
    }
}
