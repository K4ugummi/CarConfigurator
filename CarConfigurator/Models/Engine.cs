using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarConfigurator.Models
{
    // Engine of a car
    public class Engine : Component
    {
        // Power in KiloWatts ( P(hp) = P(kW) / 0.745699872 )
        public int KiloWatts { get; set; }
    }
}