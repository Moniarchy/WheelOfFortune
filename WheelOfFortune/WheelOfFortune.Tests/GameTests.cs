using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
namespace WheelOfFortune.Tests
{
    [TestClass]
    public class GameTests
    {

        [TestMethod]
        public void TestSolveTheWordIfGuessIsCorrect()
        {
            // arrange
            var game = new Game();
            var guessWord = "Doggie";
            var sr = new StringReader(guessWord);
            Console.SetIn(sr);
            
            //act
            game.SolveTheWord();
            
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
            game.SolveTheWord();

            //assert
            Assert.IsFalse(game.GameOver);
        }
    }
}
