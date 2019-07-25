using System;
using TryItOut.Service.DTOs;

namespace TryItOut.Service.Interfaces
{
    public interface IRailwaysManufacturService : IDisposable
    {
        RailwaysManufacturerDTO Read(int id);

        RailwaysManufacturersDTO Read();

        void Save();

        void Delete();

        void Update();
    }
}
