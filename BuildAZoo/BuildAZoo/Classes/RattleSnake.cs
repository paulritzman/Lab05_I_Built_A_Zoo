using System;
using System.Collections.Generic;
using System.Text;
using BuildAZoo.Interfaces;

namespace BuildAZoo.Classes
{
    public class RattleSnake : Snake, IBeEvil
    {
        public override string Sound { get; set; } = "rattle";

        public bool CausesNightmares { get; set; } = true;

        public string PhobiaCaused { get; set; } = "Ophidiophobia";
    }
}
