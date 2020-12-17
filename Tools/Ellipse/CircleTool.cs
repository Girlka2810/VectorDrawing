using System;
using System.Collections.Generic;
using System.Drawing;
using VectorDrawing.Figures;
using VectorDrawing.Figures.Parameters;
using VectorDrawing.Figures.Returns;
using VectorDrawing.RectangleConverts;

namespace VectorDrawing.Tools.Ellipse
{
    public class CircleTool : AbsractEllipse
    {
        public override int MaxCount => 2;
        public float Radius { get; set; }

        public CircleTool(Pen pen) : base(pen)
        {
            Figure = new CircleFigure();
        }
        
        public CircleTool(List<PointF> points, Pen pen) : base(points,pen)
        {
            Figure = new CircleFigure();
            if (points.Count > 2)
            {
                throw new IndexOutOfRangeException();
            }
        }
         public override void SavePoints()
        {
            base.SavePoints();
            CalculateRadius();
        }
        public override bool IsItYou(PointF point)
        {
            PointF vector = new PointF(point.X - Center.X, point.Y - Center.Y);
            float delta = (float)Math.Sqrt(vector.X * vector.X + vector.Y * vector.Y);
            if (delta >= Radius + 2 || delta <= Radius - 2)
            {
                return true;
            }
            return false;
        }
        protected override FigureParameter GenerateParametrs()
        {
            EllipseParameter figureParameter = new EllipseParameter
            {
                Center = Center,
                TemporaryPoint = TemporaryPoint
            };
            return figureParameter;
        }

       
        private void CalculateRadius()
        {
            PointF vector = new PointF(TemporaryPoint.X - Center.X, TemporaryPoint.Y - Center.Y);
            Radius = (float) Math.Sqrt(vector.X * vector.X + vector.Y * vector.Y);
        }
    }
}




