using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryItOut.CommonInterfaces
{
    public interface IToDoTasksCRUD
    {
        Domain.Models.ToDoTask Read(int identifier);

        List<Domain.Models.ToDoTask> Read();
    }
}
