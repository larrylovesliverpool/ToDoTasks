using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TryItOut.ViewModels
{
    public class LocomotiveTypeViewModel
    {
        private int _typeId;
        private string _type;
        private string _classification;
        private string _comments;

        public int TypeId { get => _typeId; set => _typeId = value; }
        public string Type { get => _type; set => _type = value; }
        public string Classification { get => _classification; set => _classification = value; }
        public string Comments { get => _comments; set => _comments = value; }
    }

    public class LocomotiveTypesViewModel : BaseViewModel
    {
        private List<LocomotiveTypeViewModel> _locomotivesTypes;
        private bool hasTypes;

        public List<LocomotiveTypeViewModel> LocomotivesTypes { get => _locomotivesTypes; set => _locomotivesTypes = value; }
        public bool HasTypes { get => hasTypes; set => hasTypes = value; }

        public LocomotiveTypesViewModel()
        {
            LocomotivesTypes = new List<LocomotiveTypeViewModel>();

            Message = new MessageBaseViewModel();
            this.Message.Text = "Error : Initial Status.";
        }
    }
}