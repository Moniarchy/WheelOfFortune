﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheelOfFortune
{
    public class Player
    {
        public string Name { get; set; }
        public int TotalMoney { get; set; }

        public Player()
        {
            Name = "Player1";
            TotalMoney = 0;
        }

    }
}
