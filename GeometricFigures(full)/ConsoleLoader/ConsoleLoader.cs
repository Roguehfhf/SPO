﻿using System;
using System.Collections.Generic;
using GeometricFigures;

namespace ConsoleLoader
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var geometricsFigure = new List<IFigures>();
            try
            {
                var rectangleFigure = new Rectangle(5, 7);
                geometricsFigure.Add(rectangleFigure);

                var circleFigure = new Circle(-5);
                geometricsFigure.Add(circleFigure);

                var triangleFigure = new Triangle(8, 8, 5);
                geometricsFigure.Add(triangleFigure);

                var ringFigure = new Ring(9.8, 8);
                geometricsFigure.Add(ringFigure);

                foreach (IFigures figure in geometricsFigure)
                {
                    Console.WriteLine("{0}: Площадь = {1},    Периметр = {2}", figure.Type, figure.Area, figure.Perimeter);
                }
            }

            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }



            Console.Read();
        }
    }
}
