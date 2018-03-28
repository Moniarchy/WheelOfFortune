using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheelOfFortune
{
    class Game
    {
        //TODO Gettere Setter for each fields
        public int Round { get; set; }
        public readonly static Char[] Vowels = new [] { 'a', 'e', 'i', 'o', 'u' };
        //TODO add more consonants
        public readonly static Char[] Consonants = new [] {'b','c','d' };
        public int Turn;
        public bool GameOver;
        public int WheelValue;
        public int NoOfPlayer;

        public Game()
        {

        }
          
        public bool IsGameOver()
        {
            return GameOver;
        }

        public void SolveTheWord()
        {
            var word = new Word();
            var guessWord = Console.ReadLine();
            if (guessWord.Equals(word.Answer))
            {
                //Win
                GameOver = true;
            }
            else
            {
                MakeChoice();
            } 
        }



    }
}
