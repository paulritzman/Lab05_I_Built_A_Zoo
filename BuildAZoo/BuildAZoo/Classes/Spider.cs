using System;
using System.Collections.Generic;
using System.Text;
using BuildAZoo.Interfaces;

namespace BuildAZoo.Classes
{
    public abstract class Spider : Bug, ICanFly, IBeEvil
    {
        // Overrides NumberOfEyes property from Animal - sets to Spider defaults
        public override int NumberOfEyes { get; set; } = 8;

        // Overrides IsCreeyCrawly property from Bug - sets to Spider defaults
        public override bool IsCreepyCrawly { get; set; } = true;

        // Sets ICanFly Interface properties - sets to Spider defaults
        public string FlyingMethod { get; set; } = "silk";

        // Sets IBeEvil Interface properties - sets to Spider defaults
        public bool CausesNightmares { get; set; } = true;

        public string PhobiaCaused { get; set; } = "Arachnophobia";

        // Overrides Eat() method from Animal - sets to Spider defaults
        public override string Eat(string diet)
        {
            return $"I slurp up the juices from {diet} like soup.";
        }

        // Overrides CrawlOutOfWall method from Bug - sets to Spider defaults
        public override string CrawlOutOfWall()
        {
            return "I sneak out of the corners of walls, ready to sprint off with my 8 legs if seen.";
        }

        // Virtual methods - set to Spider defaults
        public virtual string SpinWeb()
        {
            return "I spin lots of web, making my house in the corner of the ceiling.";
        }

        // Sets ICanFly Interface methods
        public string HowIFly()
        {
            return $"I float with {FlyingMethod}!";
        }
    }
}
