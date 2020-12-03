using System;
using System.Drawing;

namespace VectorDrawing.Figures
{
    public class RectangularTriangleFigure : IFigure
    {
        public Point[] GetPoints(FigureParameter parameter)
        {
            if(parameter.Points.Length==0) throw  new NullReferenceException("Points count can't be null");
            
            if (parameter.Points.Length == 1)
            {
                return new[]
                {
                    parameter.Points[0],
                    new Point(parameter.Points[0].X, parameter.TemporaryPoint.Y),
                    parameter.TemporaryPoint
                };
            }


            return new[]
            {
                parameter.Points[0],
                new Point(parameter.Points[0].X, parameter.Points[1].Y),
                parameter.Points[1],
            };
        }
    }
}