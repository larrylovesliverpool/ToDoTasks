using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryItOut.ViewModels;

namespace TryItOut.Helpers.Views
{
    public interface IViewModelFactory
    {
        HomeViewModel CreateHomeViewModel(string title, string message);

        AboutViewModel CreateAboutViewModel();
    }
}
