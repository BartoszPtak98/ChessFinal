using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    public class Queen : IFigure
    {
        public int[,] move(int[,] chessboard, int x, int y)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    chessboard[i, x] = 1;
                    chessboard[y, j] = 1;
                }
            }
            for (int i = 0; x + i < 8 && y + i < 8; i++)
            {
                chessboard[y + i, x + i] = 1;
            }
            for (int i = 0; x - i >= 0 && y - i >= 0; i++)
            {
                chessboard[y - i, x - i] = 1;
            }
            for (int i = 0; y + i < 8 && x - i >= 0; i++)
            {
                chessboard[x - i, y + i] = 1;
            }
            for (int i = 0; y - i >= 0 && x + i < 8; i++)
            {
                chessboard[x + i, y - i] = 1;
            }
            chessboard[y, x] = 2;
            return chessboard;
        }
    }
}

