using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryItOut.Service.DTOs;

namespace TryItOut.CommonInterfaces
{
    public interface ILocomotiveService : IDisposable
    {
        void Locomotives();

        LocomotiveDTO Read(int id);

        List<LocomotiveDTO> read();

        void Save();

        void Delete();

        void Update();
    }


}
