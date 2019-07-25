using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Objects;
using System.Globalization;
using System.Data.EntityClient;
using System.Data.SqlClient;
using System.Data.Common;

using TryItOut.CommonInterfaces;
using System.Data.Entity;
using TryItOut.Domain.Models;

namespace TryItOut.DataAccessEF
{
    public class LocomotiveRepository : ILocomotiveRepository
    {
        public Domain.Models.Locomotive Read(int identifier)
        {
            using (var context = new LocomotiveEFContext())
            {
                context.Database.Log = Console.WriteLine;

                var locomotive = context.LocomotiveEF.Find(identifier);

                return locomotive;
            }
        }

        public List<Domain.Models.Locomotive> Read()
        {
            using (var context = new LocomotiveEFContext())
            {
                context.Database.Log = Console.WriteLine;

                var locomotives = context.LocomotiveEF.ToList();

                return locomotives;
            }
        }

        /* ****************************************** */
        /* Example of joining two result set together */
        /* ****************************************** */

        public void ReadDetailsWithManufacturer()
        {
            using (var context = new RailwaysContextEF())
            {
                context.Database.Log = Console.WriteLine;

                DbSet<Locomotive> locomotives = context.LocomotiveEF;
                DbSet<RailwaysManufacturer> manufacturers = context.RailwaysManufacturerEF;
                DbSet<RailwayDecoder> decoders = context.RailwayDecoderEF;

                var listOfLocomotives = context.LocomotiveEF.ToList();
                var listOfManufacturers = context.RailwaysManufacturerEF.ToList();

                /* query join two tables together */

                var query = locomotives.Join(

                    manufacturers,
                    manu => manu.MadeBy,
                    loco => loco.ManufacturerId,
                        
                    (loco,manu) => new {

                        LocomotiveId = loco.LocoId,
                        Name = loco.Name,
                        Classification = loco.Classification,
                        Manufacturer = manu.Name,
                        decoderId = loco.Decoder,
                        loco.YearPurchased,
                    }
                );

            }
        }

        public List<LocomotiveDetails> ReadFullDetails()
        {
            List<LocomotiveDetails> locoDetails = new List<LocomotiveDetails>();

            using(var context = new RailwaysContextEF())
            {
                context.Database.Log = Console.WriteLine;

                /* execute custom stored procedure, result set mapped to locomotivedetails entity */

                locoDetails = context.LocomotiveDetailsEF.SqlQuery("LocomotiveDetailsALL").ToList();
            }

            return locoDetails;
        }

        public LocomotiveDetails ReadFullDetails(int identifier)
        {
            LocomotiveDetails locoDetails = new LocomotiveDetails();

            using (var context = new RailwaysContextEF())
            {
                context.Database.Log = Console.WriteLine;

                /* execute custom stored procedure, result set mapped to locomotivedetails entity */

                var locoDetailsListOf = context.LocomotiveDetailsEF.SqlQuery("LocomotiveDetailsALL").ToList();

                locoDetails = locoDetailsListOf.Single(x => x.LocoId == identifier);
            }

            return locoDetails;
        }
    }
}
