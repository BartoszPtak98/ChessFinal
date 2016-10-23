using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    public class Tower : Figure
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
            chessboard[y, x] = 2;
            return chessboard;
        }
    }
}
