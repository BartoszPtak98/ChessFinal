using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    public class Pawn : IFigure
    {
        public int[,] move(int[,] chessboard, int x, int y)
        {
            Console.WriteLine("Black or White ?");
            string pawnColor = Console.ReadLine();
            if (pawnColor == "white")
            {
                if (y == 1)
                {
                    chessboard[y + 2, x] = 1;
                    chessboard[y + 1, x] = 1;
                }
                else
                {
                    chessboard[y + 1, x] = 1;
                }
            }
            else
            {
                if (y == 6)
                {
                    chessboard[y - 2, x] = 1;
                    chessboard[y - 1, x] = 1;
                }
                else
                {
                    chessboard[y - 1, x] = 1;
                }
            }
            chessboard[y, x] = 2;
            return chessboard;
        }
    }
}
