using System;
using System.Collections.Generic;
using System.Drawing;
using VectorDrawing.Figures;
using VectorDrawing.Figures.Returns;

namespace VectorDrawing.Tools.Ellipse
{
    public abstract class AbsractEllipse : AbstractTool
    {
        public PointF Center { get; private set; }
        public float Width { get; set; }
        public float Height { get; set; }
        private IFigure _figure;


        public AbsractEllipse(List<PointF> points, Pen pen) : base(pen)
        {
            for (int i = 0; i < points.Count; i++)
            {
                AddPoint(points[i]);
            }
            
        }
        
        public AbsractEllipse(Pen pen) : base(pen)
        {
            ID = Guid.NewGuid().ToString();
            Points = new List<PointF>( );
            SetPen(pen);
            PointF[] points = Points.ToArray();
            Center = points.Length != 0 ? points[0]: new PointF();
        }

        public sealed override void AddPoint(PointF point)
        {
            base.AddPoint(point);
            Center = Points[0];
        }

        protected PointF[] ConvertFromRectangleToPoints(RectangleF rect)
        {
            PointF[] arr = new PointF[4];
            arr[0] = rect.Location;
            arr[1] = new PointF(rect.Location.X + rect.Width, rect.Location.Y);
            arr[2] = new PointF(rect.Location.X, rect.Location.Y + rect.Height);
            arr[3] = new PointF(rect.Location.X + rect.Width, rect.Location.Y + rect.Height);
            return arr;
        }
        public override void SavePoints()
        {
            EndShapePoints = ConvertFromRectangleToPoints(((EllipseReturn)
                _figure.Get(GenerateParametrs())).Rectangle);
        }
    }
}
