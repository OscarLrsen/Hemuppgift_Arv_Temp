using Hemuppgift_Arv_Temp.Game;
using System.Numerics;
using System.Xml.Linq;
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

namespace Hemuppgift_Arv_Temp
{
    public class TakePinsGame
    {
        public void PlayGame()
        {
            Board board = new Board();

            Console.WriteLine("****Welcome to the Matchstick Game!****");
            Console.WriteLine("");
            Console.WriteLine("In this game, there are 20 matchsticks on the board. Two players – you and the computer – take turns picking matchsticks.");
            Console.WriteLine("You can choose to take either 1 or 2 matchsticks on your turn. The player who picks the last matchstick wins the game.");
            Console.WriteLine("");
            Console.WriteLine("Be careful and choose wisely! Will you outsmart the computer (Anna) and win the game? Let’s find out!");
            Console.WriteLine(" ");
            Console.WriteLine("Start with typing in your name!");

            string playerName = Console.ReadLine();

            Player Human = new HumanPlayer(playerName);
            Player anna = new BotPlayer("Anna");
            Player currentPlayer = Human;

            while (board.GetNoPins() > 0)
            {

                int takenPins = currentPlayer.TakePins(board);

                while (!board.TakePins(takenPins))
                {
                    Console.WriteLine("Invalid amount of matches.");
                    takenPins = currentPlayer.TakePins(board);
                }
                if (board.GetNoPins() == 0)
                {
                    Console.WriteLine($"{currentPlayer.GetUserId()} won!!");
                    break;
                }


                currentPlayer = (currentPlayer == Human) ? anna : Human;
            }
        }

        public static void Main(string[] args)
        {
            TakePinsGame game = new TakePinsGame();
            game.PlayGame();
        }
    }
}
