using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryItOut.Service
{
    public class UserLoginDTO
    {
        private bool _IsLoggedIn;
        private string _message;

        public bool IsLoggedIn { get => _IsLoggedIn; set => _IsLoggedIn = value; }
        public string Message { get => _message; set => _message = value; }
    }
}
