using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Interfaces
{
    interface ICanFly
    {
        string FlyingMethod { get; set; }

        string HowIFly();
    }
}
