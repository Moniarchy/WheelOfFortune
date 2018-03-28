using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheelOfFortune
{
    public class Program
    {
        static void Main(string[] args)
        {
            Word word = new Word("Microsoft");

            while (word.CurrentlyDisplayedString.ToLower().Contains('_'))
            {
                char guess = GuessLetter.PromptForLetter();
                GuessLetter.PickLetter(guess, word.CurrentlyDisplayedString);
            }
        }
    }
}
