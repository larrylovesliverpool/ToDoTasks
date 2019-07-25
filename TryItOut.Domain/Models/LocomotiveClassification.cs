using System.ComponentModel.DataAnnotations;

namespace TryItOut.Domain.Models
{
    public class LocomotiveClassification
    {
        private int _classificationId;
        private string _power;
        private string _classification;
        private string _comments;

        [Key]
        public int ClassificationId { get => _classificationId; set => _classificationId = value; }

        [StringLength(50)]
        public string Power { get => _power; set => _power = value; }

        [StringLength(50)]
        public string Classification { get => _classification; set => _classification = value; }

        [StringLength(200)]
        public string Comments { get => _comments; set => _comments = value; }
    }
}
