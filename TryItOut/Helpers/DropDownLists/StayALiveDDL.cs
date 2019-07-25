using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TryItOut.Service;

namespace TryItOut.Helpers.DropDownLists
{
    public static class StayALiveDDL
    {
        public static SelectList StayALiveSelectList() {

            var listOfStayALive = new List<SelectListItem>();

            listOfStayALive.Add(new SelectListItem() { Text = "Yes", Value = "1" });
            listOfStayALive.Add(new SelectListItem() { Text = "No", Value = "2" });
            listOfStayALive.Add(new SelectListItem() { Text = "Unknown", Value = "3" });

            var selectList = new SelectList(listOfStayALive, "Value", "Text");

            return selectList;
        }
    }
}