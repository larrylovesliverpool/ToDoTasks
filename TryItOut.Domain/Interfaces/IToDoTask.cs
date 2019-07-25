using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryItOut.Domain.Interfaces
{
    public interface IToDoTask
    {
        int Identifier { get; set; }

        string Description { get; set; }

        DateTime CreatedOn { get; set; }

        DateTime RequiredBy { get; set; }

        DateTime CompletedOn { get; set; }
    }
}
