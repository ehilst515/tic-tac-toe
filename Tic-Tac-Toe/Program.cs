using System;
using Lab04_TicTacToe.Classes;

namespace Lab04_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            StartGame();
        }

        static void StartGame()
        {
            bool play = true;
            while(play == true)
            {
                Console.WriteLine("Player 1, enter your name: ");
                string p1Name = Console.ReadLine();
                Console.WriteLine("Player 2, enter your name: ");
                string p2Name = Console.ReadLine();
                Console.Clear();

                Player p1 = new Player();
                Player p2 = new Player();
                p1.Name = p1Name;
                p2.Name = p2Name;
                p1.Marker = "X";
                p2.Marker = "O";

                Game newGame = new Game(p1, p2);
                Player winner = newGame.Play();

                if (winner.Name != "Draw")
                {
                    Console.WriteLine($"Winner: {winner.Name}");
                    Console.ReadLine();
                }

                else
                {
                    Console.WriteLine("Draw");
                    Console.ReadLine();
                }

                Console.WriteLine("Enter 'play' or 'p' to play again, or 'quit' or 'q' if you'd like to stop.");
                string input = Console.ReadLine().ToLower();
                if(input == "play" || input == "p")
                {
                    play = true;
                }
                else
                {
                    play = false;
                }
            }
        }
    }
}