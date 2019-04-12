using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawBoardV4Suerekha
{
    public class Game
    {
        //private bool player1;
        //private bool player2;
        //public string Winner;
        //public int MovesCounter;

        //public bool Player1 { get => player1; set => player1 = value; }
        //public bool Player2 { get => player2; set => player2 = value; }

        //public enum State
        //{
        //    empty = 0,
        //    Player1 = 1,
        //    Player2 = 2
        //}

        //// 2D array of states represents the board 
        //private State[,] gameBoard = new State[7, 6];

        //public Game()
        //{
        //    Player1 = true;
        //    Player2 = false;

        //    for (int width = 0; width < gameBoard.GetLength(0); width++)
        //    {
        //        for (int height = 0; height < gameBoard.GetLength(1); height++)
        //        {
        //            gameBoard[width, height] = State.empty;
        //        }
        //    }

        //}


        public char player1;
        public char player2;
        public char[,] GameState;
       

        public Game(int r, int c, char p1, char p2)
        {
            this.player1 = p1;
            this.player2 = p2;
            this.GameState = new char[r, c];
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    GameState[i, j] = '.';
                }
            }
        }


       
        public void PrintGameState()
        {


            for (int i = 0; i < GameState.GetLength(0); i++)
            {
                for (int j = 0; j < GameState.GetLength(1); j++)
                {
                    Console.Write(GameState[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

        }

        // represents the player and the column they intend to drop the chip
        public void ApplyMove(char p, int c)
        {
            //Console.WriteLine("in apply move");
            int j;
            for (j = 0; j < GameState.GetLength(0); j++)
            {
                if (GameState[j, c] != '.') break;
            }
            Console.WriteLine("j = {0}; c = {1}", j, c);
            this.GameState[j - 1, c] = p;

        }
    }
}
