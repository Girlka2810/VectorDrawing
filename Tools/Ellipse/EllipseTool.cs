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

        public EllipseTool(Pen pen) : base(pen)
        {
            Figure = new EllipseFigure();
        }
        
        public EllipseTool(List<PointF> points, Pen pen) : base(points,pen)
        {    
            Figure = new EllipseFigure();
            if (points.Count > 2)
            {
                throw new IndexOutOfRangeException();
            }
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
