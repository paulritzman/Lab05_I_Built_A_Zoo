using System;
using System.Collections.Generic;
using System.Text;
using BuildAZoo.Interfaces;

namespace BuildAZoo.Classes
{
    public class RattleSnake : Snake, IBeEvil
    {
        // Overrides Sound property from Animal and Snake
        public override string Sound { get; set; } = "rattle";

        // Sets IBeEvil Interface properties
        public bool CausesNightmares { get; set; } = true;

        public string PhobiaCaused { get; set; } = "Ophidiophobia";
    }
}
