using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WheelOfFortune
{/// <summary>
/// The game class contains all of the game logic and is the main class responsible for using the methods of the other classes so that the game can be played.
/// </summary>
    public class Game
    {
        public int MaxRound { get; set; }
        public readonly static Char[] Vowels = new[] { 'a', 'e', 'i', 'o', 'u' };
        public int Turn;
        public bool GameOver = false;
        private int WheelValue;
        private int NumOfPlayer;
        private Wheel wheel;
        private Player player;
        public Word word = new Word("Microsoft");
        public Choice choice;

        /// <summary>
        ///     Game constructor: Initializes a new wheel that a player will be able to spin, a single player whose name is Player 1 by default, and the ability to make a choice about what action a player wants to take.
        /// </summary>
        public Game()
        {
            wheel = new Wheel();
            player = new Player("Player 1");
            choice = new Choice();
        }
        /// <summary>
        /// Checks to see if the game is over either because the player won or because they decided to stop playing.
        /// </summary>
        /// <returns>A boolean that indicates whether the game has ended or not.</returns>
        public bool IsGameOver()
        {
            return GameOver;
        }
        /// <summary>
        /// This is the logic that uses the instances initialized in the constructor. 
        /// It welcomes the user, prompts them for their name and updates it if applicable, displays the puzzle, runs the logic that allows a user to choose what they want to do, 
        /// checks to see if the user has entered a correct character or has guessed the word, and prints messages when the game is done.
        /// </summary>
        public void Start()
        {
            Console.WriteLine("Welcome to Wheel of Fortune! \n");
            Console.WriteLine("What\'s your name?");
            string name = Console.ReadLine();
            if (name == "")
            {
                name = player.Name;
            }
            else
            {
                player.Name = name;
            }
            Console.WriteLine($"Thanks for playing, {name}! Let\'s get started!");

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
            Console.WriteLine("The game is over! You can press any key to exit.");
            Console.ReadLine();

        }

    }
}