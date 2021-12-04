using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class TicTacToe
    {
        public const char X = 'X';
        public const char O = 'O';

        public void CreateBoard()
        {
            char[] board = new char[10] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };

            for (int i = 1; i < board.Length; i++)
            {
                Console.WriteLine(board[i]);
            }
        }
        public void UserInput()
        {
            Console.WriteLine("Enter you Choice from O/X :");
            char playerChoice = Convert.ToChar(Console.ReadLine());
            if (playerChoice == 'X')
            {
                Console.WriteLine("Player Chose " + playerChoice);
                Console.WriteLine("Computer Chose " + O);
            }
            else if (playerChoice == 'O')
            {
                Console.WriteLine("Player Chose " + playerChoice);
                Console.WriteLine(" Computer Chose " + X);
            }
            else
            {
                Console.WriteLine("Entered invalid input  ");
            }
        }

    }
}
