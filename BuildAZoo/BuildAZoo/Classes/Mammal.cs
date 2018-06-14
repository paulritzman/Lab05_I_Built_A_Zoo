using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    public abstract class Mammal : Animal
    {
        public virtual bool HasEarBones { get; set; } = true;

        public virtual bool HasSweatGlands { get; set; } = true;

        public override string Eat(string diet)
        {
            return $"I eat by chewing on {diet}";
        }

        public override string LookAround()
        {
            return "I see you from land with my mammal eyes!";
        }
    }
}
