//using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

//namespace WheelOfFortune.Tests
//{
//    [TestClass]
//    public class PlayerTests
//    {
//        [TestMethod]
//        public void TestPlayerConstructor()
//        {
//            var player = new Player("Player1");

//            var expectedName = "Player1";
            
//            Assert.AreEqual(expectedName, player.Name);
//        }

//        [TestMethod]
//        public void TestPlayerRoundTotalDefault()
//        {
//            // Arrange
//            var player = new Player("Adam");

//            // Act
//            var expected = 0;
//            var actual = player.RoundTotal;

//            // Assert
//            Assert.AreEqual(actual, expected);
//        }

//        [TestMethod]
//        public void TestPlayerGameTotalDefault()
//        {
//            // Arrange
//            var player = new Player("Adam");

//            // Act
//            var expected = 0;
//            var actual = player.GameTotal;

//            // Assert
//            Assert.AreEqual(actual, expected);
//        }

//        [TestMethod]
//        public void TestPlayerGameTotalChanged()
//        {
//            // Arrange
//            var player = new Player("Adam");
//            player.GameTotal = 100;

//            // Act
//            var expected = 100;
//            var actual = player.GameTotal;

//            // Assert
//            Assert.AreEqual(actual, expected);
//        }

//        [TestMethod]
//        public void TestPlayerRoundTotalChanged()
//        {
//            // Arrange
//            var player = new Player("Adam");
//            player.RoundTotal = 100;

//            // Act
//            var expected = 100;
//            var actual = player.RoundTotal;

//            // Assert
//            Assert.AreEqual(actual, expected);
//        }
//    }
//}
