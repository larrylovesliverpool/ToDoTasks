using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TryItOut.ViewModels
{
    public class RailwaysManufacturerViewModel
    {
        private int _manufacturerId;
        private string _name;

        public int manufacturerId { get => _manufacturerId; set => _manufacturerId = value; }
        public string Name { get => _name; set => _name = value; }
    }

    public class RailwaysManufacturersViewModel : BaseViewModel
    {
        private List<RailwaysManufacturerViewModel> _manufacturers;
        private bool _hasManufacturers;

        public List<RailwaysManufacturerViewModel> Manufacturers { get => _manufacturers; set => _manufacturers = value; }
        public bool HasManufacturers { get => _hasManufacturers; set => _hasManufacturers = value; }

        public RailwaysManufacturersViewModel()
        {
            Manufacturers = new List<RailwaysManufacturerViewModel>();

            Message = new MessageBaseViewModel();
            this.Message.Text = "Error : Initial Status.";
        }
    }
}