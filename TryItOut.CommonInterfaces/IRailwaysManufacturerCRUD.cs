using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryItOut.CommonInterfaces
{
    public interface IRailwaysManufacturerCRUD
    {
        Domain.Models.RailwaysManufacturer Read(int identifier);

        List<Domain.Models.RailwaysManufacturer> Read();
    }
}
