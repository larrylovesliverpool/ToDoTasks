using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TryItOut.Service;
using TryItOut.Helpers.DropDownLists;

namespace TryItOut.ViewModels
{
    public class RailwayDecoderEditNewViewModel :  BaseViewModel
    {
        public int DecoderId { get; set; }

        [Required]
        [Display(Name = "Manufacturer")]
        public string SelectedMadeBy { get; set; }
        public SelectList Manufacturer { get; set; }

        [Required]
        [Display(Name = "Stay A Live")]
        public string SelectedStayaLive { get; set; }
        public SelectList StayALive { get; set; }

        [Required]
        [Display(Name = "Connector Type")]
        public string Type { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        public RailwayDecoderEditNewViewModel() {

            this.Manufacturer = ManufacturersDDL.ManufacturersSelectList();
            this.StayALive = StayALiveDDL.StayALiveSelectList();
        }
    }
}