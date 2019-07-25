using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TryItOut.Service;

namespace TryItOut.Helpers.DropDownLists
{
    public static class ManufacturersDDL
    {
        public static SelectList ManufacturersSelectList() {

            var listOfManufacturers = new List<SelectListItem>();

            RailwaysManufacturersListOf manService = new RailwaysManufacturersListOf();

            foreach (var tuple in manService.GetListOfManufacturers())
            {
                listOfManufacturers.Add(new SelectListItem() { Text = tuple.Item2, Value = tuple.Item1.ToString() });
            }

            var selectList = new SelectList(listOfManufacturers, "Value", "Text");

            return selectList;
        }
    }
}