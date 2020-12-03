using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorDrawing;
using VectorDrawing.Figures;

namespace VectorDrawing.Figures
{
    class EllipseFigure : IEllipse
    {
       

        public Rectangle GetRectangle(EllipseFigureParameter parameter)
        {
            Point point = parameter.Center;
            Point pointEnd = parameter.TemporaryPoint;
                double delX = parameter.HorizontalRadius;
            double delY = parameter.VerticalRadius;

            Point upperLeftPoint = new Point(point.X - (point.X-pointEnd.X) / 2, point.Y - (point.Y - pointEnd.Y) / 2);
            if (parameter.Center.X>= parameter.TemporaryPoint.X)
            {
                delX= Math.Abs(point.X - pointEnd.X);
                delY = Math.Abs(point.Y - pointEnd.Y);
            }
            else
            {
                delX = Math.Abs(pointEnd.X - point.X);
                delY = Math.Abs(pointEnd.Y - point.Y);
            }
            //double r = Math.Sqrt(Math.Pow(delX, 2) + Math.Pow(delY, 2));
            //// points = new Point[];
            ////for (int i = 1; i <= 50; i++)
            ////{
            //double angle = Math.PI * 2 / 50 * i;
            //int xd = Convert.ToInt32((delX * Math.Cos(angle) + point.X)); // эллипс
            //int yd = Convert.ToInt32((delY * Math.Sin(angle) + point.Y));
            //Point addPoint = new Point(xd, yd);
            Rectangle rectangle = new Rectangle(upperLeftPoint.X, upperLeftPoint.Y, (int)delX/2, (int)delY/2);

            
            return rectangle;
        }
    }
}
//    class EllipseFigure : IFigure
//    {
//        public Point[] GetPoints(FigureParameter parameter)
//        {
//            Point prev = parameter.Points[0];
//            Point crnt = parameter.TemporaryPoint;
//            List<Point> points = new List<Point>();


//            int delx;
//            int dely;
//            if (prev.X >= crnt.X)
//            {
//                delx = Math.Abs(prev.X - crnt.X);
//                dely = Math.Abs(prev.Y - crnt.Y);
//            }
//            else
//            {
//                delx = Math.Abs(crnt.X - prev.X);
//                dely = Math.Abs(crnt.Y - prev.Y);
//            }
//            double r = Math.Sqrt(Math.Pow(delx, 2) + Math.Pow(dely, 2));
//            // points = new Point[];
//            for (int i = 1; i <= 50; i++)
//            {
//                double angle = Math.PI * 2 / 50 * i;
//                int xd = Convert.ToInt32((delx * Math.Cos(angle) + prev.X)); // эллипс
//                int yd = Convert.ToInt32((dely * Math.Sin(angle) + prev.Y));
//                Point addPoint = new Point(xd, yd);
//                points.Add(addPoint);
//            }
//            return points.ToArray();
//        }
//    }
//}

