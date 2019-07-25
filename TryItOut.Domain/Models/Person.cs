using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryItOut.Domain
{
    public class Person : IPerson
    {       
        public string Name { get; set; }
     
        public string Address { get; set; }
     
        public string Postcode { get; set; }

        public string Nationality { get; set; }
     
        public string Identifier { get; set; }

        public DateTime? dob { get; set; }

        public Person() {

            Identifier = string.Empty;
            Name = string.Empty;
            Address = string.Empty;
            Postcode = string.Empty;
            Nationality = string.Empty;
            dob = DateTime.MinValue;
        }
    }
}
