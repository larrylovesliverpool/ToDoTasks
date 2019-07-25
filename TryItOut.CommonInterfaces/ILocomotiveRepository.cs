using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryItOut.Domain.Models;

namespace TryItOut.CommonInterfaces
{
    public interface ILocomotiveRepository
    {
        Locomotive Read(int identifier);

        List<Locomotive> Read();

        LocomotiveDetails ReadFullDetails(int identifier);

        List<LocomotiveDetails> ReadFullDetails();
    }
}
