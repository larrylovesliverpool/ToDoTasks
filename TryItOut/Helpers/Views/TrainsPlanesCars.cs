using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TryItOut.CommonInterfaces;
using TryItOut.Service.Interfaces;
using TryItOut.ViewModels;

namespace TryItOut.Helpers.Views
{
    /* ******************************************** */
    /* helper class for TrainsPlanesCars Controller */
    /* ******************************************** */

    public class TrainsPlanesCars : ITrainsPlanesCars
    {
        readonly ILocomotiveService LocomotiveService = null;
        readonly ILocomotiveTypeService TypeService = null;
        readonly IRailwaysManufacturService ManufacturersService = null;

        public TrainsPlanesCars(ILocomotiveService locomotiveService,
                                ILocomotiveTypeService typeService,
                                IRailwaysManufacturService manufacturesService) {

            this.LocomotiveService = locomotiveService;
            this.TypeService = typeService;
            this.ManufacturersService = manufacturesService;
        }

        /* ********** */
        /* Locomotive */
        /* ********** */
        LocomotivesViewModel ITrainsPlanesCars.CreateLocomotivesViewModel()
        {
            throw new NotImplementedException();
        }

        LocomotiveEditViewModel ITrainsPlanesCars.CreateLocomotiveViewModel()
        {
            LocomotiveEditViewModel vm = new LocomotiveEditViewModel();

            return vm;
        }

        LocomotiveDetailsViewModel ITrainsPlanesCars.CreateLocomotiveDetailsViewModel(int identifier)
        {
            var vm = new LocomotiveDetailsViewModel();
            var dto = LocomotiveService.ReadDetails(identifier);

            /* mapper */

            vm.LocoId = dto.LocoId;
            vm.Name = dto.Name;
            vm.ClassificationDetails = dto.ClassificationDetails;
            vm.DCCValue = dto.DCCValue;
            vm.DecoderDetails = dto.DecoderDetails;
            vm.Description = dto.Description;
            vm.Manufacturer = dto.Manufacturer;
            vm.YearPurchased = dto.YearPurchased;
            vm.Power = dto.Power;

            return vm;
        }

        /* *************** */
        /* Locomotive Type */
        /* *************** */
        LocomotiveTypeEditViewModel ITrainsPlanesCars.CreateLocomotiveTypeEditViewModel()
        {
            var vm = new LocomotiveTypeEditViewModel();

            return vm;
        }

        LocomotiveTypeEditViewModel ITrainsPlanesCars.CreateLocomotiveTypeEditViewModel(int identifier)
        {
            LocomotiveTypeEditViewModel vm = new LocomotiveTypeEditViewModel();
            var dto = TypeService.Read(identifier);

            /* map to */

            vm.identifier = dto.ClassificationId;
            vm.Power = dto.Power;
            vm.Classification = dto.Classification;
            vm.Comments = dto.Comments;

            return vm;
        }

        LocomotiveTypesViewModel ITrainsPlanesCars.CreateLocomotiveTypesViewModel()
        {
            LocomotiveTypesViewModel vm = new LocomotiveTypesViewModel();

            var dto = TypeService.Read();

            /* map dto to view model */

            if (dto.hasTypes)
            {
                vm.HasTypes = true;

                foreach (var type in dto.listOfClassifications)
                {
                    vm.LocomotivesTypes.Add(new LocomotiveTypeViewModel()
                    {
                        TypeId = type.ClassificationId,
                        Type = type.Power,
                        Classification = type.Classification,
                        Comments = type.Comments
                    });
                }
            }
            else
            {
                vm.HasTypes = false;
            }

            return vm;
        }

        /* ********************* */
        /* Railway Manufacturers */
        /* ********************* */

        public RailwaysManufacturersViewModel CreateRailwayManufacturersViewModel()
        {
            RailwaysManufacturersViewModel vm = new RailwaysManufacturersViewModel();

            var dto = ManufacturersService.Read();

            /* map dto to viewmodel */

            if (dto.hasManufacturers)
            {
                vm.HasManufacturers = true;

                foreach (var man in dto.listOfManufacturers)
                {
                    vm.Manufacturers.Add(new RailwaysManufacturerViewModel()
                    {
                        manufacturerId = man.ManufacturerId,
                        Name = man.Name
                    });
                }
            }
            else
            {
                vm.HasManufacturers = false;
            }

            return vm;
        }

    }

}