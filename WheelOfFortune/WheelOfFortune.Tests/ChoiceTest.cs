using System;
using System.Diagnostics;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WheelOfFortune.Tests
{
    [TestClass]
    public class ChoiceTest
    {
        [TestMethod]
        public void TestMsgsPrint()
        {
            //arrange
            var expected = "What would you like to do? \nPlease choose one: \n1) Guess a letter \n2) Guess the word \n3) Exit game";

            //act
            var choice = new Choice(); 
            string actual = choice.PrintMsgs();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestTakeOutOfRange()
        {
            //arrange
            var expected = "7";


            //act
            var range = new Choice();
            range.TakeChoice(expected);

            //assert
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidCastException))]
        public void TestTakeOutIfNotInt()
        {
            //arrange
            var expected = "H";
            //act
            var range = new Choice();
            range.TakeChoice(expected);

            //assert
        }

        [TestMethod]
        public void TestTakeChoiceIfCorrectNumOne()
        {
            //arrange
            var expected = "GuessTheLetter();";
            var number = "1";

            //act
            var choice = new Choice();
            string actual = choice.TakeChoice(number);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestTakeChoiceIfCorrectNumTwo()
        {
            //arrange
            var expected = "GuessTheWord();";
            var number = "2";

            //act
            var choice = new Choice();
            string actual = choice.TakeChoice(number);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestTakeChoiceIfCorrectNumThree()
        {
            //arrange
            var expected = "ExitGame();";
            var number = "3";

            //act
            var choice = new Choice();
            string actual = choice.TakeChoice(number);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestActOnChoiceDefault()
        {
            //arrange
            var expected = "Please choose a number.";
            var number = 4;

            //act
            var choice = new Choice();
            string actual = choice.ActOnChoice(number);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
