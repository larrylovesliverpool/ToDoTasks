using System.Collections.Generic;
using TryItOut.Domain;

namespace TryItOut.DataAccess
{
    public interface IPersonRepository
    {
        /* CRUD Actions */

        // delete a record
        bool Delete(Person entity);

        // Read single record
        Person Read(int identifier);

        // Read all records
        IList<Person> Read();

        // Save a record
        bool Save(Person entity);
    }
}