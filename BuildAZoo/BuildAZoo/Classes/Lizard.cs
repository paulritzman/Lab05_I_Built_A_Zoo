using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    public abstract class Lizard : Reptile
    {

        // Overrides NumberOfEyes property from Animal - set to Lizard defaults
        public override int NumberOfEyes { get; set; } = 2;

        // Virtual methods - set to Lizard Defaults
        public virtual string BecomeGodzilla()
        {
            return "BRAAAH!!! Where is Mothra?!";
        }
    }
}
