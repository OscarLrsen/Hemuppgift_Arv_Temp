using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Hemuppgift_Arv_Temp.Game
{
    public class BotPlayer : Player
    {
        private Random random = new Random();
        public BotPlayer(string Name) : base(Name) { }
        public override int TakePins(Board board)
        {
            int choice = random.Next(1, 3);
            Console.WriteLine($"{Name} took {choice} matches.");
            return choice;
        }
    }
}
