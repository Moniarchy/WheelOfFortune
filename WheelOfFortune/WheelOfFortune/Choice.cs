using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WheelOfFortune
{
    /// <summary>
    /// The class Choice is a big bag of methods for displaying output to the user, validating their input, and running calls to other functions corresponding to their input
    /// At this stage, the actions are not being called yet -- the method ActsOnChoice only returns string messages naming the functions we want to eventually call
    /// </summary>
    public class Choice
    {
        /// <summary>
        /// PrintMsgs: A method that displays a message to the user, requesting their input
        /// </summary>
        /// <returns>A string requesting the user type 1, 2, or 3, corresponding to Guess a letter, Guess the word, or Exit </returns>
        /// 
        public void PrintMsgs()
        {
            Console.WriteLine("What would you like to do? \nPlease choose one: \n1) Guess a letter \n2) Guess the word \n3) Exit game");
        }

        /// <summary>
        /// TakeChoice: A method that takes the user's input, validates it, and performs an action corresponding to what they typed
        /// If the user inputs a non-integer value, it throws an InvalidCastException
        /// If the user's choice is a number that is out of range (less than 1 or greater than 3), it throws an IndexOutOfRangeException
        /// The one true code path -- a digit between 1 and 3 -- causes the method to call ActOnChoice and return a string
        /// </summary>
        /// <param name="num">The user's input, which is hopefully a digit</param>
        /// <returns>A string message to the user (for now)</returns>
        /// 
        public bool TakeChoice(Word word, string num)
        {
            int UserChoice;
            bool success = int.TryParse(num, out UserChoice);
            
            if (!success)
            {
                Console.WriteLine("Please choose a number between 1-3!");
                return false;
            }

            if (UserChoice <= 0 || UserChoice > 3)
            {
                Console.WriteLine("Please choose a number between 1-3!");
                return false;
            }
            else
            {
                return ActOnChoice(word, UserChoice);
            }
        }

        /// <summary>
        /// ActOnChoice: A big switch statement of a method that performs actions based on the user's input. Right now it just returns string messages. Later, we will call actions indicated by the strings.
        /// The user can only input the digits 1, 2, or 3, so the default case should NEVER actually be hit
        /// Validation for this method occurs inside the TakeChoice method. We should never have to call this method directly
        /// </summary>
        /// <param name="UserChoice">An int that corresponds to the user's choice of Guess the letter (1), Guess the word (2), or Exit (3)</param>
        /// <returns>Right now, it just returns a string. We will make it call actual actions when we are ready</returns>

        public bool ActOnChoice(Word word, int UserChoice)
        {
            switch (UserChoice)
            {
                case 1:
                    Console.WriteLine("Guess a letter: \n");
                    var letterGuessed = Console.ReadLine();
                    word.ShowGuessedLetters(letterGuessed);
                    return false;
                    break;

                case 2:
                    return word.SolveTheWord(word); ;
                    break;

                case 3:
                    Console.WriteLine("Game Over! \n");
                    return true;
                    break;

                default:
                    return false;
                    break;
            }  
        }
    }
}
