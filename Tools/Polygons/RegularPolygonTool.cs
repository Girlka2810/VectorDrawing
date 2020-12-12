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
        }
        
        public RegularPolygonTool(List<PointF> points, Pen pen) : base(points, pen)
        {
            if (points.Count > 2)
            {
                throw new IndexOutOfRangeException();
            }
        }

        public override void Paint(Graphics graphics)
        {
            RegularPolygonFigure polygon = new RegularPolygonFigure();
            RegularPolygonParameter figureParameter = new RegularPolygonParameter
            {
                QuantityOfCorners = this.QuantityOfCorners,
                Center = this.Center,
                TemporaryPoint = this.TemporaryPoint
            };
            var ss = ((CommonReturn) polygon.Get(figureParameter));
            graphics.DrawPolygon(Pen, ((CommonReturn)polygon.Get(figureParameter)).Points);
        }
    }
}
