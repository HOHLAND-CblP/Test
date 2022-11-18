using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    public class Circle: IFigure
    {
        double radius;
        public double Radius { get; }


        public Circle(double radius)
        {
            if (radius < 0)
                throw new ArgumentException("Radius less than zero");

            this.radius = radius;
        }
               

        public double GetSquare()
        {
            return Math.PI * Math.Pow(radius,2);
        }
    }
}