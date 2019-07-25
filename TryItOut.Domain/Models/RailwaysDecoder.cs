using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryItOut.Domain.Models
{
    public class RailwayDecoder
    {
        private int _decoderId;
        private int _manufacturer;
        private bool _stayALive;
        private string _type;
        private string _description;

        [Key]
        public int DecoderId { get => _decoderId; set => _decoderId = value; }
        public int Manufacturer { get => _manufacturer; set => _manufacturer = value; }
        public bool StayALive { get => _stayALive; set => _stayALive = value; }
        [StringLength(50)]
        public string Type { get => _type; set => _type = value; }
        [StringLength(250)]
        public string Description { get => _description; set => _description = value; }
    }
}
