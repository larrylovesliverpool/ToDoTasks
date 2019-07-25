using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryItOut.Domain.Models;
using TryItOut.Service.Models;

namespace TryItOut.Service
{
    public class LoginCheck_Password
    {
        public static bool CheckPassword(ref UserLogin user, Login loginDetails, RegisteredUser userDetails)
        {

            if (userDetails.Password == loginDetails.Password)
            {
                user.IsLoggedIn = true;
                user.Status = UserStatus.loginSuccess;
                /* Update last logged In, includes Number of attemps reset */
                //RegUserRepo.LastLoggedIn_Update(userDetails.Identifier);
            }
            else
            {
                user.IsLoggedIn = false;
                //RegUserRepo.NumberOfAtempts_Update(userDetails.Identifier);

                user.Status = UserStatus.loginfailed;
            }

            return user.IsLoggedIn;
        }
    }
}
