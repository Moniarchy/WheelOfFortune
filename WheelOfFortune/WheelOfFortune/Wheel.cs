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
        public static readonly int[] Spokes = new int[] { 500, 600, 700, 900, 2500, 0, -9 };
        public int SelectedSpoke { get; set; }

        public Wheel()
        {
        }

       /// <summary>
       /// Spin returns randomly generate value given in Spokes field
       /// </summary>
       /// <returns>SelectedSpoke</returns>

        public int Spin()
        {
            SelectedSpoke = GenerateRandomValueFromSpokes();
            return SelectedSpoke;
        }

        /// <summary>
        /// Generate dollar value randomly
        /// </summary>
        /// <returns> dollar value</returns>
        private int GenerateRandomValueFromSpokes()
        {
            Random rnd = new Random();
            var rndvalue = Spokes[rnd.Next(0, Spokes.Length)];
            return rndvalue;
        }
    }
}
