using System.ComponentModel.DataAnnotations;

namespace TryItOut.Domain.Models
{
    public class RegisteredUser : IRegisteredUser
    {
        private int _identifier;
        private string _username;
        private string _password;
        private string _firstname;
        private string _lastname;
        private string _IsActive;
        private string _lastLoggedIn;
        private int _numberOfAttempts;
        private bool _locked;

        [Key]
        public int Identifier { get => _identifier; set => _identifier = value; }
        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }
        public string Firstname { get => _firstname; set => _firstname = value; }
        public string Lastname { get => _lastname; set => _lastname = value; }
        public string IsActive { get => _IsActive; set => _IsActive = value; }
        public string LastLoggedIn { get => _lastLoggedIn; set => _lastLoggedIn = value; }
        public int NumberOfAttemps { get => _numberOfAttempts; set => _numberOfAttempts = value; }
        public bool Locked { get => _locked; set => _locked = value; }
    }
}
