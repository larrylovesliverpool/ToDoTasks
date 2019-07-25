using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryItOut.CommonInterfaces
{
    public interface IRepository<objType>
    {
        /* CRUD Actions */

       // delete a record
        void Delete(objType entity);

        // Read single record
        objType Read(int identifier);

        // Read all records
        IList<objType> Read();

        objType Save(objType entity);
    }
}
