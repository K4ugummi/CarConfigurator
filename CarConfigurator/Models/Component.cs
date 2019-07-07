using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarConfigurator.Models
{
    // The base component of each detail added to the car configuration.
    // All car-components are subclasses from this one to store basic information
    // each class should provide
    public class Component
    {
        // Unique database id in each table
        public int Id { get; set; }

        // The short name of a component (e.g. 'Super-Red')
        [Required]
        [StringLength(255)]
        public String Name { get; set; }

        // A description so users understand the meaning behind the Name during
        // configuration. (e.g. 'A redish color, glowing in the dark'
        public String Description { get; set; }

        // The price this component adds to the whole configuration
        public int Price { get; set; }

        public String ImageURL { get; set; }
    }
}