using System;
using System.Drawing;

namespace VectorDrawing.RectangleConverts
{
    public class BasicConvert : IConvert
    {
        public RectangleF ToRectangle(PointF[] points)
        {
            float width = Math.Abs(points[0].X - points[1].X);
            float height = Math.Abs(points[0].Y - points[3].Y);
            SizeF size = new SizeF(width, height);
            RectangleF rect = new RectangleF(points[0], size);
            return rect;
        }

        public PointF[] ToPoints(RectangleF rectangle)
        {
            PointF[] arr = new PointF[4];
            arr[0] = rectangle.Location;
            arr[1] = new PointF(rectangle.Location.X + rectangle.Width, rectangle.Location.Y);
            arr[2] = new PointF(rectangle.Location.X, rectangle.Location.Y + rectangle.Height);
            arr[3] = new PointF(rectangle.Location.X + rectangle.Width, rectangle.Location.Y + rectangle.Height);
            return arr;
        }
    }
}