using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WheelOfFortune.Tests
{
    [TestClass]
    public class WheelTests
    {
        [TestMethod]
        public void TestConstructor()
        {
            var wheel = new Wheel();
            var expected = 900;
            var actual = wheel.SelectedSpoke;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSpin()
        {
            var wheel = new Wheel();
            var expected = wheel.SelectedSpoke;
            var actual = wheel.Spin();

            Assert.AreEqual(expected, actual);
        }
    }
}
