using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TryItOut.ViewModels
{
    public class MessageBaseViewModel :IDisposable
    {
        private bool _isActive;
        private string _text;
        private string _type;
        private string _position;

        public string Text { get => _text; set => _text = value; }
        public string Type { get => _type; set => _type = value; }
        public string Position { get => _position; set => _position = value; }
        public bool IsActive { get => _isActive; set => _isActive = value; }

        public MessageBaseViewModel()
        {
            IsActive = false;
        }

        public MessageBaseViewModel(bool isActive, string message, string type, string position)
        {
            IsActive = isActive;
            Text = message;
            Type = type;
            Position = position;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}