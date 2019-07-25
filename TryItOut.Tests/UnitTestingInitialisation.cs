using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TryItOut.Tests.FileProcess
{
    [TestClass]
    public class UnitTestingInitialisation
    {
        [AssemblyInitialize]
        public static void AssemblyInitialise(TestContext tc)
        {
            tc.WriteLine("Assmbly initialise");
        }

        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {

        }
    }
}
