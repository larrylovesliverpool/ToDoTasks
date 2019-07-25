using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryItOut.CommonInterfaces
{
    public interface ILocomotiveTypesCRUD
    {
        Domain.Models.LocomotiveClassification Read(int identifier);

        List<Domain.Models.LocomotiveClassification> Read();
    }
}
