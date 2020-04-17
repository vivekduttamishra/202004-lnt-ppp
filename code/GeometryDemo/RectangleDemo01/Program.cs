using ConceptArchitect.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleDemo01
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle[] rectangles =
            {
                new ProperRectangle(11,4), //sleeping
                new RSquare(7),
                new Square(8), 
                new ProperRectangle(2,9)   //standing
            };

            foreach(var rectangle in rectangles)
            {
                rectangle.Draw();
                Console.WriteLine("Type={0}",rectangle.GetType().Name);
                Console.WriteLine("Area = {0}",rectangle.Area);
                Console.WriteLine("Perimeter = {0}", rectangle.Perimeter);

                if (rectangle is ProperRectangle)
                    Console.WriteLine("Orientation = {0}", (rectangle as ProperRectangle).Orientation); 
                Console.WriteLine();
                    
            }

            RSquare sq = new RSquare(9); //8 bytes
            sq.Height = 20; //not a square anymore
            sq.Draw(); //square which is not a square

            Square realSquare = new Square(9); //4 bytes
            realSquare.Side = 11; //always a square
            realSquare.Draw();


            //Square is a Shape
            //Rectangle is a Shape
            //But is Square a Rectangle? <--- Geometrically square is a rectangle
            Console.WriteLine("Is square a Rectangle: {0}",realSquare is ProperRectangle);

        }
    }
}
