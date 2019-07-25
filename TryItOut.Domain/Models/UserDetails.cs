using System.ComponentModel.DataAnnotations;

namespace TryItOut.Domain.Models
{
    public class UserDetails
    {
        private int _Identifier;

        private bool _IsLoggedIn;
        private string _UserName;
        private string _LastName;
        private string _FirstName;
        private string _LastLoggedIn;
        private int _NumberOfAttempts;

        [Key]
        public int Identifier { get => _Identifier; set => _Identifier = value; }

        public bool IsLoggedIn { get => _IsLoggedIn; set => _IsLoggedIn = value; }
        public string UserName { get => _UserName; set => _UserName = value; }
        public string LastName { get => _LastName; set => _LastName = value; }
        public string FirstName { get => _FirstName; set => _FirstName = value; }
        public string LastLoggedIn { get => _LastLoggedIn; set => _LastLoggedIn = value; }
        public int NumberOfAttempts { get => _NumberOfAttempts; set => _NumberOfAttempts = value; }
    }
}
