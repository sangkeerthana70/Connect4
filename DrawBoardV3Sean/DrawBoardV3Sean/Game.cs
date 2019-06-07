using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawBoardV3Sean
{
    class Game
    {
        public char[,] GameState;
        public char player1;
        public char player2;


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
            int j;
            for (j = 0; j < GameState.GetLength(0); j++)
            {
                if (GameState[j,c] != '.') break;
            }
            Console.WriteLine("j = {0}; c = {1}",j,c);
            this.GameState[j-1,c] = p;

        }


    }   
}
