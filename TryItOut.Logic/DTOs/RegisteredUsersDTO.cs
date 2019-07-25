using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryItOut.Service
{
    /* Single ToDoTask for DTO */
    public class RegisteredUserDTO
    {
        public int Identifier { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string IsActive { get; set; }
    }

    /* Full DTO for ToDo Tasks */
    public class RegisteredUsersDTO
    {
        public bool IsValid { get; set; }
        public int NumberOf { get; set; }
        public List<RegisteredUserDTO> registeredUsers { get; set; }


        /* initialise DTO */
        public RegisteredUsersDTO()
        {
            this.IsValid = false;
            this.registeredUsers = new List<RegisteredUserDTO>();
            this.NumberOf = 0;
        }
    }
}
