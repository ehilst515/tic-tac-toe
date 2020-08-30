using System;
using Lab04_TicTacToe.Classes;

namespace Lab04_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            StartGame();
        }

        static void StartGame()
        {
            // TODO: Setup your game. Create a new method that creates your players and instantiates the game class. Call that method in your Main method.
            // You are requesting a Winner to be returned, Determine who the winner is output the celebratory message to the correct player. If it's a draw, tell them that there is no winner. 
            Console.WriteLine("Player 1, enter your name: ");
            string p1Name = Console.ReadLine();
            Console.WriteLine("Player 2, enter your name: ");
            string p2Name = Console.ReadLine();
            Player p1 = new Player();
            Player p2 = new Player();
            p1.Name = p1Name;
            p2.Name = p2Name;
            p1.Marker = "X";
            p2.Marker = "O";
            Game newGame = new Game(p1, p2);
            Player winner = newGame.Play();
            if(winner.Name != "Draw")
            {
                Console.WriteLine($"Winner: {winner.Name}");
            }
            else
            {
                Console.WriteLine("Draw");
            }
        }
    }
}