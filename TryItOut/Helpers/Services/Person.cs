using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TryItOut.Helpers.Services
{
    public class Person : IPerson
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public string AddressGet()
        {
            return Address;
        }

        public string NameGet()
        {
            return Name;
        }
    }
}