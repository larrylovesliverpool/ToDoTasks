using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TryItOut.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public HomeViewModel() { }

        public HomeViewModel(string title)
        {
            Title = title;
        }

        public HomeViewModel(string title, string message)
        {
            Title = title;
            Message.Text = message;
        }
    }
}