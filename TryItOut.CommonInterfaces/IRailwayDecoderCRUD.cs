using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryItOut.CommonInterfaces
{
    public interface IRailwayDecoderCRUD
    {
        Domain.Models.RailwayDecoder Read(int identifier);

        List<Domain.Models.RailwayDecoder> Read();
    }
}
