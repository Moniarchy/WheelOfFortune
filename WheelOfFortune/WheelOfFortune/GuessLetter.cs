using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheelOfFortune
{
    class GuessLetter
    {
        public char PromptForLetter()
        {
            Console.Write("Write a letter: ");
            char letter = Console.ReadLine().ToCharArray()[0];
            return letter;
        }

        public void PickLetter(char letter, string word)
        {
            if(word.Contains(Char.ToLower(letter)))
            {
                ShowGuessedLetters();
            }
        }
    }


}
