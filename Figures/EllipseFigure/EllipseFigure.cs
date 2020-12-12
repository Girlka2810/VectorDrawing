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
    public class EllipseFigure : IEllipse
    {


        public RectangleF GetRectangle(EllipseFigureParameter parameter)
        {
            PointF point = parameter.Center;
            PointF pointEnd = parameter.TemporaryPoint;
            double delX = parameter.HorizontalRadius;
            double delY = parameter.VerticalRadius;
            PointF upperLeftPoint = new Point();

            if (parameter.Center.X >= parameter.TemporaryPoint.X)
            {
                delX = Math.Abs(point.X - pointEnd.X);
                delY = Math.Abs(point.Y - pointEnd.Y);
                if (point.Y > pointEnd.Y)
                {
                    upperLeftPoint = new PointF(point.X - (int)delX, point.Y - (int)delY);
                }
                else
                {
                    upperLeftPoint = new PointF(point.X - (int)delX, pointEnd.Y - (int)delY);
                }
            }
            else
            {
                delX = Math.Abs(pointEnd.X - point.X);
                delY = Math.Abs(pointEnd.Y - point.Y);
                if (pointEnd.Y > point.Y)
                {
                upperLeftPoint = new PointF(pointEnd.X - (int)delX, pointEnd.Y - (int)delY);
                }
                else
                {
                    upperLeftPoint = new PointF(pointEnd.X - (int)delX, point.Y - (int)delY);
                }
            }
            RectangleF rectangle = new RectangleF(upperLeftPoint.X, upperLeftPoint.Y, (int)delX , (int)delY);
            return rectangle;
        }

       
    }
}


