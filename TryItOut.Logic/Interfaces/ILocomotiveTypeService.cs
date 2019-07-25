using System;
using TryItOut.Service.DTOs;

namespace TryItOut.Service.Interfaces
{
    public interface ILocomotiveTypeService : IDisposable
    {
        LocomotiveClassificationDTO Read(int id);

        LocomotiveClassificationsDTO Read();

        void Save();

        void Delete();

        void Update();
    }
}
