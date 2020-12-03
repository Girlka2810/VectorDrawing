using System.Drawing;
using VectorDrawing.Figures;

namespace VectorDrawing.Tools
{
    public class RectangularTriangleTool : AbstractTool
    {
        public override int MaxCount { get; } = 2;
        
        public RectangularTriangleTool(Pen pen) : base(pen)
        {
        }
        
        public override void Paint(Graphics graphics)
        {
            RectangularTriangleFigure rectangularTriangleFigure = new RectangularTriangleFigure();
            FigureParameter figureParameter = new FigureParameter
            {
                Points = Points.ToArray(),
                TemporaryPoint = TemporaryPoint,
            };
            graphics.DrawPolygon(Pen, rectangularTriangleFigure.GetPoints(figureParameter));
        }
    }
}