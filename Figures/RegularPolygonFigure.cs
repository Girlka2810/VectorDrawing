using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorDrawing.Figures
{
    public class RegularPolygonFigure : IPolygonalFigure
    {
        /// <summary>
        /// Принимает параметр, содержащий QuantityOfCorners, Center и TemporaryPoint
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public Point[] GetPoints(RegularPolygonParameter parameter)
        {
            Point center = parameter.Center;
            Point point = parameter.TemporaryPoint;
            int vertexes = parameter.QuantityOfCorners;
            Point[] points = new Point[vertexes];
            var angle = Math.PI * 2 / vertexes;
            int deltaX = Math.Abs(center.X - point.X);
            int deltaY = Math.Abs(center.Y - point.Y);
            double z = 0;
            if (deltaX >= deltaY)
            {
                deltaX = deltaY;
            }
            else
                deltaY = deltaX;

            for (int i = 0; i < vertexes; i++)
            {
                points[i].X = (int)(center.X + deltaX*Math.Sin(z));
                points[i].Y = (int)(center.Y - deltaY*Math.Cos(z));
                z = z + angle;
            }
            return points;
        }
    }
}
