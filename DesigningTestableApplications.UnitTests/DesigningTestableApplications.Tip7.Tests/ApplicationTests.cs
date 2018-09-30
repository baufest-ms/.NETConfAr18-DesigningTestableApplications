using DesigningTestableApplications.Tip7.Good;
using DesigningTestableApplications.Tip7.Good.Wrapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DesigningTestableApplications.Tip7.Tests
{
    [TestClass]
    public class ApplicationTests
    {
        [TestMethod]
        public void DoWork()
        {
            // Setup preconditions including the setup of mock objects
            var thirdPartyLibraryMock = new Mock<IWrapper>();
            thirdPartyLibraryMock.Setup(x => x.DoWork("Tip", 7)).Returns("Tip7");

            //Inject mocked dependencies
            var application = new Application(thirdPartyLibraryMock.Object);

            // Execute the code to be tested
            var result = application.Method();

            // Assert on the expected results
            Assert.AreEqual("Tip7", result);

            // Verify that the mock object was called the expected number of times and with the expected parameters
            thirdPartyLibraryMock.Verify(x => x.DoWork("Tip", 7), Times.Once);
        }
    }
}
