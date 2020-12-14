using System;
using System.Collections.Generic;
using System.Drawing;
using VectorDrawing.Figures;
using VectorDrawing.Figures.Parameters;
using VectorDrawing.Figures.Returns;

namespace VectorDrawing.Tools.Ellipse
{
    public class CircleTool : AbsractEllipse
    {
        public override int MaxCount => 2;

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
        
        
        public override void Paint(Graphics graphics)
        {
            graphics.DrawEllipse(Pen, ((EllipseReturn)Figure.Get(GenerateParametrs())).Rectangle);
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
    }
}




