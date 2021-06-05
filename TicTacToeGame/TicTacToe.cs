
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
        public void ShowBoard(char[] board)
        {
            Console.WriteLine("     |    |  ");
            Console.WriteLine("" +board[1]+  "|"  +board[2]+  "|"  +board[3]);
            Console.WriteLine(" ____|____|____");
            Console.WriteLine("     |    |  ");
            Console.WriteLine("" + board[4] + "|" + board[5] + "|" + board[6]);
            Console.WriteLine(" ____|____|____");
            Console.WriteLine("" + board[7] + "|" + board[8] + "|" + board[9]);
            Console.WriteLine("     |    |  ");
        }
    }
}
