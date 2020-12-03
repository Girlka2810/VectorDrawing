using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorDrawing.Tools
{
    abstract class AbstractPolygonTool : AbstractTool
    {
        public int QuantityOfCorners { get; set; }
        public Point Center { get; set; }
        public override int MaxCount => QuantityOfCorners;
        protected AbstractPolygonTool(Pen pen, int num_of_corners): base(pen)
        {
            ID = Guid.NewGuid().ToString();
            Points = new List<Point> { };
            SetPen(pen);
            Point[] points = Points.ToArray();
            QuantityOfCorners = num_of_corners;
        }
        public override void AddPoint(Point point)
        {
            base.AddPoint(point);
            Center = Points[0];
        }
    }
}
