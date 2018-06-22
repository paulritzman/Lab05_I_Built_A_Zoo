using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    public class HumpBack : Whale
    {
        // Overrides Diet property from Animal
        public override string Diet { get; set; } = "krill";
    }
}
