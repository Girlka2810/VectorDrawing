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
        //public Point[] GetPoints(FigureParameter parameter)
        //{
        //    throw new NotImplementedException();
        //}

        //public Rectangle GetCircumscribedRectangle(FigureParameter parameter)
        //{
        //    Point prev = parameter.Points[0];
        //    Point crnt = parameter.TemporaryPoint;
        //    int deltaX = Math.Abs(prev.X - crnt.X);
        //    int deltaY = Math.Abs(prev.Y - crnt.Y);
        //    int radius = (int) Math.Sqrt(deltaY * deltaY + deltaX * deltaX);
        //    Size size = new Size(radius*2, radius*2);
        //    Point center = new Point(prev.X - radius, prev.Y - radius);
        //    Rectangle rectangle = new Rectangle(center, size);
        //    return rectangle;
        //}
       
        public Rectangle GetRectangle(EllipseFigureParameter parameter)
        {
            Point prev = parameter.Center;
            Point crnt = parameter.TemporaryPoint;
            int deltaX = Math.Abs(prev.X - crnt.X);
            int deltaY = Math.Abs(prev.Y - crnt.Y);
            int radius = (int)Math.Sqrt(deltaY * deltaY + deltaX * deltaX);
            Size size = new Size(radius * 2, radius * 2);
            Point center = new Point(prev.X - radius, prev.Y - radius);
            Rectangle rectangle = new Rectangle(center, size);
            return rectangle;
        }
    }
}
