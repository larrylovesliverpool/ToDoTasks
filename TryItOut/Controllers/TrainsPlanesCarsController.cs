using System;
using System.Web.Mvc;
using TryItOut.Helpers.Views;
using TryItOut.Service.Interfaces;
using TryItOut.ViewModels;

namespace TryItOut.Controllers
{
    public class TrainsPlanesCarsController : Controller
    {
        readonly ILocomotiveService service = null;
        readonly ITrainsPlanesCars helper = null;
        readonly IDecoderhelper decoderhelper = null;

        public TrainsPlanesCarsController(ILocomotiveService service, 
                                          ITrainsPlanesCars helper,
                                          IDecoderhelper decoderhelper) {

            this.service = service;
            this.helper = helper;
            this.decoderhelper = decoderhelper;
        }

        public ActionResult Index()
        {
            LocomotivesDetailsViewModel vm = new LocomotivesDetailsViewModel();

            var dto = service.ReadDetails();

            /* map dto to view model */

            if (dto.HasLocomotives)
            {
                vm.HasLocomotives = true;

                foreach (var loco in dto.listOfLocomotives)
                {
                    vm.Locomotives.Add(new LocomotiveDetailsViewModel() {

                        LocoId = loco.LocoId,
                        Name = loco.Name,
                        MadeBy = loco.MadeBy,
                        Manufacturer = loco.Manufacturer,
                        DCCValue = loco.DCCValue,
                        Decoder = loco.Decoder,
                        DecoderDetails = loco.DecoderDetails,
                        Description = loco.Description,
                        YearPurchased = loco.YearPurchased,
                        Classification = loco.Classification,
                        ClassificationDetails = loco.ClassificationDetails
                    });
                }
            }
            else
            {
                vm.HasLocomotives = false;
            }

            return View(vm);
        }

        public ActionResult LocoEditNew()
        {
            var vm = new LocomotiveEditViewModel();

            return View(vm);
        }

        [HttpPost]
        public ActionResult LocoEditNew(FormCollection frmcollection)
        {
            LocomotiveViewModel vm = new LocomotiveViewModel();

            if( ModelState.IsValid)
            {

            }

            return View(vm);
        }

        public ActionResult LocomotiveDetailsId(int locoId)
        {
            var vm = new TryItOut.ViewModels.LocomotiveDetailsViewModel();
            vm = helper.CreateLocomotiveDetailsViewModel(locoId);

            return PartialView("_LocoDetailsId",vm);
        }

        #region locotype

        /* Loco type index page */
        public ActionResult LocoType()
        {
            var vm = helper.CreateLocomotiveTypesViewModel();

            return View(vm);
        }

        public ActionResult LocoTypeNew()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LocoTypeEdit(FormCollection frmcollection)
        {
            return View(helper.CreateLocomotiveTypeEditViewModel(Convert.ToInt32(frmcollection["Hidden-identifier"])));
        }

        [HttpPost]
        public ActionResult LocoTypeEditNew(FormCollection frmcollection)
        {

            if (ModelState.IsValid)
            {

            }

            return View();
        }

        public ActionResult LocoTypeDetails()
        {
            return PartialView("_LocoTypeDetails");
        }

        #endregion

        #region Manufacturer

        public ActionResult RailwaysManufacturer()
        {
            var vm = helper.CreateRailwayManufacturersViewModel();

            return View(vm);
        }

        public ActionResult RailwayManufacturerNew() {

            return View();
        }

        public ActionResult RailwayManufacturerEdit(FormCollection frmcollection)
        {
            var vm = helper.CreateRailwayManufacturersViewModel();

            return View(vm);
        }

        [HttpPost]
        public ActionResult RailwayManufacturerEditNew(FormCollection frmcollection)
        {

            if (ModelState.IsValid)
            {

            }

            return View();
        }

        #endregion

        #region Decoder

        public ActionResult RailwayDecoders() {

            RailwayViewModel<RailwayDecoder> vm = new RailwayViewModel<RailwayDecoder>();

            vm = decoderhelper.CreateviewModel();


            return View(vm);
        }

        public ActionResult RailwayDecoderNew()
        {
            var vm = new RailwayDecoderEditNewViewModel();

            return View(vm);
        }

        #endregion

    }
}
