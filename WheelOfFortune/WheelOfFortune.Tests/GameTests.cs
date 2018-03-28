using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
namespace WheelOfFortune.Tests
{
    [TestClass]
    public class GameTests
    {
        [TestMethod]
        public void UnitTestReadFromConsole1()
        {
            //arrange
            var expected = "micro";
            var sr = new StreamReader(expected);

            Console.SetIn(sr);

            //var actual = 


        }
    }
}
