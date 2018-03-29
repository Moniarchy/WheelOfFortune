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
            var game = new Game();
            game.Start();
                Console.Write("Choose a letter: ");
                string letter = Console.ReadLine();
                word.ShowGuessedLetters(letter);
            }
        }
    }
}
