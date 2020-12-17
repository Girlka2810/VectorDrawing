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
        public override void Paint(Graphics graphics)
        {
            if (EndShapePoints.Length != 0)
            {
                IConvert convert = new BasicConvert();
                graphics.DrawEllipse(Pen, convert.ToRectangle(EndShapePoints));
            }
            else
            {
                graphics.DrawEllipse(Pen, ((EllipseReturn)Figure.Get(GenerateParametrs())).Rectangle);
            }
        }

       
        public sealed override void AddPoint(PointF point)
        {
            base.AddPoint(point);
            Center = Points[0];
        }

        public override void SavePoints()
        {
            IConvert convert = new BasicConvert();
            EndShapePoints = convert.ToPoints(((EllipseReturn)
               Figure.Get(GenerateParametrs())).Rectangle);
            Points = null;
        }
        
        

        
        
    }
}
