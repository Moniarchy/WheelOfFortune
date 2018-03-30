using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WheelOfFortune.Tests
{
    [TestClass]
    public class WordTest
    {
        [TestMethod]
        public void HideWordTest()
        {

            // arrange
            var expected = "rainbow";
            var sw = new StringWriter();
            Console.SetOut(sw);

            //act
            Word.HideWord(expected);


            // assert
            Assert.AreNotEqual(expected, sw.ToString());

        }
        [TestMethod]
        public void RandomWordFromWordBankTest()
        {

            // arrange
            var expected = "microsoft";
            var sw = new StringWriter();
            Console.SetOut(sw);

            //act
            Word.RandomWordFromWordBank();


            // assert
            Assert.AreNotEqual(expected, sw.ToString());

        }

       
    }
}
