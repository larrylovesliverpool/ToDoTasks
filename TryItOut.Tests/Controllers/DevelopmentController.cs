using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TryItOut.Controllers;

namespace TryItOut.Tests.Controllers
{
    [TestClass]
    public class DevelopmentControllerTest
    {
        [TestMethod]
        [Description("Development Controller Unit test")]
        [Owner("ddm")]
        [TestCategory("Controller")]
        public void TestForIndexController()
        {
            // Arrange
            DevelopmentController controller = new DevelopmentController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        [Owner("ddm")]
        [TestCategory("Controller")]
        public void TestForIndexView()
        {
            // Arrange
            DevelopmentController controller = new DevelopmentController();

            // Act
            var result = controller.Index() as ViewResult;

            // Assert
            Assert.AreEqual("Index", result.ViewName);
        }

        [TestMethod]
        [Owner("ddm")]
        [TestCategory("Controller")]
        public void TestForAltController()
        {
            // Arrange
            DevelopmentController controller = new DevelopmentController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        [Owner("ddm")]
        [TestCategory("Controller")]
        public void TestForAltView()
        {
            // Arrange
            DevelopmentController controller = new DevelopmentController();

            // Act
            var result = controller.Alt() as ViewResult;

            // Assert
            Assert.AreEqual("Alt", result.ViewName);
        }
    }
}
