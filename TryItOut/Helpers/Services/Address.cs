using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TryItOut.Helpers.Interfaces;

namespace TryItOut.Helpers.Services
{
    public class Address : IAddress
    {
        public string GetAddress()
        {
            throw new NotImplementedException();
        }

        public string GetPostCode()
        {
            throw new NotImplementedException();
        }

        public string GetTown()
        {
            throw new NotImplementedException();
        }
    }
}