using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WheelOfFortune.Tests
{
    [TestClass]
    public class WheelTests
    {
        [TestMethod]
        public void TestInitialState()
        {
            var wheel = new Wheel();
            var expected = 900;
            var actual = wheel.SelectedSpoke;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSpin()
        {
            //arrange
            var wheel = new Wheel();

            //act
            var actualSpoke = wheel.Spin();

            //asserrt
            var result = Wheel.Spokes.Any(x => x == actualSpoke);
            Assert.IsTrue(result);
        }
    }
}
