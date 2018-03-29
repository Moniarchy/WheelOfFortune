using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheelOfFortune
{
    /// <summary>
    /// The Player class represents both human players and computer players
    /// It holds a string Name, and two fields representing money: GameTotal and RoundTotal
    /// GameTotal is the sum of all money earned by the player
    /// RoundTotal is the amount of money earned by the current round of the game
    /// </summary>
    public class Player
    {
        /// <summary>
        /// Name: The Player's name, as a string. It doesn't have to be unique. Human players can/should be able to pick their own name
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// GameTotal: An int representing the sum of money the player has earned across all rounds. It always starts at 0. It can be negative.
        /// </summary>
        public int GameTotal { get; set; } = 0;

        /// <summary>
        /// RoundTotal: An int representing the money earned by the player during the current round. It gets reset every round to its intial value, 0. It can be negative
        /// </summary>
        public int RoundTotal { get; set; } = 0;

        public Player(string name)
        {
            Name = name;
        }

    }
}
