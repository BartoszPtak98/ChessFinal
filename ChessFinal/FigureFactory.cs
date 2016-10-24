using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    public class FigureFactory
    {
        public IFigure getFigure(string figureType)
        {
            if (figureType.ToLower() == "king") return new King();
            if (figureType.ToLower() == "horse") return new Horse();
            if (figureType.ToLower() == "tower") return new Tower();
            if (figureType.ToLower() == "queen") return new Queen();
            if (figureType.ToLower() == "bishop") return new Bishop();
            if (figureType.ToLower() == "pawn") return new Pawn();
            return null;
        }
    }
}

