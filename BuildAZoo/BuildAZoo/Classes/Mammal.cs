using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    public abstract class Mammal : Animal
    {
        // Virtual properties - set to Mammal defaults
        public virtual bool HasEarBones { get; set; } = true;

        public virtual bool HasSweatGlands { get; set; } = true;

        // Overrides Eat() method from Animal
        public override string Eat(string diet)
        {
            return $"I scarf down on {diet}";
        }

        // Overrides LookAround() method from Animal
        public override string LookAround()
        {
            return "I see you from land with my mammal eyes!";
        }
    }
}
