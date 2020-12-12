using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorDrawing.Figures
{
    public class CircleFigure : IEllipse
    {
        public RectangleF GetRectangle(EllipseFigureParameter parameter)
        {
            PointF prev = parameter.Center;
            PointF crnt = parameter.TemporaryPoint;
            float deltaX = Math.Abs(prev.X - crnt.X);
            float deltaY = Math.Abs(prev.Y - crnt.Y);
            float radius = (float)Math.Sqrt(deltaY * deltaY + deltaX * deltaX);
            SizeF size = new SizeF(radius * 2, radius * 2);
            PointF center = new PointF(prev.X - radius, prev.Y - radius);
            RectangleF rectangle = new RectangleF(center, size);
            return rectangle;
        }
    }
}
