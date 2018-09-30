using DesigningTestableApplications.Tip1.Bad;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace DesigningTestableApplications.Tip1.Tests.Bad
{
    [TestClass]
    public class ApplicationTests
    {
        [TestMethod]
        public void GetLast10LoggedMessages()
        {
            var application = new Application();
            IList<string> messages = application.GetLast10LoggedMessages();

            Assert.AreEqual(10, messages.Count);

            for (int i = 0; i < 10; i++)
            {
                Assert.AreEqual((i + 1).ToString(), messages[i]);
            }
        }

        [TestMethod]
        public void GetLast10LoggedMessagesFromCloud()
        {
            var application = new Application();
            IList<string> messages = application.GetLast10LoggedMessagesFromCloud();

            Assert.AreEqual(10, messages.Count);

            for (int i = 0; i < 10; i++)
            {
                Assert.AreEqual((i + 11).ToString(), messages[i]);
            }
        }
    }
}
