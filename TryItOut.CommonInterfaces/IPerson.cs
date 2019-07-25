using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryItOut.CommonInterfaces
{
    public interface IPerson
    {
        string Name { get; set; }

        string Identifier { get; set; }

        string IdentifierGet();

        string NameGet();
    }
}
