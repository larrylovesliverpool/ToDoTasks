using System.ComponentModel.DataAnnotations;

namespace TryItOut.Domain.Models
{

    public partial class DecoderCVValue
    {
        [Key]
        public int Id { get; set; }

        public int DecoderId { get; set; }

        public int LocomotiveId { get; set; }

        public int CVNumber { get; set; }

        [StringLength(50)]
        public string CVDescription { get; set; }

        public string CVValue { get; set; }

        [StringLength(25)]
        public string Name { get; set; }

    }
}
