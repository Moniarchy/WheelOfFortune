using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WheelOfFortune
{
    class GuessLetter
    {

        public static string PromptForLetter()
        {
            Console.Write("Choose a letter: ");
            string letter = Console.ReadLine();
            Word newWord = new Word("Microsoft");
            newWord.ShowGuessedLetters(letter);
            return letter;
        }
    }


}
