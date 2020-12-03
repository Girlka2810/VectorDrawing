using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorDrawing.Figures
{
    public class SquareFigure : IFigure
    {
        public Point[] GetPoints(FigureParameter parameter)
        {
            Point prev = parameter.Points[0];
            Point crnt = parameter.TemporaryPoint;
            Point[] points;

            int width = Module(prev.X - crnt.X);
            int height = Module(prev.Y - crnt.Y);
            if (width >= height)
            {
                crnt.X = crnt.X >= prev.X ? prev.X + height : prev.X - height;
            }
            else
                crnt.Y = crnt.Y >= prev.Y ? prev.Y + width : prev.Y - width;
            points = new Point[]
            {
                prev,
                new Point(crnt.X, prev.Y),
                crnt,
                new Point(prev.X, crnt.Y),
            };
            return points;
        }

        private int Module(int n)
        {
            return n < 0 ? n * -1 : n;
        }
    }
}