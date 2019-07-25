using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TryItOut.Service;

namespace TryItOut.Tests.FileProcess
{
    [TestClass]
    public class FileProcessTest
    {
        private const string badFileName = @"C:\Development-TryItOut\Tasks\TryItOut\App_Data\toDoTask.xml";
        private const string actFileName = @"C:\Development-TryItOut\Tasks\TryItOut\App_Data\toDoTasks.xml";

        public TestContext TestContext { get; set; }

        #region Initialise & Cleanup

        [ClassInitialize]
        public static void ClassInitialise(TestContext tc)
        {
            tc.WriteLine("Class initialisation.");
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {

        }

        #endregion

        #region test method initialise and cleanup

        [TestInitialize]
        public void TestInitialise()
        {
            TestContext.WriteLine("TestInitialise");
        }


        [TestCleanup]
        public void TestCleanup()
        {
            TestContext.WriteLine("TestCleanup");
        }

        #endregion

        [TestMethod]
        [Owner("ddm")]
        [TestCategory("FileProcess")]
        public void FileProcessInstanceNotNull()
        {
            // Arrange
            Service.FileProcess fp = new Service.FileProcess();

            // Assert
            Assert.IsNotNull(fp);
        }

        [TestMethod]
        [TestCategory("FileProcess")]
        public void FileNameDoesExist()
        {
            TestContext.WriteLine("Starting FileNameDoesExist");

            Service.FileProcess fp = new Service.FileProcess();

            var reslt = fp.FileExists(@"C:\Development-TryItOut\Tasks\TryItOut\App_Data\toDoTasks.xml");

            Assert.IsTrue(reslt);

            TestContext.WriteLine("Finished FileNameDoesExist");
        }

        [TestMethod]
        [TestCategory("FileProcess")]
        public void FileNameDoesExistMessage()
        {
            TestContext.WriteLine("Starting FileNameDoesExist");

            Service.FileProcess fp = new Service.FileProcess();

            var reslt = fp.FileExists(badFileName);

            Assert.IsTrue(reslt,"File does not exist. {0}", badFileName);

            TestContext.WriteLine("Finished FileNameDoesExist");
        }

        [TestMethod]
        [TestCategory("FileProcess")]
        public void FileNameDoesNotExist()
        {
            Service.FileProcess fp = new Service.FileProcess();

            var reslt = fp.FileExists(badFileName);

            Assert.IsFalse(reslt);
        }

        [TestMethod]
        [TestCategory("FileProcess")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FileNameNullorEmpty_ThrowsException()
        {
            Service.FileProcess fp = new TryItOut.Service.FileProcess();

            // Throws exception as Empty filename
            fp.FileExists("");
        }

        [TestMethod]
        [TestCategory("FileProcess")]
        public void FileNameNullorEmpty_ThrowsException_TryCatch()
        {
            Service.FileProcess fp = new TryItOut.Service.FileProcess();

            try
            {
                // Throws exception as Empty filename
                fp.FileExists("");
            }
            catch( ArgumentNullException)
            {
                // Success as trapped exception
                return;
            }

            Assert.Fail("Arguement Exception not thrown.");
        }
    }
}
