using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace WheelOfFortune.Tests
{
    [TestClass]
    public class WordTests
    {
        [TestMethod]
        public void TestShowGuessedLetters()
        {
            //arrange
            Word word = new Word("Microsoft");
            string expectedString = "m________\r\n";
            var sw = new StringWriter();
            Console.SetOut(sw);

            //act
            word.ShowGuessedLetters("m");


            // assert
            Assert.AreEqual(expectedString, sw.ToString());
        }
    }
}
