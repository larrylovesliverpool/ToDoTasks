using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TryItOut.CommonInterfaces
{
    public interface IAddress
    {
        string GetAddress();

        string GetTown();

        string GetPostCode();
    }
}