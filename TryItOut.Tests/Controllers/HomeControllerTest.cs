using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TryItOut;
using TryItOut.Controllers;

namespace TryItOut.Tests.Controllers
{
    /* Pointers to adopt 
     
         1. Name convention : UnitOfWork_InitialCondition_ExpectedResult 
         2. Strategy for tests
            a. successful path through method. 
            b. unsucessful paths(s) through method */

    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        [Owner("ddm")]
        [TestCategory("Controller")]
        public void HomeController_ViewResultNotNull()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        [Owner("ddm")]
        [TestCategory("Controller")]
        public void HomeController_IndexViewName()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            var result = controller.Index() as ViewResult;

            // Assert
            Assert.AreEqual("Index", result.ViewName);
        }

        [TestMethod]
        [Owner("ddm")]
        [TestCategory("Controller")]
        public void HomeController_AboutViewBagMessage()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        [Owner("ddm")]
        [TestCategory("Controller")]
        public void HomeController_AboutViewName()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            var result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("About", result.ViewName);
        }
    }
}
