using System;
using System.ComponentModel.DataAnnotations;

namespace TryItOut.Areas.ToDoTasks.ViewModels
{
    public class NewTaskViewModel
    {
        [Required]
        [Display(Name = "Task")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Required By")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}",ApplyFormatInEditMode = true)]
        public DateTime? RequiredBy { get; set; }

        [Display(Name = "Completed By")]
        public DateTime? CompletedOn { get; set; }

        [Display(Name = "Created On")]
        public DateTime CreatedOn { get; set; }

        [Required]
        [Display(Name ="Type of Task")]
        public string type { get; set; }
    }

    public enum Gender
    {
        Male,
        Female
    }

    public enum TaskType
    {
        DIY,
        Hobbies,
        Garden,
        Car,
    }
}