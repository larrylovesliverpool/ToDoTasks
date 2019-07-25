using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryItOut.CommonInterfaces;

namespace TryItOut.DataAccessEF
{
    public class RailwaysManufacturerCRUD : IRailwaysManufacturerCRUD
{
        public Domain.Models.RailwaysManufacturer Read(int identifier)
        {
            using (var context = new RailwaysManufacturerEFContext())
            {
                context.Database.Log = Console.WriteLine;

            var manufacturers = context.LocomotiveManufacturerEF.Find(identifier);

                return manufacturers;
            }
        }

        public List<Domain.Models.RailwaysManufacturer> Read()
        {
            using (var context = new RailwaysManufacturerEFContext())
            {
                context.Database.Log = Console.WriteLine;

                var manufacturers = context.LocomotiveManufacturerEF.ToList();

                return manufacturers;
            }

        }
    }
}
