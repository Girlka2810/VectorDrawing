using System;
using System.Collections.Generic;
using System.Drawing;
using VectorDrawing.Figures;
using VectorDrawing.Figures.Parameters;
using VectorDrawing.Figures.Returns;

namespace VectorDrawing.Tools.Ellipse
{
   public  class EllipseTool : AbsractEllipse
    {
        public override int MaxCount => 2;
        private IFigure _figure;

        public EllipseTool(Pen pen) : base(pen)
        {

        }
        
        public EllipseTool(List<PointF> points, Pen pen) : base(points,pen)
        {    
            if (points.Count > 2)
            {
                throw new IndexOutOfRangeException();
            }
        }

        public override void Paint(Graphics graphics)
        {
            EllipseFigure ellipse = new EllipseFigure();
            _figure = ellipse;
            FigureParameter figureParameter = GenerateParametrs();
            graphics.DrawEllipse(Pen, ((EllipseReturn)ellipse.Get(figureParameter)).Rectangle);
        }

        protected override FigureParameter GenerateParametrs()
        {
            EllipseParameter figureParameter = new EllipseParameter
            {
                Center = Center,
                TemporaryPoint = TemporaryPoint,
                HorizontalRadius = Width,
                VerticalRadius = Height

            };
            return figureParameter;
        }
    }
}
