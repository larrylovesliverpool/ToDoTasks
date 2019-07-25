using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryItOut.CommonInterfaces;

namespace TryItOut.DataAccessEF
{
    public class LocomotiveTypeCRUD : ILocomotiveTypesCRUD
    {
            public Domain.Models.LocomotiveClassification Read(int identifier)
            {
                using (var context = new LocomotiveTypeEFContext())
                {
                    context.Database.Log = Console.WriteLine;

                    var classification = context.LocomotiveClassificationEF.Find(identifier);

                    return classification;
                }
            }

            public List<Domain.Models.LocomotiveClassification> Read()
            {
                using (var context = new LocomotiveTypeEFContext())
                {
                    context.Database.Log = Console.WriteLine;

                    var classifications = context.LocomotiveClassificationEF.ToList();

                    return classifications;
            }

        }
    }
}
