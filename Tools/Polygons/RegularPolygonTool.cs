using System.Drawing;
using VectorDrawing.Figures;
using VectorDrawing.Figures.Parameters;
using VectorDrawing.Figures.Returns;

namespace VectorDrawing.Tools.Polygons
{
    class RegularPolygonTool : AbstractPolygonTool
    {
        public RegularPolygonTool(Pen pen, int numOfCorners) : base(pen, numOfCorners)
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
            graphics.DrawPolygon(Pen, ((CommonReturn)polygon.Get(figureParameter)).Points);
        }
    }
}
