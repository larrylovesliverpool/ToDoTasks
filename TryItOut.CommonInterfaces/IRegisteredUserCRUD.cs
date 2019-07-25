using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryItOut.CommonInterfaces
{
    public interface IRegisteredUserCRUD
    {
        Domain.Models.RegisteredUser Read(int identifier);

        List<Domain.Models.RegisteredUser> Read();
    }
}
