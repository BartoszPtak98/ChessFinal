using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    public class King : Figure
    {
        public int[,] move(int[,] chessboard, int x, int y)
        {
            if (y < 7 && x < 7) { chessboard[y + 1, x + 1] = 1; }
            if (y < 7 && x > 1) { chessboard[y + 1, x - 1] = 1; }
            if (y > 1 && x < 7) { chessboard[y - 1, x + 1] = 1; }
            if (y > 1 && x > 1) { chessboard[y - 1, x - 1] = 1; }
            if (y < 7) { chessboard[y + 1, x] = 1; }
            if (y > 1) { chessboard[y - 1, x] = 1; }
            if (x < 7) { chessboard[y, x + 1] = 1; }
            if (x > 1) { chessboard[y, x - 1] = 1; }
            chessboard[y, x] = 2;
            return chessboard;
        }
    }
}
