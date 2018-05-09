using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Geometry;

namespace ConsoleApp2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                var figures = new List<IFigure>
                {
                    new Circle(18),
                    new Triangle(6,4,3),
                    new Circle(3),
                    new Triangle(6,8,10),
                    new Triangle(3,7,8)
                };
                foreach (var figure in figures)
                {
                    Console.Write($"{figure.GetType().Name}: {figure.GetSquare()}");
                    if (figure is Triangle triangle)
                    {
                        Console.Write($", {triangle.IsRightAngle()}");
                    }

                    Console.WriteLine();
                }
            }
            catch (ApplicationException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
