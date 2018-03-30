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

        public Word(string answer)
        {
            this.Answer = answer;
        }



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

        /// <summary>
        /// This is a method that instantiates Random, takes an array of strings called wordBank and assigns a 
        /// string called wordToGuess to one of those random string in the array
        /// </summary>
        public static void RandomWordFromWordBank()
        {
            Random random = new Random((int)DateTime.Now.Ticks);
            string[] wordBank = { "groovie", "ghoulie", "cramps", "bad", "brains", "dead", "kennedys", "milkmen", "crass", "naked", "aggression", "doggie", "apple", "on", "are", "as", "with", "his", "they", "I", "at", "be", "this", "have", "from", "or", "one", "had", "by", "word", "but", "not", "what", "all", "were", "we", "when", "your", "can", "said", "there", "use", "an", "each", "which", "she", "do", "how", "their", "if", "will", "up", "other", "about", "out", "many", "then", "them", "these", "so", "some", "her", "would", "make", "like", "him", "into", "time", "has", "look", "two", "more", "write", "go", "see", "number", "no", "way", "could", "people", "my", "than", "first", "water", "been", "call", "who", "oil", "its", "now", "find", "long", "down", "day", "did", "get", "come", "made", "may", "part" };
            string wordToGuess = wordBank[random.Next(0, wordBank.Length)];

            HideWord(wordToGuess);

        }

        public string ShowGuessedLetters()
        {

            return ";";
        }
        
    }
}
