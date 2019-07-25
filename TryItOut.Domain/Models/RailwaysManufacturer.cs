using System.ComponentModel.DataAnnotations;

namespace TryItOut.Domain.Models
{
    public class RailwaysManufacturer
    {
        private int _manufacturerId;
        private string _name;

        [Key]
        public int ManufacturerId { get => _manufacturerId; set => _manufacturerId = value; }

        [StringLength(50)]
        public string Name { get => _name; set => _name = value; }
    }
}
