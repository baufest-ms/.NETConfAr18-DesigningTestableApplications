using System.Collections.Generic;
using DesigningTestableApplications.Tip1.Good;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesigningTestableApplications.Tip1.Tests.Good
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
    }
}
