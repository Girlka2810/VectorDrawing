using System;
using System.Collections.Generic;
using System.Drawing;

namespace VectorDrawing.Tools
{
    public abstract class AbsractEllipse : AbstractTool
    {
        public PointF Center { get; private set; }
        public float Width { get; set; }
        public float Height { get; set; }
        
        public AbsractEllipse(Pen pen) : base(pen)
        {
            ID = Guid.NewGuid().ToString();
            Points = new List<PointF> { };
            SetPen(pen);
            PointF[] points = Points.ToArray();
            Center = points.Length != 0 ? points[0]: new PointF();
        }

        public override void AddPoint(PointF point)
        {
            base.AddPoint(point);
            Center = Points[0];
        }


    }
}
