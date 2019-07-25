using System;
using System.Collections.Generic;

namespace TryItOut.Service
{
    public interface IRailwaysManufacturersListOf
    {
        List<Tuple<int, string>> GetListOfManufacturers();
    }
}