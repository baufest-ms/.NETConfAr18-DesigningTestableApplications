using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesigningTestableApplications.Tip4.Tests
{
    [TestClass]
    public class CoachTests
    {
        [TestMethod]
        public void SelectPlayerForMatch()
        {
            //Setup preconditions
            var coach = new Coach();
            var player = new Player();

            //Execute the code to be tested
            coach.SelectPlayerForMatch(player);

            //Assert on the expected results
            Assert.IsTrue(player.IsSelected);
            Assert.AreEqual(100, player.Happiness);

            Assert.AreEqual(1, coach.Players.Count);
            Assert.AreEqual(player, coach.Players.ElementAt(0));
        }
    }
}
