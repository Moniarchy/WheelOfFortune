using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheelOfFortune
{
    public class Word
    {
        public string Answer;
        public string[] AlreadyGuessedLetters;
        public string CurrentlyDisplayedString;

        /// <summary>
        /// This is a method that takes a string and converts each char
        /// to and " _ " value
        /// </summary>
        /// <param name="wordToGuess">Takes in the word for the player to guess</param>
        public static void HideWord(string wordToGuess)
        {
            
            StringBuilder displayToPlayer = new StringBuilder(wordToGuess.Length);
            for (int i = 0; i < wordToGuess.Length; i++)
                displayToPlayer.Append(" _ ");

            Console.WriteLine(displayToPlayer);
        }

        public string ShowGuessedLetters()
        {
            //Areanna
            return "";
        }
    }
}
