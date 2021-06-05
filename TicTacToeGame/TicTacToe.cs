
using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeGame
{
    public class TicTacToe
    {
       
        public void Game()
        {
            char[] board = new char[10];
            for (int i = 0; i < board.Length; i++)
            {
                board[i] = '_';
                Console.WriteLine(board[i]);
            }
        }
        public void chooseLetter()
        {
            Console.WriteLine("Choice Is Yours!!!");
            Console.WriteLine("X or O");

            string chooseLetter = Console.ReadLine();
            char.ToUpper(chooseLetter[0]);
        }
    }
}
