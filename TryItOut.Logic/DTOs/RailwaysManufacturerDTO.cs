using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryItOut.Service.DTOs
{
    public class RailwaysManufacturerDTO
    {
        private int _manufactuereId;
        private string _name;


        public int ManufacturerId { get => _manufactuereId; set => _manufactuereId = value; }
        public string Name { get => _name; set => _name = value; }
    }

    public class RailwaysManufacturersDTO
    {
        public bool hasManufacturers { get; set; }

        public int count { get; set; }

        public List<RailwaysManufacturerDTO> listOfManufacturers { get; set; }

        public RailwaysManufacturersDTO() {

            hasManufacturers = false;
            count = 0;

            listOfManufacturers = new List<RailwaysManufacturerDTO>();
        }
    }
}
