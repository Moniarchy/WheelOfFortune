using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheelOfFortune
{
    public class Game
    {
        //TODO Gettere Setter for each fields
        public int MaxRound { get; set; }
        public readonly static Char[] Vowels = new [] { 'a', 'e', 'i', 'o', 'u' };
        //TODO add more consonants
        public readonly static Char[] Consonants = new [] {'b','c','d' };
        public int Turn;
        public bool GameOver = false;
        private int WheelValue;
        private int NumOfPlayer;
        private Wheel wheel;
        private Player player;
        private Word word;
        

        /// <summary>
        ///     Game constructor: supposed to initialize 
        /// </summary>
        public Game()
        {
            wheel = new Wheel();
            player = new Player("TeamMars");
            word = new Word("Doggie");
        }
          
        public bool IsGameOver()
        {
            return GameOver;
        }

        public void Start()
        {
            Console.WriteLine("Welcome to Wheel of Fortune! \n");

            // Show Puzzle

            // currentlyDisplayedString;

            while (!GameOver)
            {
                // Until won => MakeChoice();
            }

        }

        public void SolveTheWord()
        {
            var guessWord = Console.ReadLine();
            if (guessWord.Equals(word.Answer))
            {
                //Win
                GameOver = true;
            }
            else
            {
                //MakeChoice();
            } 
        }

    }
}

