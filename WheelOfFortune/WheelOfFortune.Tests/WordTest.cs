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
        public void TestSolveTheWordIfGuessIsCorrect()
        {
            // arrange
            var game = new Game();
            var guessWord = "microsoft";
            var sr = new StringReader(guessWord);
            Console.SetIn(sr);

            //act
            word.SolveTheWord();

            //assert
            Assert.IsTrue(game.GameOver);

        }

        [TestMethod]
        public void TestSolveTheWordIfGuessIsIncorrect()
        {
            // arrange
            var game = new Game();
            var guessWord = "macrosoft";
            var sr = new StringReader(guessWord);
            Console.SetIn(sr);

            //act
            word.SolveTheWord();

            //assert
            Assert.IsFalse(game.GameOver);
        }
    }
}
