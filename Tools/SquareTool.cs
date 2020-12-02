
using System.Drawing;

namespace VectorDrawing.Tools
{
    public class SquareTool : AbstractTool
    {

        public override int MaxCount => 2;

        public SquareTool(Pen pen) : base(pen)
        {

        }


        public override void Paint(Graphics graphics)
        {
            Figures.SquareFigure square = new Figures.SquareFigure();
            Figures.FigureParameter figureParameter = new Figures.FigureParameter
            {
                Points = this.Points.ToArray(),
                TemporaryPoint = this.TemporaryPoint
            };
            graphics.DrawPolygon(Pen, square.GetPoints(figureParameter));
        }

    }
}