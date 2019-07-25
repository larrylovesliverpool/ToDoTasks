using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryItOut.Domain;
using TryItOut.Domain.Models;

namespace TryItOut.CommonInterfaces
{
    public interface IToDoTasksRepository
    {
        /* CRUD Actions */

        // delete a record
        bool Delete(ToDoTask entity);

        // Read single record
        ToDoTask Read(int identifier);

        // Read all records
        IList<ToDoTask> Read();

        // Save a record
        bool Save(ToDoTask entity);
    }
}
