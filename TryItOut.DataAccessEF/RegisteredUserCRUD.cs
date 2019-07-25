using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryItOut.CommonInterfaces;
using TryItOut.DataAccess;

namespace TryItOut.DataAccessEF
{
    public class RegisteredUserCRUD : IRegisteredUserCRUD
    {
        public Domain.Models.RegisteredUser Read(int identifier)
        {
            using (var context = new RegisteredUserEFContext())
            {
                context.Database.Log = Console.WriteLine;

                var user = context.RegisteredUserEF.Find(identifier);

                return user;
            }
        }

        public List<Domain.Models.RegisteredUser> Read()
        {
            using (var context = new RegisteredUserEFContext())
            {
                context.Database.Log = Console.WriteLine;

                var users = context.RegisteredUserEF.ToList();

                return users;
            }
        }
    }
}
