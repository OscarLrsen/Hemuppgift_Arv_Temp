using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    public class HumanPlayer : Player
    {
        public HumanPlayer(string name) : base(name) { }
        public override int TakePins(Board board)
        {
            Console.WriteLine($"{Name}, how many matches would you like to take (1 or 2)? ");
            int choice;

            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 2)
            {
                Console.WriteLine("Choose either 1 or 2.");
            }
            return choice;
        }

    }
}
