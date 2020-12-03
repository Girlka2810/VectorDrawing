using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorDrawing.Tools
{
    public abstract class AbsractEllipse : AbstractTool
    {
        public Point Center { get; set; }
        public int HorizontalRadius { get; set; }
        public int VerticalRadius { get; set; }
        
        public AbsractEllipse(Pen pen) : base(pen)
        {
            ID = Guid.NewGuid().ToString();
            Points = new List<Point> { };
            SetPen(pen);
            Point[] points = Points.ToArray();
            Center = points.Length != 0 ? points[0]: new Point(0, 0);
        }

        public override void AddPoint(Point point)
        {
            base.AddPoint(point);
        }

        public void AddRadiuses(Point point)
        {
            HorizontalRadius = point.X - Center.X;
            VerticalRadius = point.Y - Center.Y;
        }
    }
}
