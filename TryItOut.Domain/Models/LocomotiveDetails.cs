namespace TryItOut.Domain.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public class LocomotiveDetails
    {
        [Key]
        public int LocoId { get; set; }

        public string Name { get; set; }

        public int MadeBy { get; set; }

        public string Manufacturer { get; set; }

        public int Decoder { get; set; }

        public string DecoderDetails { get; set; }

        public int? DCCValue { get; set; }

        public string Description { get; set; }

        public int? YearPurchased { get; set; }

        public int? Classification { get; set; }

        public string ClassificationDetails { get; set; }

        public string Power { get; set; }
    }
}
