using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CarConfigurator.Models;

namespace CarConfigurator.ViewModels
{
    // Contains all components of an already configured car.
    // The Guid is used as a unique identifier in the database table.
    public class LoadConfigurationViewModel
    {
        public Guid Guid { get; set; }
        public Car Car { get; set; }
        public Engine Engine { get; set; }
        public Paint Paint { get; set; }
        public Rims Rims { get; set; }
        public IEnumerable<Extra> Extras { get; set; }
    }
}