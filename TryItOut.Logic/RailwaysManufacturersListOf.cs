using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryItOut.CommonInterfaces;
using TryItOut.DataAccessEF;

namespace TryItOut.Service
{
    public class RailwaysManufacturersListOf : IRailwaysManufacturersListOf
    {
        IRailwaysManufacturerCRUD repo = null;

        public RailwaysManufacturersListOf() {

            this.repo = new RailwaysManufacturerCRUD();
        }

        public RailwaysManufacturersListOf(IRailwaysManufacturerCRUD repo)
        {
            this.repo = repo;
        }

        public List<Tuple<int, string>> GetListOfManufacturers() {

            List<Tuple<int, string>> ListOfManufacturers = new List<Tuple<int, string>>();

            /* Get manufacturers from repo */

            foreach(var item in repo.Read() )
            {
                ListOfManufacturers.Add(new Tuple<int, string>(item.ManufacturerId, item.Name));
            }

            return ListOfManufacturers;
        }

    }
}
