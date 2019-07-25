using System.Collections.Generic;
using TryItOut.Domain.Models;

namespace TryItOut.CommonInterfaces
{
    public interface IRegisteredUserRepository
    {
        /* Delete user from XML file */
        bool Delete(int identity);
        bool Delete(RegisteredUser entity);
        /* ************************* */

        /* Read user from XML file */
        IList<RegisteredUser> Read();

        RegisteredUser Read(int identifier);

        RegisteredUser Read(string username);
        /* ************************* */

        /* Read user from XML file */
        bool Save(RegisteredUser entity);
        bool Save(List<RegisteredUser> entity);
        /* *********************** */

        /* Create user from XML file */
        bool Create(List<RegisteredUser> entity);
        /* ************************* */

        /* Last logged In details for user from XML file */
        string LastLoggedIn_Read(int identifier);

        void LastLoggedIn_Update(int identifier);
        /* ******************************************** */

        /* number of attempts details for user from XML file */
        string NumberOfAtempts_Read(int identifier);

        string NumberOfAtempts_Read(string username);

        void NumberOfAtempts_Update(int identifier,int numberOfAttempts);

        void NumberOfAtempts_Update(int identifier);
        /* ******************************************** */
    }
}