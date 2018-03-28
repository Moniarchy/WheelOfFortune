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
        public int Round { get; set; }
        public readonly static Char[] Vowels = new [] { 'a', 'e', 'i', 'o', 'u' };
        //TODO add more consonants
        public readonly static Char[] Consonants = new [] {'b','c','d' };
        public int Turn;
        public bool IsGameOver = false;
        public int WheelValue;
        public int NumOfPlayer;

        /// <summary>
        ///     Where all game logic stems from. 
        /// </summary>
        public Game()
        {
            Console.WriteLine("Welcome to Wheel of Fortune!");

            //Create Player
            // I believe this player instance needs to be passed to MakeChoice() but we may not need a player for the MVP;
            var player = new Player();

            // Show Puzzle 
            // currentlyDisplayedString; 

            while (!IsGameOver)
            {
                //Until won => MakeChoice();

            }


        }

    }
}
