using System;
using System.Drawing;
using VectorDrawing.Figures.Parameters;
using VectorDrawing.Figures.Returns;

namespace VectorDrawing.Figures
{
    public class EllipseFigure : IFigure
    {
        
        public FigureReturn Get(FigureParameter parameter)
        {
            if (parameter is EllipseParameter ellipseParameter)
            {
                PointF point = ellipseParameter.Center;
                PointF pointEnd = ellipseParameter.TemporaryPoint;
                double delX = ellipseParameter.HorizontalRadius;
                double delY = ellipseParameter.VerticalRadius;
                PointF upperLeftPoint = new Point();

                if (ellipseParameter.Center.X >= ellipseParameter.TemporaryPoint.X)
                {
                    delX = Math.Abs(point.X - pointEnd.X);
                    delY = Math.Abs(point.Y - pointEnd.Y);
                    if (point.Y > pointEnd.Y)
                    {
                        upperLeftPoint = new PointF(point.X - (int) delX, point.Y - (int) delY);
                    }
                    else
                    {
                        upperLeftPoint = new PointF(point.X - (int) delX, pointEnd.Y - (int) delY);
                    }
                }
                else
                {
                    delX = Math.Abs(pointEnd.X - point.X);
                    delY = Math.Abs(pointEnd.Y - point.Y);
                    if (pointEnd.Y > point.Y)
                    {
                        upperLeftPoint = new PointF(pointEnd.X - (int) delX, pointEnd.Y - (int) delY);
                    }
                    else
                    {
                        upperLeftPoint = new PointF(pointEnd.X - (int) delX, point.Y - (int) delY);
                    }
                }

                RectangleF rectangle = new RectangleF(upperLeftPoint.X, upperLeftPoint.Y, (int) delX, (int) delY);
                return new EllipseReturn() {Rectangle = rectangle};
            }
            return new FigureReturn();
        }
    }
}