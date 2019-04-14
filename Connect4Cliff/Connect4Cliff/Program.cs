using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect4Cliff
{
    class Program
    {
        static void Main(string[] args)
        {
            //GameBoard myBoard = new GameBoard();
            //myBoard.drawBoard(3, 3);
            //myBoard.drawBoard(6, 7);

            //GameBoard.drawBoard(3, 3);

            //GameBoard ticTacToe = new GameBoard(3, 3);
            //ticTacToe.drawBoard();
            GameBoard connect4 = new GameBoard(6, 7);

            Game newGame = new Game(6, 7);
            connect4.drawBoard(newGame);
            //newGame.debug_display();
            Console.WriteLine();
            Move myMove = new Move(new[] { 3, 2 }, "@");
            newGame.applyMove(myMove);
            connect4.drawBoard(newGame);
            Console.WriteLine();
            //newGame.debug_display();
            Move oppMove = new Move(new[] { 1, 6 }, "$");
            newGame.applyMove(oppMove);
            connect4.drawBoard(newGame);
        }
    }
}
