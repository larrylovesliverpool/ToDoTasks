using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryItOut.Service.DTOs;

namespace TryItOut.Service.Interfaces
{
    public interface IRailwayDecoderService<T>
    {
        T Read(int id);

        RailwayDTO<T> Read();

        void Save();

        void Delete();

        void Update();
    }
}
