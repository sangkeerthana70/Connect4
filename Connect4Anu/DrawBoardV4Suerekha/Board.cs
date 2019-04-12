using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawBoardV4Suerekha
{
    public class Board
    {
        private int widthOfBoard;
        private int heightOfBoard;

        public int WidthOfBoard { get => widthOfBoard; set => widthOfBoard = value; }
        public int HeightOfBoard { get => heightOfBoard; set => heightOfBoard = value; }

        public Board()
        {
            WidthOfBoard = 7;
            HeightOfBoard = 6;
            Board[,] board = new Board[7, 6];
        }

        
        public void DrawBlankSpacesInCell(char[] data)
        {
            int row;
            for(row = 1; row < WidthOfBoard; row++)
            {
                // data[row - 1] is to print the move in the center of each grid
                Console.Write("|  "+ data[row - 1] + "  ");
            }
            Console.WriteLine("|  " + data[row - 1] + "  |");
        }

        public void DrawBottomLinesOfCell()
        {
            for(int row = 1; row < WidthOfBoard; row++)
            {
                Console.Write("|_____");
            }
            Console.WriteLine("|_____|");
        }

        public void DrawGameBoard(char[,] moves)
        {
            char[] blanks = new char[7];
            char[] rowValue = new char[7];

            Console.Write(" -----------------------------------------");
            Console.WriteLine();
            // populate the first row of the board matrix with a single dimensional array
            for(int firstRow = 0; firstRow < blanks.Length; firstRow++)
            {
                blanks[firstRow] = ' ';
            }

            for (int column = 0; column < HeightOfBoard; column++)
            {
                DrawBlankSpacesInCell(blanks);
                // populate the second row with the updated moves from the Game.ApplyMove()
                for(int secondRow = 0; secondRow < rowValue.Length; secondRow++)
                {
                    rowValue[secondRow] = moves[column, secondRow];
                }
                DrawBlankSpacesInCell(rowValue);
                DrawBottomLinesOfCell();

            }
        }
 
    }

}

