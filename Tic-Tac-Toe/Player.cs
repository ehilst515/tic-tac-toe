using System;
using System.Collections.Generic;
using System.Linq;

namespace TicTacToe.Classes
{
    class Player
    {
        public string Name { get; set; }
        /// <summary>
        /// P1 is X and P2 will be O
        /// </summary>
        public string Marker { get; set; }

        /// <summary>
        /// Flag to determine if it is the user's turn
        /// </summary>
        public bool IsTurn { get; set; }

        public List<int> Played = new List<int>();

        public int j = 0;

        public Position GetPosition(Board board)
        {
            //if (j == 8)
            //{
            //    Console.WriteLine("Out of moves!");
            //    return null;
            //}

            Position desiredCoordinate = null;

            while (desiredCoordinate == null)
            {
                Console.WriteLine("Please select a location");
                bool isNumber = Int32.TryParse(Console.ReadLine(), out int position);

                if (!isNumber || position > 9 || position < 0)
                {
                    Console.WriteLine("Incorrect input!");
                    return null;
                }

                Played.Add(position);
                desiredCoordinate = PositionForNumber(position);
            }

            j++;
            return desiredCoordinate;
        }


        public static Position PositionForNumber(int position)
        {
            switch (position)
            {
                case 1: return new Position(0, 0); // Top Left
                case 2: return new Position(0, 1); // Top Middle
                case 3: return new Position(0, 2); // Top Right
                case 4: return new Position(1, 0); // Middle Left
                case 5: return new Position(1, 1); // Middle Middle
                case 6: return new Position(1, 2); // Middle Right
                case 7: return new Position(2, 0); // Bottom Left
                case 8: return new Position(2, 1); // Bottom Middle 
                case 9: return new Position(2, 2); // Bottom Right

                default: return null;
            }
        }

        public bool TakeTurn(Board board)
        {
            bool isValidPlay = false;
            IsTurn = true;

            Console.WriteLine($"{Name} it is your turn. Place your {Marker} on the board.");

            Position position = GetPosition(board);

            if(position == null)
            {
                return isValidPlay;
            }
            
            bool positionIsNumber = Int32.TryParse(board.GameBoard[position.Row, position.Column], out _);

            if (positionIsNumber)
            {
                board.GameBoard[position.Row, position.Column] = Marker;
                isValidPlay = true;
            }
            
            Console.WriteLine($"That space is already occupied");

            return isValidPlay;
        }
    }
}
