using System;
using System.ComponentModel.DataAnnotations;
using TryItOut.Domain.Interfaces;

namespace TryItOut.Domain.Models
{
    public class ToDoTask : IToDoTask
    {
        [Key]
        public int Identifier { get; set; }

        public string Description { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime RequiredBy { get; set; }

        public DateTime CompletedOn { get; set; }
    }
}
