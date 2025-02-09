﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    public abstract class Player
    {
        public string Name { get; set; }

        public Player(string name)
        {
            this.Name = name;
        }

        public string GetUserId()
        { return Name; }

        public abstract int TakePins(Board board);


    }
}
