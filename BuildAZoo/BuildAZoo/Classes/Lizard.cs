using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    public abstract class Lizard : Reptile
    {
        public override int NumberOfEyes { get; set; } = 2;

        public virtual string BecomeGodzilla()
        {
            return "BRAAAH!!! Where is Mothra?!";
        }
    }
}
