using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    public class Iguana : Lizard
    {
        public override string Diet { get; set; } = "vegetables";

        public override string Sound { get; set; } = "braaah";
    }
}
