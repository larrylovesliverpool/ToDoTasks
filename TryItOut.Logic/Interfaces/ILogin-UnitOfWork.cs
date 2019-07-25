using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryItOut.DataAccess;
using TryItOut.Domain.Models;
using TryItOut.Service.Models;

namespace TryItOut.CommonInterfaces
{
    /* ***************************************************************************** */
    /* a unit of work performs all tasks in one call, return success or fail,
     * usuallly done on multiple db transactions, only committing when all completed */
    /* ***************************************************************************** */

    public interface ILogin_UnitOfWork
    {
        /* work tasks, using interfaces for DI & Unit tests */

        /* The unit of work would be 
         * a. authenticate user
         * b. update LastLogedIn
         * c. reset number of attempts */

        UserLogin LoginUser(string username, string password);

    }

   
}
