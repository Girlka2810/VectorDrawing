using System;
using System.Collections.Generic;
using System.Drawing;
using VectorDrawing.Figures.Returns;
using VectorDrawing.RectangleConverts;

namespace VectorDrawing.Tools.Ellipse
{
    public abstract class AbsractEllipse : AbstractTool
    {
        public float Width { get; set; }
        public float Height { get; set; }


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

        protected void Paint(Graphics graphics, RectangleF rectangle)
        {
            graphics.DrawEllipse(Pen, rectangle);
        }
      
        public override void SavePoints()
        {
            throw new NotImplementedException();
        }
        
        public void SavePoints(IConvert convert)
        {
            EndShapePoints = convert.ToPoints(((EllipseReturn)
                Figure.Get(GenerateParametrs())).Rectangle);
            Points = null;
        }
        
        
        
        
    }
}
