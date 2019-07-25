using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryItOut.Service.DTOs;

namespace TryItOut.Service.Interfaces
{
    public interface ILocomotiveService : IDisposable
    {
        void Locomotives();

        LocomotiveDTO Read(int id);

        LocomotivesDTO read();

        LocomotiveDetailsDTO ReadDetails(int id);

        LocomotivesDetailsDTO ReadDetails();

        void Save();

        void Delete();

        void Update();

    }


}
