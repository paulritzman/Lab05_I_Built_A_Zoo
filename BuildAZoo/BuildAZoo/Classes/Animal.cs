using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    abstract class Animal
    {
        public abstract int NumberOfEyes { get; set; }

        public abstract string Diet { get; set; }

        public abstract string BodyCovering { get; set; }

        public virtual string Sound { get; set; } = "RAWR";

        public virtual string Name { get; set; } = "Frank";

        public abstract string Eat();

        public abstract string LookAround();

        public virtual string MakeSound(string sound)
        {
            return $"I go \"{sound}\"!";
        }
    }
}
