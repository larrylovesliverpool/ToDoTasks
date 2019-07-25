
using System;
using System.Collections.Generic;
using TryItOut.CommonInterfaces;
using TryItOut.Domain.Models;
using TryItOut.Service.Models;

namespace TryItOut.Service
{
    public class Login_UnitOfWork : ILogin_UnitOfWork
    {
        /* ****************** */
        /* Unit of work class */
        /* ****************** */

        private readonly IRegisteredUserRepository RegUserRepo;
        private const int maxNumberOfAttempts = 3;

        public Login_UnitOfWork(IRegisteredUserRepository RegUserRepo)
        {
            this.RegUserRepo = RegUserRepo;
        }

        /* The unit of work would be 
         * a. authenticate user
         * b. update LastLogedIn
         * c. reset number of attempts */

        public UserLogin LoginUser(string username, string password)
        {
            UserLogin user = new UserLogin();
            Login loginDetails = new Login(username,password);

            /* get users details */
            RegisteredUser userDetails = RegUserRepo.Read(loginDetails.UserName);

            if(userDetails != null)
            {
                /* ***************************************************** */
                /* have a matched user, need to ascertain if valid       */
                /* Check for attempts, Locked account and password match */
                /* ***************************************************** */

                if(CheckLocked(ref user, loginDetails, userDetails))
                {
                    if (CheckAttempts(ref user, loginDetails, userDetails))
                    {
                        CheckPassword(ref user, loginDetails, userDetails);
                    }
                }

                /* map to UserLogin object */
                user.UserName = userDetails.Username;
                user.LastLoggedIn = userDetails.LastLoggedIn;
                user.FirstName = userDetails.Firstname;
                user.LastName = userDetails.Lastname;
                user.Identifier = userDetails.Identifier;
            }
            else
            {
                /* Is not a valid user */
                user.IsLoggedIn = false;
                user.Status = UserStatus.unkown;
            }

            return user;
        }

        public bool CheckPassword(ref UserLogin user, Login loginDetails, RegisteredUser userDetails)
        {

            if (userDetails.Password == loginDetails.Password)
            {
                user.IsLoggedIn = true;
                user.Status = UserStatus.loginSuccess;
                /* Update last logged In, includes Number of attemps reset */
                RegUserRepo.LastLoggedIn_Update(userDetails.Identifier);
            }
            else
            {
                user.IsLoggedIn = false;
                RegUserRepo.NumberOfAtempts_Update(userDetails.Identifier);

                user.Status = UserStatus.loginfailed;
            }

            return user.IsLoggedIn;
        }

        public bool CheckLocked(ref UserLogin user, Login loginDetails, RegisteredUser userDetails) {

            if (userDetails.IsActive == "Locked") {

                user.IsLoggedIn = false;
                user.Status = UserStatus.accountLocked;
            }
            else
            {
                user.IsLoggedIn = true;
            }

            return user.IsLoggedIn;
        }

        public bool CheckAttempts(ref UserLogin user, Login loginDetails, RegisteredUser userDetails) {

            if (userDetails.NumberOfAttemps >= maxNumberOfAttempts)
            {
                user.IsLoggedIn = false;
                user.Status = UserStatus.attemptsexceeded;
            }
            else
            {
                user.IsLoggedIn = true;
            }

            return user.IsLoggedIn;
        }

    }

}
