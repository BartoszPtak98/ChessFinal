using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            FigureFactory figureFactory = new FigureFactory();
            Figure figure;
            int x, y;

            do
            {
                Console.Write("Figura: ");
                string figureType = Console.ReadLine();
                figure = figureFactory.getFigure(figureType);
            } while (figure == null);

            do
            {
                Console.Write("Podaj x: ");
                x = int.Parse(Console.ReadLine());
                x -= 1;
                Console.Write("Podaj y: ");
                y = int.Parse(Console.ReadLine());
                y -= 1;
            } while (0 > y && y < 7 && 0 > y && y < 7);

            GameBoard gameBoard = new GameBoard();
            gameBoard.placeFigure(figure, x, y);
        }
    }
}

