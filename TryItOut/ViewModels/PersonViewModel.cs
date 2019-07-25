using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TryItOut.Helpers.DataAnnotations;

namespace TryItOut.ViewModels
{
    public class PersonViewModel
    {
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name="Address")]
        public string Address { get; set; }

        [Required]
        [Display(Name="Postcode")]
        public string Postcode { get; set; }

        [Display(Name="Nationality")]
        public string Nationality { get; set; }

        [Required]
        [Display(Name="Identifier")]
        [RegularExpression("([0-9]*)", ErrorMessage = "Identifier needs to be a number")]
        public string Identifier { get; set; }

        [Display(Name="Date of Birth")]
        public DateTime? BirthDate { get; set; }
    }
}