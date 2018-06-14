using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    public abstract class Reptile : Animal
    {
        public override string BodyCovering { get; set; } = "Scales";

        public virtual bool ColdBlooded { get; set; } = true;

        public override string Eat(string diet)
        {
            return $"I eat {diet} in a single bite, I don't chew my food!";
        }

        public override string LookAround()
        {
            return "I can see you by smelling the air with my tongue.";
        }

        public virtual string HeatInSun(bool coldBlooded)
        {
            if (coldBlooded)
            {
                return "Mmm... The sun is nice and warm.";
            }

            return "I'm always warm, who needs the sun?";
        }
    }
}
