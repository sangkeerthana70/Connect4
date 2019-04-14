using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect4Cliff
{
    public class Game
    {
        public String[,] board { get; set; }
        //public int[][] player1 {get; set;}
        //public String player2 {get; set;}
        public Game(int height, int width)
        {
            board = new String[height, width];
            for (int row = 0; row < height; row++)
            {
                for (int column = 0; column < width; column++)
                {
                    board[row, column] = " ";
                }
            }
        }
        public void applyMove(Move move)
        {
            board[move.location[0], move.location[1]] = move.player;
        }

        public void debug_display()
        {
            for (int row = 0; row < board.GetLength(0); row++)
            {
                for (int column = 0; column < board.GetLength(1); column++)
                {
                    Console.Write(board[row, column] == " " ? "." : board[row, column]);
                }
                Console.WriteLine();
            }
        }
    }
}
