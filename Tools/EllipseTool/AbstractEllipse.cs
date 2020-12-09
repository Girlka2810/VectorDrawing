using System;
using System.Collections.Generic;
using System.Drawing;

namespace VectorDrawing.Tools
{
    public abstract class AbsractEllipse : AbstractTool
    {
        public Point Center { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        
        public AbsractEllipse(Pen pen) : base(pen)
        {
            ID = Guid.NewGuid().ToString();
            Points = new List<Point> { };
            SetPen(pen);
            Point[] points = Points.ToArray();
            Center = points.Length != 0 ? points[0]: new Point();
        }

        public override void AddPoint(Point point)
        {
            base.AddPoint(point);
            Center = Points[0];
        }

        public void AddRadiuses(Point point)
        {
            Width = point.X - Center.X;
            Height = point.Y - Center.Y;
        }
    }
}
