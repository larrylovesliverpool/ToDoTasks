using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TryItOut.ViewModels
{
    public abstract class BaseViewModel
    {
        private string _title;

        private MessageBaseViewModel _message;

        public string Title { get => _title; set => _title = value; }
        public MessageBaseViewModel Message { get => _message; set => _message = value; }
    }
}