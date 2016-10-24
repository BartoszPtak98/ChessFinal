using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    public class Horse : IFigure
    {
        public int[,] move(int[,] chessboard, int x, int y)
        {
            if (y < 7 && x < 6) { chessboard[y + 1, x + 2] = 1; }
            if (y < 6 && x < 7) { chessboard[y + 2, x + 1] = 1; }
            if (y > 1 && x > 0) { chessboard[y - 2, x - 1] = 1; }
            if (y > 0 && x > 1) { chessboard[y - 1, x - 2] = 1; }
            if (y > 0 && x < 6) { chessboard[y - 1, x + 2] = 1; }
            if (y > 1 && x < 7) { chessboard[y - 2, x + 1] = 1; }
            if (y < 7 && x > 1) { chessboard[y + 1, x - 2] = 1; }
            if (y < 6 && x > 0) { chessboard[y + 2, x - 1] = 1; }
            chessboard[y, x] = 2;
            return chessboard;
        }
    }
}
