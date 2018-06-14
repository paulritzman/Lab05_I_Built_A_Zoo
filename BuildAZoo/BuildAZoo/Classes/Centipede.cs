using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    public class Centipede : Insect
    {
        public override bool IsCreepyCrawly { get; set; } = true;

        public override string Diet { get; set; } = "rodents";

        public override string CrawlOutOfWall()
        {
            return "I come in from the garden, squeezing under your back door.";
        }
    }
}
