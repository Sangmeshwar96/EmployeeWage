using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    public class Snake
    {
        public void Ladder()
        {
            int win = 100;
            Player player1 = new Player();
            Player player2 = new Player();
            Console.WriteLine($"The starting position of player is {player1.position}");
            Console.WriteLine("\n");
            while (player1.position < win || player2.position < win)
            {
                Console.WriteLine("Player 1:");
                player1.Game();
                if ((player1.option == 1) && (player1.position < win))
                {
                    Console.WriteLine("Player 1:");
                    player1.Game();
                }
                if (player1.position > win)
                {
                    player1.position = 0;
                }
                if (player1.position == win)
                {
                    Console.WriteLine("Player 1 won the game");
                    break;
                }
                Console.WriteLine("Player 2:");
                player2.Game();
                if ((player2.option == 1) && (player2.position < win))
                {
                    Console.WriteLine("Player 2:");
                    player2.Game();
                }
                if (player2.position > win)
                {
                    player2.position = 0;
                }
                if (player2.position == win)
                {
                    Console.WriteLine("Player 2 won the game");
                }
            }
        }
    }
    public class Player
    {
        public const int ladder = 1, snake = 2;
        internal int option;
        internal int position = 0, dice = 0, roll = 0;

        public void Game()
        {
            roll++;
            Random random = new Random();
            dice = random.Next(1, 7);
            Console.WriteLine($"The number got by dice roll is {dice}");
            option = random.Next(0, 3);
            switch (option)
            {
                case ladder:
                    position += dice;
                    Console.WriteLine("The player climbed the ladder");
                    break;
                case snake:
                    position -= dice;
                    if (position < 0)
                    {
                        Console.WriteLine("The player bit by snake");
                        position = 0;
                    }
                    else
                    {
                        Console.WriteLine("The player bit by snake");
                    }
                    break;
                default:
                    Console.WriteLine($"No play for player");
                    break;
            }
            Console.WriteLine($"The player position is {position}");
            Console.WriteLine($"The dice has been rolled {roll} time by player till now");
            Console.WriteLine("\n");
        }
    }
}