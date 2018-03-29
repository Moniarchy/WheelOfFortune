using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheelOfFortune
{
    public class Wheel
    {
        //0 : Lose A Turn   -9: Bankrupt
        public static List<int> Spokes = new List<int> { 500, 600, 700, 900, 2500, 0, -9 };
        public int SelectedSpoke { get; set; }

        public Wheel()
        {
            SelectedSpoke = 900;
        }

       /// <summary>
       /// Spin returns randomly generate value given in Spokes field
       /// </summary>
       /// <returns>SelectedSpoke</returns>

        public int Spin()
        {
            //TODO : Calculate random no generator from Wheel's options
            //Set SelectedSpoke
            return SelectedSpoke;
        }
    }
}
