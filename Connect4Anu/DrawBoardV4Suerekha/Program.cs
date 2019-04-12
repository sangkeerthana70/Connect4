using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawBoardV4Suerekha
{
    class Program
    {
        static void Main(string[] args)
        {
            Board newBoard = new Board();
            

            Game newGame = new Game(6, 7, 'X', 'O');

            newBoard.DrawGameBoard(newGame.GameState);
            newGame.PrintGameState();
            newGame.ApplyMove('X', 1);
            newGame.PrintGameState();
            newBoard.DrawGameBoard(newGame.GameState);
            newGame.ApplyMove('O', 1);
            newBoard.DrawGameBoard(newGame.GameState);
            newGame.ApplyMove('X', 2);
            newBoard.DrawGameBoard(newGame.GameState);
        }
    }
}
