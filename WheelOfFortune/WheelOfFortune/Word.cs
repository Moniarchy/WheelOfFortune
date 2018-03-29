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
        public string CurrentlyDisplayedString= "_________";
        public Word(string answer)
        {
            this.Answer = "microsoft";
        }
        public void HideWord()
        {
            //Matt
        }
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
    }
}

