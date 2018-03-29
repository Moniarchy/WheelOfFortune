using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WheelOfFortune.Tests
{
    [TestClass]
    public class PlayerTests
    {
        [TestMethod]
        public void TestPlayerConstructor()
        {
            var player = new Player("Player1");
            var expectedName = "Player1";
            var expectedTotalMoney = 0;
            Assert.AreEqual(expectedName, player.Name);
            Assert.AreEqual(expectedTotalMoney, player.TotalMoney);
        }
    }
}
