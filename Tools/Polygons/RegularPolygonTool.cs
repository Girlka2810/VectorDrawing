using System;
using System.Collections.Generic;
using System.Drawing;
using VectorDrawing.Figures;
using VectorDrawing.Figures.Parameters;
using VectorDrawing.Figures.Returns;

namespace VectorDrawing.Tools.Polygons
{
    public class RegularPolygonTool : AbstractPolygonTool
    {

        public RegularPolygonTool(Pen pen) : base(pen)
        {
            Figure = new RegularPolygonFigure();
        }
        
        public RegularPolygonTool(List<PointF> points, Pen pen) : base(points, pen)
        {
            Figure = new RegularPolygonFigure();
            if (points.Count > 2)
            {
                throw new IndexOutOfRangeException();
            }
        }

        public override void Paint(Graphics graphics)
        {
            graphics.DrawPolygon(Pen, ((CommonReturn)Figure.Get(GenerateParametrs())).Points);
        }

        protected override FigureParameter GenerateParametrs()
        {
            RegularPolygonParameter figureParameter = new RegularPolygonParameter
            {
                QuantityOfCorners = this.QuantityOfCorners,
                Center = this.Center,
                TemporaryPoint = this.TemporaryPoint
            };
            return figureParameter;
        }
    }
}
