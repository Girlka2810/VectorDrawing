using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorDrawing.Figures;

namespace VectorDrawing.Figures
{
    public class RegularPolygonFigure : IPolygonalFigure
    {
        /// <summary>
        /// Принимает параметр, содержащий QuantityOfCorners, Center и TemporaryPoint
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public PointF[] GetPoints(RegularPolygonParameter parameter)
        {
            PointF center = parameter.Center;
            PointF point = parameter.TemporaryPoint;
            int vertexes = parameter.QuantityOfCorners;
            PointF[] points = new PointF[vertexes];
            double angle = Math.PI * 2 / vertexes;
            float deltaX = Math.Abs(center.X - point.X);
            float deltaY = Math.Abs(center.Y - point.Y);
            double z = 0;
            Equalization(ref deltaX, ref deltaY);

            for (int i = 0; i < vertexes; i++)
            {
                points[i].X = (float)(center.X - deltaX*Math.Sin(z));
                points[i].Y = (float)(center.Y - deltaY*Math.Cos(z));
                z = z + angle;
            }
            return points;
        }
        private void Equalization(ref float a, ref float b)
        {
            if (a >= b)
            {
                a = b;
            }
            else
                b = a;
        }
    }
}
