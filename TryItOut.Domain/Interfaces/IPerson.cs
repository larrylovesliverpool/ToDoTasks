using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryItOut.Domain
{
    public interface IPerson
    {
        string Name { get; set; }

        string Address { get; set; }

        string Postcode { get; set; }

        string Nationality { get; set; }

        string Identifier { get; set; }

        DateTime? dob { get; set; }
    }
}
