using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryItOut.Service.DTOs
{
    public class RailwayDecoderDTO
    {
        private int _decoderId;
        private int _manufacturer;
        private bool _stayALive;
        private string _type;
        private string _description;

        public int DecoderId { get => _decoderId; set => _decoderId = value; }
        public int Manufacturer { get => _manufacturer; set => _manufacturer = value; }
        public bool StayALive { get => _stayALive; set => _stayALive = value; }
        public string Type { get => _type; set => _type = value; }
        public string Description { get => _description; set => _description = value; }
    }

    public class RailwayDTO<T>
    {
        public bool HasData { get; set; }

        public List<T> ListOf { get; set; }

        public RailwayDTO()
        {
            HasData = false;
            ListOf = new List<T>();
        }
    }
}
