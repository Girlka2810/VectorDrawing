using System;
using System.Drawing;
using VectorDrawing.Figures.Parameters;
using VectorDrawing.Figures.Returns;

namespace VectorDrawing.Figures
{
    public class CircleFigure : IFigure
    {
        public FigureReturn Get(FigureParameter parameter)
        {
            if (parameter is EllipseParameter ellipseParameter)
            {
                PointF prev = ellipseParameter.Center;
                PointF crnt = ellipseParameter.TemporaryPoint;
                float deltaX = Math.Abs(prev.X - crnt.X);
                float deltaY = Math.Abs(prev.Y - crnt.Y);
                float radius = (float)Math.Sqrt(deltaY * deltaY + deltaX * deltaX);
                SizeF size = new SizeF(radius * 2, radius * 2);
                PointF center = new PointF(prev.X - radius, prev.Y - radius);
                RectangleF rectangle = new RectangleF(center, size);
                return new EllipseReturn() {Rectangle = rectangle};
            }

            return new FigureReturn();
        }
    }
}
