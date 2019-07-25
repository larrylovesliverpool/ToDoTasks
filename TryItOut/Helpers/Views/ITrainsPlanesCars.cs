using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryItOut.ViewModels;

namespace TryItOut.Helpers.Views
{
    public interface ITrainsPlanesCars
    {
        /* View model for displaying all locomotives */
        LocomotivesViewModel CreateLocomotivesViewModel();

        /* View model for editing loco details */
        LocomotiveEditViewModel CreateLocomotiveViewModel();

        /* View Model for display details of a locomotive */
        LocomotiveDetailsViewModel CreateLocomotiveDetailsViewModel(int identifier);

        /* View model for displaying all locomotive types */
        LocomotiveTypesViewModel CreateLocomotiveTypesViewModel();

        /* View model for New/editing loco types */
        LocomotiveTypeEditViewModel CreateLocomotiveTypeEditViewModel();

        LocomotiveTypeEditViewModel CreateLocomotiveTypeEditViewModel(int identifier);

        /* View model for displaying all railway manufacturers */
        RailwaysManufacturersViewModel CreateRailwayManufacturersViewModel();
    }
}
