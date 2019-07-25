using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryItOut.Helpers.Interfaces
{
    public interface IPerson
    {
        string Name { get; set; }

        string Address { get; set; }

        string NameGet();

        string AddressGet();
    }
}
