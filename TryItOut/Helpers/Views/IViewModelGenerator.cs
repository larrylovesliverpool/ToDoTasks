using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryItOut.Helpers.Views
{
    public interface IViewModelGenerator<T>
    {
        T CreateViewModel();
    }
}
