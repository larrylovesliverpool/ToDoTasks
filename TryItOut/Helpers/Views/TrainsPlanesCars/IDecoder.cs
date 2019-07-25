using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryItOut.ViewModels;

namespace TryItOut.Helpers.Views
{
    public interface IDecoderhelper
    {
        RailwayViewModel<RailwayDecoder> CreateviewModel();
    }
}
