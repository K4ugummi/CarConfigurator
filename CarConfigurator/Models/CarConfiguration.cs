using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarConfigurator.Models
{
    // A finished car configuration as it is stored in the database.
    public class CarConfiguration
    {
        public int Id { get; set; }

        public Guid Guid { get; set; }
        public int CarID { get; set; }
        public int EngineID { get; set; }
        public int PaintID { get; set; }
        public int RimID { get; set; }

        // This is ugly..
        public int Extra1 { get; set; }
        public int Extra2 { get; set; }
        public int Extra3 { get; set; }
        public int Extra4 { get; set; }
        public int Extra5 { get; set; }
    }
}