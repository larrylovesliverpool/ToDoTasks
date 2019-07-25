namespace TryItOut.Domain.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Locomotive
    {
        [Key]
        public int LocoId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int? Classification { get; set; }

        public int? MadeBy { get; set; }

        public int? Decoder { get; set; }

        public int? DCCValue { get; set; }

        public string Description { get; set; }

        public int? YearPurchased { get; set; }
    }
}
