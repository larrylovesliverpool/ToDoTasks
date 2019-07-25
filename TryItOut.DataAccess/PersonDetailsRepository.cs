using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryItOut.Domain;

namespace TryItOut.DataAccess
{
    public class PersonDetailsRepository : IPersonRepository
    {
        public bool Delete(Person entity)
        {
            throw new NotImplementedException();
        }

        public Person Read(int identifier)
        {
            throw new NotImplementedException();
        }

        public IList<Person> Read()
        {
            throw new NotImplementedException();
        }

        public bool Save(Person entity)
        {
            throw new NotImplementedException();
        }
    }
}
