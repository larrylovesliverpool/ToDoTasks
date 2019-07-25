using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryItOut.Service.DTOs
{
    public class LocomotiveDTO
    {
        public int LocoId { get; set; }

        public string Name { get; set; }

        public int? Classification { get; set; }

        public int? MadeBy { get; set; }

        public int? Decoder { get; set; }

        public int? DCCValue { get; set; }

        public string Description { get; set; }

        public int? YearPurchased { get; set; }
    }

    public class LocomotivesDTO
    {
        public bool hasLocomotives { get; set; }
        public int NumberOf { get; set; }

        public List<LocomotiveDTO> listOfLocomotives { get; set; }

        public LocomotivesDTO()
        {
            this.hasLocomotives = false;
            this.NumberOf = 0;
            this.listOfLocomotives = new List<LocomotiveDTO>();
        }

    }

    public class LocomotiveDetailsDTO
    {
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

    public class LocomotivesDetailsDTO
    {
        public bool HasLocomotives { get; set; }

        public List<LocomotiveDetailsDTO> listOfLocomotives { get; set; }

        public LocomotivesDetailsDTO()
        {
            this.HasLocomotives = false;
            this.listOfLocomotives = new List<LocomotiveDetailsDTO>();
        }
    }

}
