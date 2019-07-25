using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TryItOut.ViewModels
{
    public class RailwayViewModel<T> : BaseViewModel
    {
        private List<T> _listOf;
        private bool _hasData;

        public List<T> ListOf { get => _listOf; set => _listOf = value; }
        public bool HasData { get => _hasData; set => _hasData = value; }

        public RailwayViewModel()
        {
            ListOf = new List<T>();

            Message = new MessageBaseViewModel();
            this.Message.Text = "Error : Initial Status.";
        }
    }
}