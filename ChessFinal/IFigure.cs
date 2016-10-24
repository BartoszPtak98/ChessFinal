using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    public interface IFigure
    {
        int[,] move(int[,] chessboard, int x, int y);
    }
}
