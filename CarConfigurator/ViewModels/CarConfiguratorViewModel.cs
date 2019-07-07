using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CarConfigurator.Models;

namespace CarConfigurator.ViewModels
{
    // Contains all available Components for the car that is being configured.
    public class CarConfigViewModel
    {
        public Car Car { get; set; }
        public IEnumerable<Engine> Engines { get; set; }
        public IEnumerable<Paint> Paints { get; set; }
        public IEnumerable<Rims> Rims { get; set; }
        public IEnumerable<Extra> Extras { get; set; }

        public CarConfiguration CarConfiguration { get; set; }
    }
}