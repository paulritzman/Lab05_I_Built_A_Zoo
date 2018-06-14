using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    public abstract class Snake : Reptile
    {
        public override int NumberOfEyes { get; set; } = 2;

        public override string Diet { get; set; } = "rodents";

        public override string Sound { get; set; } = "hiss";
    }
}
