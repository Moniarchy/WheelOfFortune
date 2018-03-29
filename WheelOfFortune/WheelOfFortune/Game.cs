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
        public Word word = new Word("Microsoft");
        public Choice choice;

        /// <summary>
        ///     Game constructor: supposed to initialize 
        /// </summary>

        public Game()
        {
            wheel = new Wheel();
            player = new Player("TeamMars");
            word = new Word("Doggie");
            choice = new Choice();
        }
          
        public bool IsGameOver()
        {
            return GameOver;
        }

        public void Start()
        {
            Console.WriteLine("Welcome to Wheel of Fortune! \n");

            Console.WriteLine("Here's your puzzle: \n");

            // Show Puzzle
            Console.WriteLine(word.CurrentlyDisplayedString + "\n");

            choice.PrintMsgs();

            while (!GameOver)
            {

                var makeChoice = Console.ReadLine();
                GameOver = choice.TakeChoice(word, makeChoice);

                if (!word.CurrentlyDisplayedString.ToLower().Contains('_'))
                    GameOver = word.SolveTheWord(word);

                if (!GameOver)
                   choice.PrintMsgs();

            }
         
        }
        
    }
}