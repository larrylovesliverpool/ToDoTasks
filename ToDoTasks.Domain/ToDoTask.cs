using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ToDoTasks.Domain
{
    [Serializable]
    [XmlRoot("Tasks"), XmlType("Task")]
    public class ToDoTask
    {
        public int Identifier { get; set; }

        public string Description { get; set; }

        public bool Completed { get; set; }

        public bool Deleted { get; set; }
    }
}
