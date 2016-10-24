using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    public class Program
    {
        private readonly FigureFactory figureFactory;
        private readonly GameBoard gameBoard;
        private Figure figure;
        
        public Program()
        {
            figureFactory = new FigureFactory();
            gameBoard = new GameBoard();
        }
        
        static void Main(string[] args)
        {
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

            gameBoard.placeFigure(figure, x, y);
        }
    }
}

