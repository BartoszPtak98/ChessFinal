using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    public class GameBoard
    {
        public int[,] chessboard = new int[8, 8];

        public GameBoard()
        {
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++) chessboard[i, j] = 0;
        }

        public void placeFigure(Figure figure, int x, int y)
        {
            if (figure is King) { chessboard = ((King)figure).move(this.chessboard, x, y); }
            if (figure is Queen) { chessboard = ((Queen)figure).move(this.chessboard, x, y); }
            if (figure is Bishop) { chessboard = ((Bishop)figure).move(this.chessboard, x, y); }
            if (figure is Horse) { chessboard = ((Horse)figure).move(this.chessboard, x, y); }
            if (figure is Tower) { chessboard = ((Tower)figure).move(this.chessboard, x, y); }
            if (figure is Pawn) { chessboard = ((Pawn)figure).move(this.chessboard, x, y); }
            show();
        }

        private void show()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(chessboard[i, j] + " ");
                }
                Console.WriteLine();
            }   Console.Read();
        }
    }
}
