using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    public class VampireBat : Bat
    {
        public override string Diet { get; set; } = "blood";

        public override string Sound { get; set; } = "swoosh";
    }
}
