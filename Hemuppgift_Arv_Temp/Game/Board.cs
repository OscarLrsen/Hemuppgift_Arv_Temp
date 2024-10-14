using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    public class Board
    {
        private int SetUpPins;

        public Board()                   // Konstruktorn innehåller 20 pins som default
        {
            SetUpPins = 20;
        }
        public bool TakePins(int nummer)  // Koden till att plocka stickorna
        {
            if (nummer < 1 || nummer > 2 || nummer > SetUpPins)
            {
                Console.WriteLine("Invalid number of pins.");
                return false;
            }

            SetUpPins -= nummer; // Minska antalet stickor på brädet
            return true;
        }


        public int GetNoPins()
        {
            return SetUpPins;
        }




    }
}
