using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorDrawing;
using VectorDrawing.Figures;

namespace VectorDrawing.Tools
{
    class RegularPolygonTool : AbstractPolygonTool
    {
        public RegularPolygonTool(Pen pen, int num_of_corners) : base(pen, num_of_corners)
        {
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
            graphics.DrawPolygon(Pen, polygon.GetPoints(figureParameter));
        }
    }
}
