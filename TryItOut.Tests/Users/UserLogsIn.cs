using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Telerik.JustMock;

namespace TryItOut.Tests.Users
{
    /* ********************** */
    /* Builder pattern
     * Build a mock service for tests */

    class ServiceBuilder
    {
    } 

    [TestClass]
    public class UserLogsInTests
    {
        [TestMethod]
        [Owner("ddm")]
        [TestCategory("UserLogsIn")]
        public void UserLogsIn_WithValidCred_RedirectToHome()
        {
            //Arrange
            //var http = Mock.Create<>();

            //Action

            //Assert
            Assert.Inconclusive();
        }

        [TestMethod]
        [Owner("ddm")]
        [TestCategory("UserLogsIn")]
        public void UserLogsIn_WithOutValidCred_ReturnFailure()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        [Owner("ddm")]
        [TestCategory("UserLogsIn")]
        public void UserLogsIn_FailsThreeTimes_LocksAccount()
        {
            Assert.Inconclusive();
        }
    }

}
