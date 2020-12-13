using System;
using System.Collections.Generic;
using System.Drawing;

namespace VectorDrawing.Tools.Polygons
{
    public abstract class AbstractPolygonTool : AbstractTool
    {
        public int QuantityOfCorners { get; set; }
        public PointF Center { get; set; }
        public override int MaxCount => 2;
        
        
        public AbstractPolygonTool(List<PointF> points, Pen pen) : base(pen)
        {
            for (int i = 0; i < points.Count; i++)
            {
                AddPoint(points[i]);
            }
        }
        
        protected AbstractPolygonTool(Pen pen): base(pen)
        {
            ID = Guid.NewGuid().ToString();
            Points = new List<PointF>();
            SetPen(pen);
        }
        public sealed override void AddPoint(PointF point)
        {
            base.AddPoint(point);
            Center = Points[0];
        }
    }
}
