using System;
using System.Collections.Generic;
using System.Text;
using BuildAZoo.Interfaces;

namespace BuildAZoo.Classes
{
    public class VampireBat : Bat, IBeEvil
    {
        // Overrides Diet property from Animal
        public override string Diet { get; set; } = "blood";

        // Overrides Sound property from Animal
        public override string Sound { get; set; } = "swoosh";

        // Sets IBeEvil Interface properties
        public bool CausesNightmares { get; set; } = true;
        
        public string PhobiaCaused { get; set; } = "Chiroptophobia and Sanguivoriphobia";

        // Empty Constructor method
        public VampireBat()
        {

        }
    }
}
