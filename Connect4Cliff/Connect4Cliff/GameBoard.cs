using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect4Cliff
{
    public class GameBoard
    {

        public int height { get; set; }
        public int width { get; set; }

        public GameBoard(int height, int width)
        {
            this.height = height;
            this.width = width;
        }
        public void drawBoard(Game aGame)
        {
            for (int row = 0; row < this.height; row++)
            {
                for (int part = 0; part < 3; part++)
                {
                    for (int column = 0; column < this.width; column++)
                    {
                        //Console.Write(".");
                        switch (part)
                        {
                            case 1:
                                Console.Write("|{0}|", aGame.board[row, column]); // String interpolation 
                                break;
                            case 0:
                            case 2:
                                Console.Write("+-+");
                                break;
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
