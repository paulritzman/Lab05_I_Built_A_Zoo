using System;
using System.Collections.Generic;
using System.Text;
using BuildAZoo.Interfaces;

namespace BuildAZoo.Classes
{
    public abstract class Bat : Mammal,ICanFly
    {
        public override string BodyCovering { get; set; } = "fur";

        public override int NumberOfEyes { get; set; } = 2;

        public virtual string FlyingMethod { get; set; } = "wings";

        public virtual string HowIFly()
        {
            return "I fly very high!";
        }
    }
}
