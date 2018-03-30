using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace WheelOfFortune
{
    public class Program
    {
        static void Main(string[] args)
        {
            var game = new Game();
            RockOut();
            game.Start();
        }

        static void RockOut()
        {
            SoundPlayer soundPlayer = new SoundPlayer();
            soundPlayer.SoundLocation = "..\\..\\bgSounds\\wof_title_screen_edited.wav";
            soundPlayer.LoadAsync();
            soundPlayer.PlayLooping();

        }
    }
}
