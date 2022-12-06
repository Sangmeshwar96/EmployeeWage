using System;
using System.Xml.Linq;
using SnakeLadder;

namespace SnakeAndLadder
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Game");
            Snake snake = new Snake();
            snake.Ladder();

        }
    }
}