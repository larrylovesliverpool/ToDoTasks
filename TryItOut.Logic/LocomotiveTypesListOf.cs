using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryItOut.CommonInterfaces;
using TryItOut.DataAccessEF;

namespace TryItOut.Service
{
    public class LocomotiveTypesListOf : ILocomotiveTypesListOf
    {
        ILocomotiveTypesCRUD repo = null;

        public LocomotiveTypesListOf() {

            this.repo = new LocomotiveTypeCRUD();
        }

        public LocomotiveTypesListOf(ILocomotiveTypesCRUD repo)
        {
            this.repo = repo;
        }

        public List<Tuple<int, string>> GetListOfLocomotiveTypes() {

            List<Tuple<int, string>> ListOfManufacturers = new List<Tuple<int, string>>();

            /* Get manufacturers from repo */

            foreach(var item in repo.Read() )
            {
                ListOfManufacturers.Add(new Tuple<int, string>(item.ClassificationId, item.Power + ' ' + item.Classification));
            }

            return ListOfManufacturers;
        }

    }
}
