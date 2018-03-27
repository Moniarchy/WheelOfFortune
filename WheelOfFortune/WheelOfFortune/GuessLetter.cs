using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheelOfFortune
{
    class GuessLetter
    {
        public string PromptForLetter()
        {
            Console.Write("Write a letter: ");
            string letter = Console.ReadLine();
            return letter;
        }
    }


}
