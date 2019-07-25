using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryItOut.Service.DTOs
{
    public class LocomotiveClassificationDTO
    {
        private int _classificationId;
        private string _power;
        private string _classification;
        private string _comments;

        public int ClassificationId { get => _classificationId; set => _classificationId = value; }
        public string Power { get => _power; set => _power = value; }
        public string Classification { get => _classification; set => _classification = value; }
        public string Comments { get => _comments; set => _comments = value; }
    }

    public class LocomotiveClassificationsDTO
    {
        public bool hasTypes { get; set; }

        public int count { get; set; }

        public List<LocomotiveClassificationDTO> listOfClassifications { get; set; }

        public LocomotiveClassificationsDTO() {

            hasTypes = false;
            count = 0;

            listOfClassifications = new List<LocomotiveClassificationDTO>();
        }
    }
}
