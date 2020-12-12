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
        public PointF Center { get; set; }
        public override int MaxCount => 2;
        protected AbstractPolygonTool(Pen pen, int num_of_corners): base(pen)
        {
            ID = Guid.NewGuid().ToString();
            Points = new List<PointF> { };
            SetPen(pen);
            PointF[] points = Points.ToArray();
            QuantityOfCorners = num_of_corners;
        }
        public override void AddPoint(PointF point)
        {
            base.AddPoint(point);
            Center = Points[0];
        }
    }
}
