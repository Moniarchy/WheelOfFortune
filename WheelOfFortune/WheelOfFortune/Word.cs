using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheelOfFortune
{
    /// <summary>
    ///  The Word class contains all logic that is associated with the word's current state and the updating of that state. It holds onto the answer(which is currently hard coded) and the initial string, which is just underscores.
    ///  This class is instantiated in the Game class. For now, each instance of game has one word. In the future, each round will have one word.
    /// </summary>
    public class Word
    {
        public string Answer;
        public string[] AlreadyGuessedLetters;
        public string CurrentlyDisplayedString;
        public Word(string answer)
        {

            this.Answer = RandomWordFromWordBank();
            this.CurrentlyDisplayedString = HideWord(String.Copy(Answer));
        }
        
        /// <summary>
        /// This is a method that takes a string and converts each char to an " _ " value.
        /// Later, this method should update this class' CurrentlyDisplayedString.
        /// </summary>
        /// <param name="wordToGuess">Takes in the word for the player to guess</param>
        public static string HideWord(string wordToGuess)
        {
            
            StringBuilder displayToPlayer = new StringBuilder(wordToGuess.Length);
            for (int i = 0; i < wordToGuess.Length; i++)
                displayToPlayer.Append(" _ ");

            Console.WriteLine(displayToPlayer);
            return displayToPlayer.ToString();
        }

        /// <summary>
        /// This is a method that instantiates Random, takes an array of strings called wordBank and assigns a 
        /// string called wordToGuess to one of those random string in the array
        /// </summary>
        public static string RandomWordFromWordBank()
        {
            Random random = new Random((int)DateTime.Now.Ticks);
            string[] wordBank = { "groovie", "ghoulie", "cramps", "bad", "brains", "dead", "kennedys", "milkmen", "crass", "naked", "aggression", "doggie", "apple", "on", "are", "as", "with", "his", "they", "I", "at", "be", "this", "have", "from", "or", "one", "had", "by", "word", "but", "not", "what", "all", "were", "we", "when", "your", "can", "said", "there", "use", "an", "each", "which", "she", "do", "how", "their", "if", "will", "up", "other", "about", "out", "many", "then", "them", "these", "so", "some", "her", "would", "make", "like", "him", "into", "time", "has", "look", "two", "more", "write", "go", "see", "number", "no", "way", "could", "people", "my", "than", "first", "water", "been", "call", "who", "oil", "its", "now", "find", "long", "down", "day", "did", "get", "come", "made", "may", "part" };
            string wordToGuess = wordBank[random.Next(0, wordBank.Length)];

            return wordToGuess;

        }
        /// <summary>
        /// This method takes in a letter from the console and checks it against the answer by iterating through the answer string and searching for all occurrences of that letter in the string.
        /// It updates the CurrentlyDisplayedString by updating the string at the index of where the character was found in the answer string.
        /// It is also responsible for showing the newly updated CurrentlyDisplayedString.
        /// </summary>
        /// <param name="letter"></param>
        public void ShowGuessedLetters(string letter)
        {
            string answer = Answer;
            char[] newAnswer = CurrentlyDisplayedString.ToCharArray();
            char charLetter = Convert.ToChar(letter);
            var indexes = new List<int>();
            for (int i = 0; i <= answer.Length - 1; i++)
            {
                if (answer[i] == charLetter)
                {
                    indexes.Add(i);
                }
            }
            foreach (var index in indexes)
            {
                newAnswer[index] = charLetter;
            }
            CurrentlyDisplayedString = string.Join("", newAnswer);
            Console.WriteLine(CurrentlyDisplayedString);
        }
        /// <summary>
        /// This method is triggered by the choice a user makes to guess the word. 
        /// It prompts a user to solve a word, compares the word that the user guessed to the actual answer, and tells them if they solved correctly.
        /// <param name="word"></param>
        /// <returns></returns>
        public bool SolveTheWord(Word word)
        {
            Console.WriteLine("Solve: \n");
            var guessWord = Console.ReadLine();
            if (guessWord.Equals(word.Answer))
            {
                Console.WriteLine("You Won! \n");
                return true;
            }
            else
            {
                Console.WriteLine("Incorrect! \n");
                return false;
            }
        }
    }
}


