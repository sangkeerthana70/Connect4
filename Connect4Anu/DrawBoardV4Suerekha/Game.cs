using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawBoardV4Suerekha
{
    public class Game
    {
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
                    GameState[i, j] = '_';
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

        // GamrState is a instance variable which will be passed as a parameter from tests when this method is called
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
            int rowLength = GameState.GetLength(0);
            int colLength = GameState.GetLength(1);
            Console.WriteLine("rowLen " + rowLength);
            Console.WriteLine("colLen " + colLength);
           
            for(int row = 0; row < rowLength; row++)
            {
                for(int col = 0; col < colLength; col++)
                {
                    Console.WriteLine("row = {0}; col = {1}", row, col);
                    Console.WriteLine("rowLength - 2 " + (rowLength-2));
                    if (row < rowLength - 2)
                    {
                        
                        Console.WriteLine("GameState[row, col] = " + GameState[row, col]);
                        Console.WriteLine("GameState[row, col+1] = " + GameState[row, col+1]);
                        Console.WriteLine("GameState[row, col+2] = " + GameState[row, col+2]);
                        Console.WriteLine("GameState[row, col+3] = " + GameState[row, col+3]);
                        if ((GameState[row, col] != '_') &&
                           (GameState[row, col] == GameState[row, col + 1]) &&
                           (GameState[row, col] == GameState[row, col + 2]) && 
                           (GameState[row, col] == GameState[row, col + 3]))
                          {
                            Console.WriteLine("inside horizontal 'X' game validation");
                            return GameState[row, col];
                          }
                    }

                    if(col < colLength - 2)
                    {
                        if((GameState[row, col] != '_') &&
                            (GameState[row, col] == GameState[row + 1, col]) &&
                            (GameState[row, col] == GameState[row + 2, col]) &&
                            (GameState[row, col] == GameState[row + 3, col]))
                        {
                            Console.WriteLine("inside vertical 'O' game validation");
                            return GameState[row, col];
                        }

                    }
                }
            }
            return winner;
        }

    }
}
