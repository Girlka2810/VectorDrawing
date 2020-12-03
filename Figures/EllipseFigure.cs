using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorDrawing.Figures
{
    class EllipseFigure : IFigure
    {
        public Point[] GetPoints(FigureParameter parameter)
        {
            Point prev = parameter.Points[0];
            Point crnt = parameter.TemporaryPoint;
            List<Point> points = new List<Point>();            
            

            int delx;
            int dely;
            if (prev.X >= crnt.X)
            {
                delx = Math.Abs(prev.X - crnt.X);
                dely = Math.Abs(prev.Y - crnt.Y);
            }
            else
            {
                delx = Math.Abs(crnt.X - prev.X);
                dely = Math.Abs(crnt.Y - prev.Y);
            }
            double r = Math.Sqrt(Math.Pow(delx, 2) + Math.Pow(dely, 2));
           // points = new Point[];
            for (int i = 1; i <= 50; i++)
            {
                double angle = Math.PI * 2 / 50 * i;
                int xd = Convert.ToInt32((delx * Math.Cos(angle) + prev.X)); // эллипс
                int yd = Convert.ToInt32((dely * Math.Sin(angle) + prev.Y));
                Point addPoint = new Point(xd, yd);
                points.Add(addPoint);
           }
            return points.ToArray();
        }
    }
}
