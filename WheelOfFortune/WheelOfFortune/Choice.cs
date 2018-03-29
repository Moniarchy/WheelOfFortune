using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WheelOfFortune
{
    public class Choice
    {
        //fields
        
        //properties

        //methods     
       

        
        public string PrintMsgs()
        {
            return "What would you like to do? \nPlease choose one: \n1) Guess a letter \n2) Guess the word \n3) Exit game";
        }


        public string TakeChoice(string num)
        {
            int UserChoice;
            bool success = int.TryParse(num, out UserChoice);
            
            if (!success)
            {
                throw new InvalidCastException();
            }

            if (UserChoice <= 0 || UserChoice > 3)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                return ActOnChoice(UserChoice);
            }
        }


        public string ActOnChoice(int UserChoice)
        {
            switch (UserChoice)
            {
                case 1:
                    return "GuessTheLetter();";
                    break;

                case 2:
                    return "GuessTheWord();";
                    break;

                case 3:
                    return "ExitGame();";
                    break;

                default:
                    return "Please choose a number.";
                    break;
            }

            
        }
    }
}
