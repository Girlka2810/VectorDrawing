
using System.Collections.Generic;
using System.Drawing;
using VectorDrawing.Figures.Parameters;
using VectorDrawing.Figures.Returns;

namespace VectorDrawing.Tools
{
    public class SquareTool : AbstractTool
    {

        public override int MaxCount => 2;

        public SquareTool(Pen pen) : base(pen)
        {

        }

        
        public SquareTool(List<PointF> points, Pen pen) : base(points, pen)
        {

        }

        public override void Paint(Graphics graphics)
        {
            Figures.SquareFigure square = new Figures.SquareFigure();
            CommonParameter figureParameter = new CommonParameter
            {
                Points = this.Points.ToArray(),
                TemporaryPoint = this.TemporaryPoint
            };
            graphics.DrawPolygon(Pen, ((CommonReturn)square.Get(figureParameter)).Points);
        }

    }
}