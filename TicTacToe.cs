using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class TicTacToe
    {
        char player, computer;

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
            Console.WriteLine("Please choose which letter you want to take-- X or O");
            char letter = Convert.ToChar(Console.ReadLine());
            if (letter == 'X')
            {
                player = 'X';
                computer = 'O';
            }
            else
            {
                player = 'O';
                computer = 'X';
            }
            Console.WriteLine("Player has chosen {0} and computer {1}", player, computer);

        }

    }
}
