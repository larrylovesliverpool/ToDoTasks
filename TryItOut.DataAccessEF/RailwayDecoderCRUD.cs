using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryItOut.CommonInterfaces;

namespace TryItOut.DataAccessEF
{
    public class RailwayDecoderCRUD : IRailwayDecoderCRUD
{
        public Domain.Models.RailwayDecoder Read(int identifier)
        {
            using (var context = new RailwayDecoderEFContext())
            {
                context.Database.Log = Console.WriteLine;

                var decoder = context.RailwayDecoderEF.Find(identifier);

                return decoder;
            }
        }

        public List<Domain.Models.RailwayDecoder> Read()
        {
            using (var context = new RailwayDecoderEFContext())
            {
                context.Database.Log = Console.WriteLine;

                var decoders = context.RailwayDecoderEF.ToList();

                return decoders;
            }
        }
    }
}
