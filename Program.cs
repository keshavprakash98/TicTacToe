using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TicTacToe obj = new TicTacToe();
            obj.CreateBoard();
            obj.UserInput();
        }
    }
}
