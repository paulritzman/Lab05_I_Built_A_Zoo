using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Interfaces
{
    public interface ICanFly
    {
        string FlyingMethod { get; set; }

        string HowIFly();
    }
}
