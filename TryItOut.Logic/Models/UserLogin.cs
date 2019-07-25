using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryItOut.Service.Models
{
    [Flags]
    public enum UserStatus : short
    {
        unkown = 0,
        initial = 1,
        loginSuccess = 2,
        loginfailed = 4,
        accountLocked = 8,
        attemptsexceeded = 16
    }

    public class UserLogin   {

        private bool _IsLoggedIn;
        private int _Identifier;
        private string _UserName;
        private string _Password;
        private string _LastName;
        private string _FirstName;
        private string _LastLoggedIn;
        private int _NumberOfAttempts;
        private UserStatus _Status;

        public bool IsLoggedIn { get => _IsLoggedIn; set => _IsLoggedIn = value; }
        public string LastLoggedIn { get => _LastLoggedIn; set => _LastLoggedIn = value; }
        public int NumberOfAttempts { get => _NumberOfAttempts; set => _NumberOfAttempts = value; }
        public int Identifier { get => _Identifier; set => _Identifier = value; }
        public string LastName { get => _LastName; set => _LastName = value; }
        public string FirstName { get => _FirstName; set => _FirstName = value; }
        public string UserName { get => _UserName; set => _UserName = value; }
        public UserStatus Status { get => _Status; set => _Status = value; }
        public string Password { get => _Password; set => _Password = value; }

        public UserLogin()
        {
            IsLoggedIn = false;

            UserName = string.Empty;
            Password = string.Empty;

            FirstName = string.Empty;
            UserName = string.Empty;
            LastLoggedIn = string.Empty;

            Status = 0;
        }
    }
}
