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

        // GamrState is a instance variable which will be passed as a parameter from tests
        public bool ValidateBoard()
        {
            int noOfX = 0;
            int noOfO = 0;

            for(int row = 0; row < GameState.GetLength(0); row++)
            {
                for(int col = 0; col < GameState.GetLength(1); col++)
                {
                    if(GameState[row, col] == 'X')
                    {
                        noOfX += 1;
                        Console.WriteLine("X" + noOfX);
                    }
                    if(GameState[row, col] == 'O')
                    {
                        noOfO += 1;
                        Console.WriteLine("O" + noOfO);
                    }
                }
            }
            if(noOfX == noOfO)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public char DetermineWinner()
        {
            char winner = ' ';
            Console.WriteLine("rows " + GameState.GetLength(0));
            Console.WriteLine("columns " + GameState.GetLength(1));
           
            for(int row = 0; row < GameState.GetLength(0); row++)
            {
                for(int col = 0; col < GameState.GetLength(1); col++)
                {
                    // horizontal 'X' 's declares player1 as winner 
                    if(GameState[row, col] == player1 && GameState[row, col + 1] == player1 && GameState[row, col+2] == player1 && GameState[row, col+ 3] == player1)
                    {
                        Console.WriteLine("in Player1 horizontzl win");
                        Console.WriteLine("GameState.GetLength(1) - 2 " + (GameState.GetLength(1) - 3));
                        if (col == GameState.GetLength(1) - 2)
                        {
                            break;
                        }
                        else
                            return winner = player1;
                    }
                    // horizontal 'O' 's declares player2 as winner
                    if (GameState[row, col] == player2 && GameState[row, col + 1] == player2 && GameState[row, col + 2] == player2 && GameState[row, col + 3] == player2)
                    {
                        Console.WriteLine("in player2 horizontal win");
                        Console.WriteLine("GameState.GetLength(1) - 2 " + (GameState.GetLength(1) - 3));
                        if (col == GameState.GetLength(1) - 2)
                        {
                            break;
                        }
                        else
                            return winner = player2;
                    }

                    // vertical 'X' 's declares player1 as winner
                    
                    
                    if (GameState[row, col] == player1 && GameState[row - 1, col] == player1 && GameState[row - 2, col] == player1 && GameState[row - 3, col] == player1)
                    {
                        Console.WriteLine("r:{0} c:{1} value: {2} ", row, col, GameState[row, col]);
                        Console.WriteLine("r:{0} c:{1} value: {2} ", row - 1, col, GameState[row - 1, col]);
                        Console.WriteLine("r:{0} c:{1} value: {2} ", row - 2, col, GameState[row - 2, col]);
                        Console.WriteLine("r:{0} c:{1} value: {2} ", row - 3, col, GameState[row - 3, col]);
                        Console.WriteLine("r:{0} c:{1} value: {2} ", row - 4, col, GameState[row - 4, col]);
                        //Console.WriteLine("r:{0} c:{1} value: {2} ", row - 5, col, GameState[row + 5, col]);
                        Console.WriteLine("in vertical player1 win");
                        Console.WriteLine("GameState.GetLength(0) - 3 " + (GameState.GetLength(0) - 2));
                        //if (row == GameState.GetLength(0) - 2)
                        //{
                        //    break;
                        //}
                        //else
                        winner = player1;
                        
                    }

                    if (GameState[row, col] == player2 && GameState[row - 1, col] == player2 && GameState[row - 2, col] == player2 && GameState[row - 3, col] == player2)
                    {
                        
                        Console.WriteLine("in vertical player2 win");
                        Console.WriteLine("GameState.GetLength(0) - 3 " + (GameState.GetLength(0) - 2));
                        //if (row == GameState.GetLength(0) - 2)
                        //{
                        //    break;
                        //}
                        //else
                        winner = player2;
                       
                    }

                }
            }
            return winner;
        }

    }
}
