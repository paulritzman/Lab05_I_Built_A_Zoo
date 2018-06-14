using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    public abstract class Bug : Animal
    {
        public abstract bool IsCreepyCrawly { get; set; }

        public abstract string CrawlOutOfWall { get; set; }

        public override string LookAround()
        {
            return "I can see you with my big, bug eyes!";
        }
    }
}
