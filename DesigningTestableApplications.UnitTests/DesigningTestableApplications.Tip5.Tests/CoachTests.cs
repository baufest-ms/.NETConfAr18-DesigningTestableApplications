using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DesigningTestableApplications.Tip5.Tests
{
    [TestClass]
    public class CoachTests
    {
        [TestMethod]
        public void SelectPlayerForMatch()
        {
            // Setup preconditions including the setup of mock objects
            var coach = new Coach();
            var playerMock = new Mock<IPlayer>();

            //Inject mocked dependencies
            //Execute the code to be tested
            coach.SelectPlayerForMatch(playerMock.Object);

            //Assert on the expected results
            Assert.AreEqual(1, coach.Players.Count);
            Assert.AreEqual(playerMock.Object, coach.Players[0]);

            // Verify that the mock object was called the expected number of times and with the expected parameters
            playerMock.Verify(x => x.Selected(), Times.Once);
        }
    }
}
