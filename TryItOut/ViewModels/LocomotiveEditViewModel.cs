using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using TryItOut.Service;

namespace TryItOut.ViewModels
{
    public enum Manufacturer
    {
        Hornby,
        Bachmans,
        Heljan,
        Dapol
    }

    public class LocomotiveEditViewModel : BaseViewModel
    {
        [Required]
        [Display(Name="Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name="Description")]
        public string Description { get; set; }

        [Required]
        [Display(Name="Locomotive Type")]
        public string SelectedType { get; set; }
        public SelectList LocoType { get; set; }

        [Required]
        [Display(Name="Manufacturer")]
        public string SelectedMadeBy { get; set; }
        public SelectList Manufacturer { get; set; }

        public int Decoder { get; set; }

        public int DCCValue { get; set; }

        public int YearPurchased { get; set; }

        public LocomotiveEditViewModel()
        {
            var listOfManufacturers = new List<SelectListItem>();

            RailwaysManufacturersListOf manService = new RailwaysManufacturersListOf();

            foreach (var tuple in manService.GetListOfManufacturers())
            {
                listOfManufacturers.Add(new SelectListItem() { Text = tuple.Item2, Value = tuple.Item1.ToString() });
            }

            this.Manufacturer = new SelectList(listOfManufacturers, "Value", "Text");

            /* Locomotive types */

            var listOfLocomotiveTypes = new List<SelectListItem>();

            LocomotiveTypesListOf typeService = new LocomotiveTypesListOf();

            foreach (var tuple in typeService.GetListOfLocomotiveTypes())
            {
                listOfLocomotiveTypes.Add(new SelectListItem() { Text = tuple.Item2, Value = tuple.Item1.ToString() });
            }

            this.LocoType = new SelectList(listOfLocomotiveTypes, "Value", "Text");
        }

    }

}