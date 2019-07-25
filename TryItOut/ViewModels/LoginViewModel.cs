using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TryItOut.ViewModels
{
    public class LoginViewModel
    {
        private bool _IsLoggedIn;
        private string _message;

        [Required]
        [Display(Name = "UserName")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Password")]
        public string Password { get; set; }
        public bool IsLoggedIn { get => _IsLoggedIn; set => _IsLoggedIn = value; }
        public string Message { get => _message; set => _message = value; }
    }
}