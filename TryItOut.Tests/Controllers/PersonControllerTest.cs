using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TryItOut.Controllers;

namespace TryItOut.Tests.Controllers
{
    [TestClass]
    public class PersonControllerTest
    {
        /* Pointers to adopt 

             1. Name convention : UnitOfWork_InitialCondition_ExpectedResult 
             2. Strategy for tests
                a. successful path through method. 
                b. unsucessful paths(s) through method */

        [TestMethod]
        [Owner("ddm")]
        [TestCategory("Controller")]
        public void UserLogin_Controller_ViewResultNotNull()
        {
            // Arrange
            PersonController controller = new PersonController();

            // Act
            ViewResult result = controller.Login() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        [Owner("ddm")]
        [TestCategory("Controller")]
        public void UserLogin_Controller_ViewResultMatches()
        {
            // Arrange
            PersonController controller = new PersonController();

            // Act
            var result = controller.Login() as ViewResult;

            // Assert
            Assert.AreEqual("Login", result.ViewName);
        }

    }
}
