using System;

namespace TicTacToeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Tic Tac Toe Game");

            TicTacToe tictactoe = new TicTacToe();
            tictactoe.Game();
            tictactoe.chooseLetter();
            char[] board = new char[10];
            tictactoe.ShowBoard(board);
        }

    }
}
