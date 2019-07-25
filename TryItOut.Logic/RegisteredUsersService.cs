using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryItOut.CommonInterfaces;
using TryItOut.DataAccess;

namespace TryItOut.Service
{

    public class RegisteredUsersService : IRegisteredUsersService
    {
        private readonly IRegisteredUserRepository repo;

        public RegisteredUsersService()
        {
            this.repo = new RegisteredUserRepository();
        }

        public RegisteredUsersService(IRegisteredUserRepository repo)
        {
            this.repo = repo;
        }

        public RegisteredUsersDTO Read()
        {
            RegisteredUsersDTO usersDTO = new RegisteredUsersDTO();

            foreach(var user in repo.Read())
            {
                usersDTO.NumberOf++;
                usersDTO.registeredUsers.Add(new RegisteredUserDTO()
                {
                    Identifier = user.Identifier,
                    Username = user.Username,
                    Password = user.Password,
                    Lastname = user.Lastname,
                    Firstname = user.Firstname,
                    IsActive = user.IsActive
                });
            }

            usersDTO.IsValid = true;

            return usersDTO;
        }

        public RegisteredUsersDTO Read(int identifier)
        {
            RegisteredUsersDTO usersDTO = new RegisteredUsersDTO();

            var user = repo.Read(identifier);

            usersDTO.NumberOf = 1;
            usersDTO.registeredUsers.Add(new RegisteredUserDTO()
            {
                Identifier = user.Identifier,
                Username = user.Username,
                Password = user.Password,
                Lastname = user.Lastname,
                Firstname = user.Firstname,
                IsActive = user.IsActive
            });

            usersDTO.IsValid = true;

            return usersDTO;
        }

        /* ********************************* */
        /* Adds a new record to the XML file */
        /* ********************************* */

        public void Save()
        {
        }

        /* ******************************** */
        /* updates a record to the XML file */
        /* ******************************** */

        public void Update()
        {
        }

        public void Dispose()
        {
            /* ToDo */
        }

    }
}
