using System;
using System.Collections.Generic;
using System.Text;
using TryItOut.Helpers;
using TryItOut.Helpers.Interfaces;

namespace TryItOut.BusinessLogic
{
    public class PersonsDetails
    {
        IPerson person;
        IAddress address;

        public PersonsDetails() { }

        public PersonsDetails(IPerson person,IAddress address) {

            this.person = person;
            this.address = address;
        }
    }
}
