using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryItOut.CommonInterfaces;
using TryItOut.Service.Models;

namespace TryItOut.Service
{
    public class Login_Service : ILogin_Service
    {
        private readonly ILogin_UnitOfWork UnitOfWork;

        public Login_Service(ILogin_UnitOfWork UnitOfWork) {

            this.UnitOfWork = UnitOfWork;
        }

        
        public UserLoginDTO LoginUser(string username, string password)
        {
            UserLoginDTO dto = new UserLoginDTO();
            
            /* calls UnitOfWork for login tasks */
            var LoginAttempt = UnitOfWork.LoginUser(username, password);

            if (!LoginAttempt.IsLoggedIn)
            {
                /* **************** */
                /* login has failed */
                /* **************** */
                dto.IsLoggedIn = LoginAttempt.IsLoggedIn;
                dto.Message = LoginMessage(LoginAttempt.Status);
            }
            else
            {
                dto.IsLoggedIn = LoginAttempt.IsLoggedIn;
            }

            return dto;
        }

        private string LoginMessage(UserStatus loginStatus )
        {
            string messageText = string.Empty;

            switch ( loginStatus)
            {
                case UserStatus.loginfailed:
                    messageText = "Login has failed due to incorrect username and/or password.";
                        break;
                case UserStatus.attemptsexceeded:
                    messageText = "The number of Login attempts has been exceeded, please contact the support desk.";
                    break;
                case UserStatus.accountLocked:
                    messageText = "The user account is Locked, please contact the support desk.";
                    break;
                default:
                    break;
            }

            return messageText;
        }

    }
}
