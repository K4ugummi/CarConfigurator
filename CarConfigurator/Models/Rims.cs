using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarConfigurator.Models
{
    // The rims of a car.
    public class Rims : Component
    {
        public int Diameter { get; set; }
        public String Color { get; set; }
    }
}