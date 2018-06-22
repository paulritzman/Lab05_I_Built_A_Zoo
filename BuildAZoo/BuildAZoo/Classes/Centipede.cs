using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    public class Centipede : Insect
    {
        // Overrides IsCreepyCrawly property from Bug
        public override bool IsCreepyCrawly { get; set; } = true;

        // Overrides Diet property from Animal
        public override string Diet { get; set; } = "rodents";

        // Overrides CrawlOutOfWall method from Bug
        public override string CrawlOutOfWall()
        {
            return "I come in from the garden, squeezing under your back door.";
        }
    }
}
