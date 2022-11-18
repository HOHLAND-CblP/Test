using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    public class Triangle: FigureWithCorners, IFigure
    {
        public Triangle (double edge_1, int edge_2, int edge_3)
        {
            if (edge_1 <= 0 || edge_2 <= 0 || edge_3 <= 0)
                throw new ArgumentException("One of the sides is less than or equal to zero");

            edges = new double[3] {edge_1, edge_2, edge_3};
        }

        public bool IsTriangleRight()
        {
            double edge_1Pow = Math.Pow(edges[0], 2);
            double edge_2Pow = Math.Pow(edges[1], 2);
            double edge_3Pow = Math.Pow(edges[2], 2);

            if (edge_1Pow == edge_2Pow + edge_3Pow)
                return true;
            if (edge_2Pow == edge_1Pow + edge_3Pow)
                return true;
            if (edge_3Pow == edge_1Pow + edge_3Pow)
                return true;

            return false;
        }

        public double GetSquare()
        {
            double halfP = (edges[0] + edges[1] + edges[2]) / 2d;
            return Math.Sqrt(halfP * (halfP - edges[0]) * (halfP - edges[1]) * (halfP - edges[2]));
        }
    }
}