using System.ComponentModel.DataAnnotations;

namespace TryItOut.ViewModels
{
    public class LocomotiveTypeEditViewModel : BaseViewModel
    {
        public int identifier { get; set; }

        [Required]
        [Display(Name = "Power")]
        public string Power { get; set; }

        [Required]
        [Display(Name = "Classification")]
        public string Classification { get; set; }

        [Display(Name = "Comments")]
        public string Comments { get; set; }
    }
}