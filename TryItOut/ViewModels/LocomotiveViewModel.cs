using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TryItOut.ViewModels
{
    public class LocomotiveViewModel
    {
        public int Identifier { get; set; }

        public string Name { get; set; }

        public int? Type { get; set; }

        public int? MadeBy { get; set; }

        public int? Decoder { get; set; }

        public int? DCCValue { get; set; }

        public string Description { get; set; }

        public int? YearPurchased { get; set; }
    }

    public class LocomotivesViewModel : BaseViewModel
    {
        private List<LocomotiveViewModel> _locomotives;
        private bool hasLocomotives;

        public List<LocomotiveViewModel> Locomotives { get => _locomotives; set => _locomotives = value; }
        public bool HasLocomotives { get => hasLocomotives; set => hasLocomotives = value; }

        public LocomotivesViewModel() {

            Locomotives = new List<LocomotiveViewModel>();

            Message = new MessageBaseViewModel();
            Message.Text = "Unfortunately there seems to be a Problem.";
        }
    }

    public class LocomotiveDetailsViewModel
    {
        public int LocoId { get; set; }

        public string Name { get; set; }

        public int MadeBy { get; set; }

        public string Manufacturer { get; set; }

        public int Decoder { get; set; }

        public string DecoderDetails { get; set; }

        public int? DCCValue { get; set; }

        public string Description { get; set; }

        public int? YearPurchased { get; set; }

        public int? Classification { get; set; }

        public string ClassificationDetails { get; set; }

        public string Power { get; set; }
    }

    public class LocomotivesDetailsViewModel : BaseViewModel
    {
        private List<LocomotiveDetailsViewModel> _locomotives;
        private bool hasLocomotives;

        public List<LocomotiveDetailsViewModel> Locomotives { get => _locomotives; set => _locomotives = value; }
        public bool HasLocomotives { get => hasLocomotives; set => hasLocomotives = value; }

        public LocomotivesDetailsViewModel()
        {
            Locomotives = new List<LocomotiveDetailsViewModel>();
            Message = new MessageBaseViewModel();
            Message.Text = "Unfortunately there seems to be a Problem.";
        }
    }

    public class LocomotiveDetailsIdViewModel : BaseViewModel
    {

    }

}