using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    public abstract class Spider : Bug
    {
        public override int NumberOfEyes { get; set; } = 8;

        public override bool IsCreepyCrawly { get; set; } = true;

        public override string Eat(string diet)
        {
            return $"I slurp up the juices from {diet} like soup.";
        }

        public override string CrawlOutOfWall()
        {
            return "I sneak out of the corners of walls, ready to sprint off with my 8 legs if seen.";
        }

        public virtual string SpinWeb()
        {
            return "I spin lots of web, making my house in the corner of the ceiling.";
        }
    }
}
