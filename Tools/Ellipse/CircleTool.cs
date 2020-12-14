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
        private IFigure _figure;

        public CircleTool(Pen pen) : base(pen)
        {

        }
        
        public CircleTool(List<PointF> points, Pen pen) : base(points,pen)
        {
            if (points.Count > 2)
            {
                throw new IndexOutOfRangeException();
            }
        }
        
        
        public override void Paint(Graphics graphics)
        {
            CircleFigure circle = new CircleFigure();
            _figure = circle;
            FigureParameter figureParameter = GenerateParametrs();
            graphics.DrawEllipse(Pen, ((EllipseReturn)circle.Get(figureParameter)).Rectangle);
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




