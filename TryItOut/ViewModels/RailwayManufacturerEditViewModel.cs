using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TryItOut.ViewModels
{
    public class RailwayManufacturerEditViewModel
    {
        public int identifier { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }
    }
}