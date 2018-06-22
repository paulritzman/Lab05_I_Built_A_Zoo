using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    public abstract class Animal
    {
        // Abstract properties
        public abstract int NumberOfEyes { get; set; }

        public abstract string Diet { get; set; }

        public abstract string BodyCovering { get; set; }

        // Virtual properties - set to Animal defaults
        public virtual string Sound { get; set; } = "RAWR";

        public virtual string Name { get; set; } = "Frank";

        // Abstract methods
        public abstract string Eat(string diet);

        public abstract string LookAround();

        // Virtual methods - set to Animal defaults
        public virtual string MakeSound(string sound)
        {
            return $"I go \"{sound}\"!";
        }
    }
}
