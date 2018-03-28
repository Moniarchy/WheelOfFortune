using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheelOfFortune
{
    class Word
    {
        public string Answer;
        public string[] AlreadyGuessedLetters;
        public string CurrentlyDisplayedString;
        public Word(string answer)
        {
            this.Answer = answer;
        }
        public void HideWord()
        {
            //Matt
        }
        public string ShowGuessedLetters(char letter)
        {
            int index = Answer.IndexOf(letter);
            StringBuilder newString = new StringBuilder(CurrentlyDisplayedString);
            newString[index] = letter;
            CurrentlyDisplayedString= newString.ToString();

            Console.Write(CurrentlyDisplayedString);
            return CurrentlyDisplayedString;
        }
    }
}

