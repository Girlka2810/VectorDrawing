using System.Drawing;
using VectorDrawing.Figures;

namespace VectorDrawing.Tools
{
    public class TriangleTool : AbstractTool
    {
        public override int MaxCount { get; } = 3;
        
        public TriangleTool(Pen pen) : base(pen)
        {
        }

        
        public override void Paint(Graphics graphics)
        {
            TriangleFigure triangleFigure = new TriangleFigure();
            FigureParameter figureParameter = new FigureParameter
            {
                Points = Points.ToArray(),
                TemporaryPoint = TemporaryPoint,
            };
            graphics.DrawPolygon(Pen, triangleFigure.GetPoints(figureParameter));
        }
    }
}