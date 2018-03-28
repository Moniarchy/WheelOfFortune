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
        public void HiddenWord()
        {
            //Matt
        }

        public string ShowGuessedLetters()
        {
            //Areanna
            return "";
        }
        
    }
}
