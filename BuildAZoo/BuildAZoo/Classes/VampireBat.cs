using System;
using System.Collections.Generic;
using System.Text;
using BuildAZoo.Interfaces;

namespace BuildAZoo.Classes
{
    public class VampireBat : Bat, IBeEvil
    {
        public override string Diet { get; set; } = "blood";

        public override string Sound { get; set; } = "swoosh";

        public bool CausesNightmares { get; set; } = true;

        public string PhobiaCaused { get; set; } = "Chiroptophobia and Sanguivoriphobia";
    }
}
