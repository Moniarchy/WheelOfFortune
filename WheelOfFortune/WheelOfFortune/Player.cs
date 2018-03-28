using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheelOfFortune
{
    class Player
    {
        public string Name;
        public int GameTotal { get; set; }

        public void UpdateName(string newname)
        {
            this.Name = newname;
        }

    }
}
