using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawBoardV3Sean
{
    class Board
    {
        static String[] parts = { "|", " ", "+", "-" };
        String wall = parts[0];
        String space = parts[1];
        String plus = parts[2];
        String dash = parts[3];

        public void BuildBoard(int height, int width, char[,] moves)
        {
            for (var row = 0; row <= height * 2; row++)
            {
                for (var col = 0; col <= width; col++)
                {
                    if (row % 2 == 0)
                    {
                        Console.Write(plus + dash);
                        if (col == width - 1)
                        {
                            Console.Write(plus + space);
                            break;
                        }
                    }
                    else
                    {
                        if (col == width)
                        {
                            Console.Write(wall + space);
                            //Console.WriteLine("horz = {0}; vert = {1}; moves = {2}", horz, vert, moves[vert / 2, horz / 2]);
                        }
                        else
                        {
                            Console.Write(wall + moves[row / 2, col/2]);
                            //Console.WriteLine("row = {0}; col = {1}; moves = {2}", row, col, moves[row / 2, col / 2]);
                        }
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}

