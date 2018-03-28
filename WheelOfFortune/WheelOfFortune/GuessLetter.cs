using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WheelOfFortune
{
    class GuessLetter
    {
        
        public static char PromptForLetter()
        {
            Console.Write("Choose a letter: ");
            char letter = Console.ReadLine().ToCharArray()[0];
            return letter;
        }

        public static void PickLetter(char letter, string word)
        {
            if (word.Contains(Char.ToLower(letter)))
            {
                Word newWord = new Word(word);
                newWord.ShowGuessedLetters(Char.ToLower(letter));
            }
        }
    }


}
